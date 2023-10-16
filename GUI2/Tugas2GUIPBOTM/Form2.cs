using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas2GUIPBOTM
{
    public partial class FormTambahData : Form
    {
        public string Nama { get; set; }
        public string Lokasi { get; set; }
        public string Harga_tiket { get; set; }
        public string Status { get
            {
                if (beroperasiRadioButton.Checked)
                    return "Beroperasi";
                else if (tidakberoperasiRadioButton.Checked)
                    return "Tidak Beroperasi";
                else
                    return ""; 
            }
        }
        public FormTambahData()

        {
            InitializeComponent();

            lokasi_combobox.Items.Add("Banyuwangi");
            lokasi_combobox.Items.Add("Jember");
            lokasi_combobox.Items.Add("Malang");
            lokasi_combobox.Items.Add("Surabaya");

        }

        private void nama_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lokasi_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lokasi = lokasi_combobox.SelectedItem.ToString();
        }

        private void harga_tiket_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Nama = nama_textbox.Text;
            Harga_tiket = harga_tiket_textbox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void titleTambahData_Click(object sender, EventArgs e)
        {

        }

        private void beroperasiRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tidakberoperasiRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormTambahData_Load(object sender, EventArgs e)
        {

        }
    }
}
