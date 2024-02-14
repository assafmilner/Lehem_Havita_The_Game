
namespace Lehem_Havita_The_Game
{
    partial class Admin_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Password));
            this.Admin_form_lable = new System.Windows.Forms.Label();
            this.Password_txtBox = new System.Windows.Forms.TextBox();
            this.V_Button = new System.Windows.Forms.PictureBox();
            this.Access_lable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.V_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_form_lable
            // 
            this.Admin_form_lable.AutoSize = true;
            this.Admin_form_lable.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_form_lable.ForeColor = System.Drawing.Color.Yellow;
            this.Admin_form_lable.Location = new System.Drawing.Point(12, 9);
            this.Admin_form_lable.Name = "Admin_form_lable";
            this.Admin_form_lable.Size = new System.Drawing.Size(103, 16);
            this.Admin_form_lable.TabIndex = 0;
            this.Admin_form_lable.Text = "lorem ipusom";
            // 
            // Password_txtBox
            // 
            this.Password_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txtBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Password_txtBox.Location = new System.Drawing.Point(49, 70);
            this.Password_txtBox.Name = "Password_txtBox";
            this.Password_txtBox.Size = new System.Drawing.Size(209, 24);
            this.Password_txtBox.TabIndex = 1;
            this.Password_txtBox.TextChanged += new System.EventHandler(this.Password_txtBox_TextChanged);
            // 
            // V_Button
            // 
            this.V_Button.Image = ((System.Drawing.Image)(resources.GetObject("V_Button.Image")));
            this.V_Button.Location = new System.Drawing.Point(15, 130);
            this.V_Button.Name = "V_Button";
            this.V_Button.Size = new System.Drawing.Size(43, 37);
            this.V_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.V_Button.TabIndex = 2;
            this.V_Button.TabStop = false;
            this.V_Button.Click += new System.EventHandler(this.V_Button_Click);
            // 
            // Access_lable
            // 
            this.Access_lable.AutoSize = true;
            this.Access_lable.Font = new System.Drawing.Font("Narkisim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Access_lable.ForeColor = System.Drawing.Color.White;
            this.Access_lable.Location = new System.Drawing.Point(94, 130);
            this.Access_lable.Name = "Access_lable";
            this.Access_lable.Size = new System.Drawing.Size(78, 20);
            this.Access_lable.TabIndex = 3;
            this.Access_lable.Text = "Access ";
            // 
            // Admin_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(332, 179);
            this.Controls.Add(this.Access_lable);
            this.Controls.Add(this.V_Button);
            this.Controls.Add(this.Password_txtBox);
            this.Controls.Add(this.Admin_form_lable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Password";
            this.Text = "Admin Action";
            this.Load += new System.EventHandler(this.Admin_Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.V_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin_form_lable;
        private System.Windows.Forms.TextBox Password_txtBox;
        private System.Windows.Forms.PictureBox V_Button;
        public System.Windows.Forms.Label Access_lable;
    }
}