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
    public partial class frmChangingPass : Form
    {
        public frmChangingPass()
        {
            InitializeComponent();
            AcceptButton = button1;
        }
        public frmChangingPass(string _ID, bool _flag)
        {
            InitializeComponent();
            conn = new SqlConnection(frm.cnn);
            ID = _ID;
            flag = _flag;
            MaximizeBox = false;
        }
        frmLogin frm = new frmLogin();
        SqlConnection conn;
        string ID;
        bool flag = false;
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
        void add()
        {
            string pass = GetMD5(txtPass.Text);

            if (conn.State == ConnectionState.Closed) conn.Open();
            string update = "update NhanVien set Pass='" + pass + "',ID='"+txtID.Text+"' where ID='" + ID + "'";
            SqlCommand cmd = new SqlCommand(update,conn);
            cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open) conn.Close();
            MessageBox.Show("Đổi Pass Thành Công", "Xác Nhận");
        }
        int ktkey()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string update = "select count(*) from NhanVien where ID='"+txtID.Text+"'";
            SqlCommand cmd = new SqlCommand(update, conn);
            int kt = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return kt;
        }

        private void frmChangingPass_Load(object sender, EventArgs e)
        {
            txtID.Text = ID;
            if (flag == true) txtID.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (txtID.Text != ID)
                {
                    if (ktkey() == 0)
                    {
                        if (txtPass.Text != string.Empty) add();
                        else MessageBox.Show("Mời Nhập Pass Mới", "Thong Bao");
                    }
                    else
                    {
                        MessageBox.Show("Trùng ID nhân viên, Thông Báo");
                        return;
                    }
                }
                else
                {
                    if (txtPass.Text != string.Empty) add();
                    else MessageBox.Show("Mời Nhập Pass Mới", "Thong Bao");
                }
            }
            else
            {
                if (txtPass.Text != string.Empty) add();
                else MessageBox.Show("Mời Nhập Pass Mới", "Thong Bao");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
