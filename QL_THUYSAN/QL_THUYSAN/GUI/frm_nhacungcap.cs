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
    public partial class frm_nhacungcap : Form
    {
        BUS_Cnhacungcap a = new BUS_Cnhacungcap();
        public frm_nhacungcap()
        {
            InitializeComponent();
        }

        private void frm_nhacungcap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUYSANDataSet3.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.qL_THUYSANDataSet3.NHACUNGCAP);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo nhà cung cấp
            DTO_Cnhacungcap t = new DTO_Cnhacungcap(txtma.Text.Trim(),txttenncc.Text.Trim(),txthang.Text.Trim());
            //------Gọi hàm thêm nhà cung cấp
            a.pr_ThemNCC(t);
            this.nHACUNGCAPTableAdapter.Fill(this.qL_THUYSANDataSet3.NHACUNGCAP);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo nhà cung cấp
            DTO_Cnhacungcap t = new DTO_Cnhacungcap(txtma.Text.Trim(), txttenncc.Text.Trim(), txthang.Text.Trim());
            //------Gọi hàm sửanhà cung cấp
            a.pr_SuaNCC(t);
            this.nHACUNGCAPTableAdapter.Fill(this.qL_THUYSANDataSet3.NHACUNGCAP);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo nhà cung cấp
            DTO_Cnhacungcap t = new DTO_Cnhacungcap(txtma.Text.Trim(), txttenncc.Text.Trim(), txthang.Text.Trim());
            //------Gọi hàm sửanhà cung cấp
            a.pr_XoaNCC(t);
            this.nHACUNGCAPTableAdapter.Fill(this.qL_THUYSANDataSet3.NHACUNGCAP);
        }
    }
}
