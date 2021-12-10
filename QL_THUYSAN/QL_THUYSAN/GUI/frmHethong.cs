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
    public partial class frmHethong : Form
    {
        //------------1.Khai báo lớp GUI_CEnableMenu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();

        //------------2.Khai báo lớp có chứa hàm hủy kết nối: BUS_CDBConnect
        BUS_CDBConnect cn = new BUS_CDBConnect();

        public frmHethong()
        {
            InitializeComponent();
        }

        private void frmHethong_Load(object sender, EventArgs e)
        {
            //--------Gọi hàm Ẩn/Hiện menu
            mnu.EnableMenu(true, false);

            frmDangnhap frm = new frmDangnhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDN_Click(object sender, EventArgs e)
        {
            frmDangnhap frm = new frmDangnhap();
            frm.ShowDialog();
        }

        private void mnuHKN_Click(object sender, EventArgs e)
        {
            if (cn.DBDisConnect() == true) //Gọi hàm hủy kết nối ở lớp: BUS_CDBConnect
            {
                mnu.EnableMenu(true, false); //-----Gọi hàm Ẩn/Hiện menu
            }
        }

        private void mnuDMKH_Click(object sender, EventArgs e)
        {
            frmKhachhang frm = new frmKhachhang();
            frm.ShowDialog();
        }

        private void mnuDTBHMH_Click(object sender, EventArgs e)
        {
            frmBCDSThiet_bi frm = new frmBCDSThiet_bi();
            frm.ShowDialog();
        }

        private void mnuDTBH_Click(object sender, EventArgs e)
        {

        }

        private void mnuDTBHTT_Click(object sender, EventArgs e)
        {
            frmBCDTTN_TB frm = new frmBCDTTN_TB();
            frm.ShowDialog();
        }

        private void mnuDTBHNV_Click(object sender, EventArgs e)
        {
            frmBCDSNhanVien frm = new frmBCDSNhanVien();
            frm.ShowDialog();
        }

        private void mnuTCMH_Click(object sender, EventArgs e)
        {
            
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmct_hoadon frm = new frmct_hoadon();
            frm.ShowDialog();
        }

        private void mnuDMNV_Click(object sender, EventArgs e)
        {
            frmnhanvien frm = new frmnhanvien();
            frm.ShowDialog();
        }

        private void mnuTCHD_Click(object sender, EventArgs e)
        {
            frmhoadon frm = new frmhoadon();
            frm.ShowDialog();
        }

        private void mnuBR_Click(object sender, EventArgs e)
        {

        }

        private void mnuTG_Click(object sender, EventArgs e)
        {
            frntrogiup frm = new frntrogiup();
            frm.ShowDialog();
        }

        private void mnuTCKH_Click(object sender, EventArgs e)
        {
            frmKhachhang frm = new frmKhachhang();
            frm.ShowDialog();
        }

        private void mnuTCNV_Click(object sender, EventArgs e)
        {
            frmnhanvien frm = new frmnhanvien();
            frm.ShowDialog();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmct_hoadon frm = new frmct_hoadon();
            frm.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frntrogiup frm = new frntrogiup();
            frm.ShowDialog();
        }

        private void thiếtBịYTếToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vậtTưToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_vattu frm = new frm_vattu();
            frm.ShowDialog();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_nhacungcap frm = new frm_nhacungcap();
            frm.ShowDialog();
        }

        private void thiếtBịYTếToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_thietbi frm = new frm_thietbi();
            frm.ShowDialog();
        }

        private void thốngKêMặtHàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doanhThuThiếtBịYTếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCDSThiet_bi frm = new frmBCDSThiet_bi();
            frm.ShowDialog();
        }

        private void doanhThuVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCDSVat_tu frm = new frmBCDSVat_tu();
            frm.ShowDialog();
        }

        private void doanhThuNhânViênTheoThángNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCDTTN_NV frm = new frmBCDTTN_NV();
            frm.ShowDialog();

        }

        private void doanhThuNhânViênTừNgàyĐếnNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCDSNhanVien frm = new frmBCDSNhanVien();
            frm.ShowDialog();
        }

        private void doanhThuThiếtBịYTếMỗiThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCDTTN_TB frm = new frmBCDTTN_TB();
            frm.ShowDialog();
        }

        private void doanhThuVậtTưTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCDTTN_VT frm = new frmBCDTTN_VT();
            frm.ShowDialog();
        }
    }
}
