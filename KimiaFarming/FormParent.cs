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
        FormMasterMember f_masterMember;
        FormNewMember f_newMember;
        FormRawatInap f_rawatInap;
        FormRawatJalan f_rawatJalan;

        public String passAdmin = "admin1234";
        public FormParent()
        {
            InitializeComponent();
            Image background = Image.FromFile("image/background.jpg");
            this.BackgroundImage = background;
            f_pengguna = new FormPengguna();
            f_login = new FormLogin();
            f_masterMember = new FormMasterMember();
            f_newMember = new FormNewMember();
            f_rawatJalan = new FormRawatJalan();
            f_rawatInap = new FormRawatInap();
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
            //2 Form Master Member
            //3 Form New Member
            //4 Form Rawat Inap
            //5 Form Rawat Jalan

            //RESET FORM PARENT
            f_pengguna.Close();
            f_login.Close();
            f_masterMember.Close();
            f_newMember.Close();
            f_rawatInap.Close();
            f_rawatJalan.Close();

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
            else if (id == 2)
            {
                f_masterMember = new FormMasterMember();
                f_masterMember.MdiParent = this;
                f_masterMember.Show();
                f_masterMember.Location = new Point(0, 0);
            }
            else if (id == 3)
            {
                f_newMember = new FormNewMember();
                f_newMember.MdiParent = this;
                f_newMember.Show();
                f_newMember.Location = new Point(0, 0);
            }
            else if (id == 4)
            {
                f_rawatInap = new FormRawatInap();
                f_rawatInap.MdiParent = this;
                f_rawatInap.Show();
                f_rawatInap.Location = new Point(0, 0);
            }
            else if (id == 5)
            {
                f_rawatJalan = new FormRawatJalan();
                f_rawatJalan.MdiParent = this;
                f_rawatJalan.Show();
                f_rawatJalan.Location = new Point(0, 0);
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
                ToolStripMenuItem laporan = new ToolStripMenuItem("Laporan");
                ToolStripMenuItem laporanKunjungan = new ToolStripMenuItem("Laporan Data Kunjungan");
                laporanKunjungan.Click += laporan_kunjungan;
                ToolStripMenuItem laporanKeuangan = new ToolStripMenuItem("Laporan Keuangan");
                laporanKeuangan.Click += laporan_keuangan;
                ToolStripMenuItem laporanPerawatan = new ToolStripMenuItem("Laporan Perawatan");
                laporanPerawatan.Click += laporan_perawatan;
                ToolStripMenuItem laporanWarehouse = new ToolStripMenuItem("Laporan Warehouse");
                laporanWarehouse.Click += laporan_warehouse;
                ToolStripMenuItem laporanPegawai = new ToolStripMenuItem("Laporan Pegawai");
                laporanPegawai.Click += laporan_pegawai;
                ToolStripMenuItem laporanInap = new ToolStripMenuItem("Laporan Rawat Inap");
                laporanInap.Click += laporan_inap;
                laporan.DropDownItems.Add(laporanKunjungan);
                laporan.DropDownItems.Add(laporanKeuangan);
                laporan.DropDownItems.Add(laporanPerawatan);
                laporan.DropDownItems.Add(laporanWarehouse);
                laporan.DropDownItems.Add(laporanPegawai);
                laporan.DropDownItems.Add(laporanInap);
                menuStrip1.Items.Add(laporan);

                ToolStripMenuItem masterData = new ToolStripMenuItem("Master Data");
                ToolStripMenuItem masterPegawai = new ToolStripMenuItem("Data Pegawai");
                masterPegawai.Click += master_pegawai;
                ToolStripMenuItem masterOperasional = new ToolStripMenuItem("Data Rumah Sakit");
                masterOperasional.Click += master_operasional;
                masterData.DropDownItems.Add(masterPegawai);
                masterData.DropDownItems.Add(masterOperasional);
                menuStrip1.Items.Add(masterData);

                ToolStripMenuItem settingAdmin = new ToolStripMenuItem("Setting");
                settingAdmin.Click += setting_admin;
                menuStrip1.Items.Add(settingAdmin);

                ToolStripMenuItem logout = new ToolStripMenuItem("Log Out");
                logout.Click += logout_click;
                menuStrip1.Items.Add(logout);
            }
        }

        private void setting_admin(object sender, EventArgs e)
        {
            //Setting data password admin
        }

        private void master_operasional(object sender, EventArgs e)
        {
            //Master Data - data rumah sakit
        }

        private void master_pegawai(object sender, EventArgs e)
        {
            //Master Pegawai
        }

        private void laporan_inap(object sender, EventArgs e)
        {
            //Laporan Inap
        }

        private void laporan_pegawai(object sender, EventArgs e)
        {
            //Laporan Pegawai
        }

        private void laporan_perawatan(object sender, EventArgs e)
        {
            //Laporan Perawatan
        }

        private void laporan_keuangan(object sender, EventArgs e)
        {
            //Laporan Keuangan
        }

        private void laporan_warehouse(object sender, EventArgs e)
        {
            //Laporan Warehouse
        }

        private void laporan_kunjungan(object sender, EventArgs e)
        {
            //Laporan Kunjungan
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
            
        }

        private void konfirmasi_rawat_jalan(object sender, EventArgs e)
        {
            //RAWAT JALAN
        }

        private void logout_click(object sender, EventArgs e)
        {
            //logout
            createMenu("");
            goTo(0);
        }

        //MENU CLICK KASIR
        public void master_member(object sender, EventArgs e)
        {
            this.goTo(2);
        }
        public void new_member(object sender, EventArgs e)
        {
            this.goTo(3);
        }
        private void rawat_jalan(object sender, EventArgs e)
        {
            goTo(5);
        }

        private void rawat_inap(object sender, EventArgs e)
        {
            goTo(4);
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
