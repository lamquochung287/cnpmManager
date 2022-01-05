
namespace FinalProject
{
    partial class EditDetailPhieuNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDetailPhieuNhapKho = new System.Windows.Forms.DataGridView();
            this.bangnhapkhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageritem_dbDataSet = new FinalProject.manageritem_dbDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgayNhapKho = new System.Windows.Forms.DateTimePicker();
            this.textBoxTong = new System.Windows.Forms.TextBox();
            this.textBoxThanhTien = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxTenMatHang = new System.Windows.Forms.TextBox();
            this.textBoxIdMatHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonShowReport = new System.Windows.Forms.Button();
            this.bangnhapkhoTableAdapter = new FinalProject.manageritem_dbDataSetTableAdapters.bangnhapkhoTableAdapter();
            this.idmathangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmathangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongthanhtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailPhieuNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangnhapkhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageritem_dbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI TIẾT PHIẾU NHẬP KHO";
            // 
            // dataGridViewDetailPhieuNhapKho
            // 
            this.dataGridViewDetailPhieuNhapKho.AutoGenerateColumns = false;
            this.dataGridViewDetailPhieuNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailPhieuNhapKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmathangDataGridViewTextBoxColumn,
            this.tenmathangDataGridViewTextBoxColumn,
            this.ngaynhapDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.thanhtienDataGridViewTextBoxColumn,
            this.tongthanhtienDataGridViewTextBoxColumn});
            this.dataGridViewDetailPhieuNhapKho.DataSource = this.bangnhapkhoBindingSource;
            this.dataGridViewDetailPhieuNhapKho.Location = new System.Drawing.Point(31, 97);
            this.dataGridViewDetailPhieuNhapKho.Name = "dataGridViewDetailPhieuNhapKho";
            this.dataGridViewDetailPhieuNhapKho.RowHeadersWidth = 51;
            this.dataGridViewDetailPhieuNhapKho.RowTemplate.Height = 24;
            this.dataGridViewDetailPhieuNhapKho.Size = new System.Drawing.Size(529, 308);
            this.dataGridViewDetailPhieuNhapKho.TabIndex = 2;
            this.dataGridViewDetailPhieuNhapKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetailPhieuNhapKho_CellClick);
            this.dataGridViewDetailPhieuNhapKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bangnhapkhoBindingSource
            // 
            this.bangnhapkhoBindingSource.DataMember = "bangnhapkho";
            this.bangnhapkhoBindingSource.DataSource = this.manageritem_dbDataSet;
            // 
            // manageritem_dbDataSet
            // 
            this.manageritem_dbDataSet.DataSetName = "manageritem_dbDataSet";
            this.manageritem_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerNgayNhapKho);
            this.groupBox1.Controls.Add(this.textBoxTong);
            this.groupBox1.Controls.Add(this.textBoxThanhTien);
            this.groupBox1.Controls.Add(this.textBoxSoLuong);
            this.groupBox1.Controls.Add(this.textBoxTenMatHang);
            this.groupBox1.Controls.Add(this.textBoxIdMatHang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(616, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 308);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // dateTimePickerNgayNhapKho
            // 
            this.dateTimePickerNgayNhapKho.Location = new System.Drawing.Point(168, 133);
            this.dateTimePickerNgayNhapKho.Name = "dateTimePickerNgayNhapKho";
            this.dateTimePickerNgayNhapKho.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerNgayNhapKho.TabIndex = 10;
            // 
            // textBoxTong
            // 
            this.textBoxTong.Location = new System.Drawing.Point(168, 242);
            this.textBoxTong.Name = "textBoxTong";
            this.textBoxTong.Size = new System.Drawing.Size(134, 22);
            this.textBoxTong.TabIndex = 9;
            // 
            // textBoxThanhTien
            // 
            this.textBoxThanhTien.Location = new System.Drawing.Point(168, 208);
            this.textBoxThanhTien.Name = "textBoxThanhTien";
            this.textBoxThanhTien.Size = new System.Drawing.Size(134, 22);
            this.textBoxThanhTien.TabIndex = 9;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(168, 170);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(134, 22);
            this.textBoxSoLuong.TabIndex = 9;
            // 
            // textBoxTenMatHang
            // 
            this.textBoxTenMatHang.Location = new System.Drawing.Point(168, 95);
            this.textBoxTenMatHang.Name = "textBoxTenMatHang";
            this.textBoxTenMatHang.Size = new System.Drawing.Size(134, 22);
            this.textBoxTenMatHang.TabIndex = 9;
            // 
            // textBoxIdMatHang
            // 
            this.textBoxIdMatHang.Location = new System.Drawing.Point(168, 57);
            this.textBoxIdMatHang.Name = "textBoxIdMatHang";
            this.textBoxIdMatHang.Size = new System.Drawing.Size(134, 22);
            this.textBoxIdMatHang.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Thành Tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tổng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày Nhập Kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên mặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Mặt Hàng";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(41, 435);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 37);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(148, 435);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 37);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(381, 435);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 37);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(264, 435);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 37);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Cập Nhật";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonShowReport
            // 
            this.buttonShowReport.Location = new System.Drawing.Point(488, 435);
            this.buttonShowReport.Name = "buttonShowReport";
            this.buttonShowReport.Size = new System.Drawing.Size(98, 37);
            this.buttonShowReport.TabIndex = 4;
            this.buttonShowReport.Text = "Xem Report";
            this.buttonShowReport.UseVisualStyleBackColor = true;
            this.buttonShowReport.Click += new System.EventHandler(this.buttonShowReport_Click);
            // 
            // bangnhapkhoTableAdapter
            // 
            this.bangnhapkhoTableAdapter.ClearBeforeFill = true;
            // 
            // idmathangDataGridViewTextBoxColumn
            // 
            this.idmathangDataGridViewTextBoxColumn.DataPropertyName = "idmathang";
            this.idmathangDataGridViewTextBoxColumn.HeaderText = "idmathang";
            this.idmathangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idmathangDataGridViewTextBoxColumn.Name = "idmathangDataGridViewTextBoxColumn";
            this.idmathangDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenmathangDataGridViewTextBoxColumn
            // 
            this.tenmathangDataGridViewTextBoxColumn.DataPropertyName = "tenmathang";
            this.tenmathangDataGridViewTextBoxColumn.HeaderText = "tenmathang";
            this.tenmathangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenmathangDataGridViewTextBoxColumn.Name = "tenmathangDataGridViewTextBoxColumn";
            this.tenmathangDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaynhapDataGridViewTextBoxColumn
            // 
            this.ngaynhapDataGridViewTextBoxColumn.DataPropertyName = "ngaynhap";
            this.ngaynhapDataGridViewTextBoxColumn.HeaderText = "ngaynhap";
            this.ngaynhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaynhapDataGridViewTextBoxColumn.Name = "ngaynhapDataGridViewTextBoxColumn";
            this.ngaynhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "soluong";
            this.soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.Width = 125;
            // 
            // thanhtienDataGridViewTextBoxColumn
            // 
            this.thanhtienDataGridViewTextBoxColumn.DataPropertyName = "thanhtien";
            this.thanhtienDataGridViewTextBoxColumn.HeaderText = "thanhtien";
            this.thanhtienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thanhtienDataGridViewTextBoxColumn.Name = "thanhtienDataGridViewTextBoxColumn";
            this.thanhtienDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongthanhtienDataGridViewTextBoxColumn
            // 
            this.tongthanhtienDataGridViewTextBoxColumn.DataPropertyName = "tongthanhtien";
            this.tongthanhtienDataGridViewTextBoxColumn.HeaderText = "tongthanhtien";
            this.tongthanhtienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongthanhtienDataGridViewTextBoxColumn.Name = "tongthanhtienDataGridViewTextBoxColumn";
            this.tongthanhtienDataGridViewTextBoxColumn.Width = 125;
            // 
            // EditDetailPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 517);
            this.Controls.Add(this.buttonShowReport);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewDetailPhieuNhapKho);
            this.Controls.Add(this.label1);
            this.Name = "EditDetailPhieuNhap";
            this.Text = "Chi Tiết Phiếu Nhập Kho";
            this.Load += new System.EventHandler(this.EditDetailPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailPhieuNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangnhapkhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageritem_dbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDetailPhieuNhapKho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhapKho;
        private System.Windows.Forms.TextBox textBoxTong;
        private System.Windows.Forms.TextBox textBoxThanhTien;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxTenMatHang;
        private System.Windows.Forms.TextBox textBoxIdMatHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonShowReport;
        private manageritem_dbDataSet manageritem_dbDataSet;
        private System.Windows.Forms.BindingSource bangnhapkhoBindingSource;
        private manageritem_dbDataSetTableAdapters.bangnhapkhoTableAdapter bangnhapkhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmathangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmathangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongthanhtienDataGridViewTextBoxColumn;
    }
}