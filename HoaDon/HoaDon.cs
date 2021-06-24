using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyXuatNhapHang;
using System.Data;


namespace HoaDon
{
    public class HoaDon
    {
        frmLogin fr = new frmLogin();
        SqlConnection conn;
        public int timstt()
        {
            conn = new SqlConnection(fr.cnn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            string update = "Select Count(*) from HoaDon";
            SqlCommand cmd = new SqlCommand(update, conn);
            int t = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return t;
        }
        public int tongthanhtienhd(string mahd)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string update = "Select SUM(thanhtien) from NhapHang where MaHD_Nhap='" + mahd + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            int t = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return t;
        }
        public int ktMHD(string mahd)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string update = "Select Count(*) from HoaDon where MaHD_Nhap_Xuat='" + mahd + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            int t = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return t;
        }

        int stt;

        public int Stt
        {
            get { return timstt(); }
        }

        string maHD;

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public HoaDon()
        {

        }
    }
}
