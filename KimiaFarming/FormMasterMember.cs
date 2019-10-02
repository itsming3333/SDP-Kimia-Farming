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
    public partial class FormMasterMember : Form
    {
        public FormMasterMember()
        {
            InitializeComponent();
            Image background = Image.FromFile("image/background.jpg");
            this.BackgroundImage = background;
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.None;
            this.comboBox1.SelectedIndex = 0;
        }

        private void FormMasterMember_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
