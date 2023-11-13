using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.ReportForm
{
    public partial class FormChiTietSoLuong_TriGiatheoLoaiPhieu : DevExpress.XtraEditors.XtraForm
    {
        public FormChiTietSoLuong_TriGiatheoLoaiPhieu()
        {
            InitializeComponent();
        }
        private void btnNHAP_Click(object sender, EventArgs e)
        {
            string role = Program.role;
            string loaiPhieu = "NHAP";
            DateTime ngayBatDau = deNgayBatDau.DateTime;
            DateTime ngayKetThuc = deNgayKetThuc.DateTime;

        
            ReportChiTietSoLuong_TriGiatheoLoaiPhieu report = new ReportChiTietSoLuong_TriGiatheoLoaiPhieu(role, loaiPhieu, ngayBatDau, ngayKetThuc);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
            this.Dispose();
        }

        private void btnXUAT_Click(object sender, EventArgs e)
        {
            string role = Program.role;
            string loaiPhieu = "XUAT";
            DateTime ngayBatDau = deNgayBatDau.DateTime;
            DateTime ngayKetThuc = deNgayKetThuc.DateTime;

            ReportChiTietSoLuong_TriGiatheoLoaiPhieu report = new ReportChiTietSoLuong_TriGiatheoLoaiPhieu(role, loaiPhieu, ngayBatDau, ngayKetThuc);

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
            this.Dispose();
        }
    }
}