using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimiaFarming
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormParent parent = (FormParent)this.MdiParent;
            parent.goTo(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormParent parent = (FormParent)this.MdiParent;
            String id = textBox1.Text;
            String password = textBox2.Text;
            if(id == "kasir")
            {
                parent.goTo(-1);
                parent.createMenu("kasir");
            }
            else if(id == "dokter" || id == "suster")
            {
                parent.goTo(-1);
                parent.createMenu("perawat");
            }else if(id == "warehouse")
            {
                parent.goTo(-1);
                parent.createMenu("warehouse");
            }
            else if(id == "apoteker")
            {
                parent.goTo(-1);
                parent.createMenu("apoteker");
            }
            else
            {
                label4.Text = "Cek kembali ID/Password anda!"; 
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
