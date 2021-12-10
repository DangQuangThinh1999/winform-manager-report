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
    public class DAL_Cthietbi
    {
        //------------------1.Viết hàm gọi Stored Procedure để thêm thông tin thiết bị
        public void pr_ThemTB(DTO_Cthietbi m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_ThemTB", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSVTB", System.Data.SqlDbType.Char, 10).Value = m.MSTB;
                cmd.Parameters.Add("@TENTB", System.Data.SqlDbType.NVarChar, 50).Value = m.TENTB;
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
        //------------------2.Viết hàm gọi Stored Procedure để sửa thông tin thiết bị
        public void pr_SuaTB(DTO_Cthietbi m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_SuaTB", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSTB", System.Data.SqlDbType.Char, 10).Value = m.MSTB;
                cmd.Parameters.Add("@TENTB", System.Data.SqlDbType.NVarChar, 50).Value = m.TENTB;
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
        //------------------3.Viết hàm gọi Stored Procedure để xóa thông tin thiết bị
        public void pr_XoaTB(DTO_Cthietbi m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XoaTB", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSTB", System.Data.SqlDbType.Char, 10).Value = m.MSTB;
                cmd.Parameters.Add("@TENTB", System.Data.SqlDbType.NVarChar, 50).Value = m.TENTB;
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
