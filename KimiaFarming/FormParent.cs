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
            createMenu("");
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
            menuStrip1.Items.Clear();
            if(page == "kasir")
            {
                ToolStripMenuItem member = new ToolStripMenuItem("Member");
                ToolStripMenuItem masterMember = new ToolStripMenuItem("Data Member");
                masterMember.Click += master_member;
                ToolStripMenuItem newMember = new ToolStripMenuItem("Member Baru");
                newMember.Click += new_member;
                member.DropDownItems.Add(masterMember);
                member.DropDownItems.Add(newMember);
                menuStrip1.Items.Add(member);

                ToolStripMenuItem transaksi = new ToolStripMenuItem("Transaksi");
                ToolStripMenuItem rawatInap = new ToolStripMenuItem("Rawat Inap");
                rawatInap.Click += rawat_inap;
                ToolStripMenuItem rawatJalan = new ToolStripMenuItem("Rawat Jalan");
                rawatJalan.Click += rawat_jalan;
                ToolStripMenuItem donor = new ToolStripMenuItem("Donor");
                donor.Click += donor_click;
                transaksi.DropDownItems.Add(rawatInap);
                transaksi.DropDownItems.Add(rawatJalan);
                transaksi.DropDownItems.Add(donor);
                menuStrip1.Items.Add(transaksi);

                ToolStripMenuItem pembayaran = new ToolStripMenuItem("Pembayaran");
                pembayaran.Click += pembayaran_click;
                menuStrip1.Items.Add(pembayaran);

                ToolStripMenuItem logout = new ToolStripMenuItem("Log Out");
                logout.Click += logout_click;
                menuStrip1.Items.Add(logout);
            }else if (page == "perawat")
            {
                ToolStripMenuItem perawatan = new ToolStripMenuItem("Perawatan");
                ToolStripMenuItem konfirmasiRawatJalan = new ToolStripMenuItem("Konfirmasi Rawat Jalan");
                konfirmasiRawatJalan.Click += konfirmasi_rawat_jalan;
                ToolStripMenuItem addRawatInap = new ToolStripMenuItem("Perawatan Rawat Inap");
                addRawatInap.Click += add_rawat_inap;
                ToolStripMenuItem konfirmasiDonor = new ToolStripMenuItem("Konfirmasi Donor");
                addRawatInap.Click += konfirmasi_donor;
                perawatan.DropDownItems.Add(konfirmasiRawatJalan);
                perawatan.DropDownItems.Add(addRawatInap);
                perawatan.DropDownItems.Add(konfirmasiDonor);
                menuStrip1.Items.Add(perawatan);

                ToolStripMenuItem suratTugas = new ToolStripMenuItem("Surat Tugas");
                ToolStripMenuItem transaksiTugas = new ToolStripMenuItem("Surat Tugas Baru");
                transaksiTugas.Click += transaksi_tugas;
                ToolStripMenuItem dataTugas = new ToolStripMenuItem("Histori Surat Tugas");
                addRawatInap.Click += data_tugas;
                suratTugas.DropDownItems.Add(transaksiTugas);
                suratTugas.DropDownItems.Add(dataTugas);
                menuStrip1.Items.Add(suratTugas);

                ToolStripMenuItem logout = new ToolStripMenuItem("Log Out");
                logout.Click += logout_click;
                menuStrip1.Items.Add(logout);
            }else if(page == "warehouse")
            {
                ToolStripMenuItem warehouseObat = new ToolStripMenuItem("Warehouse Obat");
                ToolStripMenuItem dataObat = new ToolStripMenuItem("Data Stok");
                dataObat.Click += data_obat;
                ToolStripMenuItem isiStokObat = new ToolStripMenuItem("Transaksi Isi Stok");
                isiStokObat.Click += isi_stok_obat;
                ToolStripMenuItem historiStokObat = new ToolStripMenuItem("Histori Stok Obat");
                historiStokObat.Click += histori_stok_obat;
                warehouseObat.DropDownItems.Add(dataObat);
                warehouseObat.DropDownItems.Add(isiStokObat);
                warehouseObat.DropDownItems.Add(historiStokObat);
                menuStrip1.Items.Add(warehouseObat);

                ToolStripMenuItem warehouseDonor = new ToolStripMenuItem("Warehouse Donor");
                warehouseDonor.Click += data_donor;
                menuStrip1.Items.Add(warehouseDonor);

                ToolStripMenuItem logout = new ToolStripMenuItem("Log Out");
                logout.Click += logout_click;
                menuStrip1.Items.Add(logout);
            }else if(page == "apoteker")
            {
                ToolStripMenuItem warehouseObat = new ToolStripMenuItem("Data Obat");
                warehouseObat.Click += data_obat;
                ToolStripMenuItem transaksiObat = new ToolStripMenuItem("Transaksi Obat");
                transaksiObat.Click += transaksi_obat;
                menuStrip1.Items.Add(warehouseObat);
                menuStrip1.Items.Add(transaksiObat);

                ToolStripMenuItem logout = new ToolStripMenuItem("Log Out");
                logout.Click += logout_click;
                menuStrip1.Items.Add(logout);
            }else if(page == "admin")
            {

            }
        }

        private void transaksi_obat(object sender, EventArgs e)
        {
            //Transaksi Beli Obat
        }

        private void data_donor(object sender, EventArgs e)
        {
            //Master Donor
        }

        private void histori_stok_obat(object sender, EventArgs e)
        {
            //Histori Stok Obat
        }

        private void isi_stok_obat(object sender, EventArgs e)
        {
            //Transaksi Stok Obat
        }

        private void data_obat(object sender, EventArgs e)
        {
            //Data Stok Obat
        }


        //PERAWAT
        private void data_tugas(object sender, EventArgs e)
        {
            //MASTER SURAT TUGAS
        }

        private void transaksi_tugas(object sender, EventArgs e)
        {
            //TRANSAKSI SURAT TUGAS
        }

        private void konfirmasi_donor(object sender, EventArgs e)
        {
            //KONFIRMASI DONOR
        }

        private void add_rawat_inap(object sender, EventArgs e)
        {
            //RAWAT INAP
        }

        private void konfirmasi_rawat_jalan(object sender, EventArgs e)
        {
            //RAWAT JALAN
        }

        private void logout_click(object sender, EventArgs e)
        {
            //logout
            goTo(0);
        }

        //MENU CLICK KASIR
        public void master_member(object sender, EventArgs e)
        {
            //MASTER MEMBER
        }
        public void new_member(object sender, EventArgs e)
        {
            //NEW MEMBER
        }
        private void rawat_jalan(object sender, EventArgs e)
        {
            //RAWAT JALAN
        }

        private void rawat_inap(object sender, EventArgs e)
        {
            //RAWAT INAP
        }
        private void donor_click(object sender, EventArgs e)
        {
            //DONOR
        }
        private void pembayaran_click(object sender, EventArgs e)
        {
            //PEMBAYARAN
        }
    }
}
