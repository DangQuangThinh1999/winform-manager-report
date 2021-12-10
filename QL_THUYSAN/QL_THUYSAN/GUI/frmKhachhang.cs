using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmKhachhang : Form
    {
        //------Khai báo tầng BUS
        BUS_CCustomers c = new BUS_CCustomers();

      
        public frmKhachhang()
        {
            
            InitializeComponent();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUYSANDataSet1.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qL_THUYSANDataSet1.KHACHHANG);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo khách hàng
            DTO_CCustomers t = new DTO_CCustomers(txtMakh.Text.Trim(),
                                                  txtTenkh.Text.Trim(),
                                                  cboPhai.Text.Trim(),
                                                  txtDiachi.Text.Trim(),
                                                  txtDienthoai.Text.Trim());
            //------Gọi hàm thêm khách hàng
            c.pr_ThemKH(t);
            this.kHACHHANGTableAdapter.Fill(this.qL_THUYSANDataSet1.KHACHHANG);
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo khách hàng
            DTO_CCustomers t = new DTO_CCustomers(txtMakh.Text.Trim(),
                                                  txtTenkh.Text.Trim(),
                                                  cboPhai.Text.Trim(),
                                                  txtDiachi.Text.Trim(),
                                                  txtDienthoai.Text.Trim());
            //------Gọi hàm sửa khách hàng
            c.pr_suaKH(t);
            this.kHACHHANGTableAdapter.Fill(this.qL_THUYSANDataSet1.KHACHHANG);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo khách hàng
            DTO_CCustomers t = new DTO_CCustomers(txtMakh.Text.Trim(),
                                                  txtTenkh.Text.Trim(),
                                                  cboPhai.Text.Trim(),
                                                  txtDiachi.Text.Trim(),
                                                  txtDienthoai.Text.Trim());
            //------Gọi hàm xóa khách hàng
            c.pr_xoaKH(t);
            this.kHACHHANGTableAdapter.Fill(this.qL_THUYSANDataSet1.KHACHHANG);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
