namespace Week_16
{
    partial class FormWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWindow));
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLoad.BackgroundImage")));
            this.buttonLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLoad.Location = new System.Drawing.Point(12, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(25, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlay.BackgroundImage")));
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlay.Location = new System.Drawing.Point(43, 12);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(25, 23);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStop.BackgroundImage")));
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStop.Location = new System.Drawing.Point(74, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(25, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // FormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 50);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonLoad);
            this.Name = "FormWindow";
            this.ShowIcon = false;
            this.Text = "Player";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
    }
}