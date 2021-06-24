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
    public partial class frmLoadCongTy : Form
    {
        public frmLoadCongTy() 
        {
            InitializeComponent();
            MaximizeBox = false;
            AcceptButton = btnAC;
        }

        frmLogin fr = new frmLogin();
        SqlConnection conn;

        public delegate void PassMH(string s);
        public PassMH passMH;

        void load()
        {
            string cnn = fr.cnn;
            conn = new SqlConnection(cnn);
            DataTable table = new System.Data.DataTable();

            SqlCommand cmd = new SqlCommand("SELECT MaCT,TenCT from chitietCTYNhap", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            table.Load(cmd.ExecuteReader());
            conn.Close();

            dataGridView1.DataSource = table;
        }

        private void LoadCongTy_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnTIm_Click(object sender, EventArgs e)
        {

            DataTable table = new System.Data.DataTable();
            SqlCommand cmd = new SqlCommand("SELECT MaCT,TenCT from chitietCTYNhap where TenCT like N'" + txtTKCTY.Text + "'", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            table.Load(cmd.ExecuteReader());
            string s = (string)cmd.ExecuteScalar();
            conn.Close();

            MessageBox.Show("Mã Công Ty cần tìm là: " + s);
            txtMCT.Text = s;
            dataGridView1.DataSource = table;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            if (txtMCT.Text != "-")
            {
                passMH(txtMCT.Text);
                    
                this.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            string mh = row.Cells[0].Value.ToString();
            passMH(mh);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new System.Data.DataTable();
            SqlCommand cmd = new SqlCommand("SELECT MaCT,TenCT from chitietCTYNhap where TenCT like N'%" + txtTKCTY.Text + "%'", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            table.Load(cmd.ExecuteReader());
            string s = (string)cmd.ExecuteScalar();
            conn.Close();

            txtMCT.Text = s;
            dataGridView1.DataSource = table;
        }
    }
}
