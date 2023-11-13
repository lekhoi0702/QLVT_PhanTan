namespace QLVT.ReportForm
{
    partial class FormTongHopNhapXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTongHopNhapXuat));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.deNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.txtXuatBaoCao = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnXemTruoc = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Từ ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "TỔNG HỢP NHẬP XUẤT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deNgayKetThuc
            // 
            this.deNgayKetThuc.EditValue = null;
            this.deNgayKetThuc.Location = new System.Drawing.Point(522, 113);
            this.deNgayKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.deNgayKetThuc.Name = "deNgayKetThuc";
            this.deNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKetThuc.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.deNgayKetThuc.Properties.UseMaskAsDisplayFormat = true;
            this.deNgayKetThuc.Size = new System.Drawing.Size(209, 26);
            this.deNgayKetThuc.TabIndex = 13;
            // 
            // deNgayBatDau
            // 
            this.deNgayBatDau.EditValue = null;
            this.deNgayBatDau.Location = new System.Drawing.Point(162, 113);
            this.deNgayBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.deNgayBatDau.Name = "deNgayBatDau";
            this.deNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBatDau.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.deNgayBatDau.Properties.UseMaskAsDisplayFormat = true;
            this.deNgayBatDau.Size = new System.Drawing.Size(189, 26);
            this.deNgayBatDau.TabIndex = 11;
            // 
            // txtXuatBaoCao
            // 
            this.txtXuatBaoCao.AllowAnimations = true;
            this.txtXuatBaoCao.AllowMouseEffects = true;
            this.txtXuatBaoCao.AllowToggling = false;
            this.txtXuatBaoCao.AnimationSpeed = 200;
            this.txtXuatBaoCao.AutoGenerateColors = false;
            this.txtXuatBaoCao.AutoRoundBorders = false;
            this.txtXuatBaoCao.AutoSizeLeftIcon = true;
            this.txtXuatBaoCao.AutoSizeRightIcon = true;
            this.txtXuatBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.txtXuatBaoCao.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.txtXuatBaoCao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtXuatBaoCao.BackgroundImage")));
            this.txtXuatBaoCao.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.txtXuatBaoCao.ButtonText = "XUẤT BÁO CÁO";
            this.txtXuatBaoCao.ButtonTextMarginLeft = 0;
            this.txtXuatBaoCao.ColorContrastOnClick = 45;
            this.txtXuatBaoCao.ColorContrastOnHover = 45;
            this.txtXuatBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.txtXuatBaoCao.CustomizableEdges = borderEdges9;
            this.txtXuatBaoCao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtXuatBaoCao.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtXuatBaoCao.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtXuatBaoCao.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.txtXuatBaoCao.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.txtXuatBaoCao.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXuatBaoCao.ForeColor = System.Drawing.Color.White;
            this.txtXuatBaoCao.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtXuatBaoCao.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtXuatBaoCao.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.txtXuatBaoCao.IconMarginLeft = 11;
            this.txtXuatBaoCao.IconPadding = 10;
            this.txtXuatBaoCao.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtXuatBaoCao.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtXuatBaoCao.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtXuatBaoCao.IconSize = 25;
            this.txtXuatBaoCao.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtXuatBaoCao.IdleBorderRadius = 10;
            this.txtXuatBaoCao.IdleBorderThickness = 1;
            this.txtXuatBaoCao.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.txtXuatBaoCao.IdleIconLeftImage = null;
            this.txtXuatBaoCao.IdleIconRightImage = null;
            this.txtXuatBaoCao.IndicateFocus = false;
            this.txtXuatBaoCao.Location = new System.Drawing.Point(522, 189);
            this.txtXuatBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.txtXuatBaoCao.Name = "txtXuatBaoCao";
            this.txtXuatBaoCao.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtXuatBaoCao.OnDisabledState.BorderRadius = 10;
            this.txtXuatBaoCao.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.txtXuatBaoCao.OnDisabledState.BorderThickness = 1;
            this.txtXuatBaoCao.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtXuatBaoCao.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.txtXuatBaoCao.OnDisabledState.IconLeftImage = null;
            this.txtXuatBaoCao.OnDisabledState.IconRightImage = null;
            this.txtXuatBaoCao.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtXuatBaoCao.onHoverState.BorderRadius = 10;
            this.txtXuatBaoCao.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.txtXuatBaoCao.onHoverState.BorderThickness = 1;
            this.txtXuatBaoCao.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtXuatBaoCao.onHoverState.ForeColor = System.Drawing.Color.White;
            this.txtXuatBaoCao.onHoverState.IconLeftImage = null;
            this.txtXuatBaoCao.onHoverState.IconRightImage = null;
            this.txtXuatBaoCao.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtXuatBaoCao.OnIdleState.BorderRadius = 10;
            this.txtXuatBaoCao.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.txtXuatBaoCao.OnIdleState.BorderThickness = 1;
            this.txtXuatBaoCao.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.txtXuatBaoCao.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.txtXuatBaoCao.OnIdleState.IconLeftImage = null;
            this.txtXuatBaoCao.OnIdleState.IconRightImage = null;
            this.txtXuatBaoCao.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtXuatBaoCao.OnPressedState.BorderRadius = 10;
            this.txtXuatBaoCao.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.txtXuatBaoCao.OnPressedState.BorderThickness = 1;
            this.txtXuatBaoCao.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtXuatBaoCao.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.txtXuatBaoCao.OnPressedState.IconLeftImage = null;
            this.txtXuatBaoCao.OnPressedState.IconRightImage = null;
            this.txtXuatBaoCao.Size = new System.Drawing.Size(209, 49);
            this.txtXuatBaoCao.TabIndex = 9;
            this.txtXuatBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtXuatBaoCao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtXuatBaoCao.TextMarginLeft = 0;
            this.txtXuatBaoCao.TextPadding = new System.Windows.Forms.Padding(0);
            this.txtXuatBaoCao.UseDefaultRadiusAndThickness = true;
            // 
            // btnXemTruoc
            // 
            this.btnXemTruoc.AllowAnimations = true;
            this.btnXemTruoc.AllowMouseEffects = true;
            this.btnXemTruoc.AllowToggling = false;
            this.btnXemTruoc.AnimationSpeed = 200;
            this.btnXemTruoc.AutoGenerateColors = false;
            this.btnXemTruoc.AutoRoundBorders = false;
            this.btnXemTruoc.AutoSizeLeftIcon = true;
            this.btnXemTruoc.AutoSizeRightIcon = true;
            this.btnXemTruoc.BackColor = System.Drawing.Color.Transparent;
            this.btnXemTruoc.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnXemTruoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemTruoc.BackgroundImage")));
            this.btnXemTruoc.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXemTruoc.ButtonText = "XEM TRƯỚC";
            this.btnXemTruoc.ButtonTextMarginLeft = 0;
            this.btnXemTruoc.ColorContrastOnClick = 45;
            this.btnXemTruoc.ColorContrastOnHover = 45;
            this.btnXemTruoc.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnXemTruoc.CustomizableEdges = borderEdges10;
            this.btnXemTruoc.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXemTruoc.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXemTruoc.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXemTruoc.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXemTruoc.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXemTruoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTruoc.ForeColor = System.Drawing.Color.White;
            this.btnXemTruoc.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemTruoc.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXemTruoc.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXemTruoc.IconMarginLeft = 11;
            this.btnXemTruoc.IconPadding = 10;
            this.btnXemTruoc.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemTruoc.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXemTruoc.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXemTruoc.IconSize = 25;
            this.btnXemTruoc.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXemTruoc.IdleBorderRadius = 10;
            this.btnXemTruoc.IdleBorderThickness = 1;
            this.btnXemTruoc.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnXemTruoc.IdleIconLeftImage = null;
            this.btnXemTruoc.IdleIconRightImage = null;
            this.btnXemTruoc.IndicateFocus = false;
            this.btnXemTruoc.Location = new System.Drawing.Point(162, 189);
            this.btnXemTruoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemTruoc.Name = "btnXemTruoc";
            this.btnXemTruoc.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXemTruoc.OnDisabledState.BorderRadius = 10;
            this.btnXemTruoc.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXemTruoc.OnDisabledState.BorderThickness = 1;
            this.btnXemTruoc.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXemTruoc.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXemTruoc.OnDisabledState.IconLeftImage = null;
            this.btnXemTruoc.OnDisabledState.IconRightImage = null;
            this.btnXemTruoc.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXemTruoc.onHoverState.BorderRadius = 10;
            this.btnXemTruoc.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXemTruoc.onHoverState.BorderThickness = 1;
            this.btnXemTruoc.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXemTruoc.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXemTruoc.onHoverState.IconLeftImage = null;
            this.btnXemTruoc.onHoverState.IconRightImage = null;
            this.btnXemTruoc.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXemTruoc.OnIdleState.BorderRadius = 10;
            this.btnXemTruoc.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXemTruoc.OnIdleState.BorderThickness = 1;
            this.btnXemTruoc.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnXemTruoc.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXemTruoc.OnIdleState.IconLeftImage = null;
            this.btnXemTruoc.OnIdleState.IconRightImage = null;
            this.btnXemTruoc.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXemTruoc.OnPressedState.BorderRadius = 10;
            this.btnXemTruoc.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXemTruoc.OnPressedState.BorderThickness = 1;
            this.btnXemTruoc.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXemTruoc.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXemTruoc.OnPressedState.IconLeftImage = null;
            this.btnXemTruoc.OnPressedState.IconRightImage = null;
            this.btnXemTruoc.Size = new System.Drawing.Size(189, 49);
            this.btnXemTruoc.TabIndex = 8;
            this.btnXemTruoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemTruoc.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXemTruoc.TextMarginLeft = 0;
            this.btnXemTruoc.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXemTruoc.UseDefaultRadiusAndThickness = true;
            this.btnXemTruoc.Click += new System.EventHandler(this.btnXemTruoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chi nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Enabled = false;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(358, 53);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(241, 28);
            this.cmbChiNhanh.TabIndex = 15;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // FormTongHopNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 262);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deNgayKetThuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deNgayBatDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXuatBaoCao);
            this.Controls.Add(this.btnXemTruoc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTongHopNhapXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TỔNG HỢP NHẬP XUẤT";
            this.Load += new System.EventHandler(this.FormTongHopNhapXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit deNgayKetThuc;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit deNgayBatDau;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton txtXuatBaoCao;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXemTruoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
    }
}