using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmnhanvien : Form
    {
        BUS_Cnhanvien a = new BUS_Cnhanvien();
        public frmnhanvien()
        {
            InitializeComponent();
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUYSANDataSet2.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_THUYSANDataSet2.NHANVIEN);
            // TODO: This line of code loads data into the 'qL_BanHangDataSet4.NHANVIEN' table. You can move, or remove it, as needed.
      

        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ----------Gọi hàm khởi tạo nhân viên
            DTO_Cnhanvien m = new DTO_Cnhanvien(txtmanv.Text.Trim(),
                                                  txttennv.Text.Trim(),
                                                  txttendangnhap.Text.Trim(),
                                                  dtngaysinh.Text.Trim(),
                                                  cbphai.Text.Trim(),
                                                  txtdiachi.Text.Trim(),
                                                  txtdienthoai.Text.Trim(),
                                                  txtsohodon.Text.Trim(),
                                                   dtngaydangnhap.Text.Trim(),
                                                  txtsolandangnhap.Text.Trim(),
                                                  txtquyenhan.Text.Trim());
                                                  
            //------Gọi hàm thêm nhân viên
            a.pr_ThemNV(m);
            this.nHANVIENTableAdapter.Fill(this.qL_THUYSANDataSet2.NHANVIEN);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ----------Gọi hàm khởi tạo nhân viên
            DTO_Cnhanvien m = new DTO_Cnhanvien(txtmanv.Text.Trim(),
                                                  txttennv.Text.Trim(),
                                                  txttendangnhap.Text.Trim(),
                                                  dtngaysinh.Text.Trim(),
                                                  cbphai.Text.Trim(),
                                                  txtdiachi.Text.Trim(),
                                                  txtdienthoai.Text.Trim(),
                                                  txtsohodon.Text.Trim(),
                                                   dtngaydangnhap.Text.Trim(),
                                                  txtsolandangnhap.Text.Trim(),
                                                  txtquyenhan.Text.Trim());

            //------Gọi hàm xóa nhân viên
            a.pr_XoaNV(m);
            this.nHANVIENTableAdapter.Fill(this.qL_THUYSANDataSet2.NHANVIEN);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // ----------Gọi hàm khởi tạo nhân viên
            DTO_Cnhanvien m = new DTO_Cnhanvien(txtmanv.Text.Trim(),
                                                  txttennv.Text.Trim(),
                                                  txttendangnhap.Text.Trim(),
                                                  dtngaysinh.Text.Trim(),
                                                  cbphai.Text.Trim(),
                                                  txtdiachi.Text.Trim(),
                                                  txtdienthoai.Text.Trim(),
                                                  txtsohodon.Text.Trim(),
                                                   dtngaydangnhap.Text.Trim(),
                                                  txtsolandangnhap.Text.Trim(),
                                                  txtquyenhan.Text.Trim());

            //------Gọi hàm sửa nhân viên
            a.pr_SuaNV(m);
            this.nHANVIENTableAdapter.Fill(this.qL_THUYSANDataSet2.NHANVIEN);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}