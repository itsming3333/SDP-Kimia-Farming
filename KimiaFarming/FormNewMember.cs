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
    public partial class FormNewMember : Form
    {
        public FormNewMember()
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
            Image background = Image.FromFile("image/background.jpg");
            this.BackgroundImage = background;
            this.FormBorderStyle = FormBorderStyle.None;
            this.radioButton1.Checked = true;
            this.comboBox1.SelectedIndex = 0;
        }

        private void FormNewMember_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (textBox2.Text != "")
            {
                textBox1.Text = "TESTINGID1234#$";
            }
        }
    }
}
