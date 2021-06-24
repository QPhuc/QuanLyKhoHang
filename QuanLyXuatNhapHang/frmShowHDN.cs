using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyXuatNhapHang
{
    public partial class frmShowHDN : Form
    {
        public frmShowHDN()
        {
            InitializeComponent();
            conn = new SqlConnection(fr.cnn);
        }
        public frmShowHDN(string _maHD)
        {
            InitializeComponent();
            conn = new SqlConnection(fr.cnn);
            maHD = _maHD;
        }
        SqlConnection conn;
        frmLogin fr = new frmLogin();
        string maHD;

        void loadHDNHap()
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            string load = "select * from NhapHang where MaHD_Nhap='"+maHD+"'";
            SqlCommand cmd = new SqlCommand(load, conn);
            table.Load(cmd.ExecuteReader());
            if (conn.State == ConnectionState.Open) conn.Close();
            dgvNH.DataSource = table;
        }

        private void frmShowHD_Load(object sender, EventArgs e)
        {

            loadHDNHap();
            this.Text += " " + maHD;
        }
    }
}
