using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lehem_Havita_The_Game
{
    public partial class ScoreHistoryForm : Form
    {
        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB_Folder\Database.mdf;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand command;
        public ScoreHistoryForm()
        {
            InitializeComponent();

        }

        public void Delete_all_rows()
        {

            conn = new SqlConnection(connString);
            conn.Open();
            command = new SqlCommand("DELETE FROM Score_Table", conn);

            try
            {
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Add_new_score(string name , int score , int count,string diff)
        {

            conn = new SqlConnection(connString);
            conn.Open();
            command = new SqlCommand("INSERT INTO Score_Table(Player,Score,Sandwiches,Date_Time,GameDifficulty) VALUES (@Player,@Score,@Sandwiches,@Date_Time,@GameDifficulty)", conn);
            command.Parameters.AddWithValue("@Player", name);
            command.Parameters.AddWithValue("@Score", score);
            command.Parameters.AddWithValue("@Sandwiches", count);
            command.Parameters.AddWithValue("@Date_Time", DateTime.Now.ToString());
            command.Parameters.AddWithValue("@GameDifficulty", diff);

            try
            {
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Sort_and_Rank ()
        {
            MyTable.Sort(MyTable.Columns[3], System.ComponentModel.ListSortDirection.Descending);
            int rank = 1;
            foreach (DataGridViewRow row in MyTable.Rows)
            {
                row.Cells[0].Value = 0 + rank++;
            }
        }

        private void ScoreHistoryForm_Load(object sender, EventArgs e)
        {
            this.score_TableTableAdapter.Connection.ConnectionString = connString;
            this.score_TableTableAdapter.ClearBeforeFill = true;
            this.score_TableTableAdapter.Fill(this.game_DataSet_Scores.Score_Table);
            Sort_and_Rank();

         

        }
    }
}
