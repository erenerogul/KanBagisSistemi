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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_Form));
            Giris_btn = new Button();
            ımageList1 = new ImageList(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // Giris_btn
            // 
            Giris_btn.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Giris_btn.ImageAlign = ContentAlignment.TopCenter;
            Giris_btn.ImageKey = "icons8-health-64.png";
            Giris_btn.ImageList = ımageList1;
            Giris_btn.Location = new Point(323, 196);
            Giris_btn.Name = "Giris_btn";
            Giris_btn.Size = new Size(151, 105);
            Giris_btn.TabIndex = 0;
            Giris_btn.Text = "GİRİŞ";
            Giris_btn.TextAlign = ContentAlignment.BottomCenter;
            Giris_btn.UseVisualStyleBackColor = true;
            Giris_btn.Click += Giris_btn_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth16Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "healthcare (1).png");
            ımageList1.Images.SetKeyName(1, "icons8-health-64.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Sitka Display", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(177, 106);
            label1.Name = "label1";
            label1.Size = new Size(432, 53);
            label1.TabIndex = 1;
            label1.Text = "Kan bağışı yap can kurtar.";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Giris_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Giris_btn);
            Name = "Giris_Form";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Giris_btn;
        private ImageList ımageList1;
        private Label label1;
    }
}