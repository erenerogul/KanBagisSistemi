using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBagisSistemi
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void KanBagisBtn_Click(object sender, EventArgs e)
        {
            KanBagisi kanBagisi = new KanBagisi();
            kanBagisi.ShowDialog();
            this.Hide();
        }

        private void KanTakipBtn_Click(object sender, EventArgs e)
        {
            KanBagisTakip kanBagisTakip = new KanBagisTakip();
            kanBagisTakip.ShowDialog();
            this.Hide();

        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
