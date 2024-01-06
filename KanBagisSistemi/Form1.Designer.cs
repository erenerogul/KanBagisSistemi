namespace KanBagisSistemi
{
    partial class Giris_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_Form));
            this.Giris_btn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Giris_btn
            // 
            this.Giris_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Giris_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Giris_btn.ImageKey = "icons8-health-64.png";
            this.Giris_btn.ImageList = this.ımageList1;
            this.Giris_btn.Location = new System.Drawing.Point(616, 307);
            this.Giris_btn.Name = "Giris_btn";
            this.Giris_btn.Size = new System.Drawing.Size(151, 105);
            this.Giris_btn.TabIndex = 0;
            this.Giris_btn.Text = "GİRİŞ";
            this.Giris_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Giris_btn.UseVisualStyleBackColor = true;
            this.Giris_btn.Click += new System.EventHandler(this.Giris_btn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "healthcare (1).png");
            this.ımageList1.Images.SetKeyName(1, "icons8-health-64.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(437, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kan bağışı yap can kurtar.";
            // 
            // Giris_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Giris_btn);
            this.Name = "Giris_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Giris_btn;
        private ImageList ımageList1;
        private Label label1;
    }
}