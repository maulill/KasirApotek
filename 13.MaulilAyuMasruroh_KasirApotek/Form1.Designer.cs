namespace _13.MaulilAyuMasruroh_KasirApotek
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NamaObat = new System.Windows.Forms.TextBox();
            this.HargaSatuan = new System.Windows.Forms.TextBox();
            this.Tambah = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Total = new System.Windows.Forms.TextBox();
            this.KodeObat = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hsatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kembalian = new System.Windows.Forms.TextBox();
            this.Dibayar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Jumlah = new System.Windows.Forms.TextBox();
            this.Hapus = new System.Windows.Forms.Button();
            this.Bayar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Obat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Obat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga Satuan";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // NamaObat
            // 
            this.NamaObat.Location = new System.Drawing.Point(130, 244);
            this.NamaObat.Multiline = true;
            this.NamaObat.Name = "NamaObat";
            this.NamaObat.Size = new System.Drawing.Size(115, 32);
            this.NamaObat.TabIndex = 6;
            this.NamaObat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // HargaSatuan
            // 
            this.HargaSatuan.Location = new System.Drawing.Point(130, 292);
            this.HargaSatuan.Multiline = true;
            this.HargaSatuan.Name = "HargaSatuan";
            this.HargaSatuan.Size = new System.Drawing.Size(115, 29);
            this.HargaSatuan.TabIndex = 7;
            this.HargaSatuan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(130, 393);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(92, 23);
            this.Tambah.TabIndex = 10;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = true;
            this.Tambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kasir Apotek Harmoni";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(108, 683);
            this.Total.Multiline = true;
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(137, 29);
            this.Total.TabIndex = 22;
            this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
            // 
            // KodeObat
            // 
            this.KodeObat.FormattingEnabled = true;
            this.KodeObat.Items.AddRange(new object[] {
            "001",
            "002",
            "003"});
            this.KodeObat.Location = new System.Drawing.Point(130, 208);
            this.KodeObat.Name = "KodeObat";
            this.KodeObat.Size = new System.Drawing.Size(115, 24);
            this.KodeObat.TabIndex = 24;
            this.KodeObat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Hsatuan,
            this.Jumlh,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(34, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(666, 241);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode Obat";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Obat";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Hsatuan
            // 
            this.Hsatuan.HeaderText = "Harga Satuan";
            this.Hsatuan.MinimumWidth = 6;
            this.Hsatuan.Name = "Hsatuan";
            this.Hsatuan.Width = 125;
            // 
            // Jumlh
            // 
            this.Jumlh.HeaderText = "Jumlah";
            this.Jumlh.MinimumWidth = 6;
            this.Jumlh.Name = "Jumlh";
            this.Jumlh.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Harga";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Kembalian
            // 
            this.Kembalian.Location = new System.Drawing.Point(108, 753);
            this.Kembalian.Multiline = true;
            this.Kembalian.Name = "Kembalian";
            this.Kembalian.Size = new System.Drawing.Size(137, 29);
            this.Kembalian.TabIndex = 27;
            this.Kembalian.TextChanged += new System.EventHandler(this.Kembalian_TextChanged);
            // 
            // Dibayar
            // 
            this.Dibayar.Location = new System.Drawing.Point(108, 718);
            this.Dibayar.Multiline = true;
            this.Dibayar.Name = "Dibayar";
            this.Dibayar.Size = new System.Drawing.Size(137, 29);
            this.Dibayar.TabIndex = 28;
            this.Dibayar.TextChanged += new System.EventHandler(this.Dibayar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 756);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Kembalian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 721);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Dibayar";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Jumlah
            // 
            this.Jumlah.Location = new System.Drawing.Point(130, 341);
            this.Jumlah.Multiline = true;
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Size = new System.Drawing.Size(115, 29);
            this.Jumlah.TabIndex = 31;
            this.Jumlah.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Hapus
            // 
            this.Hapus.Location = new System.Drawing.Point(34, 393);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(92, 23);
            this.Hapus.TabIndex = 32;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // Bayar
            // 
            this.Bayar.Location = new System.Drawing.Point(247, 718);
            this.Bayar.Name = "Bayar";
            this.Bayar.Size = new System.Drawing.Size(75, 29);
            this.Bayar.TabIndex = 33;
            this.Bayar.Text = "Bayar";
            this.Bayar.UseVisualStyleBackColor = true;
            this.Bayar.Click += new System.EventHandler(this.Bayar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_13.MaulilAyuMasruroh_KasirApotek.Properties.Resources.WhatsApp_Image_2024_04_25_at_08_48_12_143f802a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 799);
            this.Controls.Add(this.Bayar);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Jumlah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Dibayar);
            this.Controls.Add(this.Kembalian);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.KodeObat);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.HargaSatuan);
            this.Controls.Add(this.NamaObat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NamaObat;
        private System.Windows.Forms.TextBox HargaSatuan;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.ComboBox KodeObat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Kembalian;
        private System.Windows.Forms.TextBox Dibayar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Jumlah;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hsatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button Bayar;
    }
}

