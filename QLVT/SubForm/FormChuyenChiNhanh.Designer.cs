namespace QLVT
{
    partial class FormChuyenChiNhanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnChonChiNanh = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYỂN CHI NHÁNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CHỌN CHI NHÁNH";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.BackColor = System.Drawing.Color.Transparent;
            this.cmbChiNhanh.BorderRadius = 10;
            this.cmbChiNhanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbChiNhanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbChiNhanh.ItemHeight = 30;
            this.cmbChiNhanh.Location = new System.Drawing.Point(359, 75);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(187, 36);
            this.cmbChiNhanh.TabIndex = 7;
            // 
            // btnChonChiNanh
            // 
            this.btnChonChiNanh.BorderRadius = 20;
            this.btnChonChiNanh.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnChonChiNanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonChiNanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonChiNanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonChiNanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonChiNanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnChonChiNanh.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnChonChiNanh.ForeColor = System.Drawing.Color.White;
            this.btnChonChiNanh.Location = new System.Drawing.Point(229, 137);
            this.btnChonChiNanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonChiNanh.Name = "btnChonChiNanh";
            this.btnChonChiNanh.Size = new System.Drawing.Size(187, 56);
            this.btnChonChiNanh.TabIndex = 9;
            this.btnChonChiNanh.Text = "XÁC NHẬN";
            this.btnChonChiNanh.Click += new System.EventHandler(this.btnXACNHAN_Click);
            // 
            // FormChuyenChiNhanh
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 206);
            this.Controls.Add(this.btnChonChiNanh);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IconOptions.Image = global::QLVT.Properties.Resources.logo;
            this.Name = "FormChuyenChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHUYỂN CHI NHÁNH";
            this.Load += new System.EventHandler(this.FormChuyenChiNhanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbChiNhanh;
        private Guna.UI2.WinForms.Guna2Button btnChonChiNanh;
    }
}