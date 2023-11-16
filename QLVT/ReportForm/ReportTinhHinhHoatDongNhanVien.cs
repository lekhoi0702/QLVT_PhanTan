using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace QLVT.ReportForm
{
    public partial class ReportTinhHinhHoatDongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {

        public ReportTinhHinhHoatDongNhanVien(int maNhanVien, String loaiPhieu, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            InitializeComponent();
            qlvT_NHAPXUATDataSet2.EnforceConstraints = false;
            this.sp_TinhHinhHoatDongNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_TinhHinhHoatDongNhanVienTableAdapter.Fill(qlvT_NHAPXUATDataSet2.sp_TinhHinhHoatDongNhanVien, maNhanVien, loaiPhieu, ngayBatDau, ngayKetThuc);
      
            
        }

        private void tableCell5_BeforePrint(object sender, CancelEventArgs e)
        {
            //test
        }
    }
}
