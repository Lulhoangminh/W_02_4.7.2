namespace W_02_4._7._2
{
    partial class Form_InputTeam
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
            this.label_chooseplayer1 = new System.Windows.Forms.Label();
            this.label_chooseplayer2 = new System.Windows.Forms.Label();
            this.comboBox_player1 = new System.Windows.Forms.ComboBox();
            this.comboBox_player2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_chooseplayer1
            // 
            this.label_chooseplayer1.AutoSize = true;
            this.label_chooseplayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chooseplayer1.Location = new System.Drawing.Point(25, 156);
            this.label_chooseplayer1.Name = "label_chooseplayer1";
            this.label_chooseplayer1.Size = new System.Drawing.Size(206, 29);
            this.label_chooseplayer1.TabIndex = 0;
            this.label_chooseplayer1.Text = "Chọn người chơi 1";
            // 
            // label_chooseplayer2
            // 
            this.label_chooseplayer2.AutoSize = true;
            this.label_chooseplayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chooseplayer2.Location = new System.Drawing.Point(359, 156);
            this.label_chooseplayer2.Name = "label_chooseplayer2";
            this.label_chooseplayer2.Size = new System.Drawing.Size(206, 29);
            this.label_chooseplayer2.TabIndex = 1;
            this.label_chooseplayer2.Text = "Chọn người chơi 2";
            // 
            // comboBox_player1
            // 
            this.comboBox_player1.FormattingEnabled = true;
            this.comboBox_player1.Location = new System.Drawing.Point(30, 197);
            this.comboBox_player1.Name = "comboBox_player1";
            this.comboBox_player1.Size = new System.Drawing.Size(285, 24);
            this.comboBox_player1.TabIndex = 2;
            this.comboBox_player1.DropDown += new System.EventHandler(this.comboBox_player1_DropDown);
            // 
            // comboBox_player2
            // 
            this.comboBox_player2.FormattingEnabled = true;
            this.comboBox_player2.Location = new System.Drawing.Point(364, 197);
            this.comboBox_player2.Name = "comboBox_player2";
            this.comboBox_player2.Size = new System.Drawing.Size(285, 24);
            this.comboBox_player2.TabIndex = 3;
            this.comboBox_player2.DropDown += new System.EventHandler(this.comboBox_player2_DropDown);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tiếp tục";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_Back
            // 
            this.button_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Back.Location = new System.Drawing.Point(30, 342);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(150, 75);
            this.button_Back.TabIndex = 5;
            this.button_Back.Text = "Quay lại";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Form_InputTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_player2);
            this.Controls.Add(this.comboBox_player1);
            this.Controls.Add(this.label_chooseplayer2);
            this.Controls.Add(this.label_chooseplayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_InputTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Management";
            this.Load += new System.EventHandler(this.Form_InputTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_chooseplayer1;
        private System.Windows.Forms.Label label_chooseplayer2;
        private System.Windows.Forms.ComboBox comboBox_player1;
        private System.Windows.Forms.ComboBox comboBox_player2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Back;
    }
}