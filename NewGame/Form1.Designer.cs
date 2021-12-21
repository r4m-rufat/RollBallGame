
namespace NewGame
{
    partial class RollBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RollBall));
            this.picture_ball = new System.Windows.Forms.PictureBox();
            this.ground_8 = new System.Windows.Forms.Panel();
            this.ground_7 = new System.Windows.Forms.Panel();
            this.ground_6 = new System.Windows.Forms.Panel();
            this.ground_5 = new System.Windows.Forms.Panel();
            this.ground_4 = new System.Windows.Forms.Panel();
            this.ground_1 = new System.Windows.Forms.Panel();
            this.ground_3 = new System.Windows.Forms.Panel();
            this.ground_2 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.lbl_high_score = new System.Windows.Forms.Label();
            this.lbl_point = new System.Windows.Forms.Label();
            this.gb_high_score = new System.Windows.Forms.GroupBox();
            this.top_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            this.gb_high_score.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_ball
            // 
            this.picture_ball.BackColor = System.Drawing.Color.Transparent;
            this.picture_ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_ball.Image = global::NewGame.Properties.Resources.img_ball;
            this.picture_ball.InitialImage = null;
            this.picture_ball.Location = new System.Drawing.Point(235, 439);
            this.picture_ball.Name = "picture_ball";
            this.picture_ball.Size = new System.Drawing.Size(30, 30);
            this.picture_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_ball.TabIndex = 13;
            this.picture_ball.TabStop = false;
            this.picture_ball.Tag = "ball";
            this.picture_ball.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.picture_ball_PreviewKeyDown);
            // 
            // ground_8
            // 
            this.ground_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ground_8.Location = new System.Drawing.Point(332, 41);
            this.ground_8.Name = "ground_8";
            this.ground_8.Size = new System.Drawing.Size(100, 15);
            this.ground_8.TabIndex = 11;
            this.ground_8.Tag = "platform";
            // 
            // ground_7
            // 
            this.ground_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ground_7.Location = new System.Drawing.Point(38, 89);
            this.ground_7.Name = "ground_7";
            this.ground_7.Size = new System.Drawing.Size(100, 15);
            this.ground_7.TabIndex = 12;
            this.ground_7.Tag = "platform";
            // 
            // ground_6
            // 
            this.ground_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ground_6.Location = new System.Drawing.Point(194, 178);
            this.ground_6.Name = "ground_6";
            this.ground_6.Size = new System.Drawing.Size(100, 15);
            this.ground_6.TabIndex = 10;
            this.ground_6.Tag = "platform";
            // 
            // ground_5
            // 
            this.ground_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ground_5.Location = new System.Drawing.Point(313, 269);
            this.ground_5.Name = "ground_5";
            this.ground_5.Size = new System.Drawing.Size(100, 15);
            this.ground_5.TabIndex = 6;
            this.ground_5.Tag = "platform";
            // 
            // ground_4
            // 
            this.ground_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ground_4.Location = new System.Drawing.Point(12, 311);
            this.ground_4.Name = "ground_4";
            this.ground_4.Size = new System.Drawing.Size(100, 15);
            this.ground_4.TabIndex = 7;
            this.ground_4.Tag = "platform";
            // 
            // ground_1
            // 
            this.ground_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ground_1.Location = new System.Drawing.Point(152, 607);
            this.ground_1.Name = "ground_1";
            this.ground_1.Size = new System.Drawing.Size(100, 15);
            this.ground_1.TabIndex = 8;
            this.ground_1.Tag = "platform";
            // 
            // ground_3
            // 
            this.ground_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ground_3.Location = new System.Drawing.Point(51, 474);
            this.ground_3.Name = "ground_3";
            this.ground_3.Size = new System.Drawing.Size(100, 15);
            this.ground_3.TabIndex = 9;
            this.ground_3.Tag = "platform";
            // 
            // ground_2
            // 
            this.ground_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ground_2.Location = new System.Drawing.Point(370, 527);
            this.ground_2.Name = "ground_2";
            this.ground_2.Size = new System.Drawing.Size(100, 15);
            this.ground_2.TabIndex = 5;
            this.ground_2.Tag = "platform";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_start.Image")));
            this.btn_start.Location = new System.Drawing.Point(166, 311);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(161, 89);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_start.TabIndex = 14;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Vast Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_score.ForeColor = System.Drawing.Color.Red;
            this.lbl_score.Location = new System.Drawing.Point(7, 9);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(128, 25);
            this.lbl_score.TabIndex = 15;
            this.lbl_score.Text = "Score: 0";
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.Transparent;
            this.btn_restart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_restart.BackgroundImage")));
            this.btn_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_restart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_restart.Location = new System.Drawing.Point(67, 166);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(109, 40);
            this.btn_restart.TabIndex = 17;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // lbl_high_score
            // 
            this.lbl_high_score.AutoSize = true;
            this.lbl_high_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_high_score.Font = new System.Drawing.Font("Vast Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_high_score.ForeColor = System.Drawing.Color.White;
            this.lbl_high_score.Location = new System.Drawing.Point(22, 53);
            this.lbl_high_score.Name = "lbl_high_score";
            this.lbl_high_score.Size = new System.Drawing.Size(202, 30);
            this.lbl_high_score.TabIndex = 18;
            this.lbl_high_score.Text = "High Score";
            // 
            // lbl_point
            // 
            this.lbl_point.AutoSize = true;
            this.lbl_point.BackColor = System.Drawing.Color.Transparent;
            this.lbl_point.Font = new System.Drawing.Font("Vast Shadow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_point.ForeColor = System.Drawing.Color.White;
            this.lbl_point.Location = new System.Drawing.Point(55, 111);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(114, 25);
            this.lbl_point.TabIndex = 3;
            this.lbl_point.Text = "Point: 0";
            // 
            // gb_high_score
            // 
            this.gb_high_score.BackgroundImage = global::NewGame.Properties.Resources.bg_high_score;
            this.gb_high_score.Controls.Add(this.btn_restart);
            this.gb_high_score.Controls.Add(this.lbl_high_score);
            this.gb_high_score.Controls.Add(this.lbl_point);
            this.gb_high_score.Location = new System.Drawing.Point(118, 218);
            this.gb_high_score.Name = "gb_high_score";
            this.gb_high_score.Size = new System.Drawing.Size(248, 232);
            this.gb_high_score.TabIndex = 19;
            this.gb_high_score.TabStop = false;
            this.gb_high_score.Visible = false;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Lime;
            this.top_panel.Location = new System.Drawing.Point(118, 218);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(248, 10);
            this.top_panel.TabIndex = 19;
            this.top_panel.Visible = false;
            // 
            // RollBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.gb_high_score);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.picture_ball);
            this.Controls.Add(this.ground_8);
            this.Controls.Add(this.ground_7);
            this.Controls.Add(this.ground_6);
            this.Controls.Add(this.ground_5);
            this.Controls.Add(this.ground_4);
            this.Controls.Add(this.ground_1);
            this.Controls.Add(this.ground_3);
            this.Controls.Add(this.ground_2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RollBall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RollBall";
            this.Load += new System.EventHandler(this.RollBall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            this.gb_high_score.ResumeLayout(false);
            this.gb_high_score.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_ball;
        private System.Windows.Forms.Panel ground_8;
        private System.Windows.Forms.Panel ground_7;
        private System.Windows.Forms.Panel ground_6;
        private System.Windows.Forms.Panel ground_5;
        private System.Windows.Forms.Panel ground_4;
        private System.Windows.Forms.Panel ground_1;
        private System.Windows.Forms.Panel ground_3;
        private System.Windows.Forms.Panel ground_2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label lbl_high_score;
        private System.Windows.Forms.Label lbl_point;
        private System.Windows.Forms.GroupBox gb_high_score;
        private System.Windows.Forms.Panel top_panel;
    }
}

