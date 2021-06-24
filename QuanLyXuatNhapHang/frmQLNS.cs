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
using System.Drawing.Drawing2D;

namespace QuanLyXuatNhapHang
{
    public partial class frmQLNS : Form
    {
        public frmQLNS()
        {
            InitializeComponent();
        }

        string New_ID = string.Empty;
        SqlConnection conn;
        frmLogin fr = new frmLogin();

        public frmQLNS(string s)
        {
            InitializeComponent();
            New_ID = s;
        }
        
        //string cnn;

        private void GetData(string s)
        {
            txtID.Text = s;
        }
        void enable(bool a)
        {
            foreach (Control item in grpNV.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)item;
                    tb.Enabled = a;
                }
            }
            btnID.Enabled = a;
            txtngay.Enabled = a;

        }
        void clr()
        {
            foreach (Control item in grpNV.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)item;
                    tb.Clear();
                }
            }
            string s = dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0].Value.ToString();
           
            string[] stt = s.Split('V');
            int n = int.Parse(stt[1])+1;
            string manv = "NV" + n;
            txtMNV.Text = manv; 
        }
        void load()
        {
            DataTable table = new System.Data.DataTable();
            
            SqlCommand cmd = new SqlCommand("SELECT *  from chitietNhanVien", conn);
            conn.Open();
            table.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridView1.DataSource = table;
        }
        void addnhanvien()
        {
            if (DateTime.Parse(txtngay.Text) > DateTime.Now)
            {
                MessageBox.Show("Vượt quá số ngày quy định", "Thông báo");
                return;
            }

            string[] s = new string[10];
            s[0] = txtMNV.Text;
            s[1] = txtID.Text;
            s[2] = txtTen.Text;
            s[3] = txtDC.Text;
            s[4] = txtSDT.Text;
            s[5] = txtHSL.Text;
            s[6] = txtluong.Text;
            s[7] = txtngay.Text;
            s[8] = txtchucvu.Text;
            s[9] = openFileDialog1.FileName;


           
            if(conn.State==ConnectionState.Closed) conn.Open();
            string date = "Set Dateformat DMY";
            SqlCommand cmdd = new SqlCommand(date, conn);
            cmdd.ExecuteNonQuery();
            string insertstring = "Insert into chitietNhanVien values('" + s[0] + "','" + s[1] + "',N'" + s[2] + "',N'" + s[3] + "','" + s[4] + "','" + s[5] + "','" + s[6] + "','" + s[7] + "',N'" + s[8] + "','" + s[9] + "')";
            SqlCommand cmd = new SqlCommand(insertstring, conn);
            cmd.ExecuteNonQuery();
            if(ConnectionState.Open==conn.State) conn.Close();
        }
        void del()
        {
            conn.Open();
           
            string scmd1 = "delete chitietNhanVien where MaNV= '" + txtMNV.Text + "'";
            SqlCommand cmd = new SqlCommand(scmd1, conn);
            cmd.ExecuteScalar();
            string scmd = "delete NhanVien where ID='" + txtID.Text + "'";
            SqlCommand cmd1 = new SqlCommand(scmd, conn);
            cmd1.ExecuteScalar();
            conn.Close();
        }


        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            load();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(fr.cnn);
         
            txtID.Text = New_ID;
            if (txtID.Text != string.Empty)
            {
                enable(true);
                txtID.Text = New_ID;
                btnADD.Text = "Lưu Nhân Viên";
                btnADD.ForeColor = Color.Red;
            }
            else enable(false);
            load();
            
        }
 
        private void btnADD_Click(object sender, EventArgs e)
        {
                if (btnADD.Text == "Thêm Nhân Viên")
                {
                    clr();
                    btnADD.Text = "Lưu Nhân Viên";
                    btnADD.ForeColor = Color.Red;
                    btnID.Enabled = true;
                    btnXoa.Enabled = false;
                    enable(true);
                    txtID.Enabled = false;
                    txtMNV.Enabled = false;
                    
                    
                }
                else
                {
                    btnADD.Text = "Thêm Nhân Viên";
                    btnADD.ForeColor = Color.Black;
                    try
                    {
                        addnhanvien();
                        enable(false);
                        btnXoa.Enabled = true;
                        MessageBox.Show("Them thanh cong", "Thong bao");
                        clr();
                        load();
                    }
                    catch
                    {
                        MessageBox.Show("Không điền đầy đủ thông tin, hoac nhap sai dinh dang");
                        conn.Close();
                    }
                    
                }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnADD.Text != "Lưu Nhân Viên")
            {
                DataGridViewRow row = new DataGridViewRow();
                if (e.RowIndex >= 0)
                {
                    row = dataGridView1.Rows[e.RowIndex];
                    txtID.Text = row.Cells[1].Value.ToString();
                    txtMNV.Text = row.Cells[0].Value.ToString();
                    txtTen.Text = row.Cells[2].Value.ToString();
                    txtHSL.Text = row.Cells[5].Value.ToString();
                    txtluong.Text = row.Cells[6].Value.ToString();
                    txtngay.Text = row.Cells[7].Value.ToString();
                    txtchucvu.Text = row.Cells[8].Value.ToString();
                    txtDC.Text = row.Cells[3].Value.ToString();
                    txtSDT.Text = row.Cells[4].Value.ToString();

                    ptb.ImageLocation = row.Cells[9].Value.ToString();
                }
                else return;
            }
            else return;

            
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            /*frmQLHangHoa fr = new frmQLHangHoa(true);
            fr.Show();*/
        }

        private void btnchen_Click(object sender, EventArgs e)
        {
          
            openFileDialog1.Filter= "JPG|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ptb.ImageLocation = openFileDialog1.FileName;
                openFileDialog1.Dispose();
            }
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            frmID fr = new frmID();
            fr.passControl = new frmID.PassControl(GetData);
            fr.Show(this);
        }

        private void frmQLNS_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clr();
            txtMNV.Clear();
            enable(false);
            btnADD.Enabled = true;
            btnADD.Text = "Thêm Nhân Viên";
            btnADD.ForeColor = Color.Black;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text != string.Empty && txtMNV.Text != string.Empty)
            {
                if (MessageBox.Show("Bạn có muốn xóa ID "+txtID.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    del();
                    load();
                    clr();
                }
            }
        }

        private void đổiPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                frmChangingPass fr = new frmChangingPass(dataGridView1.CurrentRow.Cells[1].Value.ToString(),true);
                fr.ShowDialog(this);
            }
        }

        private void txtHSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtngay_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Parse(txtngay.Text) > DateTime.Now)
            {
                MessageBox.Show("Vượt quá số ngày quy định", "Thông báo");
                return;
            }
        }


        

       

    }
}
