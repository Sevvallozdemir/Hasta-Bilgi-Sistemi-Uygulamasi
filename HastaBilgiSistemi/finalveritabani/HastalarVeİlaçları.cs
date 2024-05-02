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
    public partial class HastalarVeİlaçları : Form
    {
        public HastalarVeİlaçları()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=ailehekimi;User ID=postgres;password=Seval802");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into hastaarama(hasta_adi,barkod_no,ilac_adi,ilacin_tipi) values(@p1,@p2,@p3,@p4)",baglanti);
            komut.Parameters.AddWithValue("@p1", hasta_adi.Text);
            komut.Parameters.AddWithValue("@p2", Convert.ToInt64(barkod_no.Text));
            komut.Parameters.AddWithValue("@p3", ilac_adi.Text);
            komut.Parameters.AddWithValue("@p4", ilacin_tipi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from hastaarama";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
