
namespace GUI
{
    partial class frmhoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhoadon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtngayhd = new System.Windows.Forms.DateTimePicker();
            this.txtmskh = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtmshd = new System.Windows.Forms.TextBox();
            this.txtngayhd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmsnv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOADONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_THUYSANDataSet7 = new GUI.QL_THUYSANDataSet7();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.hOADONTableAdapter = new GUI.QL_THUYSANDataSet7TableAdapters.HOADONTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUYSANDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtngayhd);
            this.groupBox1.Controls.Add(this.txtmskh);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.txtmshd);
            this.groupBox1.Controls.Add(this.txtngayhd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmsnv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cần nhập";
            // 
            // dtngayhd
            // 
            this.dtngayhd.CustomFormat = "dd/MM/yyyy";
            this.dtngayhd.Location = new System.Drawing.Point(596, 127);
            this.dtngayhd.Name = "dtngayhd";
            this.dtngayhd.Size = new System.Drawing.Size(200, 22);
            this.dtngayhd.TabIndex = 8;
            // 
            // txtmskh
            // 
            this.txtmskh.Location = new System.Drawing.Point(587, 30);
            this.txtmskh.Name = "txtmskh";
            this.txtmskh.Size = new System.Drawing.Size(281, 22);
            this.txtmskh.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(154, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(269, 22);
            this.textBox3.TabIndex = 5;
            // 
            // txtmshd
            // 
            this.txtmshd.Location = new System.Drawing.Point(152, 30);
            this.txtmshd.Name = "txtmshd";
            this.txtmshd.Size = new System.Drawing.Size(272, 22);
            this.txtmshd.TabIndex = 4;
            // 
            // txtngayhd
            // 
            this.txtngayhd.AutoSize = true;
            this.txtngayhd.Location = new System.Drawing.Point(456, 127);
            this.txtngayhd.Name = "txtngayhd";
            this.txtngayhd.Size = new System.Drawing.Size(80, 15);
            this.txtngayhd.TabIndex = 3;
            this.txtngayhd.Text = "Ngày hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã số khách hàng";
            // 
            // txtmsnv
            // 
            this.txtmsnv.AutoSize = true;
            this.txtmsnv.Location = new System.Drawing.Point(38, 127);
            this.txtmsnv.Name = "txtmsnv";
            this.txtmsnv.Size = new System.Drawing.Size(94, 15);
            this.txtmsnv.TabIndex = 1;
            this.txtmsnv.Text = "Mã số nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.txttongtien);
            this.groupBox2.Controls.Add(this.txt);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(17, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(889, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(230, 38);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(99, 29);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(659, 41);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(208, 22);
            this.txttongtien.TabIndex = 4;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(569, 48);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(59, 15);
            this.txt.TabIndex = 3;
            this.txt.Text = "Tổng tiền";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "THOÁT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(126, 36);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(88, 31);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.hOADONBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(20, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(886, 210);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MSHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "MSHD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn2.HeaderText = "MANV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MSKH";
            this.dataGridViewTextBoxColumn3.HeaderText = "MSKH";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NGAYHD";
            this.dataGridViewTextBoxColumn4.HeaderText = "NGAYHD";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TONGTIEN";
            this.dataGridViewTextBoxColumn5.HeaderText = "TONGTIEN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 350;
            // 
            // hOADONBindingSource1
            // 
            this.hOADONBindingSource1.DataMember = "HOADON";
            this.hOADONBindingSource1.DataSource = this.qL_THUYSANDataSet7;
            // 
            // qL_THUYSANDataSet7
            // 
            this.qL_THUYSANDataSet7.DataSetName = "QL_THUYSANDataSet7";
            this.qL_THUYSANDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // frmhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(924, 536);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmhoadon";
            this.Text = "Thông tin hóa đơn";
            this.Load += new System.EventHandler(this.frmhoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUYSANDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmskh;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtngayhd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtmsnv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button button1;
    
        private System.Windows.Forms.Button btn_xoa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private QL_THUYSANDataSet7 qL_THUYSANDataSet7;
        private System.Windows.Forms.BindingSource hOADONBindingSource1;
        private QL_THUYSANDataSet7TableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DateTimePicker dtngayhd;
        private System.Windows.Forms.TextBox txtmshd;
    }
}