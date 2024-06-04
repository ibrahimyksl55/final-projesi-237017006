using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanıcı_girişi
{
    public partial class GirişFormu : Form
    {
        public GirişFormu()
        {
            InitializeComponent();
        }

        private void btngiriş_Click(object sender, EventArgs e)
        {
            if (txtbkadı.Text=="admin"&& txtbparola.Text=="şifre")
            {
                Anasayfa git = new Anasayfa();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı","HATA!!!");
                txtbkadı.Clear();
                txtbparola.Clear();
            }    
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            txtbkadı.Clear();
            txtbparola.Clear();
        }
    }
}
