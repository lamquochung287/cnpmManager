using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DetailPhieuNhap : Form
    {
        //dùng để lấy id phiếu nhập từ đó truy cập vào database lấy tất cả mặt hàng thông qua id phiếu nhập này
        public String idPhieuNhap;
        public DetailPhieuNhap()
        {
            InitializeComponent();
        }

        private void DetailPhieuNhap_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            DataForPhieuNhap data = new DataForPhieuNhap();
            List<bangnhapkho> listbangnhapkho = data.bangnhapkhoes.ToList();
            List<PhieuNhapReport> listreport = new List<PhieuNhapReport>();
            foreach (bangnhapkho datalist in listbangnhapkho)
            {
                // chỉ chọn tất cả sản phẩm có id phiếu nhập được chọn từ trang Phiếu Nhập Kho trước show lên trang chi tiết
                if (datalist.idphieunhap == idPhieuNhap) {
                    PhieuNhapReport temp = new PhieuNhapReport();
                    temp.idmathang = datalist.idmathang;
                    temp.tenmathang = datalist.tenmathang;
                    temp.ngaynhap = datalist.ngaynhap;
                    temp.soluong = datalist.soluong;
                    temp.thanhtien = datalist.thanhtien;
                    temp.tongthanhtien = datalist.tongthanhtien;

                    listreport.Add(temp);
                }
               

            }

            reportViewer1.LocalReport.ReportPath = "ReportDetailPhieuNhap.rdlc";
            var source = new ReportDataSource("DataPhieuNhap",listreport) ;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
