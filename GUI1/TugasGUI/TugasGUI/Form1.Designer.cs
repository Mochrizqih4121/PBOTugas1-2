﻿namespace TugasGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            Kategori = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            Negara = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Kategori, Nama, Alamat, Negara });
            dataGridView1.Location = new Point(12, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 360);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(686, 38);
            button1.Name = "button1";
            button1.Size = new Size(102, 34);
            button1.TabIndex = 1;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Kategori
            // 
            Kategori.HeaderText = "Kategori";
            Kategori.MinimumWidth = 10;
            Kategori.Name = "Kategori";
            Kategori.ReadOnly = true;
            Kategori.Width = 200;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 10;
            Nama.Name = "Nama";
            Nama.ReadOnly = true;
            Nama.Width = 200;
            // 
            // Alamat
            // 
            Alamat.HeaderText = "Alamat";
            Alamat.MinimumWidth = 10;
            Alamat.Name = "Alamat";
            Alamat.ReadOnly = true;
            Alamat.Width = 200;
            // 
            // Negara
            // 
            Negara.HeaderText = "Negara";
            Negara.MinimumWidth = 10;
            Negara.Name = "Negara";
            Negara.ReadOnly = true;
            Negara.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perusahaan";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn Kategori;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn Negara;
        private DataGridViewTextBoxColumn Ubah;
        private DataGridViewTextBoxColumn Hapus;
    }
}