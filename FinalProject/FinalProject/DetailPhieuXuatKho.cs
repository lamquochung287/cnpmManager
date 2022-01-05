using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class DetailPhieuXuatKho : Form
    {
        // biến dùng để kết nối viết query 
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public String idPhieuXuat;
        public DetailPhieuXuatKho()
        {
            InitializeComponent();
        }

        //Khi click button Add sẽ thêm dữ liệu 
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            int radioChecked = 0;
            if (radioButtonDaThanhToan.Checked == true) {
                radioChecked = 1;
            }
            command.CommandText = "insert into bangxuatkho values('" + textBoxIdMatHang.Text + "','"
                + textBoxTenMatHang.Text + "','" + dateTimeXuatKho.Value + "','" + idPhieuXuat + "',"
                + textBoxSoLuong.Text + "," + textBoxThanhTien.Text + "," + textBoxTongThanhTien.Text + ",N'"
                + textBoxTenDaiLi.Text + "',N'" + textBoxTinhTrangDonHang.Text + "'," + radioChecked + ")";
            command.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công");
            loadData(); // load lai table khi đã thêm 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from bangxuatkho where idmathang = '" + textBoxIdMatHang.Text + "'" ;
            command.ExecuteNonQuery();
            loadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            int radioChecked = 0;
            if (radioButtonDaThanhToan.Checked == true)
            {
                radioChecked = 1;
            }
            command.CommandText = "update bangxuatkho set "
                + " tenmathang = N'" + textBoxTenMatHang.Text + "', ngayxuat = '" + dateTimeXuatKho.Value + "', idPhieuXuat = '" + idPhieuXuat + "', soluong ="
                + textBoxSoLuong.Text + ", thanhtien = " + textBoxThanhTien.Text + ", tongthanhtien = " + textBoxTongThanhTien.Text + ", tendaili = N'"
                + textBoxTenDaiLi.Text + "', tinhtrangdonhang = N'" + textBoxTinhTrangDonHang.Text + "', tinhtrangthanhtoan = " + radioChecked
                + " Where idmathang = '" + textBoxIdMatHang.Text + "' and idphieuxuat = '" + idPhieuXuat+"'";
            command.ExecuteNonQuery();
            loadData();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonClear.Enabled = false;
            textBoxIdMatHang.Text = "";
            textBoxTenMatHang.Text = "";
            dateTimeXuatKho.Value = DateTime.Now;
            textBoxSoLuong.Text = "";
            textBoxThanhTien.Text = "";
            textBoxTongThanhTien.Text = "";
            textBoxTenDaiLi.Text = "";
            textBoxTinhTrangDonHang.Text = "";
            radioButtonDaThanhToan.Checked = false;
            radioButtonChuaThanhToan.Checked = false;
            dataGridViewDetailPhieuXuatKho.ClearSelection();


        }

        private void DetailPhieuXuatKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablebangxuatkho_dbDataSet.bangxuatkho' table. You can move, or remove it, as needed.
            //this.bangxuatkhoTableAdapter.Fill(this.tablebangxuatkho_dbDataSet.bangxuatkho);
            connection = new SqlConnection("Data Source=desktop-k6pkggt;Initial Catalog=manageritem_db;Integrated Security=True");
            connection.Open();
            loadData();
            
        }

        void loadData() {

            // Query lấy ra các dữ liệu sản phẩm của phiếu có id đã chọn từ trang Phiếu Xuất Kho
            command = connection.CreateCommand();
            command.CommandText = "Select * from bangxuatkho where idphieuxuat ='" +idPhieuXuat+"'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewDetailPhieuXuatKho.DataSource = table;
        }

        private void dataGridViewDetailPhieuXuatKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (buttonClear.Enabled == false)
            {
                buttonClear.Enabled = true;
            }
            if (buttonUpdate.Enabled == false)
            {
                buttonUpdate.Enabled = true;
            }
            DataGridViewRow row = this.dataGridViewDetailPhieuXuatKho.Rows[e.RowIndex];

            if (row.Cells[0].Value.ToString().Length > 0)
            {
                textBoxIdMatHang.Text = row.Cells[0].Value.ToString();
                textBoxTenMatHang.Text = row.Cells[1].Value.ToString();
                dateTimeXuatKho.Value = (DateTime)row.Cells[2].Value;
                textBoxSoLuong.Text = row.Cells[3].Value.ToString();
                textBoxThanhTien.Text = row.Cells[4].Value.ToString();
                textBoxTongThanhTien.Text = row.Cells[5].Value.ToString();
                textBoxTenDaiLi.Text = row.Cells[6].Value.ToString();
                textBoxTinhTrangDonHang.Text = row.Cells[7].Value.ToString();
                if ((Boolean)row.Cells[8].Value == true)
                {
                    radioButtonDaThanhToan.Checked = true;
                }
                else {
                    radioButtonChuaThanhToan.Checked = true;
                }

            }
        }

        private void buttonShowReport_Click(object sender, EventArgs e)
        {
            PagePrintDetailPhieuXuatKho printpage = new PagePrintDetailPhieuXuatKho();
            printpage.idPhieuXuat = idPhieuXuat;
            printpage.Show();
        }
    }
}
