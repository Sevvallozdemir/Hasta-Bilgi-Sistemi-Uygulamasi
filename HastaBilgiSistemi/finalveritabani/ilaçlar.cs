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
    public partial class ilaçlar : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=ailehekimi;User ID=postgres;password=Seval802");
        public ilaçlar()
        {
            InitializeComponent();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from ilaçtablosu";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ilacekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into ilaçtablosu(barkod_no,ilac_adi,ilac_tipi) values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt64(barkod_no.Text));
            komut1.Parameters.AddWithValue("@p2", ilac_adi.Text);
            komut1.Parameters.AddWithValue("@p3", ilac_tipi.Text);
          
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Muayene kaydı başarıyla gerçekleşmiştir");

        }
    }
}
