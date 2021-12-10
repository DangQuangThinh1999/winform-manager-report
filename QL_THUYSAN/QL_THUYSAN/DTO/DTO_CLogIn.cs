using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CLogIn
    {
        //------------Khai báo các biến dùng để LogIn
        private string _Servername;
        public string Servername
        {
            get { return _Servername; }
            set { _Servername = value; }
        }

        private string _Database;
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }

        private string _UserID;
        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        //---------Khai báo hàm khởi tạo - Constructor
        public DTO_CLogIn() { }

        public DTO_CLogIn(string sn, string db, string userid, string pass)
        {
            this.Servername = sn;
            this.Database = db;
            this.UserID = userid;
            this.Password = pass;
        }

    }
}
