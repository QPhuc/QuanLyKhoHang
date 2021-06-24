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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        frmLogin fr = new frmLogin();
        SqlConnection conn;
        void loadHDNHap()
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            string load = "select * from HoaDon";
            SqlCommand cmd = new SqlCommand(load, conn);
            table.Load(cmd.ExecuteReader());
            if (conn.State == ConnectionState.Open) conn.Close();
            dgvHD.DataSource = table;

        }
        void loadHDNhapTK(string s)
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            string load = "select * from HoaDon where MaHD_Nhap_Xuat like '%"+s+"%'";
            SqlCommand cmd = new SqlCommand(load, conn);
            table.Load(cmd.ExecuteReader());
            if (conn.State == ConnectionState.Open) conn.Close();
            dgvHD.DataSource = table;
        }
        void updateTT(string maHD,int t)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string update = "update HoaDon set thanhtoan='"+t+"' where MaHD_Nhap_Xuat='"+maHD+"'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open) conn.Close();
            //dgvHD.DataSource = table;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(fr.cnn);
            loadHDNHap();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            DataGridViewCellStyle s1 = new DataGridViewCellStyle();
            DataGridViewCellStyle s2 = new DataGridViewCellStyle();

            s1.ForeColor = Color.Black;
            s2.ForeColor = Color.Black;
            s1.BackColor = Color.White;
            s2.BackColor = Color.SkyBlue;
            for (int i = 0; i <= dgvHD.RowCount - 1; i++)
            {
                string s = dgvHD.Rows[i].Cells[1].Value.ToString();
                if (s[2] == 'X')
                    dgvHD.Rows[i].DefaultCellStyle = s1;
                else dgvHD.Rows[i].DefaultCellStyle = s2;
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            DataGridViewCellStyle s1 = new DataGridViewCellStyle();
            DataGridViewCellStyle s2 = new DataGridViewCellStyle();

            s1.ForeColor = Color.Black;
            s2.ForeColor = Color.Black;
            s1.BackColor = Color.White;
            s2.BackColor = Color.LawnGreen;
            for (int i = 0; i <= dgvHD.RowCount - 1; i++)
            {
                string s = dgvHD.Rows[i].Cells[1].Value.ToString();
                if (s[2] == 'N')
                    dgvHD.Rows[i].DefaultCellStyle = s1;
                else dgvHD.Rows[i].DefaultCellStyle = s2;
            }
        }

        private void dgvHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             DataGridViewRow row = new DataGridViewRow();
             if (e.RowIndex >= 0)
             {
                 string maHD = dgvHD.CurrentRow.Cells[1].Value.ToString();
                 if (maHD[2] == 'N')
                 {
                     frmShowHDN fr = new frmShowHDN(maHD);
                     fr.ShowDialog(this);
                 }
                 else
                 {
                     frmShowHDX fr = new frmShowHDX(maHD);
                     fr.ShowDialog(this);
                 }
             }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadHDNhapTK(txtTK.Text);
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvHD.CurrentCell != null)
            {
                if (dgvHD.CurrentRow.Cells[7].Value.ToString() == "True")
                {
                    updateTT(dgvHD.CurrentRow.Cells[1].Value.ToString(), 0);
                    MessageBox.Show("Hóa Đơn đã chuyển thành Chưa Thanh Toán", "Thông Báo Xác Nhận");
                }
                else
                {
                    updateTT(dgvHD.CurrentRow.Cells[1].Value.ToString(), 1); 
                    MessageBox.Show("Hóa Đơn đã chuyển thành Đã Thanh Toán", "Thông Báo Xác Nhận");
                }
                loadHDNHap();
               
         
            }

        }

       
    }
}
