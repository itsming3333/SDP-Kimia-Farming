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
    public partial class FormRawatJalan : Form
    {
        public FormRawatJalan()
        {
            InitializeComponent();
            Image background = Image.FromFile("image/background.jpg");
            this.BackgroundImage = background;
            this.Size = new Size(800, 600);
            timer1.Start();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormRawatJalan_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label21.Text = DateTime.Now.ToString();
        }
    }
}
