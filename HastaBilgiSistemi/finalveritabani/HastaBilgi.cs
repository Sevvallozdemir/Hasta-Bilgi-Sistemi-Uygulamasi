using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace finalveritabani
{
    public partial class HastaBilgi : Form
    {
        public HastaBilgi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=ailehekimi;User ID=postgres;password=Seval802");

        private void button_kayitekle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into deneme(tc,ad,soyadı,doğumyeri,doğumtarihi,medenidurumu,telefon,adres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            komut1.Parameters.AddWithValue("@p1", TcKimlikNo.Text);
            komut1.Parameters.AddWithValue("@p2", Adı.Text);
            komut1.Parameters.AddWithValue("@p3", Soyadı.Text);
            komut1.Parameters.AddWithValue("@p4", DoğumYeri.Text);
            komut1.Parameters.AddWithValue("@p5", DoğumTarihi.Text);
            komut1.Parameters.AddWithValue("@p6", MedeniDurumu.Text);
            komut1.Parameters.AddWithValue("@p7", Telefon.Text);
            komut1.Parameters.AddWithValue("@p8", Adres.Text);

            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta bilgi ekleme işlemi başarılı bir şekilde gerçekleşmiştir");


        }

        private void button_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from deneme";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void HastaBilgi_Load(object sender, EventArgs e)
        {

        }
    }
}
