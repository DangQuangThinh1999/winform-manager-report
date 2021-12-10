
namespace GUI
{
    partial class frmBCDSVat_tu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBCDSVat_tu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tungay = new System.Windows.Forms.DateTimePicker();
            this.denngay = new System.Windows.Forms.DateTimePicker();
            this.btn_baocao = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportVATTU = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TỪ NGÀY: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐẾN NGÀY";
            // 
            // tungay
            // 
            this.tungay.CustomFormat = "dd/mm/yyyy";
            this.tungay.Location = new System.Drawing.Point(84, 18);
            this.tungay.Name = "tungay";
            this.tungay.Size = new System.Drawing.Size(200, 20);
            this.tungay.TabIndex = 4;
            // 
            // denngay
            // 
            this.denngay.CustomFormat = "dd/mm/yyyy";
            this.denngay.Location = new System.Drawing.Point(385, 19);
            this.denngay.Name = "denngay";
            this.denngay.Size = new System.Drawing.Size(200, 20);
            this.denngay.TabIndex = 2;
            // 
            // btn_baocao
            // 
            this.btn_baocao.Location = new System.Drawing.Point(656, 19);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(75, 23);
            this.btn_baocao.TabIndex = 5;
            this.btn_baocao.Text = "BÁO CÁO";
            this.btn_baocao.UseVisualStyleBackColor = true;
            this.btn_baocao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(812, 16);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.denngay);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_baocao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tungay);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // reportVATTU
            // 
            this.reportVATTU.ActiveViewIndex = -1;
            this.reportVATTU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportVATTU.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportVATTU.Location = new System.Drawing.Point(3, 81);
            this.reportVATTU.Name = "reportVATTU";
            this.reportVATTU.Size = new System.Drawing.Size(1029, 555);
            this.reportVATTU.TabIndex = 8;
            // 
            // frmBCDSVat_tu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1044, 637);
            this.Controls.Add(this.reportVATTU);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBCDSVat_tu";
            this.Text = "Báo cáo doanh số mỗi vật tư [Từ ngày - Đến ngày]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tungay;
        private System.Windows.Forms.DateTimePicker denngay;
        private System.Windows.Forms.Button btn_baocao;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportVATTU;
    }
}