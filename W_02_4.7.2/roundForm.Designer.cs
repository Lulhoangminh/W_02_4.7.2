namespace W_02_4._7._2
{
    partial class roundForm
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
            this.playerName1 = new System.Windows.Forms.Label();
            this.playerName2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerName1
            // 
            this.playerName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerName1.AutoSize = true;
            this.playerName1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerName1.Location = new System.Drawing.Point(78, 61);
            this.playerName1.Name = "playerName1";
            this.playerName1.Padding = new System.Windows.Forms.Padding(20);
            this.playerName1.Size = new System.Drawing.Size(188, 69);
            this.playerName1.TabIndex = 0;
            this.playerName1.Text = "Người chơi 1";
            // 
            // playerName2
            // 
            this.playerName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerName2.AutoSize = true;
            this.playerName2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerName2.Location = new System.Drawing.Point(450, 61);
            this.playerName2.Name = "playerName2";
            this.playerName2.Padding = new System.Windows.Forms.Padding(20);
            this.playerName2.Size = new System.Drawing.Size(188, 69);
            this.playerName2.TabIndex = 1;
            this.playerName2.Text = "Người chơi 2";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(338, 37);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // roundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.playerName2);
            this.Controls.Add(this.playerName1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "roundForm";
            this.Text = "roundForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerName1;
        private System.Windows.Forms.Label playerName2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}