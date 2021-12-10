using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Cvattu
    {
        private string _MSVT;
        private string _TENVT;
        private string _XUATXU;
        private string _HANGSX;
        private string _SL_TON;
        private string _DONGIA;
        private string _DONVITINH;

        public string MSVT { get => _MSVT; set => _MSVT = value; }
        public string TENVT { get => _TENVT; set => _TENVT = value; }
        public string XUATXU { get => _XUATXU; set => _XUATXU = value; }
        public string HANGSX { get => _HANGSX; set => _HANGSX = value; }
        public string SL_TON { get => _SL_TON; set => _SL_TON = value; }
        public string DONGIA { get => _DONGIA; set => _DONGIA = value; }
        public string DONVITINH { get => _DONVITINH; set => _DONVITINH = value; }

        public DTO_Cvattu() { }

        public DTO_Cvattu(string MSVT,string TENVT,string XUATXU,string HANGSX,
            string SL_TON,string DONGIA, string DONVITINH)
        {
            this.MSVT = MSVT;
            this.TENVT = TENVT;
            this.XUATXU = XUATXU;
            this.HANGSX = HANGSX;
            this.SL_TON = SL_TON;
            this.DONGIA = DONGIA;
            this.DONVITINH = DONVITINH;
        }
        public DTO_Cvattu(string MSVT)
        {
            this.MSVT = MSVT;
        }
    }
}
