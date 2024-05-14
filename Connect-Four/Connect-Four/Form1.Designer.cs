namespace Connect_Four
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit_Game = new System.Windows.Forms.Button();
            this.Play_Game = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Connect_Four.Properties.Resources.ConnectFour;
            this.pictureBox1.Location = new System.Drawing.Point(42, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Exit_Game
            // 
            this.Exit_Game.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Exit_Game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_Game.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.Exit_Game.Location = new System.Drawing.Point(471, 333);
            this.Exit_Game.Name = "Exit_Game";
            this.Exit_Game.Size = new System.Drawing.Size(220, 62);
            this.Exit_Game.TabIndex = 8;
            this.Exit_Game.Text = "Exit";
            this.Exit_Game.UseVisualStyleBackColor = false;
            this.Exit_Game.Click += new System.EventHandler(this.Exit_Game_Click);
            // 
            // Play_Game
            // 
            this.Play_Game.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Play_Game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play_Game.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.Play_Game.Location = new System.Drawing.Point(426, 248);
            this.Play_Game.Name = "Play_Game";
            this.Play_Game.Size = new System.Drawing.Size(309, 65);
            this.Play_Game.TabIndex = 7;
            this.Play_Game.Text = "Play Game";
            this.Play_Game.UseVisualStyleBackColor = false;
            this.Play_Game.Click += new System.EventHandler(this.Play_Game_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 98);
            this.label1.TabIndex = 6;
            this.label1.Text = "Connect-Four";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit_Game);
            this.Controls.Add(this.Play_Game);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect-Fouer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exit_Game;
        private System.Windows.Forms.Button Play_Game;
        private System.Windows.Forms.Label label1;
    }
}

