using CrystalDecisions.Shared;
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
    public partial class frmBCDTTN_NV : Form
    {
        public frmBCDTTN_NV()
        {
            InitializeComponent();
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            //----------1.Khai báo CrytalReport: CR_MHTuDen.rpt
            CR_thangNV rp = new CR_thangNV();

            //----------2.Cung cấp thông tin đăng nhập cho CrytalReport
            ConnectionInfo myConn = new ConnectionInfo();
            TableLogOnInfo myTable = new TableLogOnInfo();
            myConn.ServerName = frmDangnhap.SV;
            myConn.DatabaseName = frmDangnhap.DB;
            myConn.UserID = frmDangnhap.UI;
            myConn.Password = frmDangnhap.Pass;
            myTable.ConnectionInfo = myConn;
            rp.Database.Tables[0].ApplyLogOnInfo(myTable);

            //-----------3.Khai báo kết nối tham số với CrytalReport
            CrystalDecisions.Shared.ParameterValues myVL = new CrystalDecisions.Shared.ParameterValues();
            CrystalDecisions.Shared.ParameterDiscreteValue PDVthang = new CrystalDecisions.Shared.ParameterDiscreteValue();
            CrystalDecisions.Shared.ParameterDiscreteValue PDVnam = new CrystalDecisions.Shared.ParameterDiscreteValue();

            //-----------4.Truyền tham số tháng năm 
            //----4.1.THEO THÁNG
            PDVthang.Value = this.txtthang.Text;
            myVL.Add(PDVthang);
            rp.DataDefinition.ParameterFields["@THANG"].ApplyCurrentValues(myVL);
            myVL.Clear();
            //----4.2.THEO NĂM
            PDVnam.Value = this.txtnam.Text;
            myVL.Add(PDVnam);
            rp.DataDefinition.ParameterFields["@NAM"].ApplyCurrentValues(myVL);
            myVL.Clear();
            //------------5.Gán CrytalReport vào CryralReportViewer
            this.crystalReportViewer1.ReportSource = rp;
            this.crystalReportViewer1.Zoom(100);
        }
    }
}
