using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        //-----------------------------------------TAB XUẤT KHO----------------------------------
        //dùng để lấy id phiếu nhập từ đó truy cập vào database lấy tất cả mặt hàng thông qua id phiếu nhập này
        public String idPhieuNhap;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phieuxuatkho_dataSet.phieuxuatkho' table. You can move, or remove it, as needed.
            this.phieuxuatkhoTableAdapter.Fill(this.phieuxuatkho_dataSet.phieuxuatkho);// data phiếu xuất gồm id phiếu xuất, ngày xuất
            // TODO: This line of code loads data into the 'dataSetPhieuNhap.phieunhap' table. You can move, or remove it, as needed.
            this.phieunhapTableAdapter.Fill(this.dataSetPhieuNhap.phieunhap); // data phiếu nhập gồm id phiếu nhập, ngày nhập
        }


        /* button tạo phiếu nhập kho ở tab Phiếu nhập kho
           chức năng: bấm để tạo ra 1 form phiếu nhập kho hiển thị chi tiết các sản phẩm 
           đã được nhập kho của phiếu đó dựa theo id phiếu nhập kho 
         */
        private void button1_Click(object sender, EventArgs e)
        {
            
            EditDetailPhieuNhap editdetailPhieuNhap = new EditDetailPhieuNhap();
            editdetailPhieuNhap.idPhieuNhap = idPhieuNhap;
            editdetailPhieuNhap.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        /*khi user chọn 1 trong các phiếu nhập kho biến idPhieuNhap lưu lại mã id của phiếu nhập
        mục đích khi user click vào button tạo phiếu nhập kho dựa vào id đã được lưu hiển thị chi tiết sản phẩm của phiếu nhập kho đó
        lên form 2
         */
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            
            if (buttonClearTab1.Enabled == false)
            {
                buttonClearTab1.Enabled = true;
            }
            if (buttonUpdateTab1.Enabled == false)
            {
                buttonUpdateTab1.Enabled = true;
            }
            if (row.Cells[0].Value.ToString().Length > 0)
            {
                idPhieuNhap = row.Cells[0].Value.ToString().Trim();
                textBoxIdPhieuNhap.Text = row.Cells[0].Value.ToString();
                dateTimePickerNgayNhap.Value = (DateTime)row.Cells[1].Value;
            }
            else {
                textBoxIdPhieuNhap.Text = "";
                dateTimePickerNgayNhap.Value = DateTime.Now;
            }

        }

        private void buttonAddTab1_Click(object sender, EventArgs e)
        {
            DataSetPhieuNhap.phieunhapRow phieunhap = this.dataSetPhieuNhap.phieunhap.AddphieunhapRow(textBoxIdPhieuNhap.Text.ToString(),
                (DateTime)dateTimePickerNgayNhap.Value);
            this.phieunhapTableAdapter.Update(phieunhap);
            MessageBox.Show("Đã thêm thành công");
        }

        private void buttonDeleteTab1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận xóa", "Xóa Phiếu Xuất Kho", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
                DataSetPhieuNhap.phieunhapRow phieunhap = (DataSetPhieuNhap.phieunhapRow)this.dataSetPhieuNhap.phieunhap.Rows[rowIndex];
                phieunhap.Delete();
                this.phieunhapTableAdapter.Update(phieunhap);
                MessageBox.Show("Đã xóa");
            }
        }

        private void buttonUpdateTab1_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
            DataSetPhieuNhap.phieunhapRow phieunhap = (DataSetPhieuNhap.phieunhapRow)this.dataSetPhieuNhap.phieunhap.Rows[rowIndex];
            phieunhap.idphieunhap = textBoxIdPhieuNhap.Text;
            phieunhap.ngaynhap = (DateTime)dateTimePickerNgayNhap.Value;
            this.phieunhapTableAdapter.Update(phieunhap);

            MessageBox.Show("Cập Nhật Phiếu Xuất Kho Thành Công");
        }

        private void buttonClearTab1_Click(object sender, EventArgs e)
        {
            textBoxIdPhieuNhap.Text = "";
            dateTimePickerNgayNhap.Value = DateTime.Now;
            buttonUpdateTab1.Enabled = false;
            buttonClearTab1.Enabled = false;
            dataGridView1.ClearSelection();
        }

        //------------------------------TAB PHIẾU XUẤT KHO-------------------------------------------------

        //lưu idPhieuXuat kho sử dụng hiển thị chi tiết phiếu xuất kho
        public String idPhieuXuat;
        // button clear trên Phiếu Xuất Kho 
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxIdPhieuXuat.Text = "";
            dateTimeNgayXuatKho.Value = DateTime.Now;
            buttonUpdate.Enabled = false;
            buttonClear.Enabled = false;
            dataGridViewPhieuXuatKho.ClearSelection();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            phieuxuatkho_dataSet.phieuxuatkhoRow phieuxuatkho =
                this.phieuxuatkho_dataSet.phieuxuatkho.AddphieuxuatkhoRow(textBoxIdPhieuXuat.Text.ToString(), (DateTime)dateTimeNgayXuatKho.Value);
            this.phieuxuatkhoTableAdapter.Update(phieuxuatkho);
            MessageBox.Show("Đã thêm thành công");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận xóa", "Xóa Phiếu Xuất Kho", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int rowIndex = this.dataGridViewPhieuXuatKho.CurrentCell.RowIndex;
                phieuxuatkho_dataSet.phieuxuatkhoRow phieuxuatkho =
                (phieuxuatkho_dataSet.phieuxuatkhoRow)this.phieuxuatkho_dataSet.phieuxuatkho.Rows[rowIndex];
                phieuxuatkho.Delete();
                this.phieuxuatkhoTableAdapter.Update(phieuxuatkho);

                MessageBox.Show("Đã xóa");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dataGridViewPhieuXuatKho.CurrentCell.RowIndex;
            phieuxuatkho_dataSet.phieuxuatkhoRow phieuxuatkho = 
                (phieuxuatkho_dataSet.phieuxuatkhoRow)this.phieuxuatkho_dataSet.phieuxuatkho.Rows[rowIndex];
            phieuxuatkho.idphieuxuat = textBoxIdPhieuXuat.Text;
            phieuxuatkho.ngayxuatkho = (DateTime)dateTimeNgayXuatKho.Value;
            this.phieuxuatkhoTableAdapter.Update(phieuxuatkho);

            MessageBox.Show("Cập Nhật Phiếu Xuất Kho Thành Công");

        }

        private void dataGridViewPhieuXuatKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (buttonClear.Enabled == false)
            {
                buttonClear.Enabled = true;
            }
            if (buttonUpdate.Enabled == false)
            {
                buttonUpdate.Enabled = true;
            }
            DataGridViewRow row = this.dataGridViewPhieuXuatKho.Rows[e.RowIndex];
            if (row.Cells[0].Value.ToString().Length > 0)
            {
                idPhieuXuat = row.Cells[0].Value.ToString().Trim();
                textBoxIdPhieuXuat.Text = row.Cells[0].Value.ToString();
                dateTimeNgayXuatKho.Value = (DateTime)row.Cells[1].Value;
            }
            else {
                textBoxIdPhieuXuat.Text = "";
                dateTimeNgayXuatKho.Value = DateTime.Now;
            }
            
        }

        private void buttonCreatePhieuXuatKho_Click(object sender, EventArgs e)
        {
            DetailPhieuXuatKho detailPhieuXuatKho = new DetailPhieuXuatKho();
            detailPhieuXuatKho.idPhieuXuat = idPhieuXuat;
            detailPhieuXuatKho.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //-------------------------TAB THỐNG KÊ----------------------------------------

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableThongKeXuatKho = new DataTable();
        DataTable tableThongKeNhapKho = new DataTable();

        //load dữ liệu cho bảng thống kê xuất kho
        void loadDataTKXuatKho()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select tenmathang as 'Tên mặt hàng xuất kho', SUM(soluong) as 'Tổng số lượng xuất kho', SUM(tongthanhtien) as 'Tổng doanh thu'" +
                " from bangxuatkho where ngayxuat >='" + dateStartTKXuatKho.Value.Date + "' AND ngayxuat <='"+ dateEndTKXuatKho.Value.Date + "'"
                + "GROUP BY tenmathang";
            adapter.SelectCommand = command;
            tableThongKeXuatKho.Clear();
            adapter.Fill(tableThongKeXuatKho);
            dataGridViewTKXuatKho.DataSource = tableThongKeXuatKho;
        }

        // Button thống kê xuất kho 
        private void buttonTKXuatKho_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=desktop-k6pkggt;Initial Catalog=manageritem_db;Integrated Security=True");
            connection.Open();
            loadDataTKXuatKho();
        }

        //load dữ liệu cho bảng thống kê nhập kho
        void loadDataTKNhapKho()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select tenmathang as 'Tên mặt hàng nhập kho', SUM(soluong) as 'Tổng số lượng nhập kho', SUM(tongthanhtien) as 'Tổng thành tiền nhập kho'" +
                " from bangnhapkho where ngaynhap >='" + dateStartTKNhapKho.Value.Date + "' AND ngaynhap <='" + dateEndTKNhapKho.Value.Date + "'"
                + "GROUP BY tenmathang";
            adapter.SelectCommand = command;
            tableThongKeNhapKho.Clear();
            adapter.Fill(tableThongKeNhapKho);
            dataTKNhapKho.DataSource = tableThongKeNhapKho;
        }

        private void buttonTKNhap_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=desktop-k6pkggt;Initial Catalog=manageritem_db;Integrated Security=True");
            connection.Open();
            loadDataTKNhapKho();
        }
    }
}
