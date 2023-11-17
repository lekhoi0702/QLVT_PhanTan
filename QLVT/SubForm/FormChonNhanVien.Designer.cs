namespace QLVT.SubForm
{
    partial class FormChonNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChonNhanVien));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dataSet = new QLVT.QLVT_NHAPXUATDataSet();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.NHANVIENTableAdapter = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.TableAdapterManager();
            this.btnXacNhan = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnThoat = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAIXOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "QLVT_NHAPXUATDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NHANVIEN";
            this.bdsNhanVien.DataSource = this.dataSet;
            // 
            // NHANVIENTableAdapter
            // 
            this.NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTHDTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.DDHTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIVATTUTableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.NHANVIENTableAdapter;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_NHAPXUATDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // btnXacNhan
            // 
            resources.ApplyResources(this.btnXacNhan, "btnXacNhan");
            this.btnXacNhan.AllowAnimations = true;
            this.btnXacNhan.AllowMouseEffects = true;
            this.btnXacNhan.AllowToggling = false;
            this.btnXacNhan.AnimationSpeed = 200;
            this.btnXacNhan.AutoGenerateColors = false;
            this.btnXacNhan.AutoRoundBorders = false;
            this.btnXacNhan.AutoSizeLeftIcon = true;
            this.btnXacNhan.AutoSizeRightIcon = true;
            this.btnXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.ButtonText = "XÁC NHẬN";
            this.btnXacNhan.ButtonTextMarginLeft = 0;
            this.btnXacNhan.ColorContrastOnClick = 45;
            this.btnXacNhan.ColorContrastOnHover = 45;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnXacNhan.CustomizableEdges = borderEdges7;
            this.btnXacNhan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXacNhan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXacNhan.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXacNhan.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXacNhan.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXacNhan.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXacNhan.IconMarginLeft = 11;
            this.btnXacNhan.IconPadding = 10;
            this.btnXacNhan.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXacNhan.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXacNhan.IconSize = 25;
            this.btnXacNhan.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.IdleBorderRadius = 1;
            this.btnXacNhan.IdleBorderThickness = 1;
            this.btnXacNhan.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.IdleIconLeftImage = null;
            this.btnXacNhan.IdleIconRightImage = null;
            this.btnXacNhan.IndicateFocus = false;
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXacNhan.OnDisabledState.BorderRadius = 1;
            this.btnXacNhan.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.OnDisabledState.BorderThickness = 1;
            this.btnXacNhan.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXacNhan.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXacNhan.OnDisabledState.IconLeftImage = null;
            this.btnXacNhan.OnDisabledState.IconRightImage = null;
            this.btnXacNhan.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXacNhan.onHoverState.BorderRadius = 1;
            this.btnXacNhan.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.onHoverState.BorderThickness = 1;
            this.btnXacNhan.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXacNhan.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.onHoverState.IconLeftImage = null;
            this.btnXacNhan.onHoverState.IconRightImage = null;
            this.btnXacNhan.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.OnIdleState.BorderRadius = 1;
            this.btnXacNhan.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.OnIdleState.BorderThickness = 1;
            this.btnXacNhan.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.OnIdleState.IconLeftImage = null;
            this.btnXacNhan.OnIdleState.IconRightImage = null;
            this.btnXacNhan.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXacNhan.OnPressedState.BorderRadius = 1;
            this.btnXacNhan.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.OnPressedState.BorderThickness = 1;
            this.btnXacNhan.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXacNhan.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.OnPressedState.IconLeftImage = null;
            this.btnXacNhan.OnPressedState.IconRightImage = null;
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXacNhan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXacNhan.TextMarginLeft = 0;
            this.btnXacNhan.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXacNhan.UseDefaultRadiusAndThickness = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.AllowAnimations = true;
            this.btnThoat.AllowMouseEffects = true;
            this.btnThoat.AllowToggling = false;
            this.btnThoat.AnimationSpeed = 200;
            this.btnThoat.AutoGenerateColors = false;
            this.btnThoat.AutoRoundBorders = false;
            this.btnThoat.AutoSizeLeftIcon = true;
            this.btnThoat.AutoSizeRightIcon = true;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnThoat.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.ButtonText = "THOÁT";
            this.btnThoat.ButtonTextMarginLeft = 0;
            this.btnThoat.ColorContrastOnClick = 45;
            this.btnThoat.ColorContrastOnHover = 45;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnThoat.CustomizableEdges = borderEdges8;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThoat.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThoat.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThoat.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnThoat.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnThoat.IconMarginLeft = 11;
            this.btnThoat.IconPadding = 10;
            this.btnThoat.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnThoat.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnThoat.IconSize = 25;
            this.btnThoat.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.IdleBorderRadius = 1;
            this.btnThoat.IdleBorderThickness = 1;
            this.btnThoat.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.IdleIconLeftImage = null;
            this.btnThoat.IdleIconRightImage = null;
            this.btnThoat.IndicateFocus = false;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThoat.OnDisabledState.BorderRadius = 1;
            this.btnThoat.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.OnDisabledState.BorderThickness = 1;
            this.btnThoat.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThoat.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThoat.OnDisabledState.IconLeftImage = null;
            this.btnThoat.OnDisabledState.IconRightImage = null;
            this.btnThoat.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThoat.onHoverState.BorderRadius = 1;
            this.btnThoat.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.onHoverState.BorderThickness = 1;
            this.btnThoat.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThoat.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnThoat.onHoverState.IconLeftImage = null;
            this.btnThoat.onHoverState.IconRightImage = null;
            this.btnThoat.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.OnIdleState.BorderRadius = 1;
            this.btnThoat.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.OnIdleState.BorderThickness = 1;
            this.btnThoat.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnThoat.OnIdleState.IconLeftImage = null;
            this.btnThoat.OnIdleState.IconRightImage = null;
            this.btnThoat.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThoat.OnPressedState.BorderRadius = 1;
            this.btnThoat.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.OnPressedState.BorderThickness = 1;
            this.btnThoat.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThoat.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnThoat.OnPressedState.IconLeftImage = null;
            this.btnThoat.OnPressedState.IconRightImage = null;
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.TextMarginLeft = 0;
            this.btnThoat.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnThoat.UseDefaultRadiusAndThickness = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gcNhanVien
            // 
            resources.ApplyResources(this.gcNhanVien, "gcNhanVien");
            this.gcNhanVien.DataSource = this.bdsNhanVien;
            this.gcNhanVien.EmbeddedNavigator.AccessibleDescription = resources.GetString("gcNhanVien.EmbeddedNavigator.AccessibleDescription");
            this.gcNhanVien.EmbeddedNavigator.AccessibleName = resources.GetString("gcNhanVien.EmbeddedNavigator.AccessibleName");
            this.gcNhanVien.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gcNhanVien.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gcNhanVien.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gcNhanVien.EmbeddedNavigator.Anchor")));
            this.gcNhanVien.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gcNhanVien.EmbeddedNavigator.BackgroundImage")));
            this.gcNhanVien.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gcNhanVien.EmbeddedNavigator.BackgroundImageLayout")));
            this.gcNhanVien.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gcNhanVien.EmbeddedNavigator.ImeMode")));
            this.gcNhanVien.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gcNhanVien.EmbeddedNavigator.MaximumSize")));
            this.gcNhanVien.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gcNhanVien.EmbeddedNavigator.TextLocation")));
            this.gcNhanVien.EmbeddedNavigator.ToolTip = resources.GetString("gcNhanVien.EmbeddedNavigator.ToolTip");
            this.gcNhanVien.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gcNhanVien.EmbeddedNavigator.ToolTipIconType")));
            this.gcNhanVien.EmbeddedNavigator.ToolTipTitle = resources.GetString("gcNhanVien.EmbeddedNavigator.ToolTipTitle");
            this.gcNhanVien.MainView = this.gridView1;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colSDT,
            this.colMACN,
            this.colTRANGTHAIXOA});
            this.gridView1.GridControl = this.gcNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            resources.ApplyResources(this.colMANV, "colMANV");
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colHO
            // 
            resources.ApplyResources(this.colHO, "colHO");
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            // 
            // colTEN
            // 
            resources.ApplyResources(this.colTEN, "colTEN");
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            // 
            // colNGAYSINH
            // 
            resources.ApplyResources(this.colNGAYSINH, "colNGAYSINH");
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            // 
            // colDIACHI
            // 
            resources.ApplyResources(this.colDIACHI, "colDIACHI");
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            // 
            // colSDT
            // 
            resources.ApplyResources(this.colSDT, "colSDT");
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.AllowEdit = false;
            // 
            // colMACN
            // 
            resources.ApplyResources(this.colMACN, "colMACN");
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            // 
            // colTRANGTHAIXOA
            // 
            resources.ApplyResources(this.colTRANGTHAIXOA, "colTRANGTHAIXOA");
            this.colTRANGTHAIXOA.FieldName = "TRANGTHAIXOA";
            this.colTRANGTHAIXOA.MinWidth = 25;
            this.colTRANGTHAIXOA.Name = "colTRANGTHAIXOA";
            this.colTRANGTHAIXOA.OptionsColumn.AllowEdit = false;
            // 
            // cmbChiNhanh
            // 
            resources.ApplyResources(this.cmbChiNhanh, "cmbChiNhanh");
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FormChonNhanVien
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Name = "FormChonNhanVien";
            this.Load += new System.EventHandler(this.FormChonNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLVT_NHAPXUATDataSet dataSet;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private QLVT_NHAPXUATDataSetTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter;
        private QLVT_NHAPXUATDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXacNhan;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThoat;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAIXOA;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
    }
}