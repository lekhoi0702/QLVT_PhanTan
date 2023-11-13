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
    public partial class FormTongHopNhapXuat : Form
    {
        public FormTongHopNhapXuat()
        {
            InitializeComponent();

        }


        private void btnXemTruoc_Click(object sender, EventArgs e)
        {

        
            DateTime ngayBatDau = deNgayBatDau.DateTime;
            DateTime ngayKetThuc = deNgayKetThuc.DateTime;
            /*
            int fromYear = dteTuNgay.DateTime.Year;
            int fromMonth = dteTuNgay.DateTime.Month;
            int toYear = dteToiNgay.DateTime.Year;
            int toMonth = dteToiNgay.DateTime.Month;
            */
            ReportTongHopNhapXuat report = new ReportTongHopNhapXuat(ngayBatDau, ngayKetThuc);        
            report.txtNgayBatDau.Text = deNgayBatDau.EditValue.ToString();
            report.txtNgayKetThuc.Text = deNgayKetThuc.EditValue.ToString();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
            this.Dispose();
        }


    }
}
