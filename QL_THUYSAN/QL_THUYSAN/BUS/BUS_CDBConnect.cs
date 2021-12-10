using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CDBConnect
    {
        //----------1.Khai báo lớp kết CSDL: DAL_CDBConnect
        DAL_CDBConnect lg = new DAL_CDBConnect();

        //----------2.Khai báo hàm để gọi hàm kết CSDL
        public bool DBConnect(DTO_CLogIn cn)
        {
            return lg.DBConnect(cn);
        }

        //----------3.Viết hàm gọi hàm hủy kết nối: DBDisConnect
        public bool DBDisConnect()
        {
            return lg.DBDisConnect();
        }
    }
}
