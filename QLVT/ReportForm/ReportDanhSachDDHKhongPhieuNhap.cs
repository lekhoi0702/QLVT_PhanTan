﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.ReportForm
{
    public partial class ReportDanhSachDDHKhongPhieuNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDanhSachDDHKhongPhieuNhap()
        {
            InitializeComponent();

            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
