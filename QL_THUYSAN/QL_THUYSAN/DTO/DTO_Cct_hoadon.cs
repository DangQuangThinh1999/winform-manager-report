namespace DTO
{
    public class DTO_Cct_hoadon
    {
   
        private string _MSHD;
        private string _MSVT;
        private string _MSTB;
        private string _SOLUONGVT;
        private string _SOLUONGTB;
        private string _THANHTIEN;

        public string MSHD { get => _MSHD; set => _MSHD = value; }
        public string MSVT { get => _MSVT; set => _MSVT = value; }
        public string MSTB { get => _MSTB; set => _MSTB = value; }
        public string SOLUONGVT { get => _SOLUONGVT; set => _SOLUONGVT = value; }
        public string SOLUONGTB { get => _SOLUONGTB; set => _SOLUONGTB = value; }
        public string THANHTIEN { get => _THANHTIEN; set => _THANHTIEN = value; }




        //--------Viết hàm khởi tạo: Constructor
        public DTO_Cct_hoadon() { }

            public DTO_Cct_hoadon(string MSHD, string MSVT,string MSTB,string SOLUONGVT, string SOLUONGTB, string THANHTIEN)
            {
                this.MSHD = MSHD;
                this.MSVT = MSVT;
                this.MSTB = MSTB;
                this.SOLUONGVT = SOLUONGVT;
                this.SOLUONGTB = SOLUONGTB;
                this.THANHTIEN = THANHTIEN;
            }
            public DTO_Cct_hoadon(string MSHD)
            {
                this.MSHD = MSHD;
            }

        }
    }

