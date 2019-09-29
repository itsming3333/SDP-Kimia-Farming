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
    public partial class FormParent : Form
    {
        FormPengguna f_pengguna;
        public FormParent()
        {
            InitializeComponent();
            f_pengguna = new FormPengguna();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f_pengguna.MdiParent = this;
            f_pengguna.Location = new Point(0, 0);
            f_pengguna.Show();
        }
    }
}
