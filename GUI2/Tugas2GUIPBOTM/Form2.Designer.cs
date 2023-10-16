namespace Tugas2GUIPBOTM
{
    partial class FormTambahData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nama_textbox = new System.Windows.Forms.TextBox();
            this.lokasi_combobox = new System.Windows.Forms.ComboBox();
            this.harga_tiket_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.titleTambahData = new System.Windows.Forms.Label();
            this.beroperasiRadioButton = new System.Windows.Forms.RadioButton();
            this.tidakberoperasiRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // nama_textbox
            // 
            this.nama_textbox.Location = new System.Drawing.Point(202, 146);
            this.nama_textbox.Name = "nama_textbox";
            this.nama_textbox.Size = new System.Drawing.Size(299, 22);
            this.nama_textbox.TabIndex = 0;
            this.nama_textbox.TextChanged += new System.EventHandler(this.nama_textbox_TextChanged);
            // 
            // lokasi_combobox
            // 
            this.lokasi_combobox.FormattingEnabled = true;
            this.lokasi_combobox.Location = new System.Drawing.Point(202, 190);
            this.lokasi_combobox.Name = "lokasi_combobox";
            this.lokasi_combobox.Size = new System.Drawing.Size(121, 24);
            this.lokasi_combobox.TabIndex = 1;
            this.lokasi_combobox.SelectedIndexChanged += new System.EventHandler(this.lokasi_combobox_SelectedIndexChanged);
            // 
            // harga_tiket_textbox
            // 
            this.harga_tiket_textbox.Location = new System.Drawing.Point(202, 239);
            this.harga_tiket_textbox.Name = "harga_tiket_textbox";
            this.harga_tiket_textbox.Size = new System.Drawing.Size(100, 22);
            this.harga_tiket_textbox.TabIndex = 2;
            this.harga_tiket_textbox.TextChanged += new System.EventHandler(this.harga_tiket_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Tempat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lokasi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Harga Tiket :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status :";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(600, 345);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 23);
            this.buttonSimpan.TabIndex = 9;
            this.buttonSimpan.Text = "simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // titleTambahData
            // 
            this.titleTambahData.AutoSize = true;
            this.titleTambahData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTambahData.Location = new System.Drawing.Point(246, 56);
            this.titleTambahData.Name = "titleTambahData";
            this.titleTambahData.Size = new System.Drawing.Size(300, 29);
            this.titleTambahData.TabIndex = 10;
            this.titleTambahData.Text = "HALAMAN TAMBAH DATA";
            this.titleTambahData.Click += new System.EventHandler(this.titleTambahData_Click);
            // 
            // beroperasiRadioButton
            // 
            this.beroperasiRadioButton.AutoSize = true;
            this.beroperasiRadioButton.Location = new System.Drawing.Point(202, 286);
            this.beroperasiRadioButton.Name = "beroperasiRadioButton";
            this.beroperasiRadioButton.Size = new System.Drawing.Size(95, 20);
            this.beroperasiRadioButton.TabIndex = 11;
            this.beroperasiRadioButton.TabStop = true;
            this.beroperasiRadioButton.Text = "Beroperasi";
            this.beroperasiRadioButton.UseVisualStyleBackColor = true;
            this.beroperasiRadioButton.CheckedChanged += new System.EventHandler(this.beroperasiRadioButton_CheckedChanged);
            // 
            // tidakberoperasiRadioButton
            // 
            this.tidakberoperasiRadioButton.AutoSize = true;
            this.tidakberoperasiRadioButton.Location = new System.Drawing.Point(320, 286);
            this.tidakberoperasiRadioButton.Name = "tidakberoperasiRadioButton";
            this.tidakberoperasiRadioButton.Size = new System.Drawing.Size(177, 20);
            this.tidakberoperasiRadioButton.TabIndex = 12;
            this.tidakberoperasiRadioButton.TabStop = true;
            this.tidakberoperasiRadioButton.Text = "Tutup / Tidak Beroperasi";
            this.tidakberoperasiRadioButton.UseVisualStyleBackColor = true;
            this.tidakberoperasiRadioButton.CheckedChanged += new System.EventHandler(this.tidakberoperasiRadioButton_CheckedChanged);
            // 
            // FormTambahData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tidakberoperasiRadioButton);
            this.Controls.Add(this.beroperasiRadioButton);
            this.Controls.Add(this.titleTambahData);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.harga_tiket_textbox);
            this.Controls.Add(this.lokasi_combobox);
            this.Controls.Add(this.nama_textbox);
            this.Name = "FormTambahData";
            this.Text = "FormTambahData";
            this.Load += new System.EventHandler(this.FormTambahData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox lokasi_combobox;
        private System.Windows.Forms.TextBox harga_tiket_textbox;
        private System.Windows.Forms.TextBox nama_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label titleTambahData;
        private System.Windows.Forms.RadioButton beroperasiRadioButton;
        private System.Windows.Forms.RadioButton tidakberoperasiRadioButton;
    }
}