namespace QLVT
{
    partial class FormVatTu
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
            System.Windows.Forms.Label txtSLT;
            System.Windows.Forms.Label txtMaLVT;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVatTu));
            this.dataSet = new QLVT.QLVT_NHAPXUATDataSet();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.VATTUTableAdapter = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.VATTUTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.TableAdapterManager();
            this.CTDDHTableAdapter = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.CTDDHTableAdapter();
            this.CTHDTableAdapter = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.CTHDTableAdapter();
            this.CTPNTableAdapter = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.CTPNTableAdapter();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTHD = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.gcVatTu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieu = new DevExpress.XtraEditors.GroupControl();
            this.cmbLoaiVT = new System.Windows.Forms.ComboBox();
            this.bdsLoaiVT = new System.Windows.Forms.BindingSource(this.components);
            this.spSTL = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaLoaiVatTu = new System.Windows.Forms.TextBox();
            this.txtDVT = new DevExpress.XtraEditors.TextEdit();
            this.txtTenVT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.LOAIVATTUTableAdapter = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.LOAIVATTUTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fKVATTULOAIVATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            txtSLT = new System.Windows.Forms.Label();
            txtMaLVT = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVT.Properties)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKVATTULOAIVATTUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSLT
            // 
            txtSLT.AutoSize = true;
            txtSLT.Location = new System.Drawing.Point(255, 40);
            txtSLT.Name = "txtSLT";
            txtSLT.Size = new System.Drawing.Size(102, 20);
            txtSLT.TabIndex = 8;
            txtSLT.Text = "Số lượng tồn";
            // 
            // txtMaLVT
            // 
            txtMaLVT.AutoSize = true;
            txtMaLVT.Location = new System.Drawing.Point(255, 83);
            txtMaLVT.Name = "txtMaLVT";
            txtMaLVT.Size = new System.Drawing.Size(110, 20);
            txtMaLVT.TabIndex = 6;
            txtMaLVT.Text = "Mã loại vật tư";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(12, 132);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(92, 20);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn vị tính";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(12, 83);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(85, 20);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên vật tư";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(12, 40);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(80, 20);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã vật tư";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "QLVT_NHAPXUATDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "VATTU";
            this.bdsVatTu.DataSource = this.dataSet;
            // 
            // VATTUTableAdapter
            // 
            this.VATTUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = this.CTDDHTableAdapter;
            this.tableAdapterManager.CTHDTableAdapter = this.CTHDTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = this.CTPNTableAdapter;
            this.tableAdapterManager.DDHTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIVATTUTableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_NHAPXUATDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = this.VATTUTableAdapter;
            // 
            // CTDDHTableAdapter
            // 
            this.CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // CTHDTableAdapter
            // 
            this.CTHDTableAdapter.ClearBeforeFill = true;
            // 
            // CTPNTableAdapter
            // 
            this.CTPNTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_VATTU";
            this.bdsCTDDH.DataSource = this.bdsVatTu;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_VATTU";
            this.bdsCTPN.DataSource = this.bdsVatTu;
            // 
            // bdsCTHD
            // 
            this.bdsCTHD.DataMember = "FK_CTHD_VATTU";
            this.bdsCTHD.DataSource = this.bdsVatTu;
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
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLamMoi,
            this.btnHoanTac,
            this.btnChuyenChiNhanh,
            this.btnThoat,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 1;
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Ghi";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 3;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_ItemClick);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn tác";
            this.btnHoanTac.Id = 4;
            this.btnHoanTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.Image")));
            this.btnHoanTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.LargeImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHOANTAC_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thoát";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1113, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 567);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1113, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 533);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1113, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 533);
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
            // gcVatTu
            // 
            this.gcVatTu.DataSource = this.bdsVatTu;
            this.gcVatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcVatTu.Location = new System.Drawing.Point(0, 34);
            this.gcVatTu.MainView = this.gridView1;
            this.gcVatTu.Name = "gcVatTu";
            this.gcVatTu.Size = new System.Drawing.Size(1113, 220);
            this.gcVatTu.TabIndex = 20;
            this.gcVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colMALVT,
            this.colSLT});
            this.gridView1.GridControl = this.gcVatTu;
            this.gridView1.Name = "gridView1";
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 94;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 25;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 94;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 25;
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 94;
            // 
            // colMALVT
            // 
            this.colMALVT.Caption = "Mã loại vật tư";
            this.colMALVT.FieldName = "MALVT";
            this.colMALVT.MinWidth = 25;
            this.colMALVT.Name = "colMALVT";
            this.colMALVT.OptionsColumn.AllowEdit = false;
            this.colMALVT.Visible = true;
            this.colMALVT.VisibleIndex = 3;
            this.colMALVT.Width = 94;
            // 
            // colSLT
            // 
            this.colSLT.Caption = "Số lượng tồn";
            this.colSLT.FieldName = "SLT";
            this.colSLT.MinWidth = 25;
            this.colSLT.Name = "colSLT";
            this.colSLT.OptionsColumn.AllowEdit = false;
            this.colSLT.Visible = true;
            this.colSLT.VisibleIndex = 4;
            this.colSLT.Width = 94;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(this.cmbLoaiVT);
            this.panelNhapLieu.Controls.Add(txtSLT);
            this.panelNhapLieu.Controls.Add(this.spSTL);
            this.panelNhapLieu.Controls.Add(txtMaLVT);
            this.panelNhapLieu.Controls.Add(this.txtMaLoaiVatTu);
            this.panelNhapLieu.Controls.Add(dVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtDVT);
            this.panelNhapLieu.Controls.Add(tENVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtTenVT);
            this.panelNhapLieu.Controls.Add(mAVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaVT);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 254);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(1113, 313);
            this.panelNhapLieu.TabIndex = 21;
            this.panelNhapLieu.Text = "Thông tin nhập liệu";
            // 
            // cmbLoaiVT
            // 
            this.cmbLoaiVT.DataSource = this.bdsLoaiVT;
            this.cmbLoaiVT.DisplayMember = "TENLVT";
            this.cmbLoaiVT.FormattingEnabled = true;
            this.cmbLoaiVT.Location = new System.Drawing.Point(371, 127);
            this.cmbLoaiVT.Name = "cmbLoaiVT";
            this.cmbLoaiVT.Size = new System.Drawing.Size(100, 28);
            this.cmbLoaiVT.TabIndex = 10;
            this.cmbLoaiVT.ValueMember = "MALVT";
            // 
            // bdsLoaiVT
            // 
            this.bdsLoaiVT.DataMember = "LOAIVATTU";
            this.bdsLoaiVT.DataSource = this.dataSet;
            // 
            // spSTL
            // 
            this.spSTL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "SLT", true));
            this.spSTL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSTL.Location = new System.Drawing.Point(371, 37);
            this.spSTL.Name = "spSTL";
            this.spSTL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSTL.Size = new System.Drawing.Size(100, 26);
            this.spSTL.TabIndex = 9;
            // 
            // txtMaLoaiVatTu
            // 
            this.txtMaLoaiVatTu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "MALVT", true));
            this.txtMaLoaiVatTu.Location = new System.Drawing.Point(371, 78);
            this.txtMaLoaiVatTu.Name = "txtMaLoaiVatTu";
            this.txtMaLoaiVatTu.Size = new System.Drawing.Size(100, 28);
            this.txtMaLoaiVatTu.TabIndex = 7;
            // 
            // txtDVT
            // 
            this.txtDVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "DVT", true));
            this.txtDVT.Location = new System.Drawing.Point(103, 129);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(125, 26);
            this.txtDVT.TabIndex = 5;
            // 
            // txtTenVT
            // 
            this.txtTenVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "TENVT", true));
            this.txtTenVT.Location = new System.Drawing.Point(103, 80);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(125, 26);
            this.txtTenVT.TabIndex = 3;
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "MAVT", true));
            this.txtMaVT.Location = new System.Drawing.Point(103, 35);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(125, 28);
            this.txtMaVT.TabIndex = 1;
            // 
            // LOAIVATTUTableAdapter
            // 
            this.LOAIVATTUTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 254);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1113, 27);
            this.fillByToolStrip.TabIndex = 26;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fKVATTULOAIVATTUBindingSource
            // 
            this.fKVATTULOAIVATTUBindingSource.DataMember = "FK_VATTU_LOAIVATTU";
            this.fKVATTULOAIVATTUBindingSource.DataSource = this.bdsLoaiVT;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 589);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcVatTu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVatTu";
            this.Text = "FormVatTu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVT.Properties)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKVATTULOAIVATTUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsVatTu;
        private QLVT_NHAPXUATDataSet dataSet;
        private QLVT_NHAPXUATDataSetTableAdapters.VATTUTableAdapter VATTUTableAdapter;
        private QLVT_NHAPXUATDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVT_NHAPXUATDataSetTableAdapters.CTDDHTableAdapter CTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private QLVT_NHAPXUATDataSetTableAdapters.CTPNTableAdapter CTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private QLVT_NHAPXUATDataSetTableAdapters.CTHDTableAdapter CTHDTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTHD;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl panelNhapLieu;
        private DevExpress.XtraEditors.SpinEdit spSTL;
        private System.Windows.Forms.TextBox txtMaLoaiVatTu;
        private DevExpress.XtraEditors.TextEdit txtDVT;
        private DevExpress.XtraEditors.TextEdit txtTenVT;
        private System.Windows.Forms.TextBox txtMaVT;
        private DevExpress.XtraGrid.GridControl gcVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colMALVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSLT;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsLoaiVT;
        private QLVT_NHAPXUATDataSetTableAdapters.LOAIVATTUTableAdapter LOAIVATTUTableAdapter;
        private System.Windows.Forms.ComboBox cmbLoaiVT;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource fKVATTULOAIVATTUBindingSource;
    }
}