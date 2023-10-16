using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas2GUIPBOTM
{
    public partial class Form1 : Form
    {
        List<Pariwisata> dataPariwisatas = new List<Pariwisata>();
        public Form1()
        {
            InitializeComponent();
            Pariwisata pariwisata = new Pariwisata();
            pariwisata.Nama = "Atlanta";
            pariwisata.Lokasi = "Banyuwangi";
            pariwisata.Harga_tiket = "100000";
            pariwisata.Status = "Beroperasi";

            dataPariwisatas.Add(pariwisata);

            dataGridView1.DataSource = dataPariwisatas;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataPariwisatas;

        }
        private void tambahdata_Click(object sender, EventArgs e)
        {
            FormTambahData formTambahData = new FormTambahData();
            if (formTambahData.ShowDialog() == DialogResult.OK)
            {
                Pariwisata pariwisataBaru = new Pariwisata
                {
                    Nama = formTambahData.Nama,
                    Lokasi = formTambahData.Lokasi,
                    Harga_tiket = formTambahData.Harga_tiket,
                    Status = formTambahData.Status,
                };

                dataPariwisatas.Add(pariwisataBaru);
                RefreshDataGridView();
            }
        }
        public class Pariwisata
        {
            public string Nama { get; set; }
            public string Lokasi { get; set; }
            public string Harga_tiket { get; set; }
            public string Status { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
