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
    public partial class frm_thietbi : Form
    {
        BUS_Cthietbi a = new BUS_Cthietbi();
        public frm_thietbi()
        {
            InitializeComponent();
        }

        private void frm_thietbi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUYSANDataSet5.THIETBI' table. You can move, or remove it, as needed.
            this.tHIETBITableAdapter.Fill(this.qL_THUYSANDataSet5.THIETBI);
            // TODO: This line of code loads data into the 'qL_THUYSANDataSet4.THIETBI' table. You can move, or remove it, as needed.
           

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo thiết bị
            DTO_Cthietbi t = new DTO_Cthietbi(txtmstb.Text.Trim(), txttentb.Text.Trim(),txtxuatxu.Text.Trim(),
                                                txthangsx.Text.Trim(),txtsl_ton.Text.Trim(),txtdongia.Text.Trim(),txtdonvitinh.Text.Trim());
            //------Gọi hàm thêm thiết bị
            a.pr_ThemTB(t);
            this.tHIETBITableAdapter.Fill(this.qL_THUYSANDataSet5.THIETBI);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo thiết bị
            DTO_Cthietbi t = new DTO_Cthietbi(txtmstb.Text.Trim(), txttentb.Text.Trim(), txtxuatxu.Text.Trim(),
                                                txthangsx.Text.Trim(), txtsl_ton.Text.Trim(), txtdongia.Text.Trim(), txtdonvitinh.Text.Trim());
            //------Gọi hàm xóa thiết bị
            a.pr_SuaTB(t);
            this.tHIETBITableAdapter.Fill(this.qL_THUYSANDataSet5.THIETBI);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo thiết bị
            DTO_Cthietbi t = new DTO_Cthietbi(txtmstb.Text.Trim(), txttentb.Text.Trim(), txtxuatxu.Text.Trim(),
                                                txthangsx.Text.Trim(), txtsl_ton.Text.Trim(), txtdongia.Text.Trim(), txtdonvitinh.Text.Trim());
            //------Gọi hàm thêm thiết bị
            a.pr_XoaTB(t);
            this.tHIETBITableAdapter.Fill(this.qL_THUYSANDataSet5.THIETBI);
        }
    }
}
