using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmhoadon : Form
    {
        BUS_Choadon a = new BUS_Choadon();
        public frmhoadon()
        {
            InitializeComponent();
        }

        private void frmhoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUYSANDataSet7.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qL_THUYSANDataSet7.HOADON);
            // TODO: This line of code loads data into the 'qL_BanHangDataSet5.HOADON' table. You can move, or remove it, as needed.


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            // ----------Gọi hàm khởi tạo hóa đơn
            DTO_Choadon m = new DTO_Choadon(txtmshd.Text.Trim(),
                                                  txtmsnv.Text.Trim(),
                                                  txtmskh.Text.Trim(),
                                                 dtngayhd.Value.ToString(),
                                                  txttongtien.Text.Trim());
            //------Gọi hàm thêm hóa đơn
            a.pr_ThemHD(m);
            this.hOADONTableAdapter.Fill(this.qL_THUYSANDataSet7.HOADON);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // ----------Gọi hàm khởi tạo hóa đơn
            DTO_Choadon m = new DTO_Choadon(txtmshd.Text.Trim(),
                                                  txtmsnv.Text.Trim(),
                                                  txtmskh.Text.Trim(),
                                                 dtngayhd.Value.ToString(),
                                                  txttongtien.Text.Trim());
            //------Gọi hàm xóa hóa đơn
            a.pr_XoaHD(m);
            this.hOADONTableAdapter.Fill(this.qL_THUYSANDataSet7.HOADON);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ----------Gọi hàm khởi tạo hóa đơn
            DTO_Choadon m = new DTO_Choadon(txtmshd.Text.Trim(),
                                                  txtmsnv.Text.Trim(),
                                                  txtmskh.Text.Trim(),
                                                  txtngayhd.Text.Trim(),
                                                  txttongtien.Text.Trim());
            //------Gọi hàm sửa hóa đơn
            a.pr_SuaHD(m);
            this.hOADONTableAdapter.Fill(this.qL_THUYSANDataSet7.HOADON);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
