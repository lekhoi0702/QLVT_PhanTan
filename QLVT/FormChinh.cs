﻿using DevExpress.XtraBars;
using QLVT.ReportForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        public void enableButtons()
        {

            

            pageQuanLyThongTin.Visible = true;
            pageBaoCao.Visible = true;
            btnTaoTaiKhoan.Enabled = true;

            if (Program.role == "USER")
            {
                btnTaoTaiKhoan.Enabled = false;
            }

            //pageTaiKhoan.Visible = true;


        }

        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            logout();
            btnDangXuat.Enabled = false;

            pageQuanLyThongTin.Visible = false;
            pageBaoCao.Visible = false;
            //pageTaiKhoan.Visible = false;

            Form f = this.CheckExists(typeof(FormDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDangNhap form = new FormDangNhap();
                //form.MdiParent = this;
                form.Show();
            }

      /*      Program.formChinh.MaNhanVien.Text = "Mã Nhân Viên:";
            Program.formChinh.HoTen.Text = "Họ tên:";
            Program.formChinh.Nhom.Text = "Thuộc nhóm:";*/
        }


        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void FormChinh_Load(object sender, EventArgs e)


        {
            enableButtons();
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormNhanVien form = new FormNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            logout();

          

            Form f = this.CheckExists(typeof(FormDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDangNhap form = new FormDangNhap();
                //form.MdiParent = this;
                form.Show();
                this.Hide();
            }

            
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormVatTu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormVatTu form = new FormVatTu();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }




        private void btnLoaiVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(SubForm.FormLoaiVatTu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
               SubForm. FormLoaiVatTu form = new SubForm.FormLoaiVatTu();
                form.MdiParent = this;
                form.Show();
            }
        }


        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormKho));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormKho form = new FormKho();
                form.MdiParent = this;
                form.Show();
            }
        }


        private void btnDDH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDDH));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDDH form = new FormDDH();
                form.MdiParent = this;
                form.Show();
            }
        }


        private void btnHD_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormHoaDon));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormHoaDon form = new FormHoaDon();
                form.MdiParent = this;
                form.Show();
            }
        }


        private void btnPhieuNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormPhieuNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormPhieuNhap form = new FormPhieuNhap();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDSNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(ReportForm.FormDanhSachNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDanhSachNhanVien form = new FormDanhSachNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }


        private void btnDSDDHKhongPhieuNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDanhSachDDHKhongPhieuNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDanhSachDDHKhongPhieuNhap form = new FormDanhSachDDHKhongPhieuNhap();
                form.MdiParent = this;
                form.Show();
            }
        }
        private void btnDMVT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDanhMucVatTu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDanhMucVatTu form = new FormDanhMucVatTu();
                form.MdiParent = this;
                form.Show();
            }
        }


        private void btnTinhHinhHoatDongNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTinhHinhHoatDongNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTinhHinhHoatDongNhanVien form = new FormTinhHinhHoatDongNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }


        private void btnTongHopNhapXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormTongHopNhapXuat f = new FormTongHopNhapXuat();
            f.Show();
        }
    }
}
