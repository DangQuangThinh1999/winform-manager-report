
namespace GUI
{
    partial class frmBCDTTN_VT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBCDTTN_VT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnbaocao = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnam);
            this.groupBox1.Controls.Add(this.txtthang);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnbaocao);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = " NĂM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "THÁNG";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(367, 19);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(100, 20);
            this.txtnam.TabIndex = 10;
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(173, 19);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(100, 20);
            this.txtthang.TabIndex = 9;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(648, 19);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(131, 25);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnbaocao
            // 
            this.btnbaocao.Location = new System.Drawing.Point(491, 21);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(135, 23);
            this.btnbaocao.TabIndex = 7;
            this.btnbaocao.Text = " BÁO CÁO     ";
            this.btnbaocao.UseVisualStyleBackColor = true;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 78);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1021, 547);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // frmBCDTTN_VT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 637);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBCDTTN_VT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh số của vật tư mỗi tháng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnbaocao;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}