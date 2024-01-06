namespace KanBagisSistemi
{
    public partial class Giris_Form : Form
    {
        public Giris_Form()
        {
            InitializeComponent();
        }

        private void Giris_btn_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.ShowDialog();
            this.Hide();
        }
    }
}