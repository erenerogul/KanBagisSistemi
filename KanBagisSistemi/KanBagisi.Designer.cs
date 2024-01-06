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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KanBagisi));
            this.StandartBagisBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.IstekUzerineBagis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StandartBagisBtn
            // 
            this.StandartBagisBtn.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StandartBagisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StandartBagisBtn.ImageKey = "icons8-blood-64 (1).png";
            this.StandartBagisBtn.ImageList = this.ımageList1;
            this.StandartBagisBtn.Location = new System.Drawing.Point(58, 132);
            this.StandartBagisBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StandartBagisBtn.Name = "StandartBagisBtn";
            this.StandartBagisBtn.Size = new System.Drawing.Size(315, 124);
            this.StandartBagisBtn.TabIndex = 0;
            this.StandartBagisBtn.Text = "STANDART BAĞIŞ";
            this.StandartBagisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StandartBagisBtn.UseVisualStyleBackColor = true;
            this.StandartBagisBtn.Click += new System.EventHandler(this.StandartBagisBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-blood-64 (1).png");
            this.ımageList1.Images.SetKeyName(1, "icons8-blood-64.png");
            // 
            // IstekUzerineBagis
            // 
            this.IstekUzerineBagis.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IstekUzerineBagis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IstekUzerineBagis.ImageKey = "icons8-blood-64.png";
            this.IstekUzerineBagis.ImageList = this.ımageList1;
            this.IstekUzerineBagis.Location = new System.Drawing.Point(58, 288);
            this.IstekUzerineBagis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IstekUzerineBagis.Name = "IstekUzerineBagis";
            this.IstekUzerineBagis.Size = new System.Drawing.Size(315, 131);
            this.IstekUzerineBagis.TabIndex = 1;
            this.IstekUzerineBagis.Text = "İSTEK ÜZERİNE BAĞIŞ";
            this.IstekUzerineBagis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IstekUzerineBagis.UseVisualStyleBackColor = true;
            this.IstekUzerineBagis.Click += new System.EventHandler(this.IstekUzerineBagis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KanBagisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IstekUzerineBagis);
            this.Controls.Add(this.StandartBagisBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KanBagisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KanBagisi";
            this.ResumeLayout(false);

        }

        #endregion

        private Button StandartBagisBtn;
        private Button IstekUzerineBagis;
        private ImageList ımageList1;
        private Button button1;
    }
}