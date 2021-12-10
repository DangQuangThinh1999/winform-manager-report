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
    public class DAL_CDBConnect
    {
        //---------------1.Khai báo lớp SqlConnnection: kết nối CSDL
        public static SqlConnection myconn = null;

        //---------------2.Viết hàm kết nối với CSDL
        public bool DBConnect(DTO_CLogIn lg)
        {
            try
            {
                myconn = new SqlConnection( "Data Source="+ lg.Servername +
                                            "; Initial Catalog="+ lg.Database +
                                            "; User ID="+ lg.UserID +
                                            ";Password="+ lg.Password);
                myconn.Open(); //----Mở kết nối CSDL
                return true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
                return false;
            }
        }
        //----------------3.Viết hàm hủy kết nối CSDL
        public bool DBDisConnect()
        {
            try
            {
                myconn.Close(); //-----Hủy kết nối
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
    }
}
