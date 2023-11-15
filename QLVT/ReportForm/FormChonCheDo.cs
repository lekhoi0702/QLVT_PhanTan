using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Model.History;
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
    public partial class FormChonCheDo : Form
    {
        public FormChonCheDo()
        {
            InitializeComponent();
            
        }

        private void btnNHAP_Click(object sender, EventArgs e)
        {

            string loaiPhieu = "NHAP";
            DateTime ngayBatDau = deNgayBatDau.DateTime;
            DateTime ngayKetThuc = deNgayKetThuc.DateTime;
            /*
            int fromYear = dteTuNgay.DateTime.Year;
            int fromMonth = dteTuNgay.DateTime.Month;
            int toYear = dteToiNgay.DateTime.Year;
            int toMonth = dteToiNgay.DateTime.Month;
            */
            ReportTinhHinhHoatDongNhanVien report = new ReportTinhHinhHoatDongNhanVien(Program.maNV,loaiPhieu,ngayBatDau,ngayKetThuc);
          
            report.txtLoaiPhieu.Text = "NHẬP";
            report.txtMaNV.Text = Program.maNV.ToString().Trim();
            report.txtHo.Text = Program.Ho;
            report.txtTen.Text = Program.Ten;
            report.txtNgaySinh.Text = Program.ngaySinh;
            report.txtDiaChi.Text = Program.diaChi;
            report.txtSDT.Text = Program.SDT;
            report.txtNgayBatDau.Text = deNgayBatDau.EditValue.ToString();
            report.txtNgayKetThuc.Text = deNgayKetThuc.EditValue.ToString();
            Console.WriteLine(deNgayBatDau.EditValue.ToString());
            report.txtMaCN.Text = Program.maCN;

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
            this.Dispose();
        }

        private void btnXUAT_Click(object sender, EventArgs e)
        {

            string loaiPhieu = "XUAT";
            DateTime ngayBatDau = deNgayBatDau.DateTime;
            DateTime ngayKetThuc = deNgayKetThuc.DateTime;
            /*
            int fromYear = dteTuNgay.DateTime.Year;
            int fromMonth = dteTuNgay.DateTime.Month;
            int toYear = dteToiNgay.DateTime.Year;
            int toMonth = dteToiNgay.DateTime.Month;
            */
            ReportTinhHinhHoatDongNhanVien report = new ReportTinhHinhHoatDongNhanVien(Program.maNV, loaiPhieu, ngayBatDau, ngayKetThuc);

            report.txtLoaiPhieu.Text = "XUAT";
            report.txtMaNV.Text = Program.maNV.ToString().Trim();
            report.txtHo.Text = Program.Ho;
            report.txtTen.Text = Program.Ten;
            report.txtNgaySinh.Text = Program.ngaySinh;
            report.txtDiaChi.Text = Program.diaChi;
            report.txtSDT.Text = Program.SDT;
            report.txtNgayBatDau.Text = deNgayBatDau.EditValue.ToString();
            report.txtNgayKetThuc.Text = deNgayKetThuc.EditValue.ToString();
            report.txtMaCN.Text = Program.maCN;

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
            this.Dispose();
        }
    }
}
