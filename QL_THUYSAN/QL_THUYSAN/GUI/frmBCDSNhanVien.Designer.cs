
namespace GUI
{
    partial class frmBCDSNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBCDSNhanVien));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btBaocao = new System.Windows.Forms.Button();
            this.Denngay = new System.Windows.Forms.DateTimePicker();
            this.Tungay = new System.Windows.Forms.DateTimePicker();
            this.cR_NV1 = new GUI.CR_NV();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 64);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1002, 517);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Từ ngày:";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(531, 19);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 24);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btBaocao
            // 
            this.btBaocao.Location = new System.Drawing.Point(410, 19);
            this.btBaocao.Margin = new System.Windows.Forms.Padding(2);
            this.btBaocao.Name = "btBaocao";
            this.btBaocao.Size = new System.Drawing.Size(75, 24);
            this.btBaocao.TabIndex = 12;
            this.btBaocao.Text = "Báo cáo";
            this.btBaocao.UseVisualStyleBackColor = true;
            this.btBaocao.Click += new System.EventHandler(this.btBaocao_Click);
            // 
            // Denngay
            // 
            this.Denngay.CustomFormat = "dd/MM/yyyy";
            this.Denngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Denngay.Location = new System.Drawing.Point(265, 23);
            this.Denngay.Margin = new System.Windows.Forms.Padding(2);
            this.Denngay.Name = "Denngay";
            this.Denngay.Size = new System.Drawing.Size(111, 20);
            this.Denngay.TabIndex = 9;
            // 
            // Tungay
            // 
            this.Tungay.CustomFormat = "dd/MM/yyyy";
            this.Tungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tungay.Location = new System.Drawing.Point(94, 23);
            this.Tungay.Margin = new System.Windows.Forms.Padding(2);
            this.Tungay.Name = "Tungay";
            this.Tungay.Size = new System.Drawing.Size(111, 20);
            this.Tungay.TabIndex = 10;
            // 
            // cR_NV1
            // 
            this.cR_NV1.InitReport += new System.EventHandler(this.cR_NV1_InitReport);
            // 
            // frmBCDSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btBaocao);
            this.Controls.Add(this.Denngay);
            this.Controls.Add(this.Tungay);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBCDSNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh số cho mỗi nhân viên [từ ngày đến ngày] ";
            this.Load += new System.EventHandler(this.frmBCDSNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CR_NV cR_NV1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btBaocao;
        private System.Windows.Forms.DateTimePicker Denngay;
        private System.Windows.Forms.DateTimePicker Tungay;
    }
}