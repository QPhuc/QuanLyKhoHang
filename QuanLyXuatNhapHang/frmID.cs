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
    public partial class frmID : Form
    {
        public frmID()
        {
            InitializeComponent();
            rdUS.Checked = true;
            conn = new SqlConnection(fr.cnn);
            AcceptButton = button1;
        }
        frmLogin fr = new frmLogin();
        SqlConnection conn;
       
        public delegate void PassControl(string s);
        public PassControl passControl;
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
        int add()
        {

            string pass = GetMD5(txtMK.Text);
            string id = txtPQ.Text + txtID.Text;
            int a = 0;
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string add = "insert into NhanVien values('" + id + "','" + pass + "')";
                SqlCommand cmd = new SqlCommand(add, conn);
                a = (int)cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            catch
            {
                MessageBox.Show("Trùng ID, bạn nên đặt ID la " + id + "123, " + id + "321,...");
            }
            return a;
        }

        private void frmID_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtID.Text==string.Empty || txtMK.Text==string.Empty || txtMKR.Text==string.Empty)
            {
                MessageBox.Show("Thiếu dũu liệu", "Thông Báo");
                return;
            }
            if (txtMK.Text != txtMKR.Text)
            {
                MessageBox.Show("Mật Khẩu không khớp", "Thông Báo");
                return;
            }
            if (add() > 0)
            {
                MessageBox.Show("thêm ID thành công");
                passControl(txtPQ.Text + txtID.Text);
                this.Close();
            }
           
        }

        private void frmID_Load(object sender, EventArgs e)
        {

        }

        private void rdUS_CheckedChanged(object sender, EventArgs e)
        {
            if (rdUS.Checked)
            {
                txtPQ.Text = "us";
               
            }
        }

        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMa.Checked)
            {
                txtPQ.Text = "ma";
                
            }
        }

        private void rdAd_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAd.Checked)
            {
                txtPQ.Text = "ad";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
