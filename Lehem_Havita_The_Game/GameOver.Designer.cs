
namespace Lehem_Havita_The_Game
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.Game_Over_Title = new System.Windows.Forms.Label();
            this.Game_Over_Score = new System.Windows.Forms.Label();
            this.Game_Over_Sandwiches = new System.Windows.Forms.Label();
            this.Game_Over_PlayerName = new System.Windows.Forms.Label();
            this.Diff_Level = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Game_Over_Title
            // 
            this.Game_Over_Title.AutoSize = true;
            this.Game_Over_Title.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Over_Title.ForeColor = System.Drawing.Color.Gold;
            this.Game_Over_Title.Location = new System.Drawing.Point(99, 14);
            this.Game_Over_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Game_Over_Title.Name = "Game_Over_Title";
            this.Game_Over_Title.Size = new System.Drawing.Size(260, 53);
            this.Game_Over_Title.TabIndex = 0;
            this.Game_Over_Title.Text = "Game Over !";
            // 
            // Game_Over_Score
            // 
            this.Game_Over_Score.AutoSize = true;
            this.Game_Over_Score.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Over_Score.ForeColor = System.Drawing.Color.LightSalmon;
            this.Game_Over_Score.Location = new System.Drawing.Point(39, 142);
            this.Game_Over_Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Game_Over_Score.Name = "Game_Over_Score";
            this.Game_Over_Score.Size = new System.Drawing.Size(84, 26);
            this.Game_Over_Score.TabIndex = 1;
            this.Game_Over_Score.Text = "Score - ";
            // 
            // Game_Over_Sandwiches
            // 
            this.Game_Over_Sandwiches.AutoSize = true;
            this.Game_Over_Sandwiches.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Over_Sandwiches.ForeColor = System.Drawing.Color.LightSalmon;
            this.Game_Over_Sandwiches.Location = new System.Drawing.Point(39, 180);
            this.Game_Over_Sandwiches.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Game_Over_Sandwiches.Name = "Game_Over_Sandwiches";
            this.Game_Over_Sandwiches.Size = new System.Drawing.Size(142, 26);
            this.Game_Over_Sandwiches.TabIndex = 2;
            this.Game_Over_Sandwiches.Text = "Sandwiches - ";
            // 
            // Game_Over_PlayerName
            // 
            this.Game_Over_PlayerName.AutoSize = true;
            this.Game_Over_PlayerName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Over_PlayerName.ForeColor = System.Drawing.Color.Khaki;
            this.Game_Over_PlayerName.Location = new System.Drawing.Point(38, 92);
            this.Game_Over_PlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Game_Over_PlayerName.Name = "Game_Over_PlayerName";
            this.Game_Over_PlayerName.Size = new System.Drawing.Size(109, 31);
            this.Game_Over_PlayerName.TabIndex = 3;
            this.Game_Over_PlayerName.Text = "Player - ";
            // 
            // Diff_Level
            // 
            this.Diff_Level.AutoSize = true;
            this.Diff_Level.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diff_Level.ForeColor = System.Drawing.Color.Beige;
            this.Diff_Level.Location = new System.Drawing.Point(250, 134);
            this.Diff_Level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Diff_Level.Name = "Diff_Level";
            this.Diff_Level.Size = new System.Drawing.Size(88, 31);
            this.Diff_Level.TabIndex = 4;
            this.Diff_Level.Text = " Diff - ";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(464, 245);
            this.Controls.Add(this.Diff_Level);
            this.Controls.Add(this.Game_Over_PlayerName);
            this.Controls.Add(this.Game_Over_Sandwiches);
            this.Controls.Add(this.Game_Over_Score);
            this.Controls.Add(this.Game_Over_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lehem Havita - The Game";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Game_Over_Title;
        private System.Windows.Forms.Label Game_Over_Score;
        private System.Windows.Forms.Label Game_Over_Sandwiches;
        private System.Windows.Forms.Label Game_Over_PlayerName;
        private System.Windows.Forms.Label Diff_Level;
    }
}