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
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
        {
            InitializeComponent();
        }
        frmLogin fr = new frmLogin();
        SqlConnection conn;
        int Add()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string ins = "insert into chitietKhachHang values('" + txtMaKH.Text + "','" + txtTenKH.Text + "','" + txtTenCT.Text + "','" + txtSoDT.Text + "','" + txtDiaChi.Text + "')";
            SqlCommand cmd = new SqlCommand(ins, conn);
            int t = cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open) conn.Close();
            return t;
        }
        void clr()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)item;
                    tb.Clear();
                }
            }
        }
        string loadMaKH()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string ma = "select count(*) from chitietKhachHang";
            SqlCommand cmd = new SqlCommand(ma, conn);
            int mact = (int)cmd.ExecuteScalar() + 1;
            if (conn.State == ConnectionState.Open) conn.Close();
            return "MKH" + mact;
        }
        void loadKH()
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            string load = "select * from chitietKhachHang";
            SqlCommand cmd = new SqlCommand(load, conn);
            table.Load(cmd.ExecuteReader());
            if (conn.State == ConnectionState.Open) conn.Close();
            dataGridView1.DataSource = table;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (btnThemKH.Text == "Thêm Khách Hàng")
            {
                clr();
                txtMaKH.Text = loadMaKH();
                btnThemKH.Text = "Lưu";
                btnThemKH.ForeColor = Color.Red;
                groupBox1.Enabled = true;

            }
            else if (btnThemKH.Text == "Lưu")
            {
                if (txtSoDT.Text == string.Empty 
                    || txtSoDT.Text == string.Empty 
                    || txtDiaChi.Text == string.Empty
                    || txtTenCT.Text == string.Empty
                    || txtTenKH.Text == string.Empty)
                {
                    MessageBox.Show("Thieu dữ liệu", "Thông Báo");
                    return;
                }
                if (Add() > 0)
                {
                    MessageBox.Show("Them Thanh Cong");
                    loadKH();
                }
                
                btnThemKH.Text = "Thêm Khách Hàng";
                btnThemKH.ForeColor = Color.Black;
                groupBox1.Enabled = false;
            }
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(fr.cnn);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadKH();
        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)47) && (e.KeyChar < (char)58)
                || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
