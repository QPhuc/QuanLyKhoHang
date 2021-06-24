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
using System.Drawing.Drawing2D;

namespace QuanLyXuatNhapHang
{
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }
        string _ID;
        
        frmLogin fr = new frmLogin();
        SqlConnection conn;
        public frmNhapHang(string ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        string currentma()
        {
            string cnn = fr.cnn;
            conn = new SqlConnection(cnn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            string stt = "Select count(*) from HD_Nhap";
            SqlCommand cmd = new SqlCommand(stt, conn);
            int hd = (int)cmd.ExecuteScalar()+1;
            if (conn.State == ConnectionState.Open) conn.Close();
            return "HDN_" + hd;
        }
        int timdongia()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string stt = "Select dongia from HangHoa where Mahang='"+txtMH.Text+"'";
            SqlCommand cmd = new SqlCommand(stt, conn);
            int dongia = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return dongia;
        }
        int capnhatsoluonghang(string mahang,int sl)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string update = "Update HangHoa set soluong = soluong+"+sl+" where Mahang='"+txtMH.Text+"'";
            SqlCommand cmd = new SqlCommand(update, conn);
            int t = cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open) conn.Close();
            return t;
            //tra ve 0 thi bao là sai

        }
        string timMANV()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string scmd = "Select MaNV from chitietNhanVien where ID= '" +_ID + "'";
            SqlCommand cmd = new SqlCommand(scmd, conn);
            string MaNV = (string)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return MaNV;
        }
        string timTenNV()
        {
            string manv = timMANV();
            if (conn.State == ConnectionState.Closed) conn.Open();
            string scmd = "Select TenNV from chitietNhanVien where MaNV= '" + manv + "'";
            SqlCommand cmd = new SqlCommand(scmd, conn);
            string TenNV = (string)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return TenNV;
        }
        int chkKey(string key)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string chk = "select count(*) from NhapHang where MaHD_Nhap='" + key + "'";
            SqlCommand cmd = new SqlCommand(chk, conn);
            int c = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return c;
        }
        string findKey()
        {
            string s = "HDN_";
            s += findlostKey();
            return s;
        }
        int findlostKey()
        {
            //int i = 1;
            if (conn.State == ConnectionState.Closed) conn.Open();
            string tbkey = "select * from NhapHang";
            SqlCommand cmd = new SqlCommand(tbkey, conn);
            SqlDataReader rd = cmd.ExecuteReader();

            int max = 0;
            while (rd.Read())
            {
                string key = rd[0].ToString();
                string[] vkey = key.Split('_');
                if (max < int.Parse(vkey[1].ToString()))
                {
                    max=int.Parse(vkey[1].ToString());
                }
            }
            rd.Close();
            if (conn.State == ConnectionState.Open) conn.Close();
            return max+1;
        }
        int Add()
        {
            string[] s = new string[7];
            s[0] = txtMHD.Text;
            s[1] = txtMH.Text;
            s[2] = txtCT.Text;
            s[3] = timMANV();
            s[4] = txtSL.Text;//int
            s[5] = txtDG.Text;//float
            s[6] = dateN.Text;
            float tt = int.Parse(txtSL.Text) * float.Parse(txtDG.Text);

            if (conn.State == ConnectionState.Closed) conn.Open();
            string date = "Set Dateformat DMY";
            SqlCommand cmdd = new SqlCommand(date, conn);
            cmdd.ExecuteNonQuery();
            string ins = "insert into NhapHang values ('" + s[0] + "','" + s[1] + "','" + s[2] + "','" + s[3] + "','" + int.Parse(s[4]) + "','" + float.Parse(s[5]) + "','" + s[6] + "','" + tt + "')";
            SqlCommand cmd = new SqlCommand(ins, conn);
            int t = cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open) conn.Close();
            return t;
        }
        void clr()
        {
            foreach (Control item in grpNH.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)item;
                    if(tb.Name!="txtMHD") tb.Clear();
                }
            }
        }
        void loadHDNHap()
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            string load = "select * from NhapHang";
            SqlCommand cmd = new SqlCommand(load, conn);
            table.Load(cmd.ExecuteReader());
            if (conn.State == ConnectionState.Open) conn.Close();
            dgvNH.DataSource = table;

            DataGridViewCellStyle s1 = new DataGridViewCellStyle();
            DataGridViewCellStyle s2 = new DataGridViewCellStyle();

            s1.ForeColor = Color.Black;
            s2.ForeColor=Color.Black;
            s1.BackColor = Color.White;
            s2.BackColor=Color.SkyBlue;
            for (int i = 0; i <= dgvNH.RowCount-1; i++)
            {
                string s = dgvNH.Rows[i].Cells[0].Value.ToString();
                if(i%2==0)
                dgvNH.Rows[i].DefaultCellStyle = s1;
                else dgvNH.Rows[i].DefaultCellStyle = s2;
            }
        }
        private void GetData(string s)
        {
            txtMH.Text = s;
        }
        private void GetDataCT(string s)
        {
            txtCT.Text = s;
        }
        int chkKEY2()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string scmd = "Select Count(*) from NhapHang where MaHD_Nhap= '" + txtMHD.Text + "' And Mahang='"+txtMH.Text+"'";
            SqlCommand cmd = new SqlCommand(scmd, conn);
            int chk = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return chk;
        }
        int kthd()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            
            string skt = "select count(*) from HoaDon where MaHD_Nhap_Xuat='"+txtMHD.Text+"'";
            SqlCommand cmd = new SqlCommand(skt, conn);
            int t = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return t;
        }
        void luuHD()
        {
            HoaDon hd = new HoaDon();
            int tt=0;
            int stt = hd.Stt;
            string s = "khong co";
           
            string tongtthd = hd.tongthanhtienhd(txtMHD.Text).ToString();

            //1 la thanh toan roi
            //0 la chua thanh toan
            if (MessageBox.Show("Ban Xac Nhan la muon luu HD nay", "Xac Nhan",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                if (MessageBox.Show("Hoa Don Nay da Thanh Toan hay Chua", "Xac Nhan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    tt = 1;
                }
                else 
                {
                    tt = 0;
                }
            }
            else return;

            if (hd.ktMHD(txtMHD.Text) == 0)
            {
                string insert = "Insert into HoaDon values ('" + stt + "','" + txtMHD.Text + "','" + timMANV().ToString() + "','" + s + "','" + txtCT.Text + "','" + dateN.Text + "','" + tongtthd.ToString() + "','" + tt + "')";
                if (conn.State == ConnectionState.Closed) conn.Open();
                string date = "set DateFormat DMY";
                SqlCommand cmdd = new SqlCommand(date, conn);
                cmdd.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open) conn.Close();

   
            }
            else
            {
                MessageBox.Show("Ma Hoa Don Da Ton Tai");
                return;
            }
        }
        void delHD()
        {
            if (dgvNH.CurrentRow != null)
            {
                if (MessageBox.Show(" ", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int sl = int.Parse(dgvNH.CurrentRow.Cells[4].Value.ToString());
                    int tt = int.Parse(dgvNH.CurrentRow.Cells[7].Value.ToString());
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    string del = "delete NhapHang where MaHD_Nhap='" + txtMHD.Text + "' And Mahang='"+txtMH.Text+"'";
                    SqlCommand cmd = new SqlCommand(del, conn);
                    cmd.ExecuteNonQuery();
                    if (conn.State == ConnectionState.Open) conn.Close();
                    capnhatsoluonghang(txtMH.Text,-sl);
                 
                }
            }
            loadHDNHap();
        }
        string timDVT()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string stt = "Select DVT from HangHoa where Mahang='" + txtMH.Text + "'";
            SqlCommand cmd = new SqlCommand(stt, conn);
            string dvt = (string)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return dvt;
        }

 


        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //txtMHD.Text = currentma();
            conn = new SqlConnection(fr.cnn);
            txtTK.Text = timTenNV();
            grpNH.Enabled = false;
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muôn thêm Hóa Đơn", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (chkKey(currentma()) == 0) txtMHD.Text = currentma();
                else txtMHD.Text = findKey();
            }
        }

        private void btnSMH_Click(object sender, EventArgs e)
        {
            frmloadHang fr = new frmloadHang();
            fr.passMH = new frmloadHang.PassMH(GetData);
            fr.Show(this);
        }

        private void btnSMCT_Click(object sender, EventArgs e)
        {
            frmLoadCongTy fr = new frmLoadCongTy();
            fr.passMH = new frmLoadCongTy.PassMH(GetDataCT);
            fr.Show(this);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (btnADD.Text == "Thêm")
            {
                if (dgvNH.CurrentCell != null) txtMHD.Clear();
                dgvNH.ClearSelection();
                dgvNH.CurrentCell = null;

                clr();
                grpNH.Enabled = true;
                btnADD.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLoad.Enabled=false;
                btnLuu.Enabled = false;
                btnADD.ForeColor = Color.Red;

            }
            else if (btnADD.Text == "Lưu")
            {
                if (DateTime.Parse(dateN.Text) > DateTime.Now)
                {
                    MessageBox.Show("Vượt quá số ngày quy định", "Thông báo");
                    return;
                }
                if (chkKEY2() > 0)
                {
                    MessageBox.Show("Hoa Don Nay da Co Mon Hang Nay");
                    btnSMH.Focus();
                    return;
                }
                if (int.Parse(txtSL.Text) == 0)
                {
                    MessageBox.Show("Xin nhập số lượng, só lượng khác 0", "Thông Báo");
                    return;
                }
                try
                {
                    if (Add() > 0)
                    {
                        MessageBox.Show("them thanh cong");
                        capnhatsoluonghang(txtMH.Text, int.Parse(txtSL.Text));
                    }
                }
                catch
                {
                    MessageBox.Show("Nhập thiếu dữ liệu, yêu cầu nhập đầy đủ","Thông báo");
                    return;
                }
                btnADD.Text = "Thêm";
                btnADD.ForeColor = Color.Black;
                clr();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLoad.Enabled = true;
                grpNH.Enabled = false;
                btnLuu.Enabled = true;

                loadHDNHap();
                dgvNH.ClearSelection();
                dgvNH.CurrentCell = null;
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadHDNHap();
        }

        private void txtMH_TextChanged(object sender, EventArgs e)
        {
            if (txtMH.Text != string.Empty)
            {
                txtDG.Text = timdongia().ToString();
                lblDVT.Text = timDVT().ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMHD.Text != string.Empty && chkKey(txtMHD.Text) > 0) luuHD();
            else return;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0 && btnADD.Text != "Lưu" && btnSua.Text == "Sữa")
            {
                row = dgvNH.Rows[e.RowIndex];
                txtMHD.Text = row.Cells[0].Value.ToString();
                txtMH.Text = row.Cells[1].Value.ToString();
                txtCT.Text = row.Cells[2].Value.ToString();
                dateN.Text = row.Cells[6].Value.ToString();
                txtSL.Text = row.Cells[4].Value.ToString();
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                return;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (kthd() == 0)
            {
                int tt = int.Parse(dgvNH.CurrentRow.Cells[7].Value.ToString());
                int sl = int.Parse(dgvNH.CurrentRow.Cells[4].Value.ToString());
                string mhd = txtMH.Text;
                if (btnSua.Text == "Sữa")
                {
                    btnSua.Text = "Đã Sữa";
                    btnSua.ForeColor = Color.Red;
                    grpNH.Enabled = true;
                    btnSMH.Enabled = false;
                    btnNew.Enabled = false;
                    btnADD.Enabled = false;

                }
                else
                {
                    int slmoi = int.Parse(txtSL.Text);
                    float ttmoi = slmoi * int.Parse(txtDG.Text);

                    if (conn.State == ConnectionState.Closed) conn.Open();
                    string date = "set dateformat DMY";
                    SqlCommand cmdd = new SqlCommand(date, conn);
                    cmdd.ExecuteNonQuery();

                    string update1 = "Update NhapHang Set ngaynhap='" + dateN.Text + "',soluong='" + slmoi + "',MaCT='" + txtCT.Text + "',thanhtien='" + ttmoi + "' where MaHD_NHap='" + txtMHD.Text + "' And Mahang='" + txtMH.Text + "'";
                    SqlCommand cmd = new SqlCommand(update1, conn);
                    cmd.ExecuteNonQuery();
                    if (conn.State == ConnectionState.Open) conn.Close();

                    if (conn.State == ConnectionState.Closed) conn.Open();
                    string update2 = "Update HangHoa set soluong += " + (slmoi - sl) + " where Mahang='" + txtMH.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(update2, conn);
                    cmd2.ExecuteNonQuery();
                    if (conn.State == ConnectionState.Open) conn.Close();

                    btnSua.Text = "Sữa";
                    btnSua.ForeColor = Color.Black;

                    btnNew.Enabled = true;
                    btnSMH.Enabled = true;
                    grpNH.Enabled = false;
                    btnADD.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Hóa Đơn này đã được xác nhận, không thể xóa", "Thông Báo");
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muón Xóa HĐ này", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (kthd() == 0) delHD();
                else
                {
                    MessageBox.Show("Hóa Đơn này đã được xác nhận, không thể xóa", "Thông Báo");
                    return;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateN_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Parse(dateN.Text) > DateTime.Now)
            {
                MessageBox.Show("Vượt quá số ngày quy định","Thông báo");
                return;
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clr();
            txtMHD.Clear();
            btnADD.Text = "Thêm";
            btnADD.ForeColor = Color.Black;
            btnSua.ForeColor = Color.Black;
            btnSua.Text = "Sữa";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            grpNH.Enabled = false;
            btnLoad.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void addMoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvNH.CurrentCell != null)
            {
                if (kthd() == 0)
                {
                    clr();
                    btnADD.Text = "Lưu";
                    btnADD.ForeColor = Color.Red;
                    btnNew.Enabled = false;
                    grpNH.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Hóa Đơn này đã được xác nhận, không thể thêm hàng", "Thông Báo");
                    return;
                }
            }
        }

        private void txtSL_KeyPress_1(object sender, KeyPressEventArgs e)
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
