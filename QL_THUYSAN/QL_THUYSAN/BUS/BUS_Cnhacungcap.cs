using System;
using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Cnhacungcap
    {
        //----Khai báo tầng DAL
        DAL_Cnhacungcap a = new DAL_Cnhacungcap();

        public void pr_ThemNCC(DTO_Cnhacungcap m)
        {
            a.pr_ThemNCC(m);
        }
        public void pr_SuaNCC(DTO_Cnhacungcap m)
        {
            a.pr_SuaNCC(m);
        }
        public void pr_XoaNCC(DTO_Cnhacungcap m)
        {
            a.pr_XoaNCC(m);
        }

    }
}
