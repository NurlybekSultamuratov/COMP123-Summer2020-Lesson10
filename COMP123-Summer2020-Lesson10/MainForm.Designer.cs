namespace COMP123_Summer2020_Lesson10
{
    partial class MainForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.MainFormLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(1232, 930);
            this.NextButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(400, 119);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // MainFormLabel
            // 
            this.MainFormLabel.AutoSize = true;
            this.MainFormLabel.Location = new System.Drawing.Point(190, 64);
            this.MainFormLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MainFormLabel.Name = "MainFormLabel";
            this.MainFormLabel.Size = new System.Drawing.Size(142, 31);
            this.MainFormLabel.TabIndex = 3;
            this.MainFormLabel.Text = "Main Form";
            this.MainFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainFormLabel.Click += new System.EventHandler(this.MainFormLabel_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(370, 199);
            this.BackButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(196, 90);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // NextButton2
            // 
            this.NextButton2.Location = new System.Drawing.Point(47, 199);
            this.NextButton2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NextButton2.Name = "NextButton2";
            this.NextButton2.Size = new System.Drawing.Size(196, 90);
            this.NextButton2.TabIndex = 2;
            this.NextButton2.Text = "Next";
            this.NextButton2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.MainFormLabel);
            this.Controls.Add(this.NextButton2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label MainFormLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton2;
    }
}