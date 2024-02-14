using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehem_Havita_The_Game
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            this.Help_Lable.Text = "Use the mouse to hover over\nthe various elements to \ndiscover information about them!";
        }

        private void Egg_pic_MouseEnter(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "  Fried Egg\n  Falling_Item -> Ingredient\n  Cost - 10";

        }

        private void Egg_pic_MouseLeave(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "";
        }

        private void Chilli_pic_MouseEnter(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "  Chuma Chilli\n  Falling_Item -> Ingredient\n  Cost - 5";
        }

        private void Chilli_pic_MouseLeave(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "";
        }

        private void Margez_pic_MouseEnter(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "  Margez Sausage\n  Falling_Item -> Ingredient\n  Cost - 7";
        }

        private void Margez_pic_MouseLeave(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "";
        }

        private void Onion_pic_MouseEnter(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "  Onion\n  Falling_Item -> Ingredient\n  Cost - 3";
        }

        private void Onion_pic_MouseLeave(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "";
        }

        private void Mayo_pic_MouseEnter(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "  Mayo\n  Falling_Item -> Ingredient\n  Cost - 3";
        }

        private void Mayo_pic_MouseLeave(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "";
        }

        private void Cucumber_pic_MouseEnter(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "  Cucumber\n  Falling_Item -> Ingredient\n  Cost - 3";
        }

        private void Cucumber_pic_MouseLeave(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "";
        }

        private void Tomato_pic_MouseEnter(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "  Tomato\n  Falling_Item -> Ingredient\n  Cost - 3";
        }

        private void Tomato_pic_MouseLeave(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "";
        }

        private void Bomb_pic_MouseEnter(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "  Ouch!\n  Be careful please!\n  Lowers the player's Lives by 1\n  Falling_Item -> Not Ingredient --> Bad";
        }

        private void Bomb_pic_MouseLeave(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "";
        }

        private void Juke_pic_MouseEnter(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "  Yikes - they are everywhere!\n  5 points were taken from you!\n  Falling_Item -> Not Ingredient --> Bad";
        }

        private void Juke_pic_MouseLeave(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "";
        }

        private void Clock_pic_MouseEnter(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "  Take your time my friend\n  get another 30 seconds!\n  Falling_Item -> Not Ingredient --> Good";
        }

        private void Clock_pic_MouseLeave(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "";
        }

        private void Soul_pic_MouseEnter(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "  Baguette with soul you just ate\n  and therefore - you'll gain extra lives and 20 points!\n  Falling_Item -> Not Ingredient --> Good";
        }

        private void Soul_pic_MouseLeave(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "";
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
         
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "All rights reserved to Itay Vazana and Assaf Milner";
        }
        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Item_desc_text_box.Text = "";
        }
    }
}
/*
            (5, "Chuma Chilli")
            (3, "Cucumber")
            (10, "Fried Egg")
            (3, "Onion")
            (3, "Mayo")
            (7, "Margez")
            (3, "Tomato")
*/