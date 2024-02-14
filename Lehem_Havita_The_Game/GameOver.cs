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
    public partial class GameOver : Form
    {
        public GameOver(string name,int score,int count,string diff_lvl)
        {
            InitializeComponent();
            this.Game_Over_PlayerName.Text += name;
            this.Game_Over_Score.Text += score.ToString();
            this.Game_Over_Sandwiches.Text += count.ToString();
            this.Diff_Level.Text += diff_lvl;
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
        
        }
    }
}
