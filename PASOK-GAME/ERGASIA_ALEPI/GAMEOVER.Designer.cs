namespace ERGASIA_ALEPI
{
    partial class GAMEOVER
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
            this.buttonquit = new System.Windows.Forms.Button();
            this.buttonmain = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonquit
            // 
            this.buttonquit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonquit.Location = new System.Drawing.Point(-1, 713);
            this.buttonquit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonquit.Name = "buttonquit";
            this.buttonquit.Size = new System.Drawing.Size(348, 93);
            this.buttonquit.TabIndex = 7;
            this.buttonquit.Text = "Quit Game";
            this.buttonquit.UseVisualStyleBackColor = true;
            this.buttonquit.Click += new System.EventHandler(this.buttonquit_Click);
            // 
            // buttonmain
            // 
            this.buttonmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonmain.Location = new System.Drawing.Point(638, 713);
            this.buttonmain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonmain.Name = "buttonmain";
            this.buttonmain.Size = new System.Drawing.Size(348, 93);
            this.buttonmain.TabIndex = 6;
            this.buttonmain.Text = "Main Menu";
            this.buttonmain.UseVisualStyleBackColor = true;
            this.buttonmain.Click += new System.EventHandler(this.ButtonMainMenu);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelname.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelname.Location = new System.Drawing.Point(220, 59);
            this.labelname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(592, 73);
            this.labelname.TabIndex = 5;
            this.labelname.Text = "ΛΕΦΤΑ ΥΠΗΡΧΑΝ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(395, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "SCORE : X";
            // 
            // GAMEOVER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ERGASIA_ALEPI.Properties.Resources.MONEY;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonquit);
            this.Controls.Add(this.buttonmain);
            this.Controls.Add(this.labelname);
            this.Name = "GAMEOVER";
            this.Text = "GAMEOVER";
            this.Load += new System.EventHandler(this.GAMEOVER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonquit;
        private System.Windows.Forms.Button buttonmain;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label1;
    }
}