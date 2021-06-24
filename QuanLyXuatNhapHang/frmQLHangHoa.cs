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
    public partial class frmQLHangHoa : Form
    {
        public frmQLHangHoa()
        {
            InitializeComponent();
        }

        frmLogin fr = new frmLogin();
        SqlConnection conn;

        string loadMaHD()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string ma = "select count(*) from HangHoa";
            SqlCommand cmd = new SqlCommand(ma, conn);
            int mahd = (int)cmd.ExecuteScalar() + 1;
            if (conn.State == ConnectionState.Open) conn.Close();
            return "MH" + mahd;
        }
        int Add()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string date = "Set Dateformat DMY";
            SqlCommand cmdd = new SqlCommand(date, conn);
            cmdd.ExecuteNonQuery();
            string ins = "insert into HangHoa values('" + txtMH.Text + "',N'" + txtTH.Text + "','" + int.Parse(txtSL.Text) + "','" + int.Parse(txtDG.Text) + "','"+cmbDVT.Text+"','" + dateNSX.Text + "','" + dateHSD.Text + "','" + openFileDialog1.FileName + "')";
            SqlCommand cmd = new SqlCommand(ins, conn);
            int t = cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open) conn.Close();
            return t;
        }
        void loadhang()
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            string load = "select * from HangHoa";
            SqlCommand cmd = new SqlCommand(load, conn);
            table.Load(cmd.ExecuteReader());
            if (conn.State == ConnectionState.Open) conn.Close();
            dataGridView1.DataSource = table;

            //to mau
            /*
            DataGridViewCellStyle s1 = new DataGridViewCellStyle();
            DataGridViewCellStyle s2 = new DataGridViewCellStyle();

            
            
            s1.ForeColor = Color.Black;
            s2.ForeColor=Color.Black;
            s1.BackColor = Color.Green;
            s2.BackColor=Color.DarkGray;
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                string s = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if(s[0]=='M'  && s[1]=='H')
                dataGridView1.Rows[i].DefaultCellStyle = s1;
            }*/

        }
        void clr()
        {
            foreach (Control item in grpHH.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)item;
                    tb.Clear();
                }
            }
            ptB.Image = null;
        }
        int chkKey(string key)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string chk = "select count(*) from HangHoa where Mahang='" + key + "'";
            SqlCommand cmd = new SqlCommand(chk, conn);
            int c = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return c;
        }
        string findKey()
        {
            string s = "MH";
            s += findlostKey();
            return s;
        }
        int findlostKey()
        {
            int i = 1;
            if (conn.State == ConnectionState.Closed) conn.Open();
            string tbkey = "select * from HangHoa";
            SqlCommand cmd = new SqlCommand(tbkey, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string key = rd[0].ToString();
                string[] vkey = key.Split('H');
                if (i != int.Parse(vkey[1].ToString()))
                {
                    return i;
                }
                else i++;
            }
            rd.Close();
            if (conn.State == ConnectionState.Open) conn.Close();
            return 0;
        }
        bool ktdate()
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (DateTime.Parse(dateNSX.Text) > DateTime.Now) return false;
            if (DateTime.Parse(dateHSD.Text) < DateTime.Now) return false;
            if (DateTime.Parse(dateHSD.Text) < DateTime.Parse(dateNSX.Text)) return false;
            return true;
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(fr.cnn);
            cmbDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            grpHH.Enabled = false;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                clr();
                if (chkKey(loadMaHD()) == 0) txtMH.Text = loadMaHD();
                else txtMH.Text = findKey();
                btnThem.Text = "Lưu";
                btnThem.ForeColor = Color.Red;
                grpHH.Enabled = true;

            }
            else if (btnThem.Text == "Lưu")
            {
                if (!ktdate())
                {
                    MessageBox.Show("Han Su Dung hoac Ngay San Xuat - sai ngay", "Thong Bao");
                    return;
                }

                foreach(Control item in grpHH.Controls )
                {
                    if(typeof(TextBox)==item.GetType())
                    {
                        TextBox tb = (TextBox)item;
                        if(tb.Text==string.Empty)
                        {
                            MessageBox.Show("Thiếu dữ liệu","Thông báo");
                            return;
                        }
                    }
                }
                if (Add() > 0)
                {
                    MessageBox.Show("Them Thanh Cong");
                    loadhang();
                }
                btnThem.Text = "Thêm";
                btnThem.ForeColor = Color.Black;
                grpHH.Enabled = false;
            }
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                ptB.ImageLocation = openFileDialog1.FileName;
                openFileDialog1.Dispose();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            grpHH.Enabled = false;
            loadhang();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0 && btnThem.Text!="Lưu")
            {
                row = dataGridView1.Rows[e.RowIndex];
                txtMH.Text = row.Cells[0].Value.ToString();
                txtTH.Text = row.Cells[1].Value.ToString();
                txtSL.Text = row.Cells[2].Value.ToString();
                txtDG.Text = row.Cells[3].Value.ToString();
                cmbDVT.Text = row.Cells[4].Value.ToString();
                dateNSX.Text = row.Cells[5].Value.ToString();
                dateHSD.Text = row.Cells[6].Value.ToString();
                ptB.ImageLocation = row.Cells[7].Value.ToString();
                
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            clr();
            grpHH.Enabled = false;
            btnThem.Text = "Thêm";
            btnThem.ForeColor = Color.Black;
        }

        private void txtDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        
    }
}
