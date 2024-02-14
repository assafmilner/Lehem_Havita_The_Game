using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;



namespace Lehem_Havita_The_Game.Classes.Base
{
    // Represents the state of the game
    public class GameState
    {
        // Arrays to hold falling items
        public  Falling_Item[] All_Ings = new Falling_Item[7];
        public  Falling_Item[] All_Not_Ings = new Falling_Item[4];

        // Dictionaries for image paths and ingredient names
        static public Dictionary<int, string> imagePaths = new Dictionary<int, string>();
        static public Dictionary<int, string> Ing_names = new Dictionary<int, string>();
        static public Dictionary<int, string> imagePaths1 = new Dictionary<int, string>();
        static public Dictionary<int, string> Not_Ing_names = new Dictionary<int, string>();

        // Other instance variables
        private List<Falling_Item> items_to_display = new List<Falling_Item>();
        public Player game_player;
        private Order game_order;
        private int Current_count_on_screen;
       
        private PictureBox Player_Cursor;
        private Game GF;
        private Random rand;
        public System.Windows.Forms.Timer timer;
        public static bool Game_is_Active;

        // Constructor to initialize game state
        public GameState(Game Game_Form, PictureBox cursor,Player Pl , Order Or, int TimeSpanTimer)
        {
            // Initialize variables
            Load_Paths_And_Names();
            Load_Arrays();
            this.GF = Game_Form;
            this.Player_Cursor = cursor;
            this.game_player = Pl;
            this.game_order = Or;
            this.game_order.Make_new_order();
            Define_cursor();
            rand = new Random();
            Current_count_on_screen = 0;
            Game_is_Active = true;
            // Create and start timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = TimeSpanTimer;
            timer.Tick += Timer_Tick;
        }

        /* Input and Timing Functions */

        // Timer tick event handler
        private void Timer_Tick(object sender, EventArgs e)
        {
             Game_is_running();
        }

        // Convert relative Y position to actual pixel position
        private int ConvertRelativeY(int y)
        {
            float relativeY = (float)y / 100; // 100 is the reference height
            return (int)(relativeY * this.GF.ClientSize.Height);
        }

        // Mouse move event handler
        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            if(timer.Enabled == true)
            {
                this.Player_Cursor.Hide();
                float relativeX = (float)e.X / this.GF.ClientSize.Width;
                float cursorX = relativeX * (this.GF.ClientSize.Width - this.Player_Cursor.Width);
                this.Player_Cursor.Left = (int)cursorX;
                this.Player_Cursor.Show();
            }
        }

        // Define player cursor appearance and behavior
        private void Define_cursor()
        {
            this.Player_Cursor.Size = new System.Drawing.Size(ConvertRelativeY(20), ConvertRelativeY(10));
            this.Player_Cursor.Location = new System.Drawing.Point(0, ConvertRelativeY(87));
            this.Player_Cursor.Image = System.Drawing.Image.FromFile("Media\\Game_Board\\Elements\\Other\\baguette.png");
            this.Player_Cursor.SizeMode = PictureBoxSizeMode.Zoom;
            this.GF.Controls.Add(this.Player_Cursor);
            this.GF.MouseMove += Game_MouseMove;
        }

        // Clear arrays and perform cleanup
        private void Clear_Arrays()
        {
            for (int i = 0; i < 7; i++)
            {
                if (i < 4)
                {
                    All_Not_Ings[i] = null;
                }
                All_Ings[i] = null;
            }
        }

        // Stop the game and perform cleanup
        public void Kill_Game_Proccess()
        {
            timer.Stop();
            imagePaths.Clear();
            Ing_names.Clear();
            imagePaths1.Clear();
            Not_Ing_names.Clear();
            Clear_Arrays();

            for (int i = 0; i<items_to_display.Count; i++)
            {
                this.GF.Controls.Remove(items_to_display[i].Picture);
                Falling_Item temp = items_to_display[i];
                items_to_display.Remove(items_to_display[i]);
                temp = null;
            }

            items_to_display.Clear();
            items_to_display = null;
        }

        /*****************************/


        /* Main GameState Functions */

        // Start the game
        public void Start_Game()
        {
            timer.Start();
        }

        // Update the game state during active gameplay
        private void Game_is_running()
        {
            if (Game_is_Active)
            {
                Move_items();
                Thread.Sleep(40);
            }
            else
            {
                Kill_Game_Proccess();
                GF.Game_is_over();
            }
        }

        // Move falling items on the screen
        private void Move_items()
        {
            Rectangle currsor_bounds = Player_Cursor.Bounds;
            if (items_to_display.Count > 0)
            {
                for (int i = 0; i < items_to_display.Count; i++)
                {
                    Rectangle itemUpperBounds = new Rectangle(items_to_display[i].Picture.Left, items_to_display[i].Picture.Top, items_to_display[i].Picture.Width, 2);
                    if (currsor_bounds.IntersectsWith(items_to_display[i].Picture.Bounds))
                    {
                        Items_was_caught(items_to_display[i]);
                        Remove_from_board(i);
                    }
                    else
                    {
                        if (items_to_display[i].Picture.Bottom >= this.GF.ClientSize.Height)
                        {
                            Remove_from_board(i);
                        }
                        else
                        {
                            Update_falling_item_display(i);
                        }
                    }

                }
            }
            else
            {
                items_to_display.Clear();
                Realod_item_to_screen();
            }
        }

        // Handle when an item is caught by the player
 
        private void Items_was_caught(Falling_Item FI)
        {
            if (FI.Picture.Visible)
            {
                FI.Picture.Visible = false;

                if (Ing_names.ContainsValue(FI.Name))
                {
                    if (game_order.Is_in_Order(((Ingredients)FI).Get_Name()))
                    {
                        Update_Score_Based_On_Item(((Ingredients)FI).Get_Cost(), ((Ingredients)FI).Get_Name());

                        if (game_order.Current_Order.Count == 0)
                        {
                            game_order.Complete_order();
                            game_player.Update_score_to_post();
                            game_order.Make_new_order();
                        }
                    }
                    else
                    {
                        Update_Score_Based_On_Item(-1, FI.Name);
                    }
                }
                else
                {
                    ((Not_Ingredients)FI).Effect_Activation(game_player);
                }
            }
        }


        // Reload falling items onto the screen
        private void Realod_item_to_screen()
        {
            int rand_index, type_of_item;
            Current_count_on_screen = rand.Next(4, 8);
            int[] Arr_x_pos = new int[Current_count_on_screen];
            Set_array_of_x_positions(Arr_x_pos, Current_count_on_screen);
            for (int j = 0; j < Current_count_on_screen; j++)
            {
                if (rand.Next(Current_count_on_screen+1) == 1)
                {
                    type_of_item = 2; //Not Ingredient
                    rand_index = rand.Next(1, 5);
                }
                else
                {
                    type_of_item = 1; //Ingredient
                    rand_index = rand.Next(1, 8);
                }
                Load_Object(rand_index, type_of_item);
                items_to_display[j].Set_location(Arr_x_pos[j]);
                this.GF.Controls.Add(items_to_display[j].Picture);
            }
        }

        /*****************************/


        /* Helper Functions */

        // Remove an item from the screen and memory
        private void Remove_from_board(int i) 
        {
            this.GF.Controls.Remove(items_to_display[i].Picture);
            Falling_Item temp = items_to_display[i];
            items_to_display.Remove(items_to_display[i]);
            temp = null;
        }

        // Update the display of a falling item
        private void Update_falling_item_display(int i)
        {
            items_to_display[i].Picture.Hide();
            items_to_display[i].Change_item_location();
            items_to_display[i].Picture.Show();
        }

        // Handle when a needed item is caught by the player
        private void Update_Score_Based_On_Item(int item_cost,string item_name)
        {
            
            game_player.Add_to_score(item_cost);
            game_order.Remove_from_current_order(item_name);
        }

        // Set the X positions for falling items
        private void Set_array_of_x_positions(int[] arr, int count)
        {
            int i, diff = (10 - count) * 30;
            int a = 0, b = diff;
            for (i = 0; i < count && b <= Game.right_border - 100; i++)
            {
                arr[i] = rand.Next(Game.left_border + a, Game.left_border + b);
                a += diff;
                b += diff;
            }
        }

        /*****************************/



        /* Initialization Functions */

        // Load initial falling item objects
        private void Load_Arrays()
        {
            Falling_Item i1 = new Chilli(4);
            Falling_Item i2 = new Cucumber(5);
            Falling_Item i3 = new Egg(2);
            Falling_Item i4 = new Onion(6);
            Falling_Item i5 = new Mayo(1);
            Falling_Item i6 = new Margez(2);
            Falling_Item i7 = new Tomato(4);

            Falling_Item ni1 = new Bomb(2);
            Falling_Item ni2 = new Clock(3);
            Falling_Item ni3 = new Cockroach(6);
            Falling_Item ni4 = new Viki_Heart(7);

            All_Ings[0] = i1;
            All_Ings[1] = i2;
            All_Ings[2] = i3;
            All_Ings[3] = i4;
            All_Ings[4] = i5;
            All_Ings[5] = i6;
            All_Ings[6] = i7;

            All_Not_Ings[0] = ni1;
            All_Not_Ings[1] = ni2;
            All_Not_Ings[2] = ni3;
            All_Not_Ings[3] = ni4;
        }

        // Load a falling item object based on index and type
        public void Load_Object(int index, int type)
        {
            if (type == 1)
            {
                switch (index)
                {
                    case 1:
                        items_to_display.Add(All_Ings[0]);
                        return;
                    case 2:
                        items_to_display.Add(All_Ings[1]);
                        return;
                    case 3:
                        items_to_display.Add(All_Ings[2]);
                        return;
                    case 4:
                        items_to_display.Add(All_Ings[3]);
                        return;
                    case 5:
                        items_to_display.Add(All_Ings[4]);
                        return;
                    case 6:
                        items_to_display.Add(All_Ings[5]);
                        return;
                    case 7:
                        items_to_display.Add(All_Ings[6]);
                        return;
                }
            }
            else
            {
                switch (index)
                {
                    case 1:
                        items_to_display.Add(All_Not_Ings[0]);
                        return;
                    case 2:
                        items_to_display.Add(All_Not_Ings[1]);
                        return;
                    case 3:
                        items_to_display.Add(All_Not_Ings[2]);
                        return;
                    case 4:
                        items_to_display.Add(All_Not_Ings[3]);
                        return;
                }
            }
        }

        // Load image paths and names for falling items
        public void Load_Paths_And_Names()
        {
            imagePaths.Add(1, "Media\\Game_Board\\Elements\\Ingredients\\chilli.png");
            imagePaths.Add(2, "Media\\Game_Board\\Elements\\Ingredients\\cucumber.png");
            imagePaths.Add(3, "Media\\Game_Board\\Elements\\Ingredients\\fried-egg.png");
            imagePaths.Add(4, "Media\\Game_Board\\Elements\\Ingredients\\onion.png");
            imagePaths.Add(5, "Media\\Game_Board\\Elements\\Ingredients\\sauce.png");
            imagePaths.Add(6, "Media\\Game_Board\\Elements\\Ingredients\\sausage.png");
            imagePaths.Add(7, "Media\\Game_Board\\Elements\\Ingredients\\tomato.png");

            Ing_names.Add(1, "Chuma Chilli");
            Ing_names.Add(2, "Cucumber");
            Ing_names.Add(3, "Fried Egg");
            Ing_names.Add(4, "Onion");
            Ing_names.Add(5, "Mayo");
            Ing_names.Add(6, "Margez");
            Ing_names.Add(7, "Tomato");

            imagePaths1.Add(1, "Media\\Game_Board\\Elements\\Not_Ingredients\\Bomb.png");
            imagePaths1.Add(2, "Media\\Game_Board\\Elements\\Not_Ingredients\\Clock.png");
            imagePaths1.Add(3, "Media\\Game_Board\\Elements\\Not_Ingredients\\Cockroach.png");
            imagePaths1.Add(4, "Media\\Game_Board\\Elements\\Not_Ingredients\\Viki_Heart.png");


            Not_Ing_names.Add(1, "Bomb");
            Not_Ing_names.Add(2, "Clock");
            Not_Ing_names.Add(3, "Cockroach");
            Not_Ing_names.Add(4, "Viki_Heart");
        }

        /*****************************/
    }
}
