
namespace GUI
{
    partial class frm_nhacungcap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nhacungcap));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mSNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_THUYSANDataSet3 = new GUI.QL_THUYSANDataSet3();
            this.nHACUNGCAPTableAdapter = new GUI.QL_THUYSANDataSet3TableAdapters.NHACUNGCAPTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txthang = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUYSANDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSNCCDataGridViewTextBoxColumn,
            this.tENNCCDataGridViewTextBoxColumn,
            this.hANGDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nHACUNGCAPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // mSNCCDataGridViewTextBoxColumn
            // 
            this.mSNCCDataGridViewTextBoxColumn.DataPropertyName = "MSNCC";
            this.mSNCCDataGridViewTextBoxColumn.HeaderText = "MSNCC";
            this.mSNCCDataGridViewTextBoxColumn.Name = "mSNCCDataGridViewTextBoxColumn";
            // 
            // tENNCCDataGridViewTextBoxColumn
            // 
            this.tENNCCDataGridViewTextBoxColumn.DataPropertyName = "TENNCC";
            this.tENNCCDataGridViewTextBoxColumn.HeaderText = "TENNCC";
            this.tENNCCDataGridViewTextBoxColumn.Name = "tENNCCDataGridViewTextBoxColumn";
            this.tENNCCDataGridViewTextBoxColumn.Width = 400;
            // 
            // hANGDataGridViewTextBoxColumn
            // 
            this.hANGDataGridViewTextBoxColumn.DataPropertyName = "HANG";
            this.hANGDataGridViewTextBoxColumn.HeaderText = "HANG";
            this.hANGDataGridViewTextBoxColumn.Name = "hANGDataGridViewTextBoxColumn";
            this.hANGDataGridViewTextBoxColumn.Width = 120;
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource.DataSource = this.qL_THUYSANDataSet3;
            // 
            // qL_THUYSANDataSet3
            // 
            this.qL_THUYSANDataSet3.DataSetName = "QL_THUYSANDataSet3";
            this.qL_THUYSANDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHACUNGCAPTableAdapter
            // 
            this.nHACUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Location = new System.Drawing.Point(32, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(533, 27);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(126, 20);
            this.txtma.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã số nhà cung cấp";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(233, 19);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 36);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(122, 19);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 36);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(24, 19);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(92, 36);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txthang);
            this.groupBox2.Controls.Add(this.txttenncc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(28, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txthang
            // 
            this.txthang.Location = new System.Drawing.Point(537, 39);
            this.txthang.Name = "txthang";
            this.txthang.Size = new System.Drawing.Size(126, 20);
            this.txthang.TabIndex = 3;
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(156, 39);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(283, 20);
            this.txttenncc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hãng ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // frm_nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 433);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_nhacungcap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhà cung cấp";
            this.Load += new System.EventHandler(this.frm_nhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUYSANDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QL_THUYSANDataSet3 qL_THUYSANDataSet3;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private QL_THUYSANDataSet3TableAdapters.NHACUNGCAPTableAdapter nHACUNGCAPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthang;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.Label label2;
    }
}