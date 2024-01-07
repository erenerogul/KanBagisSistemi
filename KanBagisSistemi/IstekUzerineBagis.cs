using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KanBagisSistemi
{
    public partial class IstekUzerineBagis : Form
    {
        public IstekUzerineBagis()
        {
            InitializeComponent();
        }
        public NpgsqlCommand cmd;
        public string sql;
        public DataTable dt;

        private void radioButton_Hastane1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public string HastaneBelirle()
        {

            if (RadioButton_Hastane1.Checked) { return RadioButton_Hastane1.Text; }
            if (RadioButton_Hastane2.Checked) { return RadioButton_Hastane2.Text; }
            if (RadioButton_Hastane3.Checked) { return RadioButton_Hastane3.Text; }
            if (RadioButton_Hastane4.Checked) { return RadioButton_Hastane4.Text; }
            if (RadioButton_Hastane5.Checked) { return RadioButton_Hastane5.Text; }
            if (RadioButton_Hastane6.Checked) { return RadioButton_Hastane6.Text; }
            if (radioButton_Hastane7.Checked) { return radioButton_Hastane7.Text; }
            if (radioButton_Hastane8.Checked) { return radioButton_Hastane8.Text; }
            else
            { MessageBox.Show("Hastane seçiniz!"); return null; }



        }
        public string kangrupBelirle()
        {
            if (I_RadioBtn_Apozitif.Checked) { return I_RadioBtn_Apozitif.Text; }
            if (I_RadioBtn_Bpozitif.Checked) { return I_RadioBtn_Bpozitif.Text; }
            if (I_RadioBtn_Anegatif.Checked) { return I_RadioBtn_Anegatif.Text; }
            if (I_RadioBtn_Bnegatif.Checked) { return I_RadioBtn_Bnegatif.Text; }
            if (I_RadioBtn_ABpozitif.Checked) { return I_RadioBtn_ABpozitif.Text; }
            if (I_RadioBtn_ABnegatif.Checked) { return I_RadioBtn_ABnegatif.Text; }
            if (I_RadioBtn_0pozitif.Checked) { return I_RadioBtn_0pozitif.Text; }
            if (I_RadioBtn_0negatif.Checked) { return I_RadioBtn_0negatif.Text; }
            else
            { MessageBox.Show("Kan grubu seçiniz!"); return null; }

        }

        public string hemsireBelirle()
        {
            if (Hemsire_radio1.Checked) { return Hemsire_radio1.Text; }
            if (Hemsire_radio2.Checked) { return Hemsire_radio2.Text; }
            if (Hemsire_radio3.Checked) { return Hemsire_radio3.Text; }
            if (Hemsire_radio4.Checked) { return Hemsire_radio4.Text; }
            else
            { MessageBox.Show("Hemşire seçiniz!"); return null; }

        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=35.246.162.48; port=5432; Database=proje; user Id=postgres; password=ora123;");

        private void IstkBgsKaydetbtn_Click(object sender, EventArgs e)
        {
            I_Sonkanbagis_tarih.Format = DateTimePickerFormat.Custom;
            I_Sonkanbagis_tarih.CustomFormat = "yyyy-MM-dd";

            int result = 0;
            try
            {
                baglanti.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("	insert into kanbagislayanlar(hastaneid,kimlikno,hastaad,hastasoyad,hastaemail,hastayas,semtid,hastaadres,hastatelno,kangrupid,hemsireid,sonkanbagistarihi,covidtest) values((select hastaneid FROM hastane WHERE hastanead = @_hastanead), @_kimlikno, @_hastaad, @_hastasoyad, @_hastaemail, @_hastayas, (select semtid from semt where semtad = @_hastasemt), @_hastaadres, @_hastatelno,(select kangrupid from kangruplari where kangrupismi = @_kangrupad),(select hemsireid from hemsire where hemsireadsoyad = @_hemsiread), @_sonkanbagis, @_covidtest); insert into alici(gonderilenad, gonderilensoyad, alicitc) VALUES(@_gad, @_gsad, @_atc); INSERT INTO kanistekleri(hastaneid, kangrupid, isteknotu, gonderilenad, gonderilensoyad, alicitc) VALUES((select hastaneid FROM hastane WHERE hastanead = @_hastanead),(select kangrupid from kangruplari where kangrupismi = @_kangrupad),@_isteknot,@_gad,@_gsad,@_atc);", baglanti);
                cmd.Parameters.AddWithValue("@_kimlikno", I_KimlikNoTxt.Text);
                cmd.Parameters.AddWithValue("@_kangrupad", kangrupBelirle());
                cmd.Parameters.AddWithValue("@_hemsiread", hemsireBelirle());
                cmd.Parameters.AddWithValue("@_hastasemt", I_Semt.Text);
                cmd.Parameters.AddWithValue("@_hastaad", I_Ad.Text);
                cmd.Parameters.AddWithValue("@_hastasoyad", I_Soyad.Text);
                cmd.Parameters.AddWithValue("@_hastaadres", I_Adres.Text);
                cmd.Parameters.AddWithValue("@_hastatelno", I_TelNo.Text);
                cmd.Parameters.AddWithValue("@_hastayas", Int32.Parse(I_Yas.Text));
                cmd.Parameters.AddWithValue("@_sonkanbagis", I_Sonkanbagis_tarih.Value);
                cmd.Parameters.AddWithValue("@_hastaemail", I_Email.Text);
                cmd.Parameters.AddWithValue("@_covidtest", DbType.Boolean).Value = I_CovidEvet.Checked;
                cmd.Parameters.AddWithValue("@_isteknot", I_IstekNotu.Text);
                cmd.Parameters.AddWithValue("@_gad", Alıcı_Ad.Text);
                cmd.Parameters.AddWithValue("@_gsad", Alıcı_Soyad.Text);
                cmd.Parameters.AddWithValue("@_atc", textAliciTc.Text);
                cmd.Parameters.AddWithValue("@_hastanead", HastaneBelirle());
                cmd.ExecuteNonQuery();
                result = 1;
                baglanti.Close();


                if (result == 1)
                {
                    MessageBox.Show("Başarılı!!");
                }
                else
                {
                    MessageBox.Show("Başarısız!!");

                }
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Errorr: " + ex.Message);
            }

            I_KimlikNoTxt.Text = I_Semt.Text = I_Ad.Text = I_Soyad.Text = I_Adres.Text = I_TelNo.Text = I_Yas.Text = I_Email.Text = I_IstekNotu.Text = Alıcı_Ad.Text = Alıcı_Soyad.Text = textAliciTc.Text = null;

        }

        KanBagisi myNewForm = new KanBagisi();
        private void button1_Click(object sender, EventArgs e)
        {

            myNewForm.Show();
            this.Hide();
        }
    }
}
