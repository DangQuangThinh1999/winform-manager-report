using DTO;
using BUS;
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
    public partial class frm_vattu : Form
    {
        BUS_Cvattu a = new BUS_Cvattu();
       
        public frm_vattu()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_vattu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUYSANDataSet.VATTU' table. You can move, or remove it, as needed.
            this.vATTUTableAdapter.Fill(this.qL_THUYSANDataSet.VATTU);

        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo vật tư
            DTO_Cvattu t = new DTO_Cvattu(txtmsvt.Text.Trim(), txttenvt.Text.Trim(), txtxuatxu.Text.Trim(),
                                                txthangsx.Text.Trim(), txtsl_ton.Text.Trim(), txtdongia.Text.Trim(), txtdonvitinh.Text.Trim());
            //------Gọi hàm thêm vật tư
            a.pr_ThemVT(t);
            this.vATTUTableAdapter.Fill(this.qL_THUYSANDataSet.VATTU);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo vật tư
            DTO_Cvattu t = new DTO_Cvattu(txtmsvt.Text.Trim(), txttenvt.Text.Trim(), txtxuatxu.Text.Trim(),
                                                txthangsx.Text.Trim(), txtsl_ton.Text.Trim(), txtdongia.Text.Trim(), txtdonvitinh.Text.Trim());
            //------Gọi hàm sửa vật tư
            a.pr_SuaVT(t);
            this.vATTUTableAdapter.Fill(this.qL_THUYSANDataSet.VATTU);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo vật tư
            DTO_Cvattu t = new DTO_Cvattu(txtmsvt.Text.Trim(), txttenvt.Text.Trim(), txtxuatxu.Text.Trim(),
                                                txthangsx.Text.Trim(), txtsl_ton.Text.Trim(), txtdongia.Text.Trim(), txtdonvitinh.Text.Trim());
            //------Gọi hàm xóa vật tư
            a.pr_XoaVT(t);
            this.vATTUTableAdapter.Fill(this.qL_THUYSANDataSet.VATTU);
        }
    }
}
