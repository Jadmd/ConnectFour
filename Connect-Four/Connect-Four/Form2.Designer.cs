namespace Connect_Four
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label2 = new System.Windows.Forms.Label();
            this.Player1_Vs_Player2 = new System.Windows.Forms.Button();
            this.Player_Vs_combeotar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 90);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mode";
            // 
            // Player1_Vs_Player2
            // 
            this.Player1_Vs_Player2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Player1_Vs_Player2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Player1_Vs_Player2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.Player1_Vs_Player2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Player1_Vs_Player2.Location = new System.Drawing.Point(404, 283);
            this.Player1_Vs_Player2.Name = "Player1_Vs_Player2";
            this.Player1_Vs_Player2.Size = new System.Drawing.Size(361, 72);
            this.Player1_Vs_Player2.TabIndex = 11;
            this.Player1_Vs_Player2.Text = "Player vs Player";
            this.Player1_Vs_Player2.UseVisualStyleBackColor = false;
            this.Player1_Vs_Player2.Click += new System.EventHandler(this.Player1_Vs_Player2_Click);
            // 
            // Player_Vs_combeotar
            // 
            this.Player_Vs_combeotar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Player_Vs_combeotar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Player_Vs_combeotar.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.Player_Vs_combeotar.Location = new System.Drawing.Point(19, 283);
            this.Player_Vs_combeotar.Name = "Player_Vs_combeotar";
            this.Player_Vs_combeotar.Size = new System.Drawing.Size(346, 72);
            this.Player_Vs_combeotar.TabIndex = 10;
            this.Player_Vs_combeotar.Text = "Player Vs Computer";
            this.Player_Vs_combeotar.UseVisualStyleBackColor = false;
            this.Player_Vs_combeotar.Click += new System.EventHandler(this.Player_Vs_combeotar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 90);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose Game ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player1_Vs_Player2);
            this.Controls.Add(this.Player_Vs_combeotar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect-Fouer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Player1_Vs_Player2;
        private System.Windows.Forms.Button Player_Vs_combeotar;
        private System.Windows.Forms.Label label1;
    }
}