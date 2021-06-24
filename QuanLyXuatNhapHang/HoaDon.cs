using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyXuatNhapHang
{
    class HoaDon
    {
        frmLogin fr = new frmLogin();
        SqlConnection conn;
        int timstt()
        {
            conn = new SqlConnection(fr.cnn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            string update = "Select Count(*) from HoaDon";
            SqlCommand cmd = new SqlCommand(update, conn);
            int t = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return t+1;
        }
        public double tongthanhtienhd(string mahd)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string tinhtong = "Select SUM(thanhtien) from NhapHang where MaHD_Nhap='" + mahd + "'";
            SqlCommand cmd = new SqlCommand(tinhtong, conn);
            double t = (double)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            return t;
        }
        public double tongthanhtienhdx(string mahd)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string tinhtong = "Select SUM(thanhtien) from XuatHang where MaHD_Xuat='" + mahd + "'";
            SqlCommand cmd = new SqlCommand(tinhtong, conn);
            double t = (double)cmd.ExecuteScalar();
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
