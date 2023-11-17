namespace QLVT.MenuForm
{
    partial class FormTaoTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoTaiKhoan));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnChonNV = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbChiNhanh = new System.Windows.Forms.CheckBox();
            this.cbUser = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO TÀI KHOẢN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(401, 91);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(55, 22);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(401, 194);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(275, 22);
            this.txtPass.TabIndex = 8;
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(401, 263);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(275, 22);
            this.txtPass2.TabIndex = 9;
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = false;
            this.bunifuButton2.AutoSizeLeftIcon = true;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "XÁC NHẬN";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges1;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 25;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.IdleBorderRadius = 1;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(275, 383);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 1;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.BorderRadius = 1;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.onHoverState.IconLeftImage = null;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.OnIdleState.BorderRadius = 1;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnIdleState.IconLeftImage = null;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.BorderRadius = 1;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.IconLeftImage = null;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(213, 39);
            this.bunifuButton2.TabIndex = 6;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnChonNV
            // 
            this.btnChonNV.AllowAnimations = true;
            this.btnChonNV.AllowMouseEffects = true;
            this.btnChonNV.AllowToggling = false;
            this.btnChonNV.AnimationSpeed = 200;
            this.btnChonNV.AutoGenerateColors = false;
            this.btnChonNV.AutoRoundBorders = false;
            this.btnChonNV.AutoSizeLeftIcon = true;
            this.btnChonNV.AutoSizeRightIcon = true;
            this.btnChonNV.BackColor = System.Drawing.Color.Transparent;
            this.btnChonNV.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnChonNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChonNV.BackgroundImage")));
            this.btnChonNV.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChonNV.ButtonText = "Chọn nhân viên";
            this.btnChonNV.ButtonTextMarginLeft = 0;
            this.btnChonNV.ColorContrastOnClick = 45;
            this.btnChonNV.ColorContrastOnHover = 45;
            this.btnChonNV.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnChonNV.CustomizableEdges = borderEdges2;
            this.btnChonNV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChonNV.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnChonNV.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnChonNV.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnChonNV.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnChonNV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonNV.ForeColor = System.Drawing.Color.White;
            this.btnChonNV.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonNV.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnChonNV.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnChonNV.IconMarginLeft = 11;
            this.btnChonNV.IconPadding = 10;
            this.btnChonNV.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChonNV.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnChonNV.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnChonNV.IconSize = 25;
            this.btnChonNV.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnChonNV.IdleBorderRadius = 1;
            this.btnChonNV.IdleBorderThickness = 1;
            this.btnChonNV.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnChonNV.IdleIconLeftImage = null;
            this.btnChonNV.IdleIconRightImage = null;
            this.btnChonNV.IndicateFocus = false;
            this.btnChonNV.Location = new System.Drawing.Point(478, 74);
            this.btnChonNV.Name = "btnChonNV";
            this.btnChonNV.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnChonNV.OnDisabledState.BorderRadius = 1;
            this.btnChonNV.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChonNV.OnDisabledState.BorderThickness = 1;
            this.btnChonNV.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnChonNV.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnChonNV.OnDisabledState.IconLeftImage = null;
            this.btnChonNV.OnDisabledState.IconRightImage = null;
            this.btnChonNV.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnChonNV.onHoverState.BorderRadius = 1;
            this.btnChonNV.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChonNV.onHoverState.BorderThickness = 1;
            this.btnChonNV.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnChonNV.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnChonNV.onHoverState.IconLeftImage = null;
            this.btnChonNV.onHoverState.IconRightImage = null;
            this.btnChonNV.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnChonNV.OnIdleState.BorderRadius = 1;
            this.btnChonNV.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChonNV.OnIdleState.BorderThickness = 1;
            this.btnChonNV.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnChonNV.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnChonNV.OnIdleState.IconLeftImage = null;
            this.btnChonNV.OnIdleState.IconRightImage = null;
            this.btnChonNV.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnChonNV.OnPressedState.BorderRadius = 1;
            this.btnChonNV.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChonNV.OnPressedState.BorderThickness = 1;
            this.btnChonNV.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnChonNV.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnChonNV.OnPressedState.IconLeftImage = null;
            this.btnChonNV.OnPressedState.IconRightImage = null;
            this.btnChonNV.Size = new System.Drawing.Size(198, 39);
            this.btnChonNV.TabIndex = 3;
            this.btnChonNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChonNV.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChonNV.TextMarginLeft = 0;
            this.btnChonNV.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnChonNV.UseDefaultRadiusAndThickness = true;
            this.btnChonNV.Click += new System.EventHandler(this.btnChonNV_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tài khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(401, 136);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(275, 22);
            this.txtTaiKhoan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Loại tài khoàn";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.AutoSize = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(401, 324);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(87, 20);
            this.cbChiNhanh.TabIndex = 13;
            this.cbChiNhanh.Text = "Chi nhánh";
            this.cbChiNhanh.UseVisualStyleBackColor = true;
            // 
            // cbUser
            // 
            this.cbUser.AutoSize = true;
            this.cbUser.Location = new System.Drawing.Point(618, 324);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(58, 20);
            this.cbUser.TabIndex = 14;
            this.cbUser.Text = "User";
            this.cbUser.UseVisualStyleBackColor = true;
            // 
            // FormTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChonNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTaoTaiKhoan";
            this.Text = "TẠO TÀI KHOẢN";
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnChonNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbChiNhanh;
        private System.Windows.Forms.CheckBox cbUser;
    }
}