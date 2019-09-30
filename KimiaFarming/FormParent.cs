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
        FormLogin f_login;
        public FormParent()
        {
            InitializeComponent();
            f_pengguna = new FormPengguna();
            f_login = new FormLogin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f_pengguna.MdiParent = this;
            f_pengguna.Show();
            f_pengguna.Location = new Point(0, 0);
        }

        public void goTo(int id)
        {
            //id Form Page
            //0 Form Pengguna
            //1 Form Login

            //RESET FORM PARENT
            f_pengguna.Close();
            f_login.Close();

            //CHANGE PAGE FUNCTION
            if(id == 0)
            {
                f_pengguna = new FormPengguna();
                f_pengguna.MdiParent = this;
                f_pengguna.Show();
                f_pengguna.Location = new Point(0, 0);
            }
            else if(id == 1)
            {
                f_login = new FormLogin();
                f_login.MdiParent = this;
                f_login.Show();
                f_login.Location = new Point(0, 0);
            }
            else
            {

            }
        }

        public void createMenu(String page)
        {
            if(page == "kasir")
            {
                ToolStripMenuItem member = new ToolStripMenuItem("Member");
                ToolStripMenuItem masterMember = new ToolStripMenuItem("Data Member");
                ToolStripMenuItem newMember = new ToolStripMenuItem("Member Baru");
                member.DropDownItems.Add(masterMember);
                member.DropDownItems.Add(newMember);
                menuStrip1.Items.Add(member);
            }
        }
    }
}
