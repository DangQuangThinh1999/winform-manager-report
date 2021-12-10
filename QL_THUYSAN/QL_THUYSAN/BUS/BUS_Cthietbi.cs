using System;
using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class BUS_Cthietbi
    {
        //----Khai báo tầng DAL
        DAL_Cthietbi a = new DAL_Cthietbi();

        public void pr_ThemTB(DTO_Cthietbi m)
        {
            a.pr_ThemTB(m);
        }
        public void pr_SuaTB(DTO_Cthietbi m)
        {
            a.pr_SuaTB(m);
        }
        public void pr_XoaTB(DTO_Cthietbi m)
        {
            a.pr_XoaTB(m);
        }
    }
}
