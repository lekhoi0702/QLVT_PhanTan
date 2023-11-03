namespace QLVT
{
    partial class FormChonDDH
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
            this.dataSet = new QLVT.QLVT_NHAPXUATDataSet();
            this.bdsDDH = new System.Windows.Forms.BindingSource(this.components);
            this.DDHTableAdapter = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.DDHTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_NHAPXUATDataSetTableAdapters.TableAdapterManager();
            this.dDHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "QLVT_NHAPXUATDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDDH
            // 
            this.bdsDDH.DataMember = "DDH";
            this.bdsDDH.DataSource = this.dataSet;
            // 
            // DDHTableAdapter
            // 
            this.DDHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTHDTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.DDHTableAdapter = this.DDHTableAdapter;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIVATTUTableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_NHAPXUATDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // dDHGridControl
            // 
            this.dDHGridControl.DataSource = this.bdsDDH;
            this.dDHGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dDHGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dDHGridControl.Location = new System.Drawing.Point(0, 0);
            this.dDHGridControl.MainView = this.gridView1;
            this.dDHGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dDHGridControl.Name = "dDHGridControl";
            this.dDHGridControl.Size = new System.Drawing.Size(704, 220);
            this.dDHGridControl.TabIndex = 1;
            this.dDHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADDH,
            this.colNGAYLAP,
            this.colMANCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.dDHGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMADDH
            // 
            this.colMADDH.Caption = "Mã đơn đặt hàng";
            this.colMADDH.FieldName = "MADDH";
            this.colMADDH.MinWidth = 25;
            this.colMADDH.Name = "colMADDH";
            this.colMADDH.OptionsColumn.AllowEdit = false;
            this.colMADDH.Visible = true;
            this.colMADDH.VisibleIndex = 0;
            this.colMADDH.Width = 93;
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
            this.colNGAYLAP.Width = 93;
            // 
            // colMANCC
            // 
            this.colMANCC.Caption = "Mã nhà cung cấp";
            this.colMANCC.FieldName = "MANCC";
            this.colMANCC.MinWidth = 25;
            this.colMANCC.Name = "colMANCC";
            this.colMANCC.OptionsColumn.AllowEdit = false;
            this.colMANCC.Visible = true;
            this.colMANCC.VisibleIndex = 2;
            this.colMANCC.Width = 93;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 93;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 93;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(117, 226);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(163, 62);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "CHỌN";
            this.simpleButton1.Click += new System.EventHandler(this.btnCHON_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(395, 226);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(163, 62);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "THOÁT";
            this.simpleButton2.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // FormChonDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 331);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dDHGridControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChonDDH";
            this.Text = "ĐƠN ĐẶT HÀNG";
            this.Load += new System.EventHandler(this.FormChonDDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLVT_NHAPXUATDataSet dataSet;
        private System.Windows.Forms.BindingSource bdsDDH;
        private QLVT_NHAPXUATDataSetTableAdapters.DDHTableAdapter DDHTableAdapter;
        private QLVT_NHAPXUATDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl dDHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAP;
        private DevExpress.XtraGrid.Columns.GridColumn colMANCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}