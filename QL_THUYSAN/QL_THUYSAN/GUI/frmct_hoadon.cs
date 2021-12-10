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
    public partial class frmct_hoadon : Form
    {
        BUS_Cct_hoadon a = new BUS_Cct_hoadon();
        public frmct_hoadon()
        {
            InitializeComponent();
        }

        private void frmct_hoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUYSANDataSet6.CHITIET_HD' table. You can move, or remove it, as needed.
            this.cHITIET_HDTableAdapter.Fill(this.qL_THUYSANDataSet6.CHITIET_HD);
            // TODO: This line of code loads data into the 'qL_BanHangDataSet3.CHITIET_HD' table. You can move, or remove it, as needed.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTO_Cct_hoadon m = new DTO_Cct_hoadon(txtmscthd.Text.Trim(),
                                               txtmsvt.Text.Trim(),
                                               txtmstb.Text.Trim(),
                                               txtsoluongvt.Text.Trim(),
                                               txtsoluongtb.Text.Trim(),
                                               txthanhtien.Text.Trim());
                                      
            //------Gọi hàm thêm chi tiết hóa đơn
            a.pr_themct_hoadon(m);
            this.cHITIET_HDTableAdapter.Fill(this.qL_THUYSANDataSet6.CHITIET_HD);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DTO_Cct_hoadon m = new DTO_Cct_hoadon(txtmscthd.Text.Trim(),
                                               txtmsvt.Text.Trim(),
                                              txtmstb.Text.Trim(),
                                              txtsoluongvt.Text.Trim(),
                                              txtsoluongtb.Text.Trim(),
                                              txthanhtien.Text.Trim());

            //------Gọi hàm sửa chi tiết hóa đơn
            a.pr_suact_hoadon(m);
            this.cHITIET_HDTableAdapter.Fill(this.qL_THUYSANDataSet6.CHITIET_HD);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DTO_Cct_hoadon m = new DTO_Cct_hoadon(txtmscthd.Text.Trim(),
                                             txtmsvt.Text.Trim(),
                                            txtmstb.Text.Trim(),
                                            txtsoluongvt.Text.Trim(),
                                            txtsoluongtb.Text.Trim(),
                                            txthanhtien.Text.Trim());

            //------Gọi hàm xóa chi tiết hóa đơn
            a.pr_xoact_hoadon(m);
            this.cHITIET_HDTableAdapter.Fill(this.qL_THUYSANDataSet6.CHITIET_HD);
        }
    }
}
