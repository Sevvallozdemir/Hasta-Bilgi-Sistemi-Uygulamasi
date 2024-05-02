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
    public partial class MuayeneSil : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=ailehekimi;User ID=postgres;password=Seval802");
        public MuayeneSil()
        {
            InitializeComponent();
        }

        private void button_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from muayene";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from muayene where tc=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", tckimlik.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarıyla gerçekleştirilmiştir.");
        }
    }
}
