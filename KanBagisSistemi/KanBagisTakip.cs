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


namespace KanBagisSistemi
{
    public partial class KanBagisTakip : Form
    {
        public KanBagisTakip()
        {
            InitializeComponent();
        }

        public NpgsqlCommand cmd;
        public string sql;
        public DataTable dt;
        private string dtgvSelected;
        private int dtgvSelectedRow;
        private int dtgvSelectedColumn;



        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=proje; user Id=postgres; password=12345;");

        private void KanBagisTakip_Load(object sender, EventArgs e)
        {

        }

        private void doldurKanistekleri()
        {
            string sorgu = ("SELECT * FROM kanbagisistekView;");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            radioButton3.Checked = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string sorgu = ("SELECT * FROM ozelistekView;");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            doldurKanistekleri();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select kimlikno,hastaad,hastasoyad,hastaadres,hastatelno,hastayas,hastaemail,covidtest,sonkanbagistarihi From Kanbagislayanlar Where kangrupid=1", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select kimlikno,hastaad,hastasoyad,hastaadres,hastatelno,hastayas,hastaemail,covidtest,sonkanbagistarihi From Kanbagislayanlar Where hemsireid=1", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select kimlikno,hastaad,hastasoyad,hastaadres,hastatelno,hastayas,hastaemail,covidtest,sonkanbagistarihi From Kanbagislayanlar Where hemsireid=4", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select kimlikno,hastaad,hastasoyad,hastaadres,hastatelno,hastayas,hastaemail,covidtest,sonkanbagistarihi From Kanbagislayanlar Where hemsireid=3", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select kimlikno,hastaad,hastasoyad,hastaadres,hastatelno,hastayas,hastaemail,covidtest,sonkanbagistarihi From Kanbagislayanlar Where hemsireid=2", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select kimlikno,hastaad,hastasoyad,hastaadres,hastatelno,hastayas,hastaemail,covidtest,sonkanbagistarihi From Kanbagislayanlar Where kangrupid=2", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select kimlikno,hastaad,hastasoyad,hastaadres,hastatelno,hastayas,hastaemail,covidtest,sonkanbagistarihi From Kanbagislayanlar Where kangrupid=3", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select kimlikno,hastaad,hastasoyad,hastaadres,hastatelno,hastayas,hastaemail,covidtest,sonkanbagistarihi From Kanbagislayanlar Where kangrupid=4", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select kimlikno,hastaad,hastasoyad,hastaadres,hastatelno,hastayas,hastaemail,covidtest,sonkanbagistarihi From Kanbagislayanlar Where kangrupid=5", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select kimlikno,hastaad,hastasoyad,hastaadres,hastatelno,hastayas,hastaemail,covidtest,sonkanbagistarihi From Kanbagislayanlar Where kangrupid=6", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select kimlikno,hastaad,hastasoyad,hastaadres,hastatelno,hastayas,hastaemail,covidtest,sonkanbagistarihi From Kanbagislayanlar Where kangrupid=7", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select kimlikno,hastaad,hastasoyad,hastaadres,hastatelno,hastayas,hastaemail,covidtest,sonkanbagistarihi From Kanbagislayanlar Where kangrupid=8", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnOzelDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnStandartDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            dtgvSelected = dataGridView1.Rows[dtgvSelectedRow].Cells["kimlikno"].Value.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand("delete from kanbagislayanlar where kimlikno=@p1", baglanti);
            // hocam delete fonksiyonu database'de mevcut..
            cmd.Parameters.AddWithValue("@p1", dtgvSelected);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme işlemi tamamlandı");
            baglanti.Close();
            doldurKanistekleri();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvSelectedRow = e.RowIndex;
        }

        private void btnStandartUpdate_Click(object sender, EventArgs e)
        {
            string had, hsad, hadres, htel, hemail;
            dtgvSelected = dataGridView1.Rows[dtgvSelectedRow].Cells["kimlikno"].Value.ToString();
            had = dataGridView1.Rows[dtgvSelectedRow].Cells["hastaad"].Value.ToString();
            hsad = dataGridView1.Rows[dtgvSelectedRow].Cells["hastasoyad"].Value.ToString();
            hadres = dataGridView1.Rows[dtgvSelectedRow].Cells["hastaadres"].Value.ToString();
            htel = dataGridView1.Rows[dtgvSelectedRow].Cells["hastatelno"].Value.ToString();
            hemail = dataGridView1.Rows[dtgvSelectedRow].Cells["hastaemail"].Value.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand("update kanbagislayanlar set hastaad = '" + had +
                "' , hastasoyad = '" + hsad +
                "' , hastaadres = '" + hadres +
                "' , hastatelno = '" + htel +
                "' , hastaemail = '" + hemail + "' where kimlikno = '" + dtgvSelected + "'", baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            doldurKanistekleri();
        }

        AnaEkran myNewForm = new AnaEkran();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            myNewForm.ShowDialog();

        }
    }
}
