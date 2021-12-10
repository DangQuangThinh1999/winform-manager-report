using DAL;
using DTO;

namespace BUS
{
    public class BUS_Cct_hoadon
    {

            DAL_Cct_hoadon b = new DAL_Cct_hoadon();
            public void pr_themct_hoadon(DTO_Cct_hoadon h)
            {
                b.pr_Themct_hoadon(h);
            }
            public void pr_suact_hoadon(DTO_Cct_hoadon h)
            {
                b.pr_Suact_hoadon(h);
            }
            public void pr_xoact_hoadon(DTO_Cct_hoadon h)
             {
            b.pr_Xoact_hoadon(h);
             }
    }
}

