namespace GUI
{
    partial class frmBCDSThiet_bi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBCDSThiet_bi));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btBaocao = new System.Windows.Forms.Button();
            this.Denngay = new System.Windows.Forms.DateTimePicker();
            this.Tungay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crystalReportViewerP = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến ngày:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ ngày:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(503, 5);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 24);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btBaocao
            // 
            this.btBaocao.Location = new System.Drawing.Point(382, 5);
            this.btBaocao.Margin = new System.Windows.Forms.Padding(2);
            this.btBaocao.Name = "btBaocao";
            this.btBaocao.Size = new System.Drawing.Size(75, 24);
            this.btBaocao.TabIndex = 6;
            this.btBaocao.Text = "Báo cáo";
            this.btBaocao.UseVisualStyleBackColor = true;
            this.btBaocao.Click += new System.EventHandler(this.btBaocao_Click);
            // 
            // Denngay
            // 
            this.Denngay.CustomFormat = "dd/MM/yyyy";
            this.Denngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Denngay.Location = new System.Drawing.Point(237, 9);
            this.Denngay.Margin = new System.Windows.Forms.Padding(2);
            this.Denngay.Name = "Denngay";
            this.Denngay.Size = new System.Drawing.Size(111, 20);
            this.Denngay.TabIndex = 3;
            this.Denngay.ValueChanged += new System.EventHandler(this.Denngay_ValueChanged);
            // 
            // Tungay
            // 
            this.Tungay.CustomFormat = "dd/MM/yyyy";
            this.Tungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tungay.Location = new System.Drawing.Point(66, 9);
            this.Tungay.Margin = new System.Windows.Forms.Padding(2);
            this.Tungay.Name = "Tungay";
            this.Tungay.Size = new System.Drawing.Size(111, 20);
            this.Tungay.TabIndex = 4;
            this.Tungay.ValueChanged += new System.EventHandler(this.Tungay_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crystalReportViewerP);
            this.groupBox1.Location = new System.Drawing.Point(1, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1026, 574);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // crystalReportViewerP
            // 
            this.crystalReportViewerP.ActiveViewIndex = -1;
            this.crystalReportViewerP.AutoSize = true;
            this.crystalReportViewerP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerP.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerP.Location = new System.Drawing.Point(2, 15);
            this.crystalReportViewerP.Margin = new System.Windows.Forms.Padding(2);
            this.crystalReportViewerP.Name = "crystalReportViewerP";
            this.crystalReportViewerP.Size = new System.Drawing.Size(1022, 557);
            this.crystalReportViewerP.TabIndex = 1;
            this.crystalReportViewerP.ToolPanelWidth = 109;
            this.crystalReportViewerP.Load += new System.EventHandler(this.crystalReportViewerP_Load);
            // 
            // frmBCDSThiet_bi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1026, 614);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btBaocao);
            this.Controls.Add(this.Denngay);
            this.Controls.Add(this.Tungay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBCDSThiet_bi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh số cho mỗi thiết bị y tế  [Từ ngày - Đến ngày]";
            this.Load += new System.EventHandler(this.frmBCDSMoiMHReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btBaocao;
        private System.Windows.Forms.DateTimePicker Denngay;
        private System.Windows.Forms.DateTimePicker Tungay;
        private System.Windows.Forms.GroupBox groupBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerP;
   
    }
}