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
using System.IO;


namespace QuanLyXuatNhapHang
{
    public partial class frmloadHang : Form
    {
        public  frmloadHang()
        {
            InitializeComponent();
            MaximizeBox = false;
            AcceptButton = btnAC;
        }

        frmLogin fr = new frmLogin();
        SqlConnection conn;
        void load()
        {
            string cnn = fr.cnn;
            conn = new SqlConnection(cnn);
            DataTable table = new System.Data.DataTable();

            SqlCommand cmd = new SqlCommand("SELECT Mahang,Tenhang from HangHoa", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            table.Load(cmd.ExecuteReader());
            conn.Close();

            dataGridView1.DataSource = table;
        }
        public delegate void PassMH(string s);
        public PassMH passMH;


        private void frmloadHang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnTIm_Click(object sender, EventArgs e)
        {
            DataTable table = new System.Data.DataTable();
            SqlCommand cmd = new SqlCommand("SELECT Mahang,Tenhang from HangHoa where Tenhang like N'%"+textBox1.Text+"%'", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            table.Load(cmd.ExecuteReader());
            string s = (string)cmd.ExecuteScalar();
            conn.Close();

            //MessageBox.Show("Mã hàng cần tìm là: " + s);
            txtMH.Text = s;
            dataGridView1.DataSource = table;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            if (txtMH.Text != "-")
            {
                passMH(txtMH.Text);


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
            SqlCommand cmd = new SqlCommand("SELECT Mahang,Tenhang from HangHoa where Tenhang like N'%" + textBox1.Text + "%'", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            table.Load(cmd.ExecuteReader());
            string s = (string)cmd.ExecuteScalar();
            conn.Close();

            txtMH.Text = s;
            dataGridView1.DataSource = table;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable table = new System.Data.DataTable();
            SqlCommand cmd = new SqlCommand("SELECT Mahang,Tenhang from HangHoa where Tenhang like '%" + textBox1.Text + "%'", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            table.Load(cmd.ExecuteReader());
            string s = (string)cmd.ExecuteScalar();
            conn.Close();

            txtMH.Text = s;
            dataGridView1.DataSource = table;
        }
    }
}
