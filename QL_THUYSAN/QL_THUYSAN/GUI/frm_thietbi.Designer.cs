
namespace GUI
{
    partial class frm_thietbi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_thietbi));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mSTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUATXUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hANGSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLTONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONVITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHIETBIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_THUYSANDataSet5 = new GUI.QL_THUYSANDataSet5();
            this.txthangsx = new System.Windows.Forms.TextBox();
            this.txtxuatxu = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtdonvitinh = new System.Windows.Forms.TextBox();
            this.txttentb = new System.Windows.Forms.TextBox();
            this.txtsl_ton = new System.Windows.Forms.TextBox();
            this.txtmstb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tHIETBITableAdapter = new GUI.QL_THUYSANDataSet5TableAdapters.THIETBITableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIETBIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUYSANDataSet5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(873, 246);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSTBDataGridViewTextBoxColumn,
            this.tENTBDataGridViewTextBoxColumn,
            this.xUATXUDataGridViewTextBoxColumn,
            this.hANGSXDataGridViewTextBoxColumn,
            this.sLTONDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.dONVITINHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tHIETBIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // mSTBDataGridViewTextBoxColumn
            // 
            this.mSTBDataGridViewTextBoxColumn.DataPropertyName = "MSTB";
            this.mSTBDataGridViewTextBoxColumn.HeaderText = "Mã số TB";
            this.mSTBDataGridViewTextBoxColumn.Name = "mSTBDataGridViewTextBoxColumn";
            this.mSTBDataGridViewTextBoxColumn.Width = 70;
            // 
            // tENTBDataGridViewTextBoxColumn
            // 
            this.tENTBDataGridViewTextBoxColumn.DataPropertyName = "TENTB";
            this.tENTBDataGridViewTextBoxColumn.HeaderText = "Tên thiết bị y tế";
            this.tENTBDataGridViewTextBoxColumn.Name = "tENTBDataGridViewTextBoxColumn";
            this.tENTBDataGridViewTextBoxColumn.Width = 270;
            // 
            // xUATXUDataGridViewTextBoxColumn
            // 
            this.xUATXUDataGridViewTextBoxColumn.DataPropertyName = "XUATXU";
            this.xUATXUDataGridViewTextBoxColumn.HeaderText = "Xuất xứ";
            this.xUATXUDataGridViewTextBoxColumn.Name = "xUATXUDataGridViewTextBoxColumn";
            // 
            // hANGSXDataGridViewTextBoxColumn
            // 
            this.hANGSXDataGridViewTextBoxColumn.DataPropertyName = "HANGSX";
            this.hANGSXDataGridViewTextBoxColumn.HeaderText = "Hãng sản xuất";
            this.hANGSXDataGridViewTextBoxColumn.Name = "hANGSXDataGridViewTextBoxColumn";
            // 
            // sLTONDataGridViewTextBoxColumn
            // 
            this.sLTONDataGridViewTextBoxColumn.DataPropertyName = "SL_TON";
            this.sLTONDataGridViewTextBoxColumn.HeaderText = "SL_ton";
            this.sLTONDataGridViewTextBoxColumn.Name = "sLTONDataGridViewTextBoxColumn";
            this.sLTONDataGridViewTextBoxColumn.Width = 70;
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            this.dONGIADataGridViewTextBoxColumn.Width = 130;
            // 
            // dONVITINHDataGridViewTextBoxColumn
            // 
            this.dONVITINHDataGridViewTextBoxColumn.DataPropertyName = "DONVITINH";
            this.dONVITINHDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.dONVITINHDataGridViewTextBoxColumn.Name = "dONVITINHDataGridViewTextBoxColumn";
            this.dONVITINHDataGridViewTextBoxColumn.Width = 76;
            // 
            // tHIETBIBindingSource
            // 
            this.tHIETBIBindingSource.DataMember = "THIETBI";
            this.tHIETBIBindingSource.DataSource = this.qL_THUYSANDataSet5;
            // 
            // qL_THUYSANDataSet5
            // 
            this.qL_THUYSANDataSet5.DataSetName = "QL_THUYSANDataSet5";
            this.qL_THUYSANDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txthangsx
            // 
            this.txthangsx.Location = new System.Drawing.Point(610, 99);
            this.txthangsx.Name = "txthangsx";
            this.txthangsx.Size = new System.Drawing.Size(234, 20);
            this.txthangsx.TabIndex = 11;
            // 
            // txtxuatxu
            // 
            this.txtxuatxu.Location = new System.Drawing.Point(177, 99);
            this.txtxuatxu.Name = "txtxuatxu";
            this.txtxuatxu.Size = new System.Drawing.Size(120, 20);
            this.txtxuatxu.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(454, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 30);
            this.button6.TabIndex = 9;
            this.button6.Text = "Hãng sản xuất";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(23, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 25);
            this.button7.TabIndex = 8;
            this.button7.Text = "Xuất xứ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txtdonvitinh
            // 
            this.txtdonvitinh.Location = new System.Drawing.Point(607, 180);
            this.txtdonvitinh.Name = "txtdonvitinh";
            this.txtdonvitinh.Size = new System.Drawing.Size(234, 20);
            this.txtdonvitinh.TabIndex = 7;
            // 
            // txttentb
            // 
            this.txttentb.Location = new System.Drawing.Point(607, 35);
            this.txttentb.Name = "txttentb";
            this.txttentb.Size = new System.Drawing.Size(235, 20);
            this.txttentb.TabIndex = 6;
            // 
            // txtsl_ton
            // 
            this.txtsl_ton.Location = new System.Drawing.Point(177, 178);
            this.txtsl_ton.Name = "txtsl_ton";
            this.txtsl_ton.Size = new System.Drawing.Size(120, 20);
            this.txtsl_ton.TabIndex = 5;
            // 
            // txtmstb
            // 
            this.txtmstb.Location = new System.Drawing.Point(177, 28);
            this.txtmstb.Name = "txtmstb";
            this.txtmstb.Size = new System.Drawing.Size(120, 20);
            this.txtmstb.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(451, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Đơn vị tính";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Số lượng tồn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tên thiết bị y tế";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txthangsx);
            this.groupBox1.Controls.Add(this.txtxuatxu);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.txtdonvitinh);
            this.groupBox1.Controls.Add(this.txttentb);
            this.groupBox1.Controls.Add(this.txtsl_ton);
            this.groupBox1.Controls.Add(this.txtmstb);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(872, 228);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mã số thiết bị y tế";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(218, 22);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(115, 23);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(77, 22);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(609, 21);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(234, 20);
            this.txtdongia.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(454, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 27);
            this.button5.TabIndex = 1;
            this.button5.Text = "Đơn giá";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(19, 24);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.txtdongia);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 57);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tHIETBITableAdapter
            // 
            this.tHIETBITableAdapter.ClearBeforeFill = true;
            // 
            // frm_thietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_thietbi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin thiết bị y tế";
            this.Load += new System.EventHandler(this.frm_thietbi_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIETBIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUYSANDataSet5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txthangsx;
        private System.Windows.Forms.TextBox txtxuatxu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtdonvitinh;
        private System.Windows.Forms.TextBox txttentb;
        private System.Windows.Forms.TextBox txtsl_ton;
        private System.Windows.Forms.TextBox txtmstb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private QL_THUYSANDataSet5 qL_THUYSANDataSet5;
        private System.Windows.Forms.BindingSource tHIETBIBindingSource;
        private QL_THUYSANDataSet5TableAdapters.THIETBITableAdapter tHIETBITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUATXUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hANGSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLTONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONVITINHDataGridViewTextBoxColumn;
    }
}