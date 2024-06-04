using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kullanıcı_girişi
{
    public partial class Anasayfa : Form
    {
        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = Eczanedb.accdb");
        OleDbCommand cmd;
        OleDbDataAdapter da;

        public Anasayfa()
        {
            InitializeComponent();
        }

        public void listele()
        {
            da = new OleDbDataAdapter("select * from ilaçlar", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            temizle();
        }

        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || pictureBox1.ImageLocation == "")
            {
                MessageBox.Show("Lütfen tüm alanları DOLDURUN !!", "EKSİK GİRİŞ HATASI!!");
            }

            else
            {
                cmd = new OleDbCommand("insert into İlaçlar (siraNo, ilacKodu, ilacAdi, fiyat, adet, resim) values (@siraNo, @ilacKodu, @ilacAdi, @fiyat, @adet, @resim)", con);
                cmd.Parameters.AddWithValue("@siraNo", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@ilacKodu", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@ilacAdi", (textBox3.Text));
                cmd.Parameters.AddWithValue("@fiyat", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@adet", int.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("kayıt yapıldı");

                listele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            OpenFileDialog dosya = openFileDialog;
            dosya.Filter = "Resim Dosyalari | *.jpg;*.png";
            dosya.ShowDialog();
            pictureBox1.ImageLocation = dosya.FileName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || pictureBox1.ImageLocation == "")
            {
                MessageBox.Show("Lütfen tüm alanları DOLDURUN !!", "EKSİK GİRİŞ HATASI!!");
            }

            else
            {
                cmd = new OleDbCommand("update ilaçlar set ilacKodu= '" + textBox2.Text + "', ilacAdi= '" + textBox3.Text + "', fiyat= '" + textBox4.Text + "', adet= '" + textBox5.Text + "', resim= '" + pictureBox1.ImageLocation + "' where siraNo= " + textBox1.Text + " ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("GÜNCELLEME ONAYLANDI");
                listele();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz ilacın sıra numarasını giriniz");
            }

            else
            {
                cmd = new OleDbCommand("delete from ilaçlar where siraNo= " + textBox1.Text + " ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Başarıyla silindi.");
                listele();
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int ilacKodu;
            if (int.TryParse(textBox6.Text, out ilacKodu))
            {
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM ilaçlar WHERE ilacKodu LIKE '" + ilacKodu + "%'", con);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ilaç kodu girin.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
