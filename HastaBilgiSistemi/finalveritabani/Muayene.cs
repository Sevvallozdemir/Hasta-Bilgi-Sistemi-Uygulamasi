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
    public partial class Muayene : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=ailehekimi;User ID=postgres;password=Seval802");
        public Muayene()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into muayene(tc,muayenetarihi,receteno,hastaninşikayeti,önerilentedavi,tani) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut1.Parameters.AddWithValue("@p1", tc.Text);
            komut1.Parameters.AddWithValue("@p2", muayenetarihi.Text);
            komut1.Parameters.AddWithValue("@p3", reçeteNo.Text);
            komut1.Parameters.AddWithValue("@p4", hastaninşikayeti.Text);
            komut1.Parameters.AddWithValue("@p5", önerilentedavi.Text);
            komut1.Parameters.AddWithValue("@p6", tani.Text);

            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Muayene kaydı başarıyla gerçekleşmiştir");

        }

        private void button_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from muayene";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
