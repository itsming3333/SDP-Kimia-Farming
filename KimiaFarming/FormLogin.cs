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
                parent.createMenu("kasir");
                parent.goTo(-1);
            }else if(id == "perawat")
            {

            }else if(id == "warehouse")
            {

            }else if(id == "apoteker")
            {

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
