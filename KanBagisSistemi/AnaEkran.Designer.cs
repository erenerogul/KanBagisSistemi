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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            KanBagisBtn = new Button();
            ımageList1 = new ImageList(components);
            KanTakipBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // KanBagisBtn
            // 
            KanBagisBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            KanBagisBtn.ImageAlign = ContentAlignment.TopCenter;
            KanBagisBtn.ImageKey = "icons8-health-64 (2).png";
            KanBagisBtn.ImageList = ımageList1;
            KanBagisBtn.Location = new Point(233, 188);
            KanBagisBtn.Name = "KanBagisBtn";
            KanBagisBtn.Size = new Size(160, 113);
            KanBagisBtn.TabIndex = 0;
            KanBagisBtn.Text = "KAN BAĞIŞI";
            KanBagisBtn.TextAlign = ContentAlignment.BottomCenter;
            KanBagisBtn.UseVisualStyleBackColor = true;
            KanBagisBtn.Click += KanBagisBtn_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-health-64 (1).png");
            ımageList1.Images.SetKeyName(1, "icons8-health-64 (2).png");
            // 
            // KanTakipBtn
            // 
            KanTakipBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            KanTakipBtn.ImageAlign = ContentAlignment.TopCenter;
            KanTakipBtn.ImageKey = "icons8-health-64 (1).png";
            KanTakipBtn.ImageList = ımageList1;
            KanTakipBtn.Location = new Point(420, 188);
            KanTakipBtn.Name = "KanTakipBtn";
            KanTakipBtn.Size = new Size(163, 113);
            KanTakipBtn.TabIndex = 1;
            KanTakipBtn.Text = "KAN BAĞIŞ TAKİP";
            KanTakipBtn.TextAlign = ContentAlignment.BottomCenter;
            KanTakipBtn.UseVisualStyleBackColor = true;
            KanTakipBtn.Click += KanTakipBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Tahoma", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(141, 93);
            label1.Name = "label1";
            label1.Size = new Size(551, 45);
            label1.TabIndex = 2;
            label1.Text = "Kan bağışı geleceğe bağıştır.";
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 456);
            Controls.Add(label1);
            Controls.Add(KanTakipBtn);
            Controls.Add(KanBagisBtn);
            Name = "AnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaEkran";
            Load += AnaEkran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button KanBagisBtn;
        private Button KanTakipBtn;
        private Label label1;
        private ImageList ımageList1;
    }
}