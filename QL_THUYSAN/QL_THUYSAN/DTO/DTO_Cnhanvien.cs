namespace DTO
{
    public class DTO_Cnhanvien
    {
        private string _MANV;
        private string _TENNV;
        private string _TENDANGNHAP;
        private string _NGAYSINH;
        private string _PHAI;
        private string _DIACHI;
        private string _DIENTHOAI;
        private string _SO_HD_THUCHIEN;
        private string _NGAYDANGNHAP;
        private string _SOLANDN;
        private string _QUYENHAN;

        public string MANV { get => _MANV; set => _MANV = value; }
        public string TENNV { get => _TENNV; set => _TENNV = value; }
        public string TENDANGNHAP { get => _TENDANGNHAP; set => _TENDANGNHAP = value; }
        public string NGAYSINH { get => _NGAYSINH; set => _NGAYSINH = value; }
        public string PHAI { get => _PHAI; set => _PHAI = value; }
        public string DIACHI { get => _DIACHI; set => _DIACHI = value; }
        public string DIENTHOAI { get => _DIENTHOAI; set => _DIENTHOAI = value; }
        public string SO_HD_THUCHIEN { get => _SO_HD_THUCHIEN; set => _SO_HD_THUCHIEN = value; }
        public string NGAYDANGNHAP { get => _NGAYDANGNHAP; set => _NGAYDANGNHAP = value; }
        public string SOLANDN { get => _SOLANDN; set => _SOLANDN = value; }
        public string QUYENHAN { get => _QUYENHAN; set => _QUYENHAN = value; }

        public DTO_Cnhanvien() { }

        public DTO_Cnhanvien(string MANV, string TENNV, string TENDANGNHAP, string NGAYSINH, string PHAI, string DIACHI, string DIENTHOAI,
                               string SO_HD_THUCHIEN, string SOLANDN, string QUYENHAN, string v)
        {
            this.MANV = MANV;
            this.TENNV = TENNV;
            this.TENDANGNHAP = TENDANGNHAP;
            this.NGAYSINH = NGAYSINH;
            this.PHAI = PHAI;
            this.DIACHI = DIACHI;
            this.DIENTHOAI = _DIENTHOAI;
            this.SO_HD_THUCHIEN = SO_HD_THUCHIEN;
            this.SOLANDN = SOLANDN;
            this.QUYENHAN = QUYENHAN;
        }
        public DTO_Cnhanvien(string MANV)
        {
            this.MANV = MANV;
        }
    }
}