
namespace FinalProject
{
    partial class DetailPhieuXuatKho
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
            this.dataGridViewDetailPhieuXuatKho = new System.Windows.Forms.DataGridView();
            this.idmathangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmathangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayxuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongthanhtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendailiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrangdonhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrangthanhtoanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bangxuatkhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablebangxuatkho_dbDataSet = new FinalProject.tablebangxuatkho_dbDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.textBoxIdMatHang = new System.Windows.Forms.TextBox();
            this.textBoxTenMatHang = new System.Windows.Forms.TextBox();
            this.dateTimeXuatKho = new System.Windows.Forms.DateTimePicker();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxThanhTien = new System.Windows.Forms.TextBox();
            this.textBoxTongThanhTien = new System.Windows.Forms.TextBox();
            this.textBoxTenDaiLi = new System.Windows.Forms.TextBox();
            this.textBoxTinhTrangDonHang = new System.Windows.Forms.TextBox();
            this.radioButtonDaThanhToan = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonShowReport = new System.Windows.Forms.Button();
            this.bangxuatkhoTableAdapter = new FinalProject.tablebangxuatkho_dbDataSetTableAdapters.bangxuatkhoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailPhieuXuatKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangxuatkhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablebangxuatkho_dbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(208, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT PHIẾU XUẤT KHO";
            // 
            // dataGridViewDetailPhieuXuatKho
            // 
            this.dataGridViewDetailPhieuXuatKho.AutoGenerateColumns = false;
            this.dataGridViewDetailPhieuXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailPhieuXuatKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmathangDataGridViewTextBoxColumn,
            this.tenmathangDataGridViewTextBoxColumn,
            this.ngayxuatDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.thanhtienDataGridViewTextBoxColumn,
            this.tongthanhtienDataGridViewTextBoxColumn,
            this.tendailiDataGridViewTextBoxColumn,
            this.tinhtrangdonhangDataGridViewTextBoxColumn,
            this.tinhtrangthanhtoanDataGridViewCheckBoxColumn});
            this.dataGridViewDetailPhieuXuatKho.DataSource = this.bangxuatkhoBindingSource;
            this.dataGridViewDetailPhieuXuatKho.Location = new System.Drawing.Point(25, 77);
            this.dataGridViewDetailPhieuXuatKho.Name = "dataGridViewDetailPhieuXuatKho";
            this.dataGridViewDetailPhieuXuatKho.RowHeadersWidth = 51;
            this.dataGridViewDetailPhieuXuatKho.RowTemplate.Height = 24;
            this.dataGridViewDetailPhieuXuatKho.Size = new System.Drawing.Size(737, 371);
            this.dataGridViewDetailPhieuXuatKho.TabIndex = 1;
            this.dataGridViewDetailPhieuXuatKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetailPhieuXuatKho_CellClick);
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
            // ngayxuatDataGridViewTextBoxColumn
            // 
            this.ngayxuatDataGridViewTextBoxColumn.DataPropertyName = "ngayxuat";
            this.ngayxuatDataGridViewTextBoxColumn.HeaderText = "ngayxuat";
            this.ngayxuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayxuatDataGridViewTextBoxColumn.Name = "ngayxuatDataGridViewTextBoxColumn";
            this.ngayxuatDataGridViewTextBoxColumn.Width = 125;
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
            // tendailiDataGridViewTextBoxColumn
            // 
            this.tendailiDataGridViewTextBoxColumn.DataPropertyName = "tendaili";
            this.tendailiDataGridViewTextBoxColumn.HeaderText = "tendaili";
            this.tendailiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tendailiDataGridViewTextBoxColumn.Name = "tendailiDataGridViewTextBoxColumn";
            this.tendailiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tinhtrangdonhangDataGridViewTextBoxColumn
            // 
            this.tinhtrangdonhangDataGridViewTextBoxColumn.DataPropertyName = "tinhtrangdonhang";
            this.tinhtrangdonhangDataGridViewTextBoxColumn.HeaderText = "tinhtrangdonhang";
            this.tinhtrangdonhangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinhtrangdonhangDataGridViewTextBoxColumn.Name = "tinhtrangdonhangDataGridViewTextBoxColumn";
            this.tinhtrangdonhangDataGridViewTextBoxColumn.Width = 125;
            // 
            // tinhtrangthanhtoanDataGridViewCheckBoxColumn
            // 
            this.tinhtrangthanhtoanDataGridViewCheckBoxColumn.DataPropertyName = "tinhtrangthanhtoan";
            this.tinhtrangthanhtoanDataGridViewCheckBoxColumn.HeaderText = "tinhtrangthanhtoan";
            this.tinhtrangthanhtoanDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.tinhtrangthanhtoanDataGridViewCheckBoxColumn.Name = "tinhtrangthanhtoanDataGridViewCheckBoxColumn";
            this.tinhtrangthanhtoanDataGridViewCheckBoxColumn.Width = 125;
            // 
            // bangxuatkhoBindingSource
            // 
            this.bangxuatkhoBindingSource.DataMember = "bangxuatkho";
            this.bangxuatkhoBindingSource.DataSource = this.tablebangxuatkho_dbDataSet;
            // 
            // tablebangxuatkho_dbDataSet
            // 
            this.tablebangxuatkho_dbDataSet.DataSetName = "tablebangxuatkho_dbDataSet";
            this.tablebangxuatkho_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Mặt Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên mặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Xuất Kho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số Lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Thành Tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tổng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên Đại Lý";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tình Trạng Đơn Hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tình Trạng Thanh Toán";
            // 
            // radioButtonChuaThanhToan
            // 
            this.radioButtonChuaThanhToan.AutoSize = true;
            this.radioButtonChuaThanhToan.Location = new System.Drawing.Point(194, 340);
            this.radioButtonChuaThanhToan.Name = "radioButtonChuaThanhToan";
            this.radioButtonChuaThanhToan.Size = new System.Drawing.Size(144, 21);
            this.radioButtonChuaThanhToan.TabIndex = 4;
            this.radioButtonChuaThanhToan.TabStop = true;
            this.radioButtonChuaThanhToan.Text = "Chưa Thanh Toán";
            this.radioButtonChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // textBoxIdMatHang
            // 
            this.textBoxIdMatHang.Location = new System.Drawing.Point(153, 34);
            this.textBoxIdMatHang.Name = "textBoxIdMatHang";
            this.textBoxIdMatHang.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdMatHang.TabIndex = 5;
            // 
            // textBoxTenMatHang
            // 
            this.textBoxTenMatHang.Location = new System.Drawing.Point(153, 79);
            this.textBoxTenMatHang.Name = "textBoxTenMatHang";
            this.textBoxTenMatHang.Size = new System.Drawing.Size(100, 22);
            this.textBoxTenMatHang.TabIndex = 6;
            // 
            // dateTimeXuatKho
            // 
            this.dateTimeXuatKho.Location = new System.Drawing.Point(153, 120);
            this.dateTimeXuatKho.Name = "dateTimeXuatKho";
            this.dateTimeXuatKho.Size = new System.Drawing.Size(200, 22);
            this.dateTimeXuatKho.TabIndex = 7;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(153, 159);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(100, 22);
            this.textBoxSoLuong.TabIndex = 8;
            // 
            // textBoxThanhTien
            // 
            this.textBoxThanhTien.Location = new System.Drawing.Point(153, 192);
            this.textBoxThanhTien.Name = "textBoxThanhTien";
            this.textBoxThanhTien.Size = new System.Drawing.Size(100, 22);
            this.textBoxThanhTien.TabIndex = 8;
            // 
            // textBoxTongThanhTien
            // 
            this.textBoxTongThanhTien.Location = new System.Drawing.Point(153, 226);
            this.textBoxTongThanhTien.Name = "textBoxTongThanhTien";
            this.textBoxTongThanhTien.Size = new System.Drawing.Size(100, 22);
            this.textBoxTongThanhTien.TabIndex = 8;
            // 
            // textBoxTenDaiLi
            // 
            this.textBoxTenDaiLi.Location = new System.Drawing.Point(153, 263);
            this.textBoxTenDaiLi.Name = "textBoxTenDaiLi";
            this.textBoxTenDaiLi.Size = new System.Drawing.Size(100, 22);
            this.textBoxTenDaiLi.TabIndex = 8;
            // 
            // textBoxTinhTrangDonHang
            // 
            this.textBoxTinhTrangDonHang.Location = new System.Drawing.Point(194, 305);
            this.textBoxTinhTrangDonHang.Name = "textBoxTinhTrangDonHang";
            this.textBoxTinhTrangDonHang.Size = new System.Drawing.Size(100, 22);
            this.textBoxTinhTrangDonHang.TabIndex = 8;
            // 
            // radioButtonDaThanhToan
            // 
            this.radioButtonDaThanhToan.AutoSize = true;
            this.radioButtonDaThanhToan.Location = new System.Drawing.Point(194, 367);
            this.radioButtonDaThanhToan.Name = "radioButtonDaThanhToan";
            this.radioButtonDaThanhToan.Size = new System.Drawing.Size(129, 21);
            this.radioButtonDaThanhToan.TabIndex = 4;
            this.radioButtonDaThanhToan.TabStop = true;
            this.radioButtonDaThanhToan.Text = "Đã Thanh Toán";
            this.radioButtonDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(68, 472);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 31);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(185, 472);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 31);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(286, 472);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(111, 31);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Cập Nhật";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(423, 472);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 31);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonShowReport
            // 
            this.buttonShowReport.Location = new System.Drawing.Point(559, 472);
            this.buttonShowReport.Name = "buttonShowReport";
            this.buttonShowReport.Size = new System.Drawing.Size(132, 31);
            this.buttonShowReport.TabIndex = 9;
            this.buttonShowReport.Text = "Xem Report";
            this.buttonShowReport.UseVisualStyleBackColor = true;
            this.buttonShowReport.Click += new System.EventHandler(this.buttonShowReport_Click);
            // 
            // bangxuatkhoTableAdapter
            // 
            this.bangxuatkhoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.textBoxTenMatHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButtonChuaThanhToan);
            this.groupBox1.Controls.Add(this.textBoxThanhTien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimeXuatKho);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButtonDaThanhToan);
            this.groupBox1.Controls.Add(this.textBoxTongThanhTien);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxIdMatHang);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxTinhTrangDonHang);
            this.groupBox1.Controls.Add(this.textBoxTenDaiLi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(811, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 425);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // DetailPhieuXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonShowReport);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewDetailPhieuXuatKho);
            this.Controls.Add(this.label1);
            this.Name = "DetailPhieuXuatKho";
            this.Text = "Chi Tiết Phiếu Xuất Kho";
            this.Load += new System.EventHandler(this.DetailPhieuXuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailPhieuXuatKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangxuatkhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablebangxuatkho_dbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDetailPhieuXuatKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonChuaThanhToan;
        private System.Windows.Forms.TextBox textBoxIdMatHang;
        private System.Windows.Forms.TextBox textBoxTenMatHang;
        private System.Windows.Forms.DateTimePicker dateTimeXuatKho;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxThanhTien;
        private System.Windows.Forms.TextBox textBoxTongThanhTien;
        private System.Windows.Forms.TextBox textBoxTenDaiLi;
        private System.Windows.Forms.TextBox textBoxTinhTrangDonHang;
        private System.Windows.Forms.RadioButton radioButtonDaThanhToan;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonShowReport;
        private tablebangxuatkho_dbDataSet tablebangxuatkho_dbDataSet;
        private System.Windows.Forms.BindingSource bangxuatkhoBindingSource;
        private tablebangxuatkho_dbDataSetTableAdapters.bangxuatkhoTableAdapter bangxuatkhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmathangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmathangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayxuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongthanhtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendailiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrangdonhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tinhtrangthanhtoanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}