using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class DTO_Cthietbi
    {
        private string _MSTB;
        private string _TENTB;
        private string _XUATXU;
        private string _HANGSX;
        private string _SL_TON;
        private string _DONGIA;
        private string _DONVITINH;

        public string MSTB { get => _MSTB; set => _MSTB = value; }
        public string TENTB { get => _TENTB; set => _TENTB = value; }
        public string XUATXU { get => _XUATXU; set => _XUATXU = value; }
        public string HANGSX { get => _HANGSX; set => _HANGSX = value; }
        public string SL_TON { get => _SL_TON; set => _SL_TON = value; }
        public string DONGIA { get => _DONGIA; set => _DONGIA = value; }
        public string DONVITINH { get => _DONVITINH; set => _DONVITINH = value; }

        public DTO_Cthietbi() { }

        public DTO_Cthietbi(string MSTB, string TENTB, string XUATXU, string HANGSX,
            string SL_TON, string DONGIA, string DONVITINH)
        {
            this.MSTB = MSTB;
            this.TENTB = TENTB;
            this.XUATXU = XUATXU;
            this.HANGSX = HANGSX;
            this.SL_TON = SL_TON;
            this.DONGIA = DONGIA;
            this.DONVITINH = DONVITINH;
        }
        public DTO_Cthietbi(string MSTB)
        {
            this.MSTB = MSTB;
        }
    }
}

