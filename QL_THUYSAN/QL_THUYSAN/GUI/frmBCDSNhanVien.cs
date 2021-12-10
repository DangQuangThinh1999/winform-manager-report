﻿using CrystalDecisions.Shared;
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
    public partial class frmBCDSNhanVien : Form
    {
        public frmBCDSNhanVien()
        {
            InitializeComponent();
        }

        private void frmBCDSNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btBaocao_Click(object sender, EventArgs e)
        {
            //----------1.Khai báo CrytalReport: CR_MHTuDen.rpt
            CR_NV rp = new CR_NV();

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
            CrystalDecisions.Shared.ParameterDiscreteValue PDVTungay = new CrystalDecisions.Shared.ParameterDiscreteValue();
            CrystalDecisions.Shared.ParameterDiscreteValue PDVDenngay = new CrystalDecisions.Shared.ParameterDiscreteValue();

            //-----------4.Truyền tham số Từ ngày - Đến ngày
            //----4.1.Từ ngày
            PDVTungay.Value = this.Tungay.Value;
            myVL.Add(PDVTungay);
            rp.DataDefinition.ParameterFields["@TUDAY"].ApplyCurrentValues(myVL);
            myVL.Clear();
            //----4.2.Đến ngày
            PDVDenngay.Value = this.Denngay.Value;
            myVL.Add(PDVDenngay);
            rp.DataDefinition.ParameterFields["@DENNGAY"].ApplyCurrentValues(myVL);
            myVL.Clear();
            //------------5.Gán CrytalReport vào CryralReportViewer
            this.crystalReportViewer1.ReportSource = rp;
            this.crystalReportViewer1.Zoom(100);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {

        }

        private void cR_NV1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
