
namespace GUI
{
    partial class frmct_hoadon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmct_hoadon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmscthd = new System.Windows.Forms.TextBox();
            this.txthanhtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoluongtb = new System.Windows.Forms.TextBox();
            this.txtsoluongvt = new System.Windows.Forms.TextBox();
            this.txtmstb = new System.Windows.Forms.TextBox();
            this.txtmsvt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cHITIETHDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_THUYSANDataSet6 = new GUI.QL_THUYSANDataSet6();
            this.cHITIETHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIET_HDTableAdapter = new GUI.QL_THUYSANDataSet6TableAdapters.CHITIET_HDTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUYSANDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmscthd);
            this.groupBox1.Controls.Add(this.txthanhtien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtsoluongtb);
            this.groupBox1.Controls.Add(this.txtsoluongvt);
            this.groupBox1.Controls.Add(this.txtmstb);
            this.groupBox1.Controls.Add(this.txtmsvt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cần nhập";
            // 
            // txtmscthd
            // 
            this.txtmscthd.Location = new System.Drawing.Point(147, 151);
            this.txtmscthd.Name = "txtmscthd";
            this.txtmscthd.Size = new System.Drawing.Size(216, 25);
            this.txtmscthd.TabIndex = 5;
            // 
            // txthanhtien
            // 
            this.txthanhtien.Location = new System.Drawing.Point(563, 151);
            this.txthanhtien.Name = "txthanhtien";
            this.txthanhtien.Size = new System.Drawing.Size(217, 25);
            this.txthanhtien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã số CT_HD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thành tiền";
            // 
            // txtsoluongtb
            // 
            this.txtsoluongtb.Location = new System.Drawing.Point(563, 93);
            this.txtsoluongtb.Name = "txtsoluongtb";
            this.txtsoluongtb.Size = new System.Drawing.Size(202, 25);
            this.txtsoluongtb.TabIndex = 7;
            // 
            // txtsoluongvt
            // 
            this.txtsoluongvt.Location = new System.Drawing.Point(556, 35);
            this.txtsoluongvt.Name = "txtsoluongvt";
            this.txtsoluongvt.Size = new System.Drawing.Size(210, 25);
            this.txtsoluongvt.TabIndex = 6;
            // 
            // txtmstb
            // 
            this.txtmstb.Location = new System.Drawing.Point(146, 93);
            this.txtmstb.Name = "txtmstb";
            this.txtmstb.Size = new System.Drawing.Size(217, 25);
            this.txtmstb.TabIndex = 5;
            // 
            // txtmsvt
            // 
            this.txtmsvt.Location = new System.Drawing.Point(146, 39);
            this.txtmsvt.Name = "txtmsvt";
            this.txtmsvt.Size = new System.Drawing.Size(216, 25);
            this.txtmsvt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượt thiết bị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng vât tư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số vật tư";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số thiết bị";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(29, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(437, 24);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(91, 36);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(619, 23);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 35);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(234, 21);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(96, 37);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(18, 25);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(102, 34);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.mSVTDataGridViewTextBoxColumn,
            this.mSTBDataGridViewTextBoxColumn,
            this.sOLUONGVTDataGridViewTextBoxColumn,
            this.sOLUONGTBDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.cHITIETHDBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(30, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 205);
            this.dataGridView1.TabIndex = 2;
            // 
            // cHITIETHDBindingSource1
            // 
            this.cHITIETHDBindingSource1.DataMember = "CHITIET_HD";
            this.cHITIETHDBindingSource1.DataSource = this.qL_THUYSANDataSet6;
            // 
            // qL_THUYSANDataSet6
            // 
            this.qL_THUYSANDataSet6.DataSetName = "QL_THUYSANDataSet6";
            this.qL_THUYSANDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHITIETHDBindingSource
            // 
            this.cHITIETHDBindingSource.DataMember = "CHITIET_HD";
            // 
            // cHITIET_HDTableAdapter
            // 
            this.cHITIET_HDTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MSHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "MSHD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // mSVTDataGridViewTextBoxColumn
            // 
            this.mSVTDataGridViewTextBoxColumn.DataPropertyName = "MSVT";
            this.mSVTDataGridViewTextBoxColumn.HeaderText = "MSVT";
            this.mSVTDataGridViewTextBoxColumn.Name = "mSVTDataGridViewTextBoxColumn";
            this.mSVTDataGridViewTextBoxColumn.Width = 70;
            // 
            // mSTBDataGridViewTextBoxColumn
            // 
            this.mSTBDataGridViewTextBoxColumn.DataPropertyName = "MSTB";
            this.mSTBDataGridViewTextBoxColumn.HeaderText = "MSTB";
            this.mSTBDataGridViewTextBoxColumn.Name = "mSTBDataGridViewTextBoxColumn";
            this.mSTBDataGridViewTextBoxColumn.Width = 70;
            // 
            // sOLUONGVTDataGridViewTextBoxColumn
            // 
            this.sOLUONGVTDataGridViewTextBoxColumn.DataPropertyName = "SOLUONGVT";
            this.sOLUONGVTDataGridViewTextBoxColumn.HeaderText = "SOLUONGVT";
            this.sOLUONGVTDataGridViewTextBoxColumn.Name = "sOLUONGVTDataGridViewTextBoxColumn";
            this.sOLUONGVTDataGridViewTextBoxColumn.Width = 150;
            // 
            // sOLUONGTBDataGridViewTextBoxColumn
            // 
            this.sOLUONGTBDataGridViewTextBoxColumn.DataPropertyName = "SOLUONGTB";
            this.sOLUONGTBDataGridViewTextBoxColumn.HeaderText = "SOLUONGTB";
            this.sOLUONGTBDataGridViewTextBoxColumn.Name = "sOLUONGTBDataGridViewTextBoxColumn";
            this.sOLUONGTBDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "THANHTIEN";
            this.dataGridViewTextBoxColumn2.HeaderText = "THANHTIEN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 251;
            // 
            // frmct_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmct_hoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.frmct_hoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUYSANDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
   
        private System.Windows.Forms.BindingSource cHITIETHDBindingSource;
       
      
        private System.Windows.Forms.TextBox txtsoluongtb;
        private System.Windows.Forms.TextBox txtsoluongvt;
        private System.Windows.Forms.TextBox txtmstb;
        private System.Windows.Forms.TextBox txtmsvt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txtmscthd;
        private System.Windows.Forms.TextBox txthanhtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private QL_THUYSANDataSet6 qL_THUYSANDataSet6;
        private System.Windows.Forms.BindingSource cHITIETHDBindingSource1;
        private QL_THUYSANDataSet6TableAdapters.CHITIET_HDTableAdapter cHITIET_HDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}