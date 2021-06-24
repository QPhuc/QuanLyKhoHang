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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
            txtID.ShortcutsEnabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
        }
        //dòng lệnh chạy khắp các form
        public string cnn = @"Data Source = .\TQUANGPHUC; Initial Catalog=QLKHOHANG; User ID =sa; Password=123456";
        //bool num = false;


        int kt()
        {
            if (txtID.Text == string.Empty) return 0;
            if (txtPass.Text == string.Empty) return 0;

            //string pass = GetMD5(txtPass.Text);

            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();
            string scmd = "Select count(*) from NhanVien where ID= '" + txtID.Text + "' and PASS = '" + txtPass.Text + "'";
            SqlCommand cmd = new SqlCommand(scmd,conn);
            int kt= (int)cmd.ExecuteScalar();
            conn.Close();
            return kt;
        }
        private String GetMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }

       
        //0: admin
        //1: manager
        //2: user
        /*string timMANV()
        {
            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();
            string scmd = "Select MaNV from chitietNhanVien where ID= '" + txtID.Text + "'";
            SqlCommand cmd = new SqlCommand(scmd, conn);
            string MaNV = (string)cmd.ExecuteScalar();
            conn.Close();
            return MaNV;
        }*/
        public string t = string.Empty;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (kt() > 0)
            {
                string ID = txtID.Text;
                if (ID[0] == 'a' && ID[1] == 'd')
                {
                    frmMain fr = new frmMain(0, ID);
                    this.Hide();
                    fr.Show();
                }
                else
                {
                    bool xd = false;
                    if (ID[0] == 'm' && ID[1] == 'a')
                    {
                        xd = true;
                        frmMain fr = new frmMain(1, ID);
                        this.Hide();
                        fr.Show();
                    }
                    else if (ID[0] == 'u' && ID[1] == 's')
                    {
                        frmMain fr = new frmMain(2, ID);
                        this.Hide();
                        fr.Show();
                    }
                    else
                    {
                        MessageBox.Show("ID khong co quyen truy cap");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Sai hoặc thiếu thông tin người dùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
    }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtPass.Clear();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (DialogResult.Yes == MessageBox.Show("Bạn Muốn Thoát Khỏi Chương Trình", "Thông Báo Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //{
             
            //    e.Cancel = false;
            //}
            //else e.Cancel = true;
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar > (char)47) && (e.KeyChar < (char)58) 
                || ((e.KeyChar > (char)64)) && (e.KeyChar < (char)91)) 
                || (e.KeyChar>(char)96) && (e.KeyChar<(char)123) 
                || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            /*LinearGradientBrush dr = new LinearGradientBrush(this.ClientRectangle, 
                                                            Color.White, 
                                                            Color.PapayaWhip, 
                                                            90F);
            e.Graphics.FillRectangle(dr, this.ClientRectangle);*/
        }

    }
}
