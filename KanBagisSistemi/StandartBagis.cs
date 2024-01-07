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
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KanBagisSistemi
{
    public partial class StandartBagis : Form
    {

        public StandartBagis()
        {
            InitializeComponent();
        }
        private NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection("server=localhost; port=5432; Database=proje; user Id=postgres; password=12345;");
        }

        public NpgsqlCommand cmd;
        public string sql;
        public DataTable dt;



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public string kangrupBelirle()
        {
            if (SRadioBtn_Apozitif.Checked) { return SRadioBtn_Apozitif.Text; }
            if (SRadioBtn_Bpozitif.Checked) { return SRadioBtn_Bpozitif.Text; }
            if (SRadioBtn_Anegatif.Checked) { return SRadioBtn_Anegatif.Text; }
            if (SRadioBtn_Bnegatif.Checked) { return SRadioBtn_Bnegatif.Text; }
            if (SRadioBtn_ABpozitif.Checked) { return SRadioBtn_ABpozitif.Text; }
            if (SRadioBtn_ABnegatif.Checked) { return SRadioBtn_ABnegatif.Text; }
            if (SRadioBtn_0pozitif.Checked) { return SRadioBtn_0pozitif.Text; }
            if (SRadioBtn_0negatif.Checked) { return SRadioBtn_0negatif.Text; }
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

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=proje; user Id=postgres; password=12345;");

        private void StandartBagisKaydetbtn_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            int result = 0;
            try
            {
                baglanti.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("insert into kanbagislayanlar(kimlikno,covidtest,sonkanbagistarihi,hastaemail,hastayas,hastaad,hastasoyad,hastaadres,hastatelno,semtid,hemsireid,kangrupid)\r\n\tvalues(@_kimlikno,@_covidtest,@_sonkanbagis,@_hastaemail,@_hastayas,@_hastaad,@_hastasoyad,@_hastaadres,@_hastatelno,(select semtid from semt where semtad=@_hastasemt),(select hemsireid from hemsire where hemsireadsoyad=@_hemsiread),(select kangrupid from kangruplari where kangrupismi=@_kangrupad));", baglanti);
                // standart_insert() şeklinde database'de fonksiyon mevcuttur hocam..
                cmd.Parameters.AddWithValue("@_kimlikno", S_KimlikNoTxt.Text);
                cmd.Parameters.AddWithValue("@_kangrupad", kangrupBelirle());
                cmd.Parameters.AddWithValue("@_hemsiread", hemsireBelirle());
                cmd.Parameters.AddWithValue("@_hastasemt", textBox1.Text);
                cmd.Parameters.AddWithValue("@_hastaad", S_Ad.Text);
                cmd.Parameters.AddWithValue("@_hastasoyad", S_Soyad.Text);
                cmd.Parameters.AddWithValue("@_hastaadres", S_Adres.Text);
                cmd.Parameters.AddWithValue("@_hastatelno", S_TelNo.Text);
                cmd.Parameters.AddWithValue("@_hastayas", Int32.Parse(S_Yas.Text));
                cmd.Parameters.AddWithValue("@_sonkanbagis", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@_hastaemail", S_Email.Text);
                cmd.Parameters.AddWithValue("@_covidtest", DbType.Boolean).Value = S_CovidEvet.Checked;
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

            S_KimlikNoTxt.Text = textBox1.Text = S_Ad.Text = S_Soyad.Text = S_Adres.Text = S_TelNo.Text = S_Yas.Text = S_Email.Text = null;

        }



        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        KanBagisi myNewForm = new KanBagisi();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            myNewForm.ShowDialog();
        }
    }
}
