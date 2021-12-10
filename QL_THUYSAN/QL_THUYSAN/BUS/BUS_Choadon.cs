using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Choadon
    {
        DAL_Choa_don c = new DAL_Choa_don();

        public void pr_ThemHD(DTO_Choadon t)
        {
            c.pr_ThemHD(t);
        }
        public void pr_SuaHD(DTO_Choadon t)
        {
            c.pr_SuaHD(t);
        }
        public void pr_XoaHD(DTO_Choadon t)
        {
            c.pr_XoaHD(t);
        }
    }
}
