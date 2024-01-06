namespace KanBagisSistemi
{
    partial class AnaEkran
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.KanBagisBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.KanTakipBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KanBagisBtn
            // 
            this.KanBagisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KanBagisBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KanBagisBtn.ImageKey = "icons8-health-64 (2).png";
            this.KanBagisBtn.ImageList = this.ımageList1;
            this.KanBagisBtn.Location = new System.Drawing.Point(162, 325);
            this.KanBagisBtn.Name = "KanBagisBtn";
            this.KanBagisBtn.Size = new System.Drawing.Size(160, 113);
            this.KanBagisBtn.TabIndex = 0;
            this.KanBagisBtn.Text = "KAN BAĞIŞI";
            this.KanBagisBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KanBagisBtn.UseVisualStyleBackColor = true;
            this.KanBagisBtn.Click += new System.EventHandler(this.KanBagisBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-health-64 (1).png");
            this.ımageList1.Images.SetKeyName(1, "icons8-health-64 (2).png");
            // 
            // KanTakipBtn
            // 
            this.KanTakipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KanTakipBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KanTakipBtn.ImageKey = "icons8-health-64 (1).png";
            this.KanTakipBtn.ImageList = this.ımageList1;
            this.KanTakipBtn.Location = new System.Drawing.Point(357, 325);
            this.KanTakipBtn.Name = "KanTakipBtn";
            this.KanTakipBtn.Size = new System.Drawing.Size(163, 113);
            this.KanTakipBtn.TabIndex = 1;
            this.KanTakipBtn.Text = "KAN BAĞIŞ TAKİP";
            this.KanTakipBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KanTakipBtn.UseVisualStyleBackColor = true;
            this.KanTakipBtn.Click += new System.EventHandler(this.KanTakipBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kan bağışı geleceğe bağıştır.";
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KanTakipBtn);
            this.Controls.Add(this.KanBagisBtn);
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button KanBagisBtn;
        private Button KanTakipBtn;
        private Label label1;
        private ImageList ımageList1;
    }
}