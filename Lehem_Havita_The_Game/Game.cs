using Lehem_Havita_The_Game.Classes.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Lehem_Havita_The_Game
{
    public partial class Game : Form
    {
        public ScoreHistoryForm Score_Window_Ref;
        public Order current_order;
        public Player current_Player;
        private GameState GamePlay;

        private string diff_name = "";
        public int Item_speed_by_diff = 180; 
        public int diff_id = 1;
        public int sec = 59;
        public int min = 2;
        string current_time = "";
        public const int right_border = 1100;
        public const int left_border = 210;
        public int time_extra_counter = 30;

        public Game(string P_name , ScoreHistoryForm SW , int diff_Level)
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
            current_Player = new Player(this, P_name);
            current_order = new Order(this);
            Score_Window_Ref = SW;
            diff_id = diff_Level;

        }

        private void Game_Load(object sender, EventArgs e)
        { 
            Config_game_by_diffID();
            GamePlay = new GameState(this, pictureBoxCursor, current_Player, current_order, Item_speed_by_diff);
            Game_Timer.Start();
            GamePlay.Start_Game();
        }


        private void Config_game_by_diffID()
        {
            switch (diff_id)
            {
                case 1:
                   
                    Item_speed_by_diff = 180;
                    diff_name = " Easy";
                    Timer_Countdown.Text = "3:00";
                    return;
                case 2:
               
                    Item_speed_by_diff = 100;
                    diff_name = " Medium";
                    Timer_Countdown.Text = "2:00";
                    return;
                case 3:
                   
                    Item_speed_by_diff = 60;
                    diff_name = " Hard";
                    Timer_Countdown.Text = "1:00";
                    return;                   
            }
        }

        private void Pause_play_btn_Click(object sender, EventArgs e)
        {
            if (Game_Timer.Enabled == true)
            {
                Game_Timer.Stop();
                GamePlay.timer.Stop();
                pause_play_btn.Image = Image.FromFile("Media\\Buttons\\Play.png");
            }
            else
            {
                Game_Timer.Start();
                GamePlay.timer.Start();
                pause_play_btn.Image = Image.FromFile("Media\\Buttons\\Pause.png");
            }
        }

        public void Post_ing(List<string> ings)
        {
            ing1.Text = ings[0];
            ing2.Text = ings[1];
            ing3.Text = ings[2];
            ing4.Text = ings[3];
            ing5.Text = ings[4];
        }

        public void Update_life_display(int lives)
        {
            switch (lives)
            {
                case 5:
                    live5.Visible = true;
                    return;
                case 4:
                    live5.Visible = false;
                    live4.Visible = true;
                    return;
                case 3:
                    live4.Visible = false;
                    live3.Visible = true;
                    return;
                case 2:
                    live3.Visible = false;
                    live2.Visible = true;
                    return;
                case 1:
                    live2.Visible = false;
                    live1.Visible = true;
                    return;
                case 0:
                    live1.Visible = false;
                    return;
            }
        }

        public void Remove_ing_from_order_display(string ing)
        {
            if (String.Equals(ing, ing1.Text) == true)
            {
                ing1.Text = "";
                return;
            }
            if (String.Equals(ing, ing2.Text) == true)
            {
                ing2.Text = "";
                return;
            }
            if (String.Equals(ing, ing3.Text) == true)
            {
                ing3.Text = "";
                return;
            }
            if (String.Equals(ing, ing4.Text) == true)
            {
                ing4.Text = "";
                return;
            }
            if (String.Equals(ing, ing5.Text) == true)
            {
                ing5.Text = "";
                return;
            }
        }

        public void Post_score(int s)
        {
            Score_lable.Text = "SCORE : " + s;
        }

        public void Update_sandwich_count(int count)
        {
            Sandwich_Counter.Text = count + " x ";
        }

        public void Talking_viki(string sentence)
        {
            cheer_lable.Show();
            cheer_lable.Text = sentence;
        }

        public void Effect_time(int time_diff)
        {
            if(time_diff >= 0)
            {
                if (sec + time_diff > 59)
                {
                    min++;
                    sec = (sec + time_diff) - 59;
                }
                else sec += time_diff;
            }
            else
            {
                if(sec + time_diff < 0)
                {
                    if (min > 0)
                    {
                        sec = 59 + (sec + time_diff);
                        min--;
                    }
                    else if(sec >= 30)
                    {
                        sec += time_diff;
                    }
                }
            }
        }

        private void Game_Timer_Tick(object sender, EventArgs e)
        {
            
            if (sec == 0)
            {
                min--;
                sec = 59;
            }
            if (sec < 10)
            {
                current_time = "0" + min.ToString() + ":0" + sec--.ToString();

            }
            else
            {
                current_time = "0" + min.ToString() + ":" + sec--.ToString();
            }
            switch (min)
            {
                case 2:
                    Timer_Countdown.ForeColor = Color.LimeGreen;
                    break;
                case 1:
                    Timer_Countdown.ForeColor = Color.Yellow;
                    break;
                case 0:
                    Timer_Countdown.ForeColor = Color.OrangeRed;
                    break;
            }
            Timer_Countdown.Text = current_time;
            if (min == 0 && sec <= 0)
            {
                Game_Timer.Stop();
                GameState.Game_is_Active = false;
            }
        }

        public void Game_is_over()
        {
            GameOver GO_Form = new GameOver(current_Player.Name, current_Player.Score, current_order.Order_count,diff_name);
            GO_Form.ShowDialog();
            Score_Window_Ref.Add_new_score(current_Player.Name,current_Player.Score,current_order.Order_count,diff_name);
            this.Close();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GameState.Game_is_Active == true)
            {
                GamePlay.Kill_Game_Proccess();
                GamePlay = null;
                Game_Timer.Stop();
            }

        }

    }
}

