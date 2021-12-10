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
     public class DAL_Choa_don
    {
        //--------1.Viết hàm gọi Stored Procedure để thêm thông tin hóa đơn
        public void pr_ThemHD(DTO_Choadon m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_ThemHD", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSHD", System.Data.SqlDbType.Char, 10).Value = m.MSHD;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = m.MANV;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 10).Value = m.MSKH;
                cmd.Parameters.Add("@NGAYHD", System.Data.SqlDbType.DateTime).Value = m.NGAYHD;
                cmd.Parameters.Add("@TONGTIEN", System.Data.SqlDbType.Float).Value = m.TONGTIEN;
                cmd.ExecuteNonQuery(); //-----Thực hiện Stored Prcedure
                cmd.Parameters.Clear();
            }
            catch (Exception teo)
            {
                MessageBox.Show(teo.Message.ToString());
            }
        }
        //------2. Viết hàm gọi Stored Procedure để sửa thông tin hóa đơn
        public void pr_SuaHD(DTO_Choadon m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_SuaHD", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSHD", System.Data.SqlDbType.Char, 10).Value = m.MSHD;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = m.MANV;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 10).Value = m.MSKH;
                cmd.Parameters.Add("@NGAYHD", System.Data.SqlDbType.DateTime).Value = m.NGAYHD;
                cmd.Parameters.Add("@TONGTIEN", System.Data.SqlDbType.Float).Value = m.TONGTIEN;
                cmd.ExecuteNonQuery(); //-----Thực hiện Stored Prcedure
                cmd.Parameters.Clear();
            }
            catch (Exception teo)
            {
                MessageBox.Show(teo.Message.ToString());
            }
        }
        //------3. Viết hàm gọi Stored Procedure để xóa thông tin hóa đơn
        public void pr_XoaHD(DTO_Choadon m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XoaHD", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSHD", System.Data.SqlDbType.Char, 10).Value = m.MSHD;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = m.MANV;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 10).Value = m.MSKH;
                cmd.Parameters.Add("@NGAYHD", System.Data.SqlDbType.DateTime).Value = m.NGAYHD;
                cmd.Parameters.Add("@TONGTIEN", System.Data.SqlDbType.Float).Value = m.TONGTIEN;
                cmd.ExecuteNonQuery(); //-----Thực hiện Stored Prcedure
                cmd.Parameters.Clear();
            }
            catch (Exception teo)
            {
                MessageBox.Show(teo.Message.ToString());
            }
        }
    }
}
