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
    public class DAL_Cvattu
    {
        //------------------1.Viết hàm gọi Stored Procedure để thêm thông tin vật tư
        public void pr_ThemVT(DTO_Cvattu m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_ThemVT", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSVT", System.Data.SqlDbType.Char, 10).Value = m.MSVT;
                cmd.Parameters.Add("@TENVT", System.Data.SqlDbType.NVarChar, 50).Value = m.TENVT;
                cmd.Parameters.Add("@XUATXU", System.Data.SqlDbType.NVarChar, 50).Value = m.XUATXU;
                cmd.Parameters.Add("@HANGSX", System.Data.SqlDbType.NVarChar, 50).Value = m.HANGSX;
                cmd.Parameters.Add("@SL_TON", System.Data.SqlDbType.Int).Value = m.SL_TON;
                cmd.Parameters.Add("@DONGIA", System.Data.SqlDbType.Float).Value = m.DONGIA;
                cmd.Parameters.Add("@DONVITINH", System.Data.SqlDbType.NVarChar, 10).Value = m.DONVITINH;
                cmd.ExecuteNonQuery(); //-----Thực hiện Stored Prcedure
                cmd.Parameters.Clear();
            }
            catch (Exception thinh)
            {
                MessageBox.Show(thinh.Message.ToString());
            }
        }
        //------------------2.Viết hàm gọi Stored Procedure để sửa thông tin vật tư
        public void pr_SuaVT(DTO_Cvattu m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_SuaVT", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSVT", System.Data.SqlDbType.Char, 10).Value = m.MSVT;
                cmd.Parameters.Add("@TENVT", System.Data.SqlDbType.NVarChar, 50).Value = m.TENVT;
                cmd.Parameters.Add("@XUATXU", System.Data.SqlDbType.NVarChar, 50).Value = m.XUATXU;
                cmd.Parameters.Add("@HANGSX", System.Data.SqlDbType.NVarChar, 50).Value = m.HANGSX;
                cmd.Parameters.Add("@SL_TON", System.Data.SqlDbType.Int).Value = m.SL_TON;
                cmd.Parameters.Add("@DONGIA", System.Data.SqlDbType.Float).Value = m.DONGIA;
                cmd.Parameters.Add("@DONVITINH", System.Data.SqlDbType.NVarChar, 10).Value = m.DONVITINH;
                cmd.ExecuteNonQuery(); //-----Thực hiện Stored Prcedure
                cmd.Parameters.Clear();
            }
            catch (Exception thinh)
            {
                MessageBox.Show(thinh.Message.ToString());
            }
        }
        //------------------3.Viết hàm gọi Stored Procedure để xóa  thông tin vật tư
        public void pr_XoaVT(DTO_Cvattu m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XoaVT", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSVT", System.Data.SqlDbType.Char, 10).Value = m.MSVT;
                cmd.Parameters.Add("@TENVT", System.Data.SqlDbType.NVarChar, 50).Value = m.TENVT;
                cmd.Parameters.Add("@XUATXU", System.Data.SqlDbType.NVarChar, 50).Value = m.XUATXU;
                cmd.Parameters.Add("@HANGSX", System.Data.SqlDbType.NVarChar, 50).Value = m.HANGSX;
                cmd.Parameters.Add("@SL_TON", System.Data.SqlDbType.Int).Value = m.SL_TON;
                cmd.Parameters.Add("@DONGIA", System.Data.SqlDbType.Float).Value = m.DONGIA;
                cmd.Parameters.Add("@DONVITINH", System.Data.SqlDbType.NVarChar, 10).Value = m.DONVITINH;
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
