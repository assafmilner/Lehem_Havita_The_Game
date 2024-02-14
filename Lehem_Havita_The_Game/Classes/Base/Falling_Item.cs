using System;
using System.Drawing;
using System.Windows.Forms;


namespace Lehem_Havita_The_Game.Classes.Base
{
    // Represents a falling item in the game
    public class Falling_Item
    {
        // Properties
        public string Name{ get; set; }
        public PictureBox Picture { get; set; }
        public int XPosition { get; set; }
        public double Falling_speed { get; set; }
        protected int Id { get; set; }
        protected string ImagePath { get; set; }

        private Random random;

        // Constructor
        public Falling_Item()
        {
            random = new Random();
            this.Picture = new PictureBox();
            this.Picture.SizeMode = PictureBoxSizeMode.Zoom;
            this.Picture.Size = new Size(50, 50);
            this.Picture.BackColor = Color.Transparent;
            this.Falling_speed = random.Next(10, 22);

        }
        // Destructor
        ~Falling_Item()
        {

        }

        // Set initial location of the falling item
        public void Set_location(int x_pos)
        {

            this.Picture.Left = x_pos;
            this.Picture.Top = 0;
        }

        // Update the item's location as it falls
        public void Change_item_location()
        {
            this.Picture.Top += (int)Falling_speed;
        }
    }
}







