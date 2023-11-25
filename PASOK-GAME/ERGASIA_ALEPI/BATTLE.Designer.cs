namespace ERGASIA_ALEPI
{
    partial class BATTLE
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
            this.label_score = new System.Windows.Forms.Label();
            this.label_life = new System.Windows.Forms.Label();
            this.lifebar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.movement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_score.ForeColor = System.Drawing.Color.White;
            this.label_score.Location = new System.Drawing.Point(12, 812);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(122, 31);
            this.label_score.TabIndex = 1;
            this.label_score.Text = "Score : 0";
            // 
            // label_life
            // 
            this.label_life.AutoSize = true;
            this.label_life.BackColor = System.Drawing.Color.Transparent;
            this.label_life.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_life.ForeColor = System.Drawing.Color.White;
            this.label_life.Location = new System.Drawing.Point(839, 786);
            this.label_life.Name = "label_life";
            this.label_life.Size = new System.Drawing.Size(72, 31);
            this.label_life.TabIndex = 2;
            this.label_life.Text = "LIFE";
            // 
            // lifebar
            // 
            this.lifebar.Location = new System.Drawing.Point(778, 820);
            this.lifebar.Maximum = 10;
            this.lifebar.Name = "lifebar";
            this.lifebar.Size = new System.Drawing.Size(194, 23);
            this.lifebar.TabIndex = 3;
            this.lifebar.Tag = "lifebar";
            this.lifebar.Value = 10;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Image = global::ERGASIA_ALEPI.Properties.Resources.PLAYER;
            this.player.Location = new System.Drawing.Point(422, 643);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(114, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Black;
            this.enemy.Image = global::ERGASIA_ALEPI.Properties.Resources.PIG;
            this.enemy.Location = new System.Drawing.Point(422, 12);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(114, 99);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy.TabIndex = 5;
            this.enemy.TabStop = false;
            this.enemy.Tag = "enemy";
            this.enemy.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1600;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 6;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // movement
            // 
            this.movement.Enabled = true;
            this.movement.Interval = 20;
            this.movement.Tick += new System.EventHandler(this.movement_Tick);
            // 
            // BATTLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ERGASIA_ALEPI.Properties.Resources.MONEY;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.player);
            this.Controls.Add(this.lifebar);
            this.Controls.Add(this.label_life);
            this.Controls.Add(this.label_score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BATTLE";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BATTLE_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_life;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        public System.Windows.Forms.PictureBox player;
        public System.Windows.Forms.PictureBox enemy;
        public System.Windows.Forms.ProgressBar lifebar;
        public System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Timer movement;
    }
}

