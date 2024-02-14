
namespace Lehem_Havita_The_Game
{
    partial class InsertNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertNameForm));
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.input_Name = new System.Windows.Forms.Label();
            this.V_button = new System.Windows.Forms.PictureBox();
            this.Diff_Level_input = new System.Windows.Forms.Label();
            this.Easy_btn = new System.Windows.Forms.Button();
            this.mid_btn = new System.Windows.Forms.Button();
            this.hard_btn = new System.Windows.Forms.Button();
            this.Level_details = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.V_button)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_textBox.ForeColor = System.Drawing.Color.Black;
            this.Name_textBox.Location = new System.Drawing.Point(12, 54);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(196, 27);
            this.Name_textBox.TabIndex = 0;
            this.Name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_textBox.TextChanged += new System.EventHandler(this.Name_textBox_TextChanged);
            // 
            // input_Name
            // 
            this.input_Name.AutoSize = true;
            this.input_Name.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Name.ForeColor = System.Drawing.Color.Gold;
            this.input_Name.Location = new System.Drawing.Point(12, 12);
            this.input_Name.Name = "input_Name";
            this.input_Name.Size = new System.Drawing.Size(159, 23);
            this.input_Name.TabIndex = 1;
            this.input_Name.Text = "Insert Your Name";
            // 
            // V_button
            // 
            this.V_button.Image = ((System.Drawing.Image)(resources.GetObject("V_button.Image")));
            this.V_button.Location = new System.Drawing.Point(238, 12);
            this.V_button.Name = "V_button";
            this.V_button.Size = new System.Drawing.Size(59, 50);
            this.V_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.V_button.TabIndex = 2;
            this.V_button.TabStop = false;
            this.V_button.Click += new System.EventHandler(this.V_button_Click);
            // 
            // Diff_Level_input
            // 
            this.Diff_Level_input.AutoSize = true;
            this.Diff_Level_input.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diff_Level_input.ForeColor = System.Drawing.Color.LightSalmon;
            this.Diff_Level_input.Location = new System.Drawing.Point(12, 102);
            this.Diff_Level_input.Name = "Diff_Level_input";
            this.Diff_Level_input.Size = new System.Drawing.Size(123, 20);
            this.Diff_Level_input.TabIndex = 3;
            this.Diff_Level_input.Text = "Difficulty Level";
            // 
            // Easy_btn
            // 
            this.Easy_btn.BackColor = System.Drawing.Color.LightGreen;
            this.Easy_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easy_btn.Location = new System.Drawing.Point(24, 135);
            this.Easy_btn.Name = "Easy_btn";
            this.Easy_btn.Size = new System.Drawing.Size(69, 37);
            this.Easy_btn.TabIndex = 4;
            this.Easy_btn.Text = "Easy";
            this.Easy_btn.UseVisualStyleBackColor = false;
            this.Easy_btn.Click += new System.EventHandler(this.Easy_btn_Click);
            // 
            // mid_btn
            // 
            this.mid_btn.BackColor = System.Drawing.Color.Coral;
            this.mid_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mid_btn.Location = new System.Drawing.Point(117, 135);
            this.mid_btn.Name = "mid_btn";
            this.mid_btn.Size = new System.Drawing.Size(69, 37);
            this.mid_btn.TabIndex = 5;
            this.mid_btn.Text = "Mid";
            this.mid_btn.UseVisualStyleBackColor = false;
            this.mid_btn.Click += new System.EventHandler(this.Mid_btn_Click);
            // 
            // hard_btn
            // 
            this.hard_btn.BackColor = System.Drawing.Color.Crimson;
            this.hard_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hard_btn.Location = new System.Drawing.Point(211, 135);
            this.hard_btn.Name = "hard_btn";
            this.hard_btn.Size = new System.Drawing.Size(69, 37);
            this.hard_btn.TabIndex = 6;
            this.hard_btn.Text = "Hard";
            this.hard_btn.UseVisualStyleBackColor = false;
            this.hard_btn.Click += new System.EventHandler(this.Hard_btn_Click);
            // 
            // Level_details
            // 
            this.Level_details.AutoSize = true;
            this.Level_details.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level_details.ForeColor = System.Drawing.Color.GreenYellow;
            this.Level_details.Location = new System.Drawing.Point(33, 205);
            this.Level_details.Name = "Level_details";
            this.Level_details.Size = new System.Drawing.Size(0, 25);
            this.Level_details.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(198, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "(Defualt - Easy)";
            // 
            // InsertNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(309, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Level_details);
            this.Controls.Add(this.hard_btn);
            this.Controls.Add(this.mid_btn);
            this.Controls.Add(this.Easy_btn);
            this.Controls.Add(this.Diff_Level_input);
            this.Controls.Add(this.V_button);
            this.Controls.Add(this.input_Name);
            this.Controls.Add(this.Name_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Before we start..";
            this.Load += new System.EventHandler(this.InsertNameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.V_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label input_Name;
        private System.Windows.Forms.PictureBox V_button;
        private System.Windows.Forms.Label Diff_Level_input;
        private System.Windows.Forms.Button Easy_btn;
        private System.Windows.Forms.Button mid_btn;
        private System.Windows.Forms.Button hard_btn;
        private System.Windows.Forms.Label Level_details;
        private System.Windows.Forms.Label label1;
    }
}