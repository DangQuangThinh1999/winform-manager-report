namespace DTO
{
    public class DTO_Choadon
    {
        private string _MSHD;
        private string _MANV;
        private string _MSKH;
        private string _NGAYHD;
        private string _TONGTIEN;

        public string MSHD { get => _MSHD; set => _MSHD = value; }
 
        public string MSKH { get => _MSKH; set => _MSKH = value; }
        public string NGAYHD { get => _NGAYHD; set => _NGAYHD = value; }
        public string TONGTIEN { get => _TONGTIEN; set => _TONGTIEN = value; }
        public string MANV { get => _MANV; set => _MANV = value; }

        public DTO_Choadon() { }

        public DTO_Choadon(string MSHD, string MANV, string MSKH, string NGAYHD, string TONGTIEN)
        {
            this.MSHD = MSHD;
            this.MANV = MANV;
            this.MSKH = MSKH;
            this.NGAYHD = NGAYHD;
            this.TONGTIEN = TONGTIEN;
        }
        public DTO_Choadon(string MSHD)
        {
            this.MSHD = MSHD;
        }
    }

}