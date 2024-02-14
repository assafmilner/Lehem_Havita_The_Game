
namespace Lehem_Havita_The_Game
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pictureBoxCursor = new System.Windows.Forms.PictureBox();
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.pause_play_btn = new System.Windows.Forms.PictureBox();
            this.cheer_lable = new System.Windows.Forms.Label();
            this.Viki_cheer = new System.Windows.Forms.PictureBox();
            this.Timer_Countdown = new System.Windows.Forms.Label();
            this.Sandwich_Counter = new System.Windows.Forms.Label();
            this.sandwichPic = new System.Windows.Forms.PictureBox();
            this.live1 = new System.Windows.Forms.PictureBox();
            this.live2 = new System.Windows.Forms.PictureBox();
            this.live3 = new System.Windows.Forms.PictureBox();
            this.live4 = new System.Windows.Forms.PictureBox();
            this.live5 = new System.Windows.Forms.PictureBox();
            this.Score_lable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ing5 = new System.Windows.Forms.Label();
            this.ing4 = new System.Windows.Forms.Label();
            this.ing3 = new System.Windows.Forms.Label();
            this.ing2 = new System.Windows.Forms.Label();
            this.ing1 = new System.Windows.Forms.Label();
            this.Game_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCursor)).BeginInit();
            this.Side_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause_play_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Viki_cheer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandwichPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.live1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.live2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.live3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.live4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.live5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCursor
            // 
            this.pictureBoxCursor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.pictureBoxCursor, "pictureBoxCursor");
            this.pictureBoxCursor.Name = "pictureBoxCursor";
            this.pictureBoxCursor.TabStop = false;
            this.pictureBoxCursor.Tag = "";
            this.pictureBoxCursor.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.Game_Load);
            // 
            // Side_Panel
            // 
            this.Side_Panel.BackColor = System.Drawing.Color.Gold;
            this.Side_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Side_Panel.Controls.Add(this.pause_play_btn);
            this.Side_Panel.Controls.Add(this.cheer_lable);
            this.Side_Panel.Controls.Add(this.Viki_cheer);
            this.Side_Panel.Controls.Add(this.Timer_Countdown);
            this.Side_Panel.Controls.Add(this.Sandwich_Counter);
            this.Side_Panel.Controls.Add(this.sandwichPic);
            this.Side_Panel.Controls.Add(this.live1);
            this.Side_Panel.Controls.Add(this.live2);
            this.Side_Panel.Controls.Add(this.live3);
            this.Side_Panel.Controls.Add(this.live4);
            this.Side_Panel.Controls.Add(this.live5);
            this.Side_Panel.Controls.Add(this.Score_lable);
            this.Side_Panel.Controls.Add(this.panel1);
            resources.ApplyResources(this.Side_Panel, "Side_Panel");
            this.Side_Panel.ForeColor = System.Drawing.Color.Black;
            this.Side_Panel.Name = "Side_Panel";
            // 
            // pause_play_btn
            // 
            resources.ApplyResources(this.pause_play_btn, "pause_play_btn");
            this.pause_play_btn.Name = "pause_play_btn";
            this.pause_play_btn.TabStop = false;
            this.pause_play_btn.Click += new System.EventHandler(this.Pause_play_btn_Click);
            // 
            // cheer_lable
            // 
            resources.ApplyResources(this.cheer_lable, "cheer_lable");
            this.cheer_lable.BackColor = System.Drawing.Color.Transparent;
            this.cheer_lable.ForeColor = System.Drawing.Color.Firebrick;
            this.cheer_lable.Name = "cheer_lable";
            // 
            // Viki_cheer
            // 
            resources.ApplyResources(this.Viki_cheer, "Viki_cheer");
            this.Viki_cheer.Name = "Viki_cheer";
            this.Viki_cheer.TabStop = false;
            // 
            // Timer_Countdown
            // 
            this.Timer_Countdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.Timer_Countdown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Timer_Countdown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.Timer_Countdown, "Timer_Countdown");
            this.Timer_Countdown.ForeColor = System.Drawing.Color.LimeGreen;
            this.Timer_Countdown.Name = "Timer_Countdown";
            // 
            // Sandwich_Counter
            // 
            resources.ApplyResources(this.Sandwich_Counter, "Sandwich_Counter");
            this.Sandwich_Counter.ForeColor = System.Drawing.Color.DarkRed;
            this.Sandwich_Counter.Name = "Sandwich_Counter";
            // 
            // sandwichPic
            // 
            resources.ApplyResources(this.sandwichPic, "sandwichPic");
            this.sandwichPic.Name = "sandwichPic";
            this.sandwichPic.TabStop = false;
            // 
            // live1
            // 
            resources.ApplyResources(this.live1, "live1");
            this.live1.Name = "live1";
            this.live1.TabStop = false;
            // 
            // live2
            // 
            resources.ApplyResources(this.live2, "live2");
            this.live2.Name = "live2";
            this.live2.TabStop = false;
            // 
            // live3
            // 
            resources.ApplyResources(this.live3, "live3");
            this.live3.Name = "live3";
            this.live3.TabStop = false;
            // 
            // live4
            // 
            resources.ApplyResources(this.live4, "live4");
            this.live4.Name = "live4";
            this.live4.TabStop = false;
            // 
            // live5
            // 
            resources.ApplyResources(this.live5, "live5");
            this.live5.Name = "live5";
            this.live5.TabStop = false;
            // 
            // Score_lable
            // 
            resources.ApplyResources(this.Score_lable, "Score_lable");
            this.Score_lable.BackColor = System.Drawing.Color.Transparent;
            this.Score_lable.ForeColor = System.Drawing.Color.Maroon;
            this.Score_lable.Name = "Score_lable";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ing5);
            this.panel1.Controls.Add(this.ing4);
            this.panel1.Controls.Add(this.ing3);
            this.panel1.Controls.Add(this.ing2);
            this.panel1.Controls.Add(this.ing1);
            this.panel1.Name = "panel1";
            // 
            // ing5
            // 
            resources.ApplyResources(this.ing5, "ing5");
            this.ing5.BackColor = System.Drawing.Color.Transparent;
            this.ing5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.ing5.Name = "ing5";
            // 
            // ing4
            // 
            resources.ApplyResources(this.ing4, "ing4");
            this.ing4.BackColor = System.Drawing.Color.Transparent;
            this.ing4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.ing4.Name = "ing4";
            // 
            // ing3
            // 
            resources.ApplyResources(this.ing3, "ing3");
            this.ing3.BackColor = System.Drawing.Color.Transparent;
            this.ing3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.ing3.Name = "ing3";
            // 
            // ing2
            // 
            resources.ApplyResources(this.ing2, "ing2");
            this.ing2.BackColor = System.Drawing.Color.Transparent;
            this.ing2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.ing2.Name = "ing2";
            // 
            // ing1
            // 
            resources.ApplyResources(this.ing1, "ing1");
            this.ing1.BackColor = System.Drawing.Color.Transparent;
            this.ing1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.ing1.Name = "ing1";
            // 
            // Game_Timer
            // 
            this.Game_Timer.Interval = 1000;
            this.Game_Timer.Tick += new System.EventHandler(this.Game_Timer_Tick);
            // 
            // Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.Gold;
            this.CausesValidation = false;
            this.Controls.Add(this.Side_Panel);
            this.Controls.Add(this.pictureBoxCursor);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCursor)).EndInit();
            this.Side_Panel.ResumeLayout(false);
            this.Side_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause_play_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Viki_cheer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandwichPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.live1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.live2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.live3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.live4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.live5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.PictureBox pictureBoxCursor;
        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ing5;
        private System.Windows.Forms.Label ing4;
        private System.Windows.Forms.Label ing3;
        private System.Windows.Forms.Label ing2;
        private System.Windows.Forms.Label Score_lable;
        private System.Windows.Forms.Label ing1;
        private System.Windows.Forms.PictureBox live1;
        private System.Windows.Forms.PictureBox live2;
        private System.Windows.Forms.PictureBox live3;
        private System.Windows.Forms.PictureBox live4;
        private System.Windows.Forms.PictureBox live5;
        private System.Windows.Forms.Label Sandwich_Counter;
        private System.Windows.Forms.PictureBox sandwichPic;
        private System.Windows.Forms.PictureBox Viki_cheer;
        private System.Windows.Forms.Label cheer_lable;
        private System.Windows.Forms.Label Timer_Countdown;
        public System.Windows.Forms.Timer Game_Timer;
        private System.Windows.Forms.PictureBox pause_play_btn;
    }
}

