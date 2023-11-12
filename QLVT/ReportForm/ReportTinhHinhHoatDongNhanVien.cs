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
            qlvT_NHAPXUATDataSet22.EnforceConstraints = false;
            this.sp_TinhHinhHoatDongNhanVienTableAdapter1.Connection.ConnectionString = Program.connstr;      
            this.sp_TinhHinhHoatDongNhanVienTableAdapter1.ClearBeforeFill = true;
            this.sp_TinhHinhHoatDongNhanVienTableAdapter1.Fill(qlvT_NHAPXUATDataSet22.sp_TinhHinhHoatDongNhanVien, maNhanVien, loaiPhieu, ngayBatDau, ngayKetThuc);
            
        }
    }
}
