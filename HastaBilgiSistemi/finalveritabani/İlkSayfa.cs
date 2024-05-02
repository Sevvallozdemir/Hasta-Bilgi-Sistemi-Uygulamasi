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
    public partial class İlkSayfa : Form
    {
        public İlkSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaBilgi hastabilgi = new HastaBilgi();
            hastabilgi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Muayene muayene = new Muayene();
            muayene.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaKayıtSil sil = new HastaKayıtSil();
            sil.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MuayeneSil sil = new MuayeneSil();
            sil.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Recete recete = new Recete();
            recete.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ilaçlar ilac = new ilaçlar();
            ilac.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HastaİlacTakip tıkla = new HastaİlacTakip();
            tıkla.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HastaArama gir = new HastaArama();
            gir.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HastalarVeİlaçları evet = new HastalarVeİlaçları();
            evet.ShowDialog();
        }
    }
}
