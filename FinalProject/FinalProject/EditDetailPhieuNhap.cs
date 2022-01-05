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
    public partial class EditDetailPhieuNhap : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public String idPhieuNhap;
        public EditDetailPhieuNhap()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonClear.Enabled = false;
            textBoxIdMatHang.Text = "";
            textBoxTenMatHang.Text = "";
            textBoxSoLuong.Text = "";
            textBoxThanhTien.Text = "";
            textBoxTong.Text = "";
            dateTimePickerNgayNhapKho.Value = DateTime.Now;
        }

        void loadData()
        {

            // Query lấy ra các dữ liệu sản phẩm của phiếu có id đã chọn từ trang Phiếu Xuất Kho
            command = connection.CreateCommand();
            command.CommandText = "Select * from bangnhapkho where idphieunhap ='" + idPhieuNhap + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewDetailPhieuNhapKho.DataSource = table;
        }

        private void EditDetailPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manageritem_dbDataSet.bangnhapkho' table. You can move, or remove it, as needed.
            //this.bangnhapkhoTableAdapter.Fill(this.manageritem_dbDataSet.bangnhapkho);
            connection = new SqlConnection("Data Source=desktop-k6pkggt;Initial Catalog=manageritem_db;Integrated Security=True");
            connection.Open();
            loadData();

        }

        private void dataGridViewDetailPhieuNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (buttonClear.Enabled == false)
            {
                buttonClear.Enabled = true;
            }
            if (buttonUpdate.Enabled == false)
            {
                buttonUpdate.Enabled = true;
            }
            DataGridViewRow row = this.dataGridViewDetailPhieuNhapKho.Rows[e.RowIndex];
            if (row.Cells[0].Value.ToString().Length > 0)
            {
                textBoxIdMatHang.Text = row.Cells[0].Value.ToString();
                textBoxTenMatHang.Text = row.Cells[1].Value.ToString();
                textBoxSoLuong.Text = row.Cells[3].Value.ToString();
                textBoxThanhTien.Text = row.Cells[4].Value.ToString();
                textBoxTong.Text = row.Cells[5].Value.ToString();
                dateTimePickerNgayNhapKho.Value = (DateTime)row.Cells[2].Value;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into bangnhapkho values('" + textBoxIdMatHang.Text + "',N'"
                + textBoxTenMatHang.Text + "','" + dateTimePickerNgayNhapKho.Value + "','" + idPhieuNhap + "',"
                + textBoxSoLuong.Text + "," + textBoxThanhTien.Text + "," + textBoxTong.Text + ")";
            command.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công");
            loadData(); // load lai table khi đã thêm 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from bangnhapkho where idmathang = '" + textBoxIdMatHang.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update bangnhapkho set "
                + " tenmathang = N'" + textBoxTenMatHang.Text + "', ngaynhap = '" + dateTimePickerNgayNhapKho.Value + "', idphieunhap = '" + idPhieuNhap + "', soluong ="
                + textBoxSoLuong.Text + ", thanhtien = " + textBoxThanhTien.Text + ", tongthanhtien = " + textBoxTong.Text
                + " Where idmathang = '" + textBoxIdMatHang.Text + "' and idphieunhap = '" + idPhieuNhap + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void buttonShowReport_Click(object sender, EventArgs e)
        {
            DetailPhieuNhap printReportPhieuNhap = new DetailPhieuNhap();
            printReportPhieuNhap.idPhieuNhap = idPhieuNhap;
            printReportPhieuNhap.Show();
        }
    }
}
