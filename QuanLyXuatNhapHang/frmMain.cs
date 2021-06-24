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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string _ID;
        frmLogin fr = new frmLogin();
        SqlConnection conn;
        string timMANV()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string scmd = "Select MaNV from chitietNhanVien where ID= '" + _ID + "'";
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
        public frmMain(int quyentruycap,string ID)
        {
            InitializeComponent();
            if (quyentruycap == 1)
            {
                QLNS.Visible = false;
            }
            else if (quyentruycap == 2)
            {
                QLNS.Visible = false;
                QLCTN.Visible = false;
                QLKH.Visible = false;
            }
            _ID = ID;
            MaximizeBox = false;
        }

        private void QLNS_Click(object sender, EventArgs e)
        {
            bool a = true;
            foreach (Form i in this.MdiChildren)
            {
                if (i.Name == "frmQLNS")
                {
                    i.Activate();
                    a = false;
                }
                else
                {
                    i.Close();
                }
            }
            if (a == true)
            {
                frmQLNS fr = new frmQLNS();
                fr.MdiParent = this;
                fr.Show();
                this.ClientSize = new System.Drawing.Size(fr.Size.Width, fr.Size.Height + 20);
                fr.Dock = DockStyle.Fill;
                picM.Hide();
            }
            else
            {
                return;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Thoát", "Xac Nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;
        }

        private void QLH_Click(object sender, EventArgs e)
        {
            bool a = true;
            foreach (Form i in this.MdiChildren)
            {
                if (i.Name == "frmQLHangHoa")
                {
                    //i.ActiveMdiChild;
                    a = false;
                }
                else
                {
                    i.Close();

                }
            }
            if (a == true)
            {
                frmQLHangHoa fr = new frmQLHangHoa();
                fr.MdiParent = this;
                fr.Show();
                this.ClientSize = new System.Drawing.Size(fr.Size.Width, fr.Size.Height+20);
                fr.Dock = DockStyle.Fill;
                picM.Hide();
            }
            else
            {
                return;
            }
        }

        private void QLXH_Click(object sender, EventArgs e)
        {
            bool a = true;
            foreach (Form i in this.MdiChildren)
            {
                if (i.Name == "frmXuatHang")
                {
                    //i.ActiveMdiChild;
                    a = false;
                }
                else
                {

                    i.Close();

                }
            }
            if (a == true)
            {
                frmXuatHang fr = new frmXuatHang(_ID);
                fr.MdiParent = this;
                fr.Show();
                this.ClientSize = new System.Drawing.Size(fr.Size.Width, fr.Size.Height + 20);
                fr.Dock = DockStyle.Fill;
                picM.Hide();
            }
            else
            {
                return;
            }
        }

        private void QLNH_Click(object sender, EventArgs e)
        {
            bool a = true;
            foreach (Form i in this.MdiChildren)
            {
                if (i.Name == "frmNhapHang")
                {
                    i.Activate();
                    a = false;
                }
                else
                {

                    i.Close();

                }
            }
            if (a == true)
            {
                frmNhapHang fr = new frmNhapHang(_ID);
                fr.MdiParent = this;
                fr.Show();
                this.ClientSize = new System.Drawing.Size(fr.Size.Width, fr.Size.Height + 20);
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Dock = DockStyle.Fill;
                picM.Hide();
            }
            else
            {
                return;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(fr.cnn);
            lblName.Text = timTenNV();
        }

        private void xHD_Click(object sender, EventArgs e)
        {
            bool a = true;
            foreach (Form i in this.MdiChildren)
            {
                if (i.Name == "frmHoaDon")
                {
                    i.Activate();
                    a = false;
                }
                else i.Close();
                
            }
            if (a == true)
            {
                frmHoaDon fr = new frmHoaDon();
                fr.MdiParent = this;
                fr.Show();
                this.ClientSize = new System.Drawing.Size(fr.Size.Width, fr.Size.Height + 20);
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Dock = DockStyle.Fill;
                picM.Hide();
            }
            else
            {
                return;
            }
        }

        private void QLKH_Click(object sender, EventArgs e)
        {
            bool a = true;
            foreach (Form i in this.MdiChildren)
            {
                if (i.Name == "frmQLKhachHang")
                {
                    i.Activate();
                    a = false;
                }
                else i.Close();

            }
            if (a == true)
            {
                frmQLKhachHang fr = new frmQLKhachHang();
                fr.MdiParent = this;
                fr.Show();
                this.ClientSize = new System.Drawing.Size(fr.Size.Width, fr.Size.Height + 20);
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Dock = DockStyle.Fill;
                picM.Hide();
            }
            else
            {
                return;
            }
        }

        private void QLCTN_Click(object sender, EventArgs e)
        {
            bool a = true;
            foreach (Form i in this.MdiChildren)
            {
                if (i.Name == "frmQLCongTy")
                {
                    i.Activate();
                    a = false;
                }
                else i.Close();

            }
            if (a == true)
            {
                frmQLCongTy fr = new frmQLCongTy();
                fr.MdiParent = this;
                fr.Show();
                this.ClientSize = new System.Drawing.Size(fr.Size.Width, fr.Size.Height + 20);
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Dock = DockStyle.Fill;
                picM.Hide();
            }
            else
            {
                return;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin fr = new frmLogin();
            fr.Show();
            this.Dispose();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            if (grpHT.Visible == false)
                grpHT.Visible = true;
            else grpHT.Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin fr = new frmLogin();
            fr.Show();
            this.Dispose();
        }

        private void btnCPass_Click(object sender, EventArgs e)
        {
            if (_ID[0] == 'a' && _ID[1] == 'd')
            {
                frmChangingPass fr = new frmChangingPass(_ID, true);
                fr.ShowDialog(this);
            }
            else
            {
                frmChangingPass fr = new frmChangingPass(_ID, false);
                fr.ShowDialog(this);
            }
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLienHe fr = new frmLienHe();
            fr.ShowDialog(this);
        }

        
       
    }
}
