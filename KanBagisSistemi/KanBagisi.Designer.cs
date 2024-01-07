namespace KanBagisSistemi
{
    partial class KanBagisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KanBagisi));
            StandartBagisBtn = new Button();
            ımageList1 = new ImageList(components);
            IstekUzerineBagis = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // StandartBagisBtn
            // 
            StandartBagisBtn.Font = new Font("Segoe UI Variable Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            StandartBagisBtn.ImageAlign = ContentAlignment.MiddleRight;
            StandartBagisBtn.ImageKey = "icons8-blood-64 (1).png";
            StandartBagisBtn.ImageList = ımageList1;
            StandartBagisBtn.Location = new Point(79, 195);
            StandartBagisBtn.Name = "StandartBagisBtn";
            StandartBagisBtn.Size = new Size(276, 93);
            StandartBagisBtn.TabIndex = 0;
            StandartBagisBtn.Text = "STANDART BAĞIŞ";
            StandartBagisBtn.TextAlign = ContentAlignment.MiddleLeft;
            StandartBagisBtn.UseVisualStyleBackColor = true;
            StandartBagisBtn.Click += StandartBagisBtn_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-blood-64 (1).png");
            ımageList1.Images.SetKeyName(1, "icons8-blood-64.png");
            // 
            // IstekUzerineBagis
            // 
            IstekUzerineBagis.Font = new Font("Segoe UI Variable Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            IstekUzerineBagis.ImageAlign = ContentAlignment.MiddleRight;
            IstekUzerineBagis.ImageKey = "icons8-blood-64.png";
            IstekUzerineBagis.ImageList = ımageList1;
            IstekUzerineBagis.Location = new Point(440, 190);
            IstekUzerineBagis.Name = "IstekUzerineBagis";
            IstekUzerineBagis.Size = new Size(276, 98);
            IstekUzerineBagis.TabIndex = 1;
            IstekUzerineBagis.Text = "İSTEK ÜZERİNE BAĞIŞ";
            IstekUzerineBagis.TextAlign = ContentAlignment.MiddleLeft;
            IstekUzerineBagis.UseVisualStyleBackColor = true;
            IstekUzerineBagis.Click += IstekUzerineBagis_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 11);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "GERİ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KanBagisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(823, 464);
            Controls.Add(button1);
            Controls.Add(IstekUzerineBagis);
            Controls.Add(StandartBagisBtn);
            Name = "KanBagisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KanBagisi";
            ResumeLayout(false);
        }

        #endregion

        private Button StandartBagisBtn;
        private Button IstekUzerineBagis;
        private ImageList ımageList1;
        private Button button1;
    }
}