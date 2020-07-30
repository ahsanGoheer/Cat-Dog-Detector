namespace Cat_Detector
{
    partial class catDogDetector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catDogDetector));
            this.imagePathTb = new System.Windows.Forms.TextBox();
            this.loadImageBtn = new System.Windows.Forms.Button();
            this.pictureHolder = new System.Windows.Forms.PictureBox();
            this.predictBtn = new System.Windows.Forms.Button();
            this.statusRtb = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePathTb
            // 
            this.imagePathTb.Location = new System.Drawing.Point(299, 33);
            this.imagePathTb.Name = "imagePathTb";
            this.imagePathTb.ReadOnly = true;
            this.imagePathTb.Size = new System.Drawing.Size(247, 22);
            this.imagePathTb.TabIndex = 0;
            // 
            // loadImageBtn
            // 
            this.loadImageBtn.Location = new System.Drawing.Point(589, 21);
            this.loadImageBtn.Name = "loadImageBtn";
            this.loadImageBtn.Size = new System.Drawing.Size(75, 47);
            this.loadImageBtn.TabIndex = 1;
            this.loadImageBtn.Text = "Load";
            this.loadImageBtn.UseVisualStyleBackColor = true;
            this.loadImageBtn.Click += new System.EventHandler(this.loadImageBtn_Click);
            // 
            // pictureHolder
            // 
            this.pictureHolder.Location = new System.Drawing.Point(259, 90);
            this.pictureHolder.Name = "pictureHolder";
            this.pictureHolder.Size = new System.Drawing.Size(364, 321);
            this.pictureHolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHolder.TabIndex = 2;
            this.pictureHolder.TabStop = false;
            // 
            // predictBtn
            // 
            this.predictBtn.Location = new System.Drawing.Point(396, 437);
            this.predictBtn.Name = "predictBtn";
            this.predictBtn.Size = new System.Drawing.Size(109, 51);
            this.predictBtn.TabIndex = 3;
            this.predictBtn.Text = "Predict";
            this.predictBtn.UseVisualStyleBackColor = true;
            this.predictBtn.Click += new System.EventHandler(this.predictBtn_Click);
            // 
            // statusRtb
            // 
            this.statusRtb.Location = new System.Drawing.Point(703, 155);
            this.statusRtb.Name = "statusRtb";
            this.statusRtb.Size = new System.Drawing.Size(211, 158);
            this.statusRtb.TabIndex = 4;
            this.statusRtb.Text = "";
            // 
            // catDogDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 541);
            this.Controls.Add(this.statusRtb);
            this.Controls.Add(this.predictBtn);
            this.Controls.Add(this.pictureHolder);
            this.Controls.Add(this.loadImageBtn);
            this.Controls.Add(this.imagePathTb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "catDogDetector";
            this.Text = "Cat Dog Detector";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imagePathTb;
        private System.Windows.Forms.Button loadImageBtn;
        private System.Windows.Forms.PictureBox pictureHolder;
        private System.Windows.Forms.Button predictBtn;
        private System.Windows.Forms.RichTextBox statusRtb;
    }
}

