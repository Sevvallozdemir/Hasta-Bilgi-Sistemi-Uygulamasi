﻿using Npgsql;
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
    public partial class HastaArama : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=ailehekimi;User ID=postgres;password=Seval802");
        public HastaArama()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from hastaarama";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select*from hastaarama where hasta_adi Like '%" + hasta_adi.Text + "%'", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}