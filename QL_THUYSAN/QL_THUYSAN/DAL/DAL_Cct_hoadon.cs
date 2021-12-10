using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DAL
{
    public class DAL_Cct_hoadon
    {
        //--------1.Viết hàm gọi Stored Procedure để thêm mới chi tiết hóa đơn
        public void pr_Themct_hoadon(DTO_Cct_hoadon h)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_Themct_hoadon", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSHD", System.Data.SqlDbType.Char, 10).Value = h.MSHD;
                cmd.Parameters.Add("@MSVT", System.Data.SqlDbType.Char, 10).Value = h.MSVT;
                cmd.Parameters.Add("@MSTB", System.Data.SqlDbType.Char, 10).Value = h.MSTB;
                cmd.Parameters.Add("@SOLUONGVT", System.Data.SqlDbType.Int).Value = h.SOLUONGVT;
                cmd.Parameters.Add("@SOLUONGTB", System.Data.SqlDbType.Int).Value = h.SOLUONGTB;
                cmd.Parameters.Add("@THANHTIEN", System.Data.SqlDbType.Money).Value = h.THANHTIEN;
                cmd.ExecuteNonQuery(); //-----Thực hiện Stored Prcedure
                cmd.Parameters.Clear();
            }
            catch (Exception thinh)
            {
                MessageBox.Show(thinh.Message.ToString());

            }
        }
        //--------2.Viết hàm gọi Stored Procedure để sửa chi tiết hóa đơn
        public void pr_Suact_hoadon(DTO_Cct_hoadon h)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_Suact_hoadon", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSHD", System.Data.SqlDbType.Char, 10).Value = h.MSHD;
                cmd.Parameters.Add("@MSVT", System.Data.SqlDbType.Char, 10).Value = h.MSVT;
                cmd.Parameters.Add("@MSTB", System.Data.SqlDbType.Char, 10).Value = h.MSTB;
                cmd.Parameters.Add("@SOLUONGVT", System.Data.SqlDbType.Int).Value = h.SOLUONGVT;
                cmd.Parameters.Add("@SOLUONGTB", System.Data.SqlDbType.Int).Value = h.SOLUONGTB;
                cmd.Parameters.Add("@THANHTIEN", System.Data.SqlDbType.Money).Value = h.THANHTIEN;
                cmd.ExecuteNonQuery(); //-----Thực hiện Stored Prcedure
                cmd.Parameters.Clear();
            }
            catch (Exception thinh)
            {
                MessageBox.Show(thinh.Message.ToString());

            }
        }

        //--------3.Viết hàm gọi Stored Procedure để xóa chi tiết hóa đơn
        public void pr_Xoact_hoadon(DTO_Cct_hoadon h)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_Xoact_hoadon", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSHD", System.Data.SqlDbType.Char, 10).Value = h.MSHD;
                cmd.Parameters.Add("@MSVT", System.Data.SqlDbType.Char, 10).Value = h.MSVT;
                cmd.Parameters.Add("@MSTB", System.Data.SqlDbType.Char, 10).Value = h.MSTB;
                cmd.Parameters.Add("@SOLUONGVT", System.Data.SqlDbType.Int).Value = h.SOLUONGVT;
                cmd.Parameters.Add("@SOLUONGTB", System.Data.SqlDbType.Int).Value = h.SOLUONGTB;
                cmd.Parameters.Add("@THANHTIEN", System.Data.SqlDbType.Money).Value = h.THANHTIEN;
                cmd.ExecuteNonQuery(); //-----Thực hiện Stored Prcedure
                cmd.Parameters.Clear();
            }
            catch (Exception thinh)
            {
                MessageBox.Show(thinh.Message.ToString());

            }
        }
    }

    
}


