namespace QLVT
{
    partial class FormHoaDon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAHDLabel;
            System.Windows.Forms.Label nGAYLAPLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC = new DevExpress.XtraBars.BarButtonItem();
            this.btnEXIT = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenu = new DevExpress.XtraBars.BarSubItem();
            this.btnCheDoDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheDoCTDDH = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.dataSet = new QLVT.QLVT_NHAPXUATDataSet();
            this.bdsHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.HOADONTableAdapter = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.HOADONTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.TableAdapterManager();
            this.CTHDTableAdapter = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.CTHDTableAdapter();
            this.KHOTableAdapter = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.KHOTableAdapter();
            this.panelNhapLieu = new DevExpress.XtraEditors.GroupControl();
            this.panelHD = new DevExpress.XtraEditors.GroupControl();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.bdsKhachHang = new System.Windows.Forms.BindingSource(this.components);
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.deNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelCTHD = new DevExpress.XtraEditors.GroupControl();
            this.txtDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.cmbVatTu = new System.Windows.Forms.ComboBox();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.bdsCTHD = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.KHACHHANGTableAdapter = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.KHACHHANGTableAdapter();
            this.VATTUTableAdapter = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.VATTUTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gcHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCTHD = new DevExpress.XtraGrid.GridControl();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAHDLabel = new System.Windows.Forms.Label();
            nGAYLAPLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHD)).BeginInit();
            this.panelHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCTHD)).BeginInit();
            this.panelCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(8, 32);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(84, 20);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã vật tư:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(2, 156);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(78, 20);
            sOLUONGLabel.TabIndex = 2;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(5, 188);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(70, 20);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // mAHDLabel
            // 
            mAHDLabel.AutoSize = true;
            mAHDLabel.Location = new System.Drawing.Point(5, 26);
            mAHDLabel.Name = "mAHDLabel";
            mAHDLabel.Size = new System.Drawing.Size(101, 20);
            mAHDLabel.TabIndex = 0;
            mAHDLabel.Text = "Mã hoá đơn:";
            // 
            // nGAYLAPLabel
            // 
            nGAYLAPLabel.AutoSize = true;
            nGAYLAPLabel.Location = new System.Drawing.Point(5, 59);
            nGAYLAPLabel.Name = "nGAYLAPLabel";
            nGAYLAPLabel.Size = new System.Drawing.Size(77, 20);
            nGAYLAPLabel.TabIndex = 2;
            nGAYLAPLabel.Text = "Ngày lập:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(8, 141);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(112, 20);
            mANVLabel.TabIndex = 4;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(8, 187);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(69, 20);
            mAKHOLabel.TabIndex = 6;
            mAKHOLabel.Text = "Mã kho:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(8, 95);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(124, 20);
            mAKHLabel.TabIndex = 8;
            mAKHLabel.Text = "Mã khách hàng:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTHEM,
            this.btnXOA,
            this.btnGHI,
            this.btnLAMMOI,
            this.btnHOANTAC,
            this.btnChuyenChiNhanh,
            this.btnThoat,
            this.btnEXIT,
            this.btnMenu,
            this.btnCheDoDDH,
            this.btnCheDoCTDDH});
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(285, 154);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGHI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHOANTAC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEXIT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMenu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 1;
            this.bar1.Text = "Tools";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Caption = "Thêm";
            this.btnTHEM.Id = 0;
            this.btnTHEM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTHEM.ImageOptions.Image")));
            this.btnTHEM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTHEM.ImageOptions.LargeImage")));
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnXOA
            // 
            this.btnXOA.Caption = "Xoá";
            this.btnXOA.Id = 1;
            this.btnXOA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXOA.ImageOptions.Image")));
            this.btnXOA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXOA.ImageOptions.LargeImage")));
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnGHI
            // 
            this.btnGHI.Caption = "Ghi";
            this.btnGHI.Id = 2;
            this.btnGHI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGHI.ImageOptions.Image")));
            this.btnGHI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGHI.ImageOptions.LargeImage")));
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_ItemClick);
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Caption = "Làm mới";
            this.btnLAMMOI.Id = 3;
            this.btnLAMMOI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLAMMOI.ImageOptions.Image")));
            this.btnLAMMOI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLAMMOI.ImageOptions.LargeImage")));
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_ItemClick);
            // 
            // btnHOANTAC
            // 
            this.btnHOANTAC.Caption = "Hoàn tác";
            this.btnHOANTAC.Id = 4;
            this.btnHOANTAC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHOANTAC.ImageOptions.Image")));
            this.btnHOANTAC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHOANTAC.ImageOptions.LargeImage")));
            this.btnHOANTAC.Name = "btnHOANTAC";
            this.btnHOANTAC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHOANTAC_ItemClick);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Caption = "Thoát";
            this.btnEXIT.Id = 7;
            this.btnEXIT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEXIT.ImageOptions.Image")));
            this.btnEXIT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEXIT.ImageOptions.LargeImage")));
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
            // 
            // btnMenu
            // 
            this.btnMenu.Caption = "Chuyển Form";
            this.btnMenu.Id = 8;
            this.btnMenu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.ImageOptions.Image")));
            this.btnMenu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.ImageOptions.LargeImage")));
            this.btnMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCheDoDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheDoCTDDH)});
            this.btnMenu.Name = "btnMenu";
            // 
            // btnCheDoDDH
            // 
            this.btnCheDoDDH.Caption = "Hoá đơn";
            this.btnCheDoDDH.Id = 9;
            this.btnCheDoDDH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCheDoDDH.ImageOptions.LargeImage")));
            this.btnCheDoDDH.Name = "btnCheDoDDH";
            this.btnCheDoDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheDoDonDatHang_ItemClick);
            // 
            // btnCheDoCTDDH
            // 
            this.btnCheDoCTDDH.Caption = "Chi tiết hoá đơn";
            this.btnCheDoCTDDH.Id = 10;
            this.btnCheDoCTDDH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCheDoCTDDH.ImageOptions.LargeImage")));
            this.btnCheDoCTDDH.Name = "btnCheDoCTDDH";
            this.btnCheDoCTDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheDoCTHD_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1268, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 725);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1268, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 691);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1268, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 691);
            // 
            // btnChuyenChiNhanh
            // 
            this.btnChuyenChiNhanh.Caption = "Chuyển chi nhánh";
            this.btnChuyenChiNhanh.Id = 5;
            this.btnChuyenChiNhanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenChiNhanh.ImageOptions.Image")));
            this.btnChuyenChiNhanh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChuyenChiNhanh.ImageOptions.LargeImage")));
            this.btnChuyenChiNhanh.Name = "btnChuyenChiNhanh";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "dataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsHoaDon
            // 
            this.bdsHoaDon.DataMember = "HOADON";
            this.bdsHoaDon.DataSource = this.dataSet;
            // 
            // HOADONTableAdapter
            // 
            this.HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTHDTableAdapter = this.CTHDTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.DDHTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = this.HOADONTableAdapter;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = this.KHOTableAdapter;
            this.tableAdapterManager.LOAIVATTUTableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_NHAPXUATDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // CTHDTableAdapter
            // 
            this.CTHDTableAdapter.ClearBeforeFill = true;
            // 
            // KHOTableAdapter
            // 
            this.KHOTableAdapter.ClearBeforeFill = true;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(this.panelHD);
            this.panelNhapLieu.Controls.Add(this.panelControl3);
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 441);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(916, 325);
            this.panelNhapLieu.TabIndex = 8;
            this.panelNhapLieu.Text = "Thông tin nhập liệu";
            // 
            // panelHD
            // 
            this.panelHD.Controls.Add(this.cmbKhachHang);
            this.panelHD.Controls.Add(this.cmbKho);
            this.panelHD.Controls.Add(mAKHLabel);
            this.panelHD.Controls.Add(this.txtMaKH);
            this.panelHD.Controls.Add(mAKHOLabel);
            this.panelHD.Controls.Add(this.txtMaKho);
            this.panelHD.Controls.Add(mANVLabel);
            this.panelHD.Controls.Add(this.txtMaNV);
            this.panelHD.Controls.Add(nGAYLAPLabel);
            this.panelHD.Controls.Add(this.deNgayLap);
            this.panelHD.Controls.Add(mAHDLabel);
            this.panelHD.Controls.Add(this.txtMaHD);
            this.panelHD.Location = new System.Drawing.Point(2, 25);
            this.panelHD.Name = "panelHD";
            this.panelHD.Size = new System.Drawing.Size(590, 300);
            this.panelHD.TabIndex = 2;
            this.panelHD.Text = "Thông tin đơn đặt hàng";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.DataSource = this.bdsKhachHang;
            this.cmbKhachHang.DisplayMember = "TENKH";
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(251, 95);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(166, 28);
            this.cmbKhachHang.TabIndex = 11;
            this.cmbKhachHang.ValueMember = "MAKH";
            // 
            // bdsKhachHang
            // 
            this.bdsKhachHang.DataMember = "KHACHHANG";
            this.bdsKhachHang.DataSource = this.dataSet;
            // 
            // cmbKho
            // 
            this.cmbKho.DataSource = this.bdsKho;
            this.cmbKho.DisplayMember = "TENKHO";
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(251, 187);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(166, 28);
            this.cmbKho.TabIndex = 10;
            this.cmbKho.ValueMember = "MAKHO";
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "KHO";
            this.bdsKho.DataSource = this.dataSet;
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoaDon, "MAKH", true));
            this.txtMaKH.Location = new System.Drawing.Point(135, 95);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 28);
            this.txtMaKH.TabIndex = 9;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoaDon, "MAKHO", true));
            this.txtMaKho.Location = new System.Drawing.Point(135, 187);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(100, 28);
            this.txtMaKho.TabIndex = 7;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoaDon, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(135, 141);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 28);
            this.txtMaNV.TabIndex = 5;
            // 
            // deNgayLap
            // 
            this.deNgayLap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHoaDon, "NGAYLAP", true));
            this.deNgayLap.EditValue = null;
            this.deNgayLap.Enabled = false;
            this.deNgayLap.Location = new System.Drawing.Point(135, 63);
            this.deNgayLap.MenuManager = this.barManager1;
            this.deNgayLap.Name = "deNgayLap";
            this.deNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayLap.Size = new System.Drawing.Size(125, 26);
            this.deNgayLap.TabIndex = 3;
            // 
            // txtMaHD
            // 
            this.txtMaHD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoaDon, "MAHD", true));
            this.txtMaHD.Location = new System.Drawing.Point(135, 26);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 28);
            this.txtMaHD.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelCTHD);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 26);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(912, 297);
            this.panelControl3.TabIndex = 1;
            // 
            // panelCTHD
            // 
            this.panelCTHD.Controls.Add(dONGIALabel);
            this.panelCTHD.Controls.Add(this.txtDonGia);
            this.panelCTHD.Controls.Add(this.cmbVatTu);
            this.panelCTHD.Controls.Add(sOLUONGLabel);
            this.panelCTHD.Controls.Add(this.txtSoLuong);
            this.panelCTHD.Controls.Add(mAVTLabel);
            this.panelCTHD.Controls.Add(this.txtMaVT);
            this.panelCTHD.Location = new System.Drawing.Point(592, 0);
            this.panelCTHD.Name = "panelCTHD";
            this.panelCTHD.Size = new System.Drawing.Size(322, 299);
            this.panelCTHD.TabIndex = 6;
            this.panelCTHD.Text = "Thông tin chi tiết đơn đặt hàng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDonGia.Location = new System.Drawing.Point(120, 185);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGia.Size = new System.Drawing.Size(125, 26);
            this.txtDonGia.TabIndex = 7;
            // 
            // cmbVatTu
            // 
            this.cmbVatTu.DataSource = this.bdsVatTu;
            this.cmbVatTu.DisplayMember = "TENVT";
            this.cmbVatTu.FormattingEnabled = true;
            this.cmbVatTu.Location = new System.Drawing.Point(98, 86);
            this.cmbVatTu.Name = "cmbVatTu";
            this.cmbVatTu.Size = new System.Drawing.Size(122, 28);
            this.cmbVatTu.TabIndex = 6;
            this.cmbVatTu.ValueMember = "MAVT";
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "VATTU";
            this.bdsVatTu.DataSource = this.dataSet;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTHD, "SOLUONG", true));
            this.txtSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuong.Location = new System.Drawing.Point(120, 153);
            this.txtSoLuong.MenuManager = this.barManager1;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Size = new System.Drawing.Size(125, 26);
            this.txtSoLuong.TabIndex = 3;
            // 
            // bdsCTHD
            // 
            this.bdsCTHD.DataMember = "FK_CTHD_HOADON";
            this.bdsCTHD.DataSource = this.bdsHoaDon;
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTHD, "MAVT", true));
            this.txtMaVT.Location = new System.Drawing.Point(98, 29);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(100, 28);
            this.txtMaVT.TabIndex = 1;
            // 
            // KHACHHANGTableAdapter
            // 
            this.KHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // VATTUTableAdapter
            // 
            this.VATTUTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1268, 51);
            this.panelControl1.TabIndex = 13;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(463, 11);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(323, 28);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // gcHoaDon
            // 
            this.gcHoaDon.DataSource = this.bdsHoaDon;
            this.gcHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHoaDon.Location = new System.Drawing.Point(0, 85);
            this.gcHoaDon.MainView = this.gridView1;
            this.gcHoaDon.MenuManager = this.barManager1;
            this.gcHoaDon.Name = "gcHoaDon";
            this.gcHoaDon.Size = new System.Drawing.Size(1268, 357);
            this.gcHoaDon.TabIndex = 14;
            this.gcHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHD,
            this.colNGAYLAP,
            this.colMANV,
            this.colMAKHO,
            this.colMAKH});
            this.gridView1.GridControl = this.gcHoaDon;
            this.gridView1.Name = "gridView1";
            // 
            // colMAHD
            // 
            this.colMAHD.Caption = "Mã hóa đơn";
            this.colMAHD.FieldName = "MAHD";
            this.colMAHD.MinWidth = 25;
            this.colMAHD.Name = "colMAHD";
            this.colMAHD.OptionsColumn.AllowEdit = false;
            this.colMAHD.Visible = true;
            this.colMAHD.VisibleIndex = 0;
            this.colMAHD.Width = 94;
            // 
            // colNGAYLAP
            // 
            this.colNGAYLAP.Caption = "Ngày lập";
            this.colNGAYLAP.FieldName = "NGAYLAP";
            this.colNGAYLAP.MinWidth = 25;
            this.colNGAYLAP.Name = "colNGAYLAP";
            this.colNGAYLAP.OptionsColumn.AllowEdit = false;
            this.colNGAYLAP.Visible = true;
            this.colNGAYLAP.VisibleIndex = 1;
            this.colNGAYLAP.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 2;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 3;
            this.colMAKHO.Width = 94;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã khách hàng";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 4;
            this.colMAKH.Width = 94;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHD1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.gcCTHD;
            this.gridView2.Name = "gridView2";
            // 
            // colMAHD1
            // 
            this.colMAHD1.Caption = "Mã hóa đơn";
            this.colMAHD1.FieldName = "MAHD";
            this.colMAHD1.MinWidth = 25;
            this.colMAHD1.Name = "colMAHD1";
            this.colMAHD1.OptionsColumn.AllowEdit = false;
            this.colMAHD1.Visible = true;
            this.colMAHD1.VisibleIndex = 0;
            this.colMAHD1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // gcCTHD
            // 
            this.gcCTHD.DataSource = this.bdsCTHD;
            this.gcCTHD.Location = new System.Drawing.Point(916, 441);
            this.gcCTHD.MainView = this.gridView2;
            this.gcCTHD.MenuManager = this.barManager1;
            this.gcCTHD.Name = "gcCTHD";
            this.gcCTHD.Size = new System.Drawing.Size(519, 325);
            this.gcCTHD.TabIndex = 0;
            this.gcCTHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 747);
            this.Controls.Add(this.gcCTHD);
            this.Controls.Add(this.gcHoaDon);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDon";
            this.Text = "HOÁ ĐƠN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelHD)).EndInit();
            this.panelHD.ResumeLayout(false);
            this.panelHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCTHD)).EndInit();
            this.panelCTHD.ResumeLayout(false);
            this.panelCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        private DevExpress.XtraBars.BarButtonItem btnHOANTAC;
        private DevExpress.XtraBars.BarButtonItem btnEXIT;
        private DevExpress.XtraBars.BarSubItem btnMenu;
        private DevExpress.XtraBars.BarButtonItem btnCheDoDDH;
        private DevExpress.XtraBars.BarButtonItem btnCheDoCTDDH;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsHoaDon;
        private QLVT_NHAPXUATDataSet dataSet;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private QLVT_NHAPXUATDataSetTableAdapters.HOADONTableAdapter HOADONTableAdapter;
        private QLVT_NHAPXUATDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl panelNhapLieu;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private QLVT_NHAPXUATDataSetTableAdapters.CTHDTableAdapter CTHDTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTHD;
        private QLVT_NHAPXUATDataSetTableAdapters.KHOTableAdapter KHOTableAdapter;
        private System.Windows.Forms.BindingSource bdsKho;
        private System.Windows.Forms.BindingSource bdsKhachHang;
        private QLVT_NHAPXUATDataSetTableAdapters.KHACHHANGTableAdapter KHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private QLVT_NHAPXUATDataSetTableAdapters.VATTUTableAdapter VATTUTableAdapter;
        private DevExpress.XtraGrid.GridControl gcHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAP;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl panelCTHD;
        private DevExpress.XtraEditors.SpinEdit txtDonGia;
        private System.Windows.Forms.ComboBox cmbVatTu;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private System.Windows.Forms.TextBox txtMaVT;
        private DevExpress.XtraEditors.GroupControl panelHD;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.ComboBox cmbKho;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.TextBox txtMaNV;
        private DevExpress.XtraEditors.DateEdit deNgayLap;
        private System.Windows.Forms.TextBox txtMaHD;
        private DevExpress.XtraGrid.GridControl gcCTHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHD1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
    }
}