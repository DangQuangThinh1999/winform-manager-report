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
   public class DAL_Cnhanvien
    {
        //---------- 1 Viết hàm gọi Stored Procedure để thêm thông tin nhân viên
        public void pr_ThemNV(DTO_Cnhanvien n)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_ThemNV", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = n.MANV;
                cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar, 30).Value = n.TENNV;
                cmd.Parameters.Add("@TENDANGNHAP", System.Data.SqlDbType.NVarChar,256).Value = n.TENDANGNHAP;
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = n.NGAYSINH;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NChar, 10).Value = n.PHAI;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 50).Value = n.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = n.DIENTHOAI;
                cmd.Parameters.Add("@SO_HD_THUCHIEN", System.Data.SqlDbType.Int).Value = n.SO_HD_THUCHIEN;
                cmd.Parameters.Add("@NGAYDANGNHAP", System.Data.SqlDbType.DateTime).Value = n.NGAYDANGNHAP;
                cmd.Parameters.Add("@SOLANDN", System.Data.SqlDbType.Int).Value = n.SOLANDN;
                cmd.Parameters.Add("@QUYENHAN", System.Data.SqlDbType.NVarChar, 20).Value = n.QUYENHAN;
                cmd.ExecuteNonQuery(); //-----Thực hiện Stored Prcedure
                cmd.Parameters.Clear();
            }
            catch (Exception teo)
            {
                MessageBox.Show(teo.Message.ToString());
            }
        }
       
         //---------- 2. Viết hàm gọi Stored Procedure để sửa thông tin nhân viên
        public void pr_SuaNV(DTO_Cnhanvien n)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_SuaNV", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = n.MANV;
                cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar, 30).Value = n.TENNV;
                cmd.Parameters.Add("@TENDANGNHAP", System.Data.SqlDbType.NVarChar,256).Value = n.TENDANGNHAP;
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = n.NGAYSINH;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NChar, 10).Value = n.PHAI;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 50).Value = n.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = n.DIENTHOAI;
                cmd.Parameters.Add("@SO_HD_THUCHIEN", System.Data.SqlDbType.Int).Value = n.SO_HD_THUCHIEN;
                cmd.Parameters.Add("@NGAYDANGNHAP", System.Data.SqlDbType.DateTime).Value = n.NGAYDANGNHAP;
                cmd.Parameters.Add("@SOLANDN", System.Data.SqlDbType.Int).Value = n.SOLANDN;
                cmd.Parameters.Add("@QUYENHAN", System.Data.SqlDbType.NVarChar, 20).Value = n.QUYENHAN;
                cmd.ExecuteNonQuery(); //-----Thực hiện Stored Prcedure
                cmd.Parameters.Clear();
            }
            catch (Exception teo)
            {
                MessageBox.Show(teo.Message.ToString());
            }
        }
        //---------- 3. Viết hàm gọi Stored Procedure để xóa thông tin nhân viên
        public void pr_XoaNV(DTO_Cnhanvien n)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XoaNV", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = n.MANV;
                cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar, 30).Value = n.TENNV;
                cmd.Parameters.Add("@TENDANGNHAP", System.Data.SqlDbType.NVarChar, 256).Value = n.TENDANGNHAP;
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = n.NGAYSINH;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NChar, 10).Value = n.PHAI;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 50).Value = n.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = n.DIENTHOAI;
                cmd.Parameters.Add("@SO_HD_THUCHIEN", System.Data.SqlDbType.Int).Value = n.SO_HD_THUCHIEN;
                cmd.Parameters.Add("@NGAYDANGNHAP", System.Data.SqlDbType.DateTime).Value = n.NGAYDANGNHAP;
                cmd.Parameters.Add("@SOLANDN", System.Data.SqlDbType.Int).Value = n.SOLANDN;
                cmd.Parameters.Add("@QUYENHAN", System.Data.SqlDbType.NVarChar, 20).Value = n.QUYENHAN;
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
