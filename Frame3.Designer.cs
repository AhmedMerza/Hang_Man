namespace Hang_Man
{
    partial class Frame3
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
            this.WinLoseL = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.RDNormal = new System.Windows.Forms.RadioButton();
            this.RDHard = new System.Windows.Forms.RadioButton();
            this.RDEazy = new System.Windows.Forms.RadioButton();
            this.DifficultL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WinLoseL
            // 
            this.WinLoseL.AutoSize = true;
            this.WinLoseL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinLoseL.ForeColor = System.Drawing.Color.LimeGreen;
            this.WinLoseL.Location = new System.Drawing.Point(12, 43);
            this.WinLoseL.Name = "WinLoseL";
            this.WinLoseL.Size = new System.Drawing.Size(161, 25);
            this.WinLoseL.TabIndex = 0;
            this.WinLoseL.Text = "You have won";
            this.WinLoseL.Click += new System.EventHandler(this.WinLoseL_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(41, 191);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(98, 50);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // RDNormal
            // 
            this.RDNormal.AutoSize = true;
            this.RDNormal.Location = new System.Drawing.Point(69, 134);
            this.RDNormal.Name = "RDNormal";
            this.RDNormal.Size = new System.Drawing.Size(58, 17);
            this.RDNormal.TabIndex = 7;
            this.RDNormal.Text = "Normal";
            this.RDNormal.UseVisualStyleBackColor = true;
            // 
            // RDHard
            // 
            this.RDHard.AutoSize = true;
            this.RDHard.Location = new System.Drawing.Point(133, 134);
            this.RDHard.Name = "RDHard";
            this.RDHard.Size = new System.Drawing.Size(48, 17);
            this.RDHard.TabIndex = 8;
            this.RDHard.Text = "Hard";
            this.RDHard.UseVisualStyleBackColor = true;
            // 
            // RDEazy
            // 
            this.RDEazy.AutoSize = true;
            this.RDEazy.Location = new System.Drawing.Point(15, 134);
            this.RDEazy.Name = "RDEazy";
            this.RDEazy.Size = new System.Drawing.Size(48, 17);
            this.RDEazy.TabIndex = 6;
            this.RDEazy.Text = "Eazy";
            this.RDEazy.UseVisualStyleBackColor = true;
            // 
            // DifficultL
            // 
            this.DifficultL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DifficultL.AutoSize = true;
            this.DifficultL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultL.Location = new System.Drawing.Point(60, 94);
            this.DifficultL.Name = "DifficultL";
            this.DifficultL.Size = new System.Drawing.Size(79, 20);
            this.DifficultL.TabIndex = 5;
            this.DifficultL.Text = "Difficulty";
            // 
            // Frame3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 259);
            this.Controls.Add(this.RDNormal);
            this.Controls.Add(this.RDHard);
            this.Controls.Add(this.RDEazy);
            this.Controls.Add(this.DifficultL);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.WinLoseL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frame3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hang Man";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WinLoseL;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.RadioButton RDNormal;
        private System.Windows.Forms.RadioButton RDHard;
        private System.Windows.Forms.RadioButton RDEazy;
        private System.Windows.Forms.Label DifficultL;
    }
}