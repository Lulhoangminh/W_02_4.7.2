namespace W_02_4._7._2
{
    partial class selectForm
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
            this.titleForm = new System.Windows.Forms.Label();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.quesComboBox = new System.Windows.Forms.ComboBox();
            this.levelButton = new System.Windows.Forms.Button();
            this.quesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleForm
            // 
            this.titleForm.AutoSize = true;
            this.titleForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleForm.Location = new System.Drawing.Point(85, 66);
            this.titleForm.Name = "titleForm";
            this.titleForm.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.titleForm.Size = new System.Drawing.Size(214, 69);
            this.titleForm.TabIndex = 0;
            this.titleForm.Text = "Nhập Điểm";
            // 
            // levelComboBox
            // 
            this.levelComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.levelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Location = new System.Drawing.Point(90, 208);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(314, 37);
            this.levelComboBox.TabIndex = 1;
            // 
            // quesComboBox
            // 
            this.quesComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quesComboBox.FormattingEnabled = true;
            this.quesComboBox.Location = new System.Drawing.Point(90, 295);
            this.quesComboBox.Name = "quesComboBox";
            this.quesComboBox.Size = new System.Drawing.Size(314, 37);
            this.quesComboBox.TabIndex = 2;
            // 
            // levelButton
            // 
            this.levelButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.levelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelButton.Location = new System.Drawing.Point(458, 207);
            this.levelButton.Name = "levelButton";
            this.levelButton.Size = new System.Drawing.Size(186, 37);
            this.levelButton.TabIndex = 3;
            this.levelButton.Text = "chọn level";
            this.levelButton.UseVisualStyleBackColor = true;
            // 
            // quesButton
            // 
            this.quesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quesButton.Location = new System.Drawing.Point(458, 294);
            this.quesButton.Name = "quesButton";
            this.quesButton.Size = new System.Drawing.Size(186, 36);
            this.quesButton.TabIndex = 4;
            this.quesButton.Text = "hiển thị câu hỏi";
            this.quesButton.UseVisualStyleBackColor = true;
            // 
            // selectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.quesButton);
            this.Controls.Add(this.levelButton);
            this.Controls.Add(this.quesComboBox);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(this.titleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "selectForm";
            this.Text = "selectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleForm;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.ComboBox quesComboBox;
        private System.Windows.Forms.Button levelButton;
        private System.Windows.Forms.Button quesButton;
    }
}