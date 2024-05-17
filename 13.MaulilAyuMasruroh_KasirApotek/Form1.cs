using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _13.MaulilAyuMasruroh_KasirApotek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
                this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
                Bayar.Click += new EventHandler(Bayar_Click);
               
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)

        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddtoDatagrid();
            CalculateTotalHarga();
            
        }

        private void AddtoDatagrid()
        {
            double thargasatuan, tjumlah, ttotal;

            thargasatuan = double.Parse(HargaSatuan.Text);
            tjumlah = double.Parse(Jumlah.Text);

            ttotal = thargasatuan * tjumlah;

            Total.Text = ttotal.ToString();
            dataGridView1.Rows.Add(KodeObat.Text, NamaObat.Text, HargaSatuan.Text, Jumlah.Text, Total.Text);

        }
        private void CalculateTotalHarga()
        {
            decimal totalHarga = 0;
            decimal hargaSatuan;
            int jumlah;

            int baris = dataGridView1.Rows.Count - 1;

            for (int i = 0; i < baris; i++)
            {
                hargaSatuan = Decimal.Parse(dataGridView1.Rows[i].Cells["Hsatuan"].Value.ToString());

                jumlah = int.Parse(dataGridView1.Rows[i].Cells["Jumlh"].Value.ToString());

                totalHarga += hargaSatuan * jumlah;

            }

            Total.Text = totalHarga.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
         }

        private object Chr(int v)
        {
            throw new NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (KodeObat.SelectedItem == "001")
            {
                NamaObat.Text = "Bodrex";
                HargaSatuan.Text = "5000";
            }
            else if (KodeObat.SelectedItem == "002")
            {
                NamaObat.Text = "Paracetamol";
                HargaSatuan.Text = "15000";
            }
            else if (KodeObat.SelectedItem == "003")
            {
                NamaObat.Text = "Promag";
                HargaSatuan.Text = "12000";


            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            


                

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        

        

        private void Total_TextChanged(object sender, EventArgs e)
        {
           
        }
        
       

        private void Jumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            KodeObat.SelectedIndex = -1;
            NamaObat.Clear();
            HargaSatuan.Clear();
            Jumlah.Clear();
        }

        private void Dibayar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Bayar_Click(object sender, EventArgs e)
        {
            
                double totlharga, totldibayar, tkembalian;

                totlharga = double.Parse(Total.Text);
                totldibayar = double.Parse(Dibayar.Text);
                totldibayar = double.Parse(Dibayar.Text);

                tkembalian = totldibayar - totlharga;

                Kembalian.Text = tkembalian.ToString();

            

        }

        private void Kembalian_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
