
namespace Lehem_Havita_The_Game
{
    partial class ScoreHistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreHistoryForm));
            this.MyTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDifficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameDataSetScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_DataSet_Scores = new Lehem_Havita_The_Game.Game_DataSet_Scores();
            this.score_TableTableAdapter = new Lehem_Havita_The_Game.Game_DataSet_ScoresTableAdapters.Score_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataSetScoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_DataSet_Scores)).BeginInit();
            this.SuspendLayout();
            // 
            // MyTable
            // 
            this.MyTable.AllowUserToAddRows = false;
            this.MyTable.AllowUserToDeleteRows = false;
            this.MyTable.AllowUserToResizeColumns = false;
            this.MyTable.AllowUserToResizeRows = false;
            this.MyTable.AutoGenerateColumns = false;
            this.MyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MyTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MyTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.gameDifficultyDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.MyTable.DataSource = this.scoreTableBindingSource;
            this.MyTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTable.GridColor = System.Drawing.Color.Black;
            this.MyTable.Location = new System.Drawing.Point(0, 0);
            this.MyTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MyTable.MultiSelect = false;
            this.MyTable.Name = "MyTable";
            this.MyTable.ReadOnly = true;
            this.MyTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MyTable.RowHeadersVisible = false;
            this.MyTable.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gold;
            this.MyTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.MyTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MyTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MyTable.Size = new System.Drawing.Size(1221, 586);
            this.MyTable.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Rank";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Rank";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Player";
            this.dataGridViewTextBoxColumn2.HeaderText = "Player";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // gameDifficultyDataGridViewTextBoxColumn
            // 
            this.gameDifficultyDataGridViewTextBoxColumn.DataPropertyName = "GameDifficulty";
            this.gameDifficultyDataGridViewTextBoxColumn.HeaderText = "Difficulty";
            this.gameDifficultyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gameDifficultyDataGridViewTextBoxColumn.Name = "gameDifficultyDataGridViewTextBoxColumn";
            this.gameDifficultyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn3.HeaderText = "Score";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sandwiches";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sandwiches";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date_Time";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date Time";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // scoreTableBindingSource
            // 
            this.scoreTableBindingSource.DataMember = "Score_Table";
            this.scoreTableBindingSource.DataSource = this.gameDataSetScoresBindingSource;
            // 
            // gameDataSetScoresBindingSource
            // 
            this.gameDataSetScoresBindingSource.DataSource = this.game_DataSet_Scores;
            this.gameDataSetScoresBindingSource.Position = 0;
            // 
            // game_DataSet_Scores
            // 
            this.game_DataSet_Scores.DataSetName = "Game_DataSet_Scores";
            this.game_DataSet_Scores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // score_TableTableAdapter
            // 
            this.score_TableTableAdapter.ClearBeforeFill = true;
            // 
            // ScoreHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1221, 586);
            this.Controls.Add(this.MyTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScoreHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lehem Havita - The Game (Score Board)";
            this.Load += new System.EventHandler(this.ScoreHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataSetScoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_DataSet_Scores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.BindingSource gameDataSetScoresBindingSource;
        private Game_DataSet_Scores game_DataSet_Scores;
        private System.Windows.Forms.BindingSource scoreTableBindingSource;
        private Game_DataSet_ScoresTableAdapters.Score_TableTableAdapter score_TableTableAdapter;
        public System.Windows.Forms.DataGridView MyTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDifficultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}