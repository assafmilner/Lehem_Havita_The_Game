using System;
using System.Windows.Forms;

namespace Lehem_Havita_The_Game
{
    public partial class InsertNameForm : Form
    {
        public InsertNameForm()
        {
            InitializeComponent();
            this.V_button.Hide();
        }

        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Name_textBox.TextLength != 0)
            {
                V_button.Show();
            }
            else
            {
                V_button.Hide();
            }
        }

        private void V_button_Click(object sender, EventArgs e)
        {
            Main_Menu.input_name = Name_textBox.Text;
            this.Close();
        }

        private void InsertNameForm_Load(object sender, EventArgs e)
        {
            Easy_btn.FlatStyle = FlatStyle.Flat;
            mid_btn.FlatStyle = FlatStyle.Standard;
            hard_btn.FlatStyle = FlatStyle.Standard;
            Level_details.ForeColor = Easy_btn.BackColor;
            Level_details.Text = "3 minutes - Low Speed";
            Main_Menu.diff_level = 1;
        }

        private void Easy_btn_Click(object sender, EventArgs e)
        {
            Easy_btn.FlatStyle = FlatStyle.Flat;
            mid_btn.FlatStyle = FlatStyle.Standard;
            hard_btn.FlatStyle = FlatStyle.Standard;
            Level_details.ForeColor = Easy_btn.BackColor;
            Level_details.Text = "3 minutes - Low Speed";
            Main_Menu.diff_level = 1;
            

        }

        private void Mid_btn_Click(object sender, EventArgs e)
        {
            Easy_btn.FlatStyle = FlatStyle.Standard;
            mid_btn.FlatStyle = FlatStyle.Flat;
            hard_btn.FlatStyle = FlatStyle.Standard;
            Level_details.ForeColor = mid_btn.BackColor;
            Level_details.Text = "2 minutes - Mid Speed";
            Main_Menu.diff_level = 2;
        }

        private void Hard_btn_Click(object sender, EventArgs e)
        {
            Easy_btn.FlatStyle = FlatStyle.Standard;
            mid_btn.FlatStyle = FlatStyle.Standard;
            hard_btn.FlatStyle = FlatStyle.Flat;
            Level_details.ForeColor = hard_btn.BackColor;
            Level_details.Text = "1 minutes - High Speed";
            Main_Menu.diff_level = 3;
        }
    }
}
