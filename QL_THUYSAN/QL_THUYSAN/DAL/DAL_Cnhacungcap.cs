using System;
using DTO;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
   public class DAL_Cnhacungcap
    {
        //------------------1.Viết hàm gọi Stored Procedure để thêm thông tin nhà cung cấp
        public void pr_ThemNCC(DTO_Cnhacungcap m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_ThemNCC", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSNCC", System.Data.SqlDbType.Char, 10).Value = m.MSNCC;
                cmd.Parameters.Add("@TENNCC", System.Data.SqlDbType.NVarChar, 50).Value = m.TENNCC;
                cmd.Parameters.Add("@HANG", System.Data.SqlDbType.NVarChar, 50).Value = m.HANG;
   
                cmd.ExecuteNonQuery(); //-----Thực hiện Stored Prcedure
                cmd.Parameters.Clear();
            }
            catch (Exception thinh)
            {
                MessageBox.Show(thinh.Message.ToString());
            }
        }
        //------------------2.Viết hàm gọi Stored Procedure để sửa thông tin nhà cung cấp
        public void pr_SuaNCC(DTO_Cnhacungcap m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_SuaNCC", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSNCC", System.Data.SqlDbType.Char, 10).Value = m.MSNCC;
                cmd.Parameters.Add("@TENNCC", System.Data.SqlDbType.NVarChar, 50).Value = m.TENNCC;
                cmd.Parameters.Add("@HANG", System.Data.SqlDbType.NVarChar, 50).Value = m.HANG;
                cmd.ExecuteNonQuery(); //-----Thực hiện Stored Prcedure
                cmd.Parameters.Clear();
            }
            catch (Exception thinh)
            {
                MessageBox.Show(thinh.Message.ToString());
            }
        }
        //------------------2.Viết hàm gọi Stored Procedure để xóa thông tin nhà cung cấp
        public void pr_XoaNCC(DTO_Cnhacungcap m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XoaNCC", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSNCC", System.Data.SqlDbType.Char, 10).Value = m.MSNCC;
                cmd.Parameters.Add("@TENNCC", System.Data.SqlDbType.NVarChar, 50).Value = m.TENNCC;
                cmd.Parameters.Add("@HANG", System.Data.SqlDbType.NVarChar, 50).Value = m.HANG;
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
