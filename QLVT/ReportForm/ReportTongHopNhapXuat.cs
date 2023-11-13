using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.ReportForm
{
    public partial class ReportTongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportTongHopNhapXuat()
        {
            InitializeComponent();
        }

        public ReportTongHopNhapXuat(DateTime ngayBatDau,DateTime NgayKetThuc)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngayBatDau;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = NgayKetThuc;

            this.sqlDataSource1.Fill();


        }

    }
}
