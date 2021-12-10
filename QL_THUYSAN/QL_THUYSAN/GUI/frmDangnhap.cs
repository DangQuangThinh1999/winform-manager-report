
using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class frmDangnhap : Form
    {
        //------------Khai báo lớp có chứa hàm kết nối CSDL
        BUS_CDBConnect cn = new BUS_CDBConnect();

        //------------Khai báo lớp có chứa hàm Ẩn/Hiện menu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();

        //------------Khai báo các biến chứa thông tin đăng nhập
        public static string SV = string.Empty;
        public static string DB = string.Empty;
        public static string UI = string.Empty;
        public static string Pass = string.Empty;

        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            SV = txtServername.Text.Trim();
            DB = txtDatabase.Text.Trim();
            UI = txtUserID.Text.Trim();
            Pass = txtPassword.Text.Trim();
            //---------1.Gọi hàm khởi tạo ở lớp: DTO_CLogIn
            DTO_CLogIn lg = new DTO_CLogIn(txtServername.Text.Trim(), 
                                           txtDatabase.Text.Trim(), 
                                           txtUserID.Text.Trim(), 
                                           txtPassword.Text.Trim());

            //----------2.Gọi hàm kết nối CSDL ở tầng: BUS
            if (cn.DBConnect(lg) == true)
            {
                this.Close();                //---Đóng form Đăng nhập
                mnu.EnableMenu(false, true); //---Gọi hàm Ẩn/Hiện menu
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
