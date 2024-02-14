using System;
using System.Windows.Forms;

namespace Lehem_Havita_The_Game
{
    public partial class Main_Menu : Form
    {

        public ScoreHistoryForm Score_Window;
        public static int diff_level = 1;
        public static string input_name = "";
        private Game GameForm;
        public Main_Menu()
        {
            InitializeComponent();
            Load += Main_Menu_Load;
            Score_Window = new ScoreHistoryForm();
           
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Scores_Table_btn_Click(object sender, EventArgs e)
        {
            Score_Window.ShowDialog();
        }

        private void PlayMusic_btn_Click(object sender, EventArgs e)
        {
            string URL_Theme = "https://youtu.be/_RFUj-sGCp8?si=fCkX2Ov5OClhLXNs&t=13";
            System.Diagnostics.Process.Start(URL_Theme);
        }

        private void Play_Game_btn_Click(object sender, EventArgs e)
        {
            InsertNameForm Player_Name_input = new InsertNameForm();
            Player_Name_input.ShowDialog();
            if (input_name.Length == 0) return;
            else
            {
                
                GameForm = new Game(input_name, Score_Window,diff_level);
                diff_level = 1;
                GameForm.ShowDialog();
            }
            input_name = "";
        }

        private void Help_btn_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }

        private void Reset_Tables_Click(object sender, EventArgs e)
        {
            Admin_Password Admin_Action = new Admin_Password();
            Admin_Action.ShowDialog();
            if (String.Equals(Admin_Action.Access_lable.Text, "Authorized Access"))
            {
                Score_Window.Delete_all_rows();
            }
        }
    }
}
