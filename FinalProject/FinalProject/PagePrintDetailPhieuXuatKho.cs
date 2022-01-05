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
    public partial class PagePrintDetailPhieuXuatKho : Form
    {
        public String idPhieuXuat;
        public PagePrintDetailPhieuXuatKho()
        {
            InitializeComponent();
        }

        private void PagePrintDetailPhieuXuatKho_Load(object sender, EventArgs e)
        {
            ModelPrintPhieuXuatKho context = new ModelPrintPhieuXuatKho();
            List<bangxuatkho> listbangxuatkho = context.bangxuatkhoes.ToList();
            List<DataBangXuatKho> dataxuatkho = new List<DataBangXuatKho>();
            foreach (bangxuatkho data in listbangxuatkho)
            {
                if (data.idphieuxuat == idPhieuXuat)
                {
                    DataBangXuatKho temp = new DataBangXuatKho();
                    temp.idmathang = data.idmathang;
                    temp.idphieuxuat = data.idphieuxuat;
                    temp.ngayxuat = data.ngayxuat;
                    temp.soluong = data.soluong;
                    temp.tenmathang = data.tenmathang;
                    temp.thanhtien = data.thanhtien;
                    temp.tinhtrangdonhang = data.tinhtrangdonhang;
                    if (data.tinhtrangthanhtoan == true)
                    {//convert boolean true, false to String show table report
                        temp.tinhtrangthanhtoan = "đã thanh toán";
                    }
                    else
                    {
                        temp.tinhtrangthanhtoan = "chưa thanh toán";
                    }

                    temp.tendaili = data.tendaili;
                    temp.tongthanhtien = data.tongthanhtien;

                    dataxuatkho.Add(temp);
                }
            }
            reportViewer1.LocalReport.ReportPath = "ReportDetailPhieuXuatKho.rdlc";
            var source = new ReportDataSource("PrintPhieuXuatKhoDataSet",dataxuatkho);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
