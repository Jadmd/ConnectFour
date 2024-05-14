namespace Connect_Four
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Draw_Lap = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.new_game = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.P_red = new System.Windows.Forms.Label();
            this.P_yellow = new System.Windows.Forms.Label();
            this.Player_yellow = new System.Windows.Forms.Label();
            this.Player_red = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Draw_Lap
            // 
            this.Draw_Lap.AutoSize = true;
            this.Draw_Lap.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Draw_Lap.Location = new System.Drawing.Point(676, 181);
            this.Draw_Lap.Name = "Draw_Lap";
            this.Draw_Lap.Size = new System.Drawing.Size(33, 34);
            this.Draw_Lap.TabIndex = 22;
            this.Draw_Lap.Text = "0";
            // 
            // Draw
            // 
            this.Draw.AutoSize = true;
            this.Draw.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Draw.Location = new System.Drawing.Point(462, 181);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(90, 34);
            this.Draw.TabIndex = 21;
            this.Draw.Text = "Draw";
            // 
            // new_game
            // 
            this.new_game.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.new_game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.new_game.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_game.Location = new System.Drawing.Point(450, 263);
            this.new_game.Name = "new_game";
            this.new_game.Size = new System.Drawing.Size(296, 58);
            this.new_game.TabIndex = 20;
            this.new_game.Text = "New Game";
            this.new_game.UseVisualStyleBackColor = false;
            this.new_game.Click += new System.EventHandler(this.new_game_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(481, 339);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(226, 58);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // P_red
            // 
            this.P_red.AutoSize = true;
            this.P_red.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_red.Location = new System.Drawing.Point(676, 108);
            this.P_red.Name = "P_red";
            this.P_red.Size = new System.Drawing.Size(33, 34);
            this.P_red.TabIndex = 18;
            this.P_red.Text = "0";
            // 
            // P_yellow
            // 
            this.P_yellow.AutoSize = true;
            this.P_yellow.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_yellow.Location = new System.Drawing.Point(676, 35);
            this.P_yellow.Name = "P_yellow";
            this.P_yellow.Size = new System.Drawing.Size(33, 34);
            this.P_yellow.TabIndex = 17;
            this.P_yellow.Text = "0";
            // 
            // Player_yellow
            // 
            this.Player_yellow.AutoSize = true;
            this.Player_yellow.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_yellow.Location = new System.Drawing.Point(462, 35);
            this.Player_yellow.Name = "Player_yellow";
            this.Player_yellow.Size = new System.Drawing.Size(202, 34);
            this.Player_yellow.TabIndex = 16;
            this.Player_yellow.Text = "Player yellow";
            // 
            // Player_red
            // 
            this.Player_red.AutoSize = true;
            this.Player_red.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_red.Location = new System.Drawing.Point(462, 108);
            this.Player_red.Name = "Player_red";
            this.Player_red.Size = new System.Drawing.Size(166, 34);
            this.Player_red.TabIndex = 15;
            this.Player_red.Text = "Player red ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.Draw_Lap);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.new_game);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.P_red);
            this.Controls.Add(this.P_yellow);
            this.Controls.Add(this.Player_yellow);
            this.Controls.Add(this.Player_red);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect-Fouer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Draw_Lap;
        private System.Windows.Forms.Label Draw;
        private System.Windows.Forms.Button new_game;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label P_red;
        private System.Windows.Forms.Label P_yellow;
        private System.Windows.Forms.Label Player_yellow;
        private System.Windows.Forms.Label Player_red;
    }
}