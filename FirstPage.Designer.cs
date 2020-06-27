namespace Hang_Man
{
    partial class FirstPage
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
            this.tbnPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RDNormal = new System.Windows.Forms.RadioButton();
            this.RDHard = new System.Windows.Forms.RadioButton();
            this.RDEazy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbnPlay
            // 
            this.tbnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbnPlay.Location = new System.Drawing.Point(68, 423);
            this.tbnPlay.Name = "tbnPlay";
            this.tbnPlay.Size = new System.Drawing.Size(75, 23);
            this.tbnPlay.TabIndex = 0;
            this.tbnPlay.Text = "Play";
            this.tbnPlay.UseVisualStyleBackColor = true;
            this.tbnPlay.Click += new System.EventHandler(this.buttonPLay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hang_Man.Properties.Resources._10;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 319);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RDNormal);
            this.panel2.Controls.Add(this.RDHard);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.tbnPlay);
            this.panel2.Controls.Add(this.RDEazy);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 460);
            this.panel2.TabIndex = 3;
            // 
            // RDNormal
            // 
            this.RDNormal.AutoSize = true;
            this.RDNormal.Location = new System.Drawing.Point(73, 374);
            this.RDNormal.Name = "RDNormal";
            this.RDNormal.Size = new System.Drawing.Size(58, 17);
            this.RDNormal.TabIndex = 3;
            this.RDNormal.Text = "Normal";
            this.RDNormal.UseVisualStyleBackColor = true;
            this.RDNormal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RDHard
            // 
            this.RDHard.AutoSize = true;
            this.RDHard.Location = new System.Drawing.Point(137, 374);
            this.RDHard.Name = "RDHard";
            this.RDHard.Size = new System.Drawing.Size(48, 17);
            this.RDHard.TabIndex = 4;
            this.RDHard.Text = "Hard";
            this.RDHard.UseVisualStyleBackColor = true;
            this.RDHard.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RDEazy
            // 
            this.RDEazy.AutoSize = true;
            this.RDEazy.Location = new System.Drawing.Point(19, 374);
            this.RDEazy.Name = "RDEazy";
            this.RDEazy.Size = new System.Drawing.Size(48, 17);
            this.RDEazy.TabIndex = 2;
            this.RDEazy.Text = "Eazy";
            this.RDEazy.UseVisualStyleBackColor = true;
            this.RDEazy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Difficulty";
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(204, 462);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FirstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hang Man";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbnPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RDEazy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RDHard;
        private System.Windows.Forms.RadioButton RDNormal;
    }
}

