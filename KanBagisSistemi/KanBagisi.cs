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
    public partial class KanBagisi : Form
    {
        public KanBagisi()
        {
            InitializeComponent();
        }

        private void StandartBagisBtn_Click(object sender, EventArgs e)
        {
            StandartBagis standartBagis = new StandartBagis();
            standartBagis.ShowDialog();
            this.Hide();
        }

        private void IstekUzerineBagis_Click(object sender, EventArgs e)
        {
            IstekUzerineBagis Istek_uzerine_bagis = new IstekUzerineBagis();
            Istek_uzerine_bagis.ShowDialog();
            this.Hide();
        }

        AnaEkran myNewForm = new AnaEkran();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            myNewForm.ShowDialog();
        }
    }
}
