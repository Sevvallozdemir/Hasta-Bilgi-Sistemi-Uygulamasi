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

namespace finalveritabani
{
    public partial class Recete : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=ailehekimi;User ID=postgres;password=Seval802");
        public Recete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into recetetable(hasta_adi,tc,receteno,barkod_no) values(@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", hasta_adi.Text);
            komut1.Parameters.AddWithValue("@p2", Convert.ToInt64(tckimlik.Text));
            komut1.Parameters.AddWithValue("@p3", Convert.ToInt64(receteno.Text));
            komut1.Parameters.AddWithValue("@p4", Convert.ToInt64(barkod_no.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Reçete başarılı bir şekilde oluşturuldu.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from recetetable";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
