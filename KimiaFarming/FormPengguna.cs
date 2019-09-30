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
    public partial class FormPengguna : Form
    {
        public FormPengguna()
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormPengguna_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormParent parent = (FormParent)this.MdiParent;
            parent.goTo(-1);
            parent.createMenu("admin");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormParent parent = (FormParent)this.MdiParent;
            parent.goTo(1);
        }
    }
}
