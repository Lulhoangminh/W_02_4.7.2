namespace W_02_4._7._2
{
    partial class Form_Begin
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
            this.label_start = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_start.Location = new System.Drawing.Point(163, 133);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(494, 58);
            this.label_start.TabIndex = 0;
            this.label_start.Text = "BẮT ĐẦU CUỘC THI";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(242, 223);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(319, 95);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Form_Begin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_Begin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Button button_start;
    }
}