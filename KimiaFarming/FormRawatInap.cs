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
    public partial class FormRawatInap : Form
    {
        public FormRawatInap()
        {
            InitializeComponent();
            Image background = Image.FromFile("image/background.jpg");
            this.BackgroundImage = background;
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.None;
            timer1.Start();
        }

        private void FormRawatInap_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label21.Text = DateTime.Now.ToString();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
