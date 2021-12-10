
namespace GUI
{
    partial class frmBCDTTN_TB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBCDTTN_TB));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnbaocao = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 46);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(994, 577);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // btnbaocao
            // 
            this.btnbaocao.Location = new System.Drawing.Point(420, 17);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(135, 23);
            this.btnbaocao.TabIndex = 1;
            this.btnbaocao.Text = " BÁO CÁO     ";
            this.btnbaocao.UseVisualStyleBackColor = true;
            this.btnbaocao.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(577, 15);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(131, 25);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(102, 15);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(100, 20);
            this.txtthang.TabIndex = 3;
            this.txtthang.TextChanged += new System.EventHandler(this.txtthang_TextChanged);
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(296, 15);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(100, 20);
            this.txtnam.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "THÁNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = " NĂM";
            // 
            // frmBCDTTN_TB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtthang);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnbaocao);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBCDTTN_TB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh sô thiết bị y tế mỗi tháng";
            this.Load += new System.EventHandler(this.frmBCDTTN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnbaocao;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}