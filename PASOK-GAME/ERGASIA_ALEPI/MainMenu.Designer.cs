namespace ERGASIA_ALEPI
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.buttonstart = new System.Windows.Forms.Button();
            this.buttonquit = new System.Windows.Forms.Button();
            this.buttonscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1045, 478);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelname.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelname.Location = new System.Drawing.Point(234, 108);
            this.labelname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(469, 73);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "ΠΑΣΟΚ GAME";
            // 
            // buttonstart
            // 
            this.buttonstart.BackColor = System.Drawing.Color.White;
            this.buttonstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonstart.Location = new System.Drawing.Point(639, 767);
            this.buttonstart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(348, 93);
            this.buttonstart.TabIndex = 2;
            this.buttonstart.Text = "Start Game";
            this.buttonstart.UseVisualStyleBackColor = false;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttonquit
            // 
            this.buttonquit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonquit.Location = new System.Drawing.Point(0, 767);
            this.buttonquit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonquit.Name = "buttonquit";
            this.buttonquit.Size = new System.Drawing.Size(348, 93);
            this.buttonquit.TabIndex = 3;
            this.buttonquit.Text = "Quit Game";
            this.buttonquit.UseVisualStyleBackColor = true;
            this.buttonquit.Click += new System.EventHandler(this.buttonquit_Click);
            // 
            // buttonscore
            // 
            this.buttonscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonscore.Location = new System.Drawing.Point(410, 767);
            this.buttonscore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonscore.Name = "buttonscore";
            this.buttonscore.Size = new System.Drawing.Size(161, 93);
            this.buttonscore.TabIndex = 4;
            this.buttonscore.Text = "Score";
            this.buttonscore.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ERGASIA_ALEPI.Properties.Resources.MONEY;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.buttonscore);
            this.Controls.Add(this.buttonquit);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ΠΑΣΟΚ GAME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Button buttonquit;
        private System.Windows.Forms.Button buttonscore;
    }
}