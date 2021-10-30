namespace Week_13
{
    partial class Form1
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
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(12, 12);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(314, 20);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.Text = "Type something...";
            // 
            // buttonAsk
            // 
            this.buttonAsk.Location = new System.Drawing.Point(12, 38);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(314, 23);
            this.buttonAsk.TabIndex = 1;
            this.buttonAsk.Text = "ASK";
            this.buttonAsk.UseVisualStyleBackColor = true;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 68);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.textBoxQuestion);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ASK ME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonAsk;
    }
}

