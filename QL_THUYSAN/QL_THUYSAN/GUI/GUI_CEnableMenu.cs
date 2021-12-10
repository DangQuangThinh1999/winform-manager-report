using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class GUI_CEnableMenu
    {
        //--------------Khai báo form hệ thống
        public static frmHethong frmHT = new frmHethong();

        //--------------Viết hàm Ẩ/Hiện menu hệ thống
        public void EnableMenu(bool d1, bool d2)
        {
            frmHT.mnuDN.Enabled = d1;   //----Đăng nhập
            frmHT.mnuHKN.Enabled = d2;  //----Hủy kết nối
           
            frmHT.mnuBC.Enabled = d2;   //----Báo cáo
        }
        //-------------Viết hàm chính cho hệ thống: Main()
        static void Main()
        {
            Application.Run(frmHT);
        }
    }
}
