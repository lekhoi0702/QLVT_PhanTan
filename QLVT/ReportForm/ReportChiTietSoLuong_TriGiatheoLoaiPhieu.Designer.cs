namespace QLVT.ReportForm
{
    partial class ReportChiTietSoLuong_TriGiatheoLoaiPhieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportChiTietSoLuong_TriGiatheoLoaiPhieu));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter2 = new QLVT.QLVT_NHAPXUATDataSet1TableAdapters.sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter3 = new QLVT.QLVT_NHAPXUATDataSet1TableAdapters.sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.Name = "Detail";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter2
            // 
            this.sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter2.ClearBeforeFill = true;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "zephyrus-g15\\mssqlserver1.QLVT_NHAPXUAT.dbo1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "sp_ChiTietSoLuong_TriGiatheoLoaiPhieu";
            queryParameter1.Name = "@ROLE";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "CONGTY";
            queryParameter2.Name = "@LOAI";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = "NHAP";
            queryParameter3.Name = "@NGAYBATDAU";
            queryParameter3.Type = typeof(System.DateTime);
            queryParameter3.ValueInfo = "2022-01-01";
            queryParameter4.Name = "@NGAYKETTHUC";
            queryParameter4.Type = typeof(System.DateTime);
            queryParameter4.ValueInfo = "2024-01-01";
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4});
            storedProcQuery1.StoredProcName = "sp_ChiTietSoLuong_TriGiatheoLoaiPhieu";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter3
            // 
            this.sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter3.ClearBeforeFill = true;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.16667F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 11.5D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TENVT]")});
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 0.4D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TONGSOLUONG]")});
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell2.Weight = 0.4D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TONGTRIGIA]")});
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell3.Weight = 0.4D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[THANGNAM]")});
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.Weight = 0.4D;
            // 
            // ReportChiTietSoLuong_TriGiatheoLoaiPhieu
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataAdapter = this.sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter3;
            this.DataMember = "sp_ChiTietSoLuong_TriGiatheoLoaiPhieu";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private QLVT_NHAPXUATDataSet1 qlvT_NHAPXUATDataSet11;
        private QLVT_NHAPXUATDataSet1TableAdapters.sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private QLVT_NHAPXUATDataSet1 qlvT_NHAPXUATDataSet12;
        private QLVT_NHAPXUATDataSet1TableAdapters.sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter1;
        private QLVT_NHAPXUATDataSet1TableAdapters.sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private QLVT_NHAPXUATDataSet1TableAdapters.sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter sp_ChiTietSoLuong_TriGiatheoLoaiPhieuTableAdapter3;
    }
}
