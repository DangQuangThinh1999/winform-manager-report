
namespace GUI
{
    partial class frm_vattu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vattu));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txthangsx = new System.Windows.Forms.TextBox();
            this.txtxuatxu = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtdonvitinh = new System.Windows.Forms.TextBox();
            this.txttenvt = new System.Windows.Forms.TextBox();
            this.txtsl_ton = new System.Windows.Forms.TextBox();
            this.txtmsvt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mSVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUATXUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hANGSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLTONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONVITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_THUYSANDataSet = new GUI.QL_THUYSANDataSet();
            this.vATTUTableAdapter = new GUI.QL_THUYSANDataSetTableAdapters.VATTUTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUYSANDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.txtdongia);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(27, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 57);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
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
            this.txtdongia.Location = new System.Drawing.Point(518, 21);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(234, 25);
            this.txtdongia.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 20);
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
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txthangsx);
            this.groupBox1.Controls.Add(this.txtxuatxu);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.txtdonvitinh);
            this.groupBox1.Controls.Add(this.txttenvt);
            this.groupBox1.Controls.Add(this.txtsl_ton);
            this.groupBox1.Controls.Add(this.txtmsvt);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(768, 228);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vật tư";
            // 
            // txthangsx
            // 
            this.txthangsx.Location = new System.Drawing.Point(517, 99);
            this.txthangsx.Name = "txthangsx";
            this.txthangsx.Size = new System.Drawing.Size(234, 25);
            this.txthangsx.TabIndex = 11;
            this.txthangsx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtxuatxu
            // 
            this.txtxuatxu.Location = new System.Drawing.Point(177, 99);
            this.txtxuatxu.Name = "txtxuatxu";
            this.txtxuatxu.Size = new System.Drawing.Size(120, 25);
            this.txtxuatxu.TabIndex = 10;
            this.txtxuatxu.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(361, 99);
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
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtdonvitinh
            // 
            this.txtdonvitinh.Location = new System.Drawing.Point(523, 178);
            this.txtdonvitinh.Name = "txtdonvitinh";
            this.txtdonvitinh.Size = new System.Drawing.Size(234, 25);
            this.txtdonvitinh.TabIndex = 7;
            // 
            // txttenvt
            // 
            this.txttenvt.Location = new System.Drawing.Point(523, 33);
            this.txttenvt.Name = "txttenvt";
            this.txttenvt.Size = new System.Drawing.Size(235, 25);
            this.txttenvt.TabIndex = 6;
            // 
            // txtsl_ton
            // 
            this.txtsl_ton.Location = new System.Drawing.Point(177, 178);
            this.txtsl_ton.Name = "txtsl_ton";
            this.txtsl_ton.Size = new System.Drawing.Size(120, 25);
            this.txtsl_ton.TabIndex = 5;
            // 
            // txtmsvt
            // 
            this.txtmsvt.Location = new System.Drawing.Point(177, 28);
            this.txtmsvt.Name = "txtmsvt";
            this.txtmsvt.Size = new System.Drawing.Size(120, 25);
            this.txtmsvt.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(367, 178);
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
            this.button2.Location = new System.Drawing.Point(367, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tên vật tư";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mã số vật tư";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(30, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(764, 246);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSVTDataGridViewTextBoxColumn,
            this.tENVTDataGridViewTextBoxColumn,
            this.xUATXUDataGridViewTextBoxColumn,
            this.hANGSXDataGridViewTextBoxColumn,
            this.sLTONDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.dONVITINHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vATTUBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // mSVTDataGridViewTextBoxColumn
            // 
            this.mSVTDataGridViewTextBoxColumn.DataPropertyName = "MSVT";
            this.mSVTDataGridViewTextBoxColumn.HeaderText = "Msvt";
            this.mSVTDataGridViewTextBoxColumn.Name = "mSVTDataGridViewTextBoxColumn";
            this.mSVTDataGridViewTextBoxColumn.Width = 80;
            // 
            // tENVTDataGridViewTextBoxColumn
            // 
            this.tENVTDataGridViewTextBoxColumn.DataPropertyName = "TENVT";
            this.tENVTDataGridViewTextBoxColumn.HeaderText = "Tenvt";
            this.tENVTDataGridViewTextBoxColumn.Name = "tENVTDataGridViewTextBoxColumn";
            this.tENVTDataGridViewTextBoxColumn.Width = 170;
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
            this.sLTONDataGridViewTextBoxColumn.HeaderText = "Sl_ton";
            this.sLTONDataGridViewTextBoxColumn.Name = "sLTONDataGridViewTextBoxColumn";
            this.sLTONDataGridViewTextBoxColumn.Width = 50;
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            // 
            // dONVITINHDataGridViewTextBoxColumn
            // 
            this.dONVITINHDataGridViewTextBoxColumn.DataPropertyName = "DONVITINH";
            this.dONVITINHDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.dONVITINHDataGridViewTextBoxColumn.Name = "dONVITINHDataGridViewTextBoxColumn";
            // 
            // vATTUBindingSource
            // 
            this.vATTUBindingSource.DataMember = "VATTU";
            this.vATTUBindingSource.DataSource = this.qL_THUYSANDataSet;
            // 
            // qL_THUYSANDataSet
            // 
            this.qL_THUYSANDataSet.DataSetName = "QL_THUYSANDataSet";
            this.qL_THUYSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vATTUTableAdapter
            // 
            this.vATTUTableAdapter.ClearBeforeFill = true;
            // 
            // frm_vattu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 594);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_vattu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN VẬT TƯ";
            this.Load += new System.EventHandler(this.frm_vattu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUYSANDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txthangsx;
        private System.Windows.Forms.TextBox txtxuatxu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtdonvitinh;
        private System.Windows.Forms.TextBox txttenvt;
        private System.Windows.Forms.TextBox txtsl_ton;
        private System.Windows.Forms.TextBox txtmsvt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QL_THUYSANDataSet qL_THUYSANDataSet;
        private System.Windows.Forms.BindingSource vATTUBindingSource;
        private QL_THUYSANDataSetTableAdapters.VATTUTableAdapter vATTUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUATXUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hANGSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLTONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONVITINHDataGridViewTextBoxColumn;
    }
}