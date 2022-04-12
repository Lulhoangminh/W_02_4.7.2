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
            this.comboBox_Vong = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_pointplayer1 = new System.Windows.Forms.Label();
            this.label2_pointplayer2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_chonvong = new System.Windows.Forms.Label();
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
            this.playerName2.Location = new System.Drawing.Point(385, 61);
            this.playerName2.Name = "playerName2";
            this.playerName2.Padding = new System.Windows.Forms.Padding(20);
            this.playerName2.Size = new System.Drawing.Size(188, 69);
            this.playerName2.TabIndex = 1;
            this.playerName2.Text = "Người chơi 2";
            // 
            // comboBox_Vong
            // 
            this.comboBox_Vong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_Vong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Vong.FormattingEnabled = true;
            this.comboBox_Vong.Location = new System.Drawing.Point(163, 224);
            this.comboBox_Vong.Name = "comboBox_Vong";
            this.comboBox_Vong.Size = new System.Drawing.Size(338, 37);
            this.comboBox_Vong.TabIndex = 2;
            this.comboBox_Vong.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox_Vong.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(254, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_pointplayer1
            // 
            this.label_pointplayer1.AutoSize = true;
            this.label_pointplayer1.Location = new System.Drawing.Point(83, 151);
            this.label_pointplayer1.Name = "label_pointplayer1";
            this.label_pointplayer1.Size = new System.Drawing.Size(38, 16);
            this.label_pointplayer1.TabIndex = 4;
            this.label_pointplayer1.Text = "Điểm";
            // 
            // label2_pointplayer2
            // 
            this.label2_pointplayer2.AutoSize = true;
            this.label2_pointplayer2.Location = new System.Drawing.Point(387, 151);
            this.label2_pointplayer2.Name = "label2_pointplayer2";
            this.label2_pointplayer2.Size = new System.Drawing.Size(38, 16);
            this.label2_pointplayer2.TabIndex = 5;
            this.label2_pointplayer2.Text = "Điểm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(438, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label_chonvong
            // 
            this.label_chonvong.AutoSize = true;
            this.label_chonvong.Location = new System.Drawing.Point(163, 202);
            this.label_chonvong.Name = "label_chonvong";
            this.label_chonvong.Size = new System.Drawing.Size(74, 16);
            this.label_chonvong.TabIndex = 8;
            this.label_chonvong.Text = "Chọn vòng:";
            // 
            // roundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.label_chonvong);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2_pointplayer2);
            this.Controls.Add(this.label_pointplayer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_Vong);
            this.Controls.Add(this.playerName2);
            this.Controls.Add(this.playerName1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "roundForm";
            this.Text = "roundForm";
            this.Load += new System.EventHandler(this.roundForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerName1;
        private System.Windows.Forms.Label playerName2;
        private System.Windows.Forms.ComboBox comboBox_Vong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_pointplayer1;
        private System.Windows.Forms.Label label2_pointplayer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_chonvong;
    }
}