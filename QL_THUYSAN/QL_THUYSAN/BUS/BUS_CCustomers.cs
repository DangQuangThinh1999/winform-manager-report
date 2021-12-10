using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CCustomers
    {
        //----Khai báo tầng DAL
        DAL_CCustomers c = new DAL_CCustomers();

        public void pr_ThemKH(DTO_CCustomers t)
        {
            c.pr_ThemKH(t);
        }
        public void pr_suaKH(DTO_CCustomers t)
        {
            c.pr_suaKH(t);
        }
        public void pr_xoaKH(DTO_CCustomers t)
        {
            c.pr_xoaKH(t);
        }
    }
}
