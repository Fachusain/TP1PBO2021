using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class menu : Form
    {
        string jenisBarang;
        int minHarga;
        int maxHarga;

        List<dataBarang> barang = new List<dataBarang>();
        public menu()
        {
            InitializeComponent();
            nambah_barang();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        void nambah_barang()
        {

            this.barang.Add(new dataBarang("Speaker", "900000", "1", "Elektronik"));
            this.barang.Add(new dataBarang("Kalung", "20000", "2", "Aksesoris"));
            this.barang.Add(new dataBarang("Mouse", "15000", "3", "Elektronik"));
            this.barang.Add(new dataBarang("Crewneck", "10000", "4", "Pakaian"));

            foreach (dataBarang data in this.barang) 
            {
                Panel p = addPanel(data.getNamaBarang, data.getHarga, data.getIdBarang, data.getJenisProduk);
                
                tempat_produk.Controls.Add(p);
            }
        }



        Panel addPanel(string nama, string harga, string idbarang, string jenisproduk)
        {
            Panel p = new Panel();
            p.Width = 160;
            p.Height = 211;
            p.BackColor = System.Drawing.Color.Blue;
            Button tombol = addButton();
            Label label = addLabel(nama);
            Label label2 = addLabel2(harga);
            p.Controls.Add(tombol);
            p.Controls.Add(label);
            p.Controls.Add(label2);
            return p;
        }

        Button addButton()
        {
            Button p = new Button();
            p.Size = new Size(59, 31);
            p.Location = new System.Drawing.Point(40, 145);
            p.BackColor = System.Drawing.Color.White;
            p.Text = "Beli";

            return p;
        }

        Label addLabel(string nama)
        {
            Label p = new Label();
            p.Size = new Size(107, 17);
            p.Location = new System.Drawing.Point(20, 77);
            p.ForeColor = System.Drawing.Color.Black;
            p.Text = nama;

            return p;
        }

        Label addLabel2(string harga)
        {
            Label p = new Label();
            p.Size = new Size(107, 17);
            p.Location = new System.Drawing.Point(20, 110);
            p.ForeColor = System.Drawing.Color.Black;
            p.Text = harga;

            return p;
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void tempat_produk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox value = (ComboBox)sender;
                value.DropDownStyle = ComboBoxStyle.DropDownList;
                this.jenisBarang = value.SelectedItem.ToString().ToLower();
        }

        private void ambilHarga(string value)
        {
            if (value == "100rb - 200rb")
            {
                this.minHarga = 100000;
                this.maxHarga = 200000;
            }else if(value == "200rb - 500rb")
            {
                this.minHarga = 200000;
                this.maxHarga = 500000;
            }else if (value == "500rb - 1jt")
            {
                this.minHarga = 500000;
                this.maxHarga = 1000000; 
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    internal class comboBox1
    {
    }

    class dataBarang
    {
        public dataBarang(string nama, string harga, string idbarang, string jenisproduk)
        {
            getNamaBarang = nama;
            getHarga = harga;
            getIdBarang = idbarang;
            getJenisProduk = jenisproduk;
        }
        public string getNamaBarang
        {
            get; set;
        }

        public string getHarga
        {
            get; set;
        }

        public string getIdBarang
        {
            get; set;
        }
        public string getJenisProduk
        {
            get; set;
        }
    }
}
