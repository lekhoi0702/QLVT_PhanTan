using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.ReportForm
{
    public partial class ReportChiTietSoLuong_TriGiatheoLoaiPhieu : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportChiTietSoLuong_TriGiatheoLoaiPhieu(String role,String loaiPhieu,DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = role;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = loaiPhieu;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = ngayBatDau;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = ngayKetThuc;







        }

    }
}
