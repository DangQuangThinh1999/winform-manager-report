using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Cvattu
    {
        //----Khai báo tầng DAL
        DAL_Cvattu a = new DAL_Cvattu();

        public void pr_ThemVT(DTO_Cvattu m)
        {
            a.pr_ThemVT(m);
        }
        public void pr_SuaVT(DTO_Cvattu m)
        {
            a.pr_SuaVT(m);
        }
        public void pr_XoaVT(DTO_Cvattu m)
        {
            a.pr_XoaVT(m);
        }
    }
}
