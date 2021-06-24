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
    public partial class frmShowHDX : Form
    {
        public frmShowHDX()
        {
            InitializeComponent();
        }

        public frmShowHDX(string _maHD)
        {
            InitializeComponent();
            conn = new SqlConnection(fr.cnn);
            maHD = _maHD;
        }
        SqlConnection conn;
        frmLogin fr = new frmLogin();
        string maHD;
        void loadHDXuat()
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            string load = "select * from XuatHang where MaHD_Xuat='" + maHD + "'";
            SqlCommand cmd = new SqlCommand(load, conn);
            table.Load(cmd.ExecuteReader());
            if (conn.State == ConnectionState.Open) conn.Close();
            dgvXH.DataSource = table;
        }

        private void frmShowHDX_Load(object sender, EventArgs e)
        {
            loadHDXuat();
            this.Text += " " + maHD;
        }
    }
}
