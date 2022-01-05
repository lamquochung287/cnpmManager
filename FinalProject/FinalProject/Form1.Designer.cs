
namespace FinalProject
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonClearTab1 = new System.Windows.Forms.Button();
            this.buttonUpdateTab1 = new System.Windows.Forms.Button();
            this.buttonDeleteTab1 = new System.Windows.Forms.Button();
            this.buttonAddTab1 = new System.Windows.Forms.Button();
            this.dateTimePickerNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.textBoxIdPhieuNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idphieunhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieunhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPhieuNhap = new FinalProject.DataSetPhieuNhap();
            this.tabPhieuXuatKho = new System.Windows.Forms.TabPage();
            this.dateTimeNgayXuatKho = new System.Windows.Forms.DateTimePicker();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxIdPhieuXuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreatePhieuXuatKho = new System.Windows.Forms.Button();
            this.dataGridViewPhieuXuatKho = new System.Windows.Forms.DataGridView();
            this.idphieuxuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayxuatkhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuxuatkhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuxuatkho_dataSet = new FinalProject.phieuxuatkho_dataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTKNhap = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataTKNhapKho = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dateEndTKNhapKho = new System.Windows.Forms.DateTimePicker();
            this.dateStartTKNhapKho = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTKXuatKho = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewTKXuatKho = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dateEndTKXuatKho = new System.Windows.Forms.DateTimePicker();
            this.dateStartTKXuatKho = new System.Windows.Forms.DateTimePicker();
            this.phieunhapTableAdapter = new FinalProject.DataSetPhieuNhapTableAdapters.phieunhapTableAdapter();
            this.phieuxuatkhoTableAdapter = new FinalProject.phieuxuatkho_dataSetTableAdapters.phieuxuatkhoTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPhieuNhap)).BeginInit();
            this.tabPhieuXuatKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuXuatKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuatkhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuatkho_dataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTKNhapKho)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTKXuatKho)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPhieuXuatKho);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonClearTab1);
            this.tabPage1.Controls.Add(this.buttonUpdateTab1);
            this.tabPage1.Controls.Add(this.buttonDeleteTab1);
            this.tabPage1.Controls.Add(this.buttonAddTab1);
            this.tabPage1.Controls.Add(this.dateTimePickerNgayNhap);
            this.tabPage1.Controls.Add(this.textBoxIdPhieuNhap);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phiếu Nhập Kho";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonClearTab1
            // 
            this.buttonClearTab1.Location = new System.Drawing.Point(583, 226);
            this.buttonClearTab1.Name = "buttonClearTab1";
            this.buttonClearTab1.Size = new System.Drawing.Size(86, 39);
            this.buttonClearTab1.TabIndex = 10;
            this.buttonClearTab1.Text = "Clear";
            this.buttonClearTab1.UseVisualStyleBackColor = true;
            this.buttonClearTab1.Click += new System.EventHandler(this.buttonClearTab1_Click);
            // 
            // buttonUpdateTab1
            // 
            this.buttonUpdateTab1.Location = new System.Drawing.Point(450, 226);
            this.buttonUpdateTab1.Name = "buttonUpdateTab1";
            this.buttonUpdateTab1.Size = new System.Drawing.Size(86, 39);
            this.buttonUpdateTab1.TabIndex = 10;
            this.buttonUpdateTab1.Text = "Cập Nhật";
            this.buttonUpdateTab1.UseVisualStyleBackColor = true;
            this.buttonUpdateTab1.Click += new System.EventHandler(this.buttonUpdateTab1_Click);
            // 
            // buttonDeleteTab1
            // 
            this.buttonDeleteTab1.Location = new System.Drawing.Point(583, 173);
            this.buttonDeleteTab1.Name = "buttonDeleteTab1";
            this.buttonDeleteTab1.Size = new System.Drawing.Size(86, 41);
            this.buttonDeleteTab1.TabIndex = 10;
            this.buttonDeleteTab1.Text = "Xóa";
            this.buttonDeleteTab1.UseVisualStyleBackColor = true;
            this.buttonDeleteTab1.Click += new System.EventHandler(this.buttonDeleteTab1_Click);
            // 
            // buttonAddTab1
            // 
            this.buttonAddTab1.Location = new System.Drawing.Point(450, 173);
            this.buttonAddTab1.Name = "buttonAddTab1";
            this.buttonAddTab1.Size = new System.Drawing.Size(86, 41);
            this.buttonAddTab1.TabIndex = 10;
            this.buttonAddTab1.Text = "Thêm";
            this.buttonAddTab1.UseVisualStyleBackColor = true;
            this.buttonAddTab1.Click += new System.EventHandler(this.buttonAddTab1_Click);
            // 
            // dateTimePickerNgayNhap
            // 
            this.dateTimePickerNgayNhap.Location = new System.Drawing.Point(558, 123);
            this.dateTimePickerNgayNhap.Name = "dateTimePickerNgayNhap";
            this.dateTimePickerNgayNhap.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerNgayNhap.TabIndex = 9;
            // 
            // textBoxIdPhieuNhap
            // 
            this.textBoxIdPhieuNhap.Location = new System.Drawing.Point(558, 72);
            this.textBoxIdPhieuNhap.Name = "textBoxIdPhieuNhap";
            this.textBoxIdPhieuNhap.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdPhieuNhap.TabIndex = 8;
            this.textBoxIdPhieuNhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã Phiếu Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(211, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "PHIẾU NHẬP KHO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tạo Phiếu Nhập Kho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idphieunhapDataGridViewTextBoxColumn,
            this.ngaynhapDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phieunhapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idphieunhapDataGridViewTextBoxColumn
            // 
            this.idphieunhapDataGridViewTextBoxColumn.DataPropertyName = "idphieunhap";
            this.idphieunhapDataGridViewTextBoxColumn.HeaderText = "Mã Phiếu Nhập";
            this.idphieunhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idphieunhapDataGridViewTextBoxColumn.Name = "idphieunhapDataGridViewTextBoxColumn";
            this.idphieunhapDataGridViewTextBoxColumn.Width = 140;
            // 
            // ngaynhapDataGridViewTextBoxColumn
            // 
            this.ngaynhapDataGridViewTextBoxColumn.DataPropertyName = "ngaynhap";
            this.ngaynhapDataGridViewTextBoxColumn.HeaderText = "Ngày Nhập";
            this.ngaynhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaynhapDataGridViewTextBoxColumn.Name = "ngaynhapDataGridViewTextBoxColumn";
            this.ngaynhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // phieunhapBindingSource
            // 
            this.phieunhapBindingSource.DataMember = "phieunhap";
            this.phieunhapBindingSource.DataSource = this.dataSetPhieuNhap;
            // 
            // dataSetPhieuNhap
            // 
            this.dataSetPhieuNhap.DataSetName = "DataSetPhieuNhap";
            this.dataSetPhieuNhap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPhieuXuatKho
            // 
            this.tabPhieuXuatKho.Controls.Add(this.dateTimeNgayXuatKho);
            this.tabPhieuXuatKho.Controls.Add(this.buttonUpdate);
            this.tabPhieuXuatKho.Controls.Add(this.buttonDelete);
            this.tabPhieuXuatKho.Controls.Add(this.buttonClear);
            this.tabPhieuXuatKho.Controls.Add(this.buttonAdd);
            this.tabPhieuXuatKho.Controls.Add(this.textBoxIdPhieuXuat);
            this.tabPhieuXuatKho.Controls.Add(this.label4);
            this.tabPhieuXuatKho.Controls.Add(this.label3);
            this.tabPhieuXuatKho.Controls.Add(this.label1);
            this.tabPhieuXuatKho.Controls.Add(this.buttonCreatePhieuXuatKho);
            this.tabPhieuXuatKho.Controls.Add(this.dataGridViewPhieuXuatKho);
            this.tabPhieuXuatKho.Location = new System.Drawing.Point(4, 25);
            this.tabPhieuXuatKho.Name = "tabPhieuXuatKho";
            this.tabPhieuXuatKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuXuatKho.Size = new System.Drawing.Size(778, 408);
            this.tabPhieuXuatKho.TabIndex = 1;
            this.tabPhieuXuatKho.Text = "Phiếu Xuất Kho";
            this.tabPhieuXuatKho.UseVisualStyleBackColor = true;
            // 
            // dateTimeNgayXuatKho
            // 
            this.dateTimeNgayXuatKho.Location = new System.Drawing.Point(588, 121);
            this.dateTimeNgayXuatKho.Name = "dateTimeNgayXuatKho";
            this.dateTimeNgayXuatKho.Size = new System.Drawing.Size(161, 22);
            this.dateTimeNgayXuatKho.TabIndex = 13;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(588, 251);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 41);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Cập Nhật";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(461, 251);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 41);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(588, 191);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(88, 41);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(461, 191);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 41);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxIdPhieuXuat
            // 
            this.textBoxIdPhieuXuat.Location = new System.Drawing.Point(588, 79);
            this.textBoxIdPhieuXuat.Name = "textBoxIdPhieuXuat";
            this.textBoxIdPhieuXuat.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdPhieuXuat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Xuất Kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Phiếu Xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(238, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "PHIẾU XUẤT KHO";
            // 
            // buttonCreatePhieuXuatKho
            // 
            this.buttonCreatePhieuXuatKho.Location = new System.Drawing.Point(478, 315);
            this.buttonCreatePhieuXuatKho.Name = "buttonCreatePhieuXuatKho";
            this.buttonCreatePhieuXuatKho.Size = new System.Drawing.Size(163, 32);
            this.buttonCreatePhieuXuatKho.TabIndex = 3;
            this.buttonCreatePhieuXuatKho.Text = "Tạo Phiếu Xuất Kho";
            this.buttonCreatePhieuXuatKho.UseVisualStyleBackColor = true;
            this.buttonCreatePhieuXuatKho.Click += new System.EventHandler(this.buttonCreatePhieuXuatKho_Click);
            // 
            // dataGridViewPhieuXuatKho
            // 
            this.dataGridViewPhieuXuatKho.AutoGenerateColumns = false;
            this.dataGridViewPhieuXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuXuatKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idphieuxuatDataGridViewTextBoxColumn,
            this.ngayxuatkhoDataGridViewTextBoxColumn});
            this.dataGridViewPhieuXuatKho.DataSource = this.phieuxuatkhoBindingSource;
            this.dataGridViewPhieuXuatKho.Location = new System.Drawing.Point(26, 79);
            this.dataGridViewPhieuXuatKho.Name = "dataGridViewPhieuXuatKho";
            this.dataGridViewPhieuXuatKho.RowHeadersWidth = 51;
            this.dataGridViewPhieuXuatKho.RowTemplate.Height = 24;
            this.dataGridViewPhieuXuatKho.Size = new System.Drawing.Size(333, 251);
            this.dataGridViewPhieuXuatKho.TabIndex = 2;
            this.dataGridViewPhieuXuatKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhieuXuatKho_CellClick);
            // 
            // idphieuxuatDataGridViewTextBoxColumn
            // 
            this.idphieuxuatDataGridViewTextBoxColumn.DataPropertyName = "idphieuxuat";
            this.idphieuxuatDataGridViewTextBoxColumn.HeaderText = "idphieuxuat";
            this.idphieuxuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idphieuxuatDataGridViewTextBoxColumn.Name = "idphieuxuatDataGridViewTextBoxColumn";
            this.idphieuxuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayxuatkhoDataGridViewTextBoxColumn
            // 
            this.ngayxuatkhoDataGridViewTextBoxColumn.DataPropertyName = "ngayxuatkho";
            this.ngayxuatkhoDataGridViewTextBoxColumn.HeaderText = "ngayxuatkho";
            this.ngayxuatkhoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayxuatkhoDataGridViewTextBoxColumn.Name = "ngayxuatkhoDataGridViewTextBoxColumn";
            this.ngayxuatkhoDataGridViewTextBoxColumn.Width = 125;
            // 
            // phieuxuatkhoBindingSource
            // 
            this.phieuxuatkhoBindingSource.DataMember = "phieuxuatkho";
            this.phieuxuatkhoBindingSource.DataSource = this.phieuxuatkho_dataSet;
            // 
            // phieuxuatkho_dataSet
            // 
            this.phieuxuatkho_dataSet.DataSetName = "phieuxuatkho_dataSet";
            this.phieuxuatkho_dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(778, 408);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống Kê";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTKNhap);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dataTKNhapKho);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateEndTKNhapKho);
            this.groupBox2.Controls.Add(this.dateStartTKNhapKho);
            this.groupBox2.Location = new System.Drawing.Point(17, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống Kê Nhập Kho";
            // 
            // buttonTKNhap
            // 
            this.buttonTKNhap.Location = new System.Drawing.Point(645, 20);
            this.buttonTKNhap.Name = "buttonTKNhap";
            this.buttonTKNhap.Size = new System.Drawing.Size(103, 23);
            this.buttonTKNhap.TabIndex = 4;
            this.buttonTKNhap.Text = "Thống Kê";
            this.buttonTKNhap.UseVisualStyleBackColor = true;
            this.buttonTKNhap.Click += new System.EventHandler(this.buttonTKNhap_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Từ";
            // 
            // dataTKNhapKho
            // 
            this.dataTKNhapKho.AllowUserToAddRows = false;
            this.dataTKNhapKho.AllowUserToDeleteRows = false;
            this.dataTKNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTKNhapKho.Location = new System.Drawing.Point(7, 50);
            this.dataTKNhapKho.Name = "dataTKNhapKho";
            this.dataTKNhapKho.ReadOnly = true;
            this.dataTKNhapKho.RowHeadersWidth = 51;
            this.dataTKNhapKho.RowTemplate.Height = 24;
            this.dataTKNhapKho.Size = new System.Drawing.Size(741, 142);
            this.dataTKNhapKho.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Đến";
            // 
            // dateEndTKNhapKho
            // 
            this.dateEndTKNhapKho.Location = new System.Drawing.Point(399, 22);
            this.dateEndTKNhapKho.Name = "dateEndTKNhapKho";
            this.dateEndTKNhapKho.Size = new System.Drawing.Size(223, 22);
            this.dateEndTKNhapKho.TabIndex = 0;
            this.dateEndTKNhapKho.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateStartTKNhapKho
            // 
            this.dateStartTKNhapKho.Location = new System.Drawing.Point(65, 21);
            this.dateStartTKNhapKho.Name = "dateStartTKNhapKho";
            this.dateStartTKNhapKho.Size = new System.Drawing.Size(227, 22);
            this.dateStartTKNhapKho.TabIndex = 0;
            this.dateStartTKNhapKho.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTKXuatKho);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dataGridViewTKXuatKho);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateEndTKXuatKho);
            this.groupBox1.Controls.Add(this.dateStartTKXuatKho);
            this.groupBox1.Location = new System.Drawing.Point(17, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê Xuất Kho";
            // 
            // buttonTKXuatKho
            // 
            this.buttonTKXuatKho.Location = new System.Drawing.Point(645, 21);
            this.buttonTKXuatKho.Name = "buttonTKXuatKho";
            this.buttonTKXuatKho.Size = new System.Drawing.Size(103, 23);
            this.buttonTKXuatKho.TabIndex = 4;
            this.buttonTKXuatKho.Text = "Thống Kê";
            this.buttonTKXuatKho.UseVisualStyleBackColor = true;
            this.buttonTKXuatKho.Click += new System.EventHandler(this.buttonTKXuatKho_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Từ";
            // 
            // dataGridViewTKXuatKho
            // 
            this.dataGridViewTKXuatKho.AllowUserToAddRows = false;
            this.dataGridViewTKXuatKho.AllowUserToDeleteRows = false;
            this.dataGridViewTKXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTKXuatKho.Location = new System.Drawing.Point(19, 50);
            this.dataGridViewTKXuatKho.Name = "dataGridViewTKXuatKho";
            this.dataGridViewTKXuatKho.ReadOnly = true;
            this.dataGridViewTKXuatKho.RowHeadersWidth = 51;
            this.dataGridViewTKXuatKho.RowTemplate.Height = 24;
            this.dataGridViewTKXuatKho.Size = new System.Drawing.Size(729, 143);
            this.dataGridViewTKXuatKho.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đến";
            // 
            // dateEndTKXuatKho
            // 
            this.dateEndTKXuatKho.Location = new System.Drawing.Point(399, 21);
            this.dateEndTKXuatKho.Name = "dateEndTKXuatKho";
            this.dateEndTKXuatKho.Size = new System.Drawing.Size(223, 22);
            this.dateEndTKXuatKho.TabIndex = 0;
            this.dateEndTKXuatKho.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateStartTKXuatKho
            // 
            this.dateStartTKXuatKho.Location = new System.Drawing.Point(65, 21);
            this.dateStartTKXuatKho.Name = "dateStartTKXuatKho";
            this.dateStartTKXuatKho.Size = new System.Drawing.Size(227, 22);
            this.dateStartTKXuatKho.TabIndex = 0;
            this.dateStartTKXuatKho.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // phieunhapTableAdapter
            // 
            this.phieunhapTableAdapter.ClearBeforeFill = true;
            // 
            // phieuxuatkhoTableAdapter
            // 
            this.phieuxuatkhoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Quản lí điện thoại";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPhieuNhap)).EndInit();
            this.tabPhieuXuatKho.ResumeLayout(false);
            this.tabPhieuXuatKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuXuatKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuatkhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuatkho_dataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTKNhapKho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTKXuatKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPhieuXuatKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreatePhieuXuatKho;
        private System.Windows.Forms.DataGridView dataGridViewPhieuXuatKho;
        private System.Windows.Forms.TabPage tabPage3;
        private DataSetPhieuNhap dataSetPhieuNhap;
        private System.Windows.Forms.BindingSource phieunhapBindingSource;
        private DataSetPhieuNhapTableAdapters.phieunhapTableAdapter phieunhapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieunhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhapDataGridViewTextBoxColumn;
        private phieuxuatkho_dataSet phieuxuatkho_dataSet;
        private System.Windows.Forms.BindingSource phieuxuatkhoBindingSource;
        private phieuxuatkho_dataSetTableAdapters.phieuxuatkhoTableAdapter phieuxuatkhoTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieuxuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayxuatkhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxIdPhieuXuat;
        private System.Windows.Forms.DateTimePicker dateTimeNgayXuatKho;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhap;
        private System.Windows.Forms.TextBox textBoxIdPhieuNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClearTab1;
        private System.Windows.Forms.Button buttonUpdateTab1;
        private System.Windows.Forms.Button buttonDeleteTab1;
        private System.Windows.Forms.Button buttonAddTab1;
        private System.Windows.Forms.DateTimePicker dateStartTKXuatKho;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataTKNhapKho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateEndTKNhapKho;
        private System.Windows.Forms.DateTimePicker dateStartTKNhapKho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewTKXuatKho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateEndTKXuatKho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonTKNhap;
        private System.Windows.Forms.Button buttonTKXuatKho;
    }
}

