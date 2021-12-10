using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class BUS_Cnhanvien
    {
        DAL_Cnhanvien v = new DAL_Cnhanvien();
        public void pr_ThemNV(DTO_Cnhanvien n)
        {
            v.pr_ThemNV(n);
        }
        public void pr_SuaNV(DTO_Cnhanvien n)
        {
            v.pr_SuaNV(n);
        }
        public void pr_XoaNV(DTO_Cnhanvien n)
        {
            v.pr_XoaNV(n);
        }
    }
}
