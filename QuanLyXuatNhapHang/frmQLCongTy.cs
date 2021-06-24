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
    public partial class frmQLCongTy : Form
    {
        public frmQLCongTy()
        {
            InitializeComponent();
            
        }
        frmLogin fr = new frmLogin();
        SqlConnection conn;

        int Add()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string ins = "insert into chitietCTYNhap values('" + txtMaCT.Text + "','" + txtTenCT.Text + "','" + txtTenDD.Text + "','" + txtSoDT.Text + "','" + txtDiaChi.Text + "')";
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
        string loadMaCT()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string ma = "select count(*) from chitietCTYNhap";
            SqlCommand cmd = new SqlCommand(ma, conn);
            int mact = (int)cmd.ExecuteScalar() + 1;
            if (conn.State == ConnectionState.Open) conn.Close();
            return "MCT" + mact;
        }


        void loadCTy()
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            string load = "select * from chitietCTYNhap";
            SqlCommand cmd = new SqlCommand(load, conn);
            table.Load(cmd.ExecuteReader());
            if (conn.State == ConnectionState.Open) conn.Close();
            dataGridView1.DataSource = table;
        }
        private void btnThemMCT_Click(object sender, EventArgs e)
        {
            if (btnThemMCT.Text == "Thêm Mã CTy")
            {
                clr();
                txtMaCT.Text = loadMaCT();
                btnThemMCT.Text = "Lưu";
                btnThemMCT.ForeColor = Color.Red;
                groupBox1.Enabled = true;

            }
            else if (btnThemMCT.Text == "Lưu")
            {
                if (txtSoDT.Text == string.Empty
                    || txtSoDT.Text == string.Empty
                    || txtDiaChi.Text == string.Empty
                    || txtTenCT.Text == string.Empty
                    || txtTenDD.Text == string.Empty)
                {
                    MessageBox.Show("Thiếu dữ liệu", "Thông Báo");
                    return;
                }
                if (Add() > 0)
                {
                    MessageBox.Show("Them Thanh Cong");
                    loadCTy();
                }
                btnThemMCT.Text = "Thêm Mã CTy";
                btnThemMCT.ForeColor = Color.Black;
                groupBox1.Enabled = false;
            }
        }

        private void frmQLCongTy_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(fr.cnn);

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadCTy();
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
