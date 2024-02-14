using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lehem_Havita_The_Game
{
    public partial class Admin_Password : Form
    {
        public Admin_Password()
        {
            InitializeComponent();
            Admin_form_lable.Text = "Restart the Score board\nEnter Administartor password:";
            Password_txtBox.PasswordChar = '*';
            
        }

        private void Password_txtBox_TextChanged(object sender, EventArgs e)
        {
            Access_lable.Hide();
            if (Password_txtBox.TextLength != 0)
            {
                V_Button.Show();
            }
            else
            {
                V_Button.Hide();
            }
        }

        private void V_Button_Click(object sender, EventArgs e)
        {
            Access_lable.Show();
            if (String.Equals(Password_txtBox.Text, "Noodle"))
            {
                Access_lable.ForeColor = Color.Lime;
                Access_lable.Text = "Authorized Access";
            }
            else
            {
                Access_lable.ForeColor = Color.OrangeRed;
                Access_lable.Text = "Access Denied";
            }
        }

        private void Admin_Password_Load(object sender, EventArgs e)
        {
            V_Button.Hide();
            Access_lable.Hide();
        }
    }
}
