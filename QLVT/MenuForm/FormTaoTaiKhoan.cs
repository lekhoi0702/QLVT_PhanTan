using QLVT.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.MenuForm
{
    public partial class FormTaoTaiKhoan : Form
    {
       
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChonNV_Click(object sender, EventArgs e)
        {
            FormChonNhanVien form = new FormChonNhanVien();
            form.ShowDialog();
            txtMaNV.Text = Program.manvDuocChon.ToString().Trim();
        }

        private bool kiemTraDuLieuDauVao()
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Thiếu mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtPass.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtPass2.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtPass.Text != txtPass2.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Thiếu tài khoản", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            String taikhoan = txtTaiKhoan.Text.Trim();  
            String matKhau = txtPass.Text;
            String maNhanVien = Program.manvDuocChon.ToString().Trim();
            String vaiTro = "";
            if (Program.role == "CONGTY")
            {
                vaiTro = "CONGTY";
            }
            else {
                vaiTro = (cbChiNhanh.Checked == true) ? "CHINHANH" : "USER";
            }
             

           
            String cauTruyVan =
                    "EXEC sp_TaoTaiKhoan '" + taikhoan + "' , '" + matKhau + "', '"
                    + maNhanVien + "', '" + vaiTro + "'";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {


                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
          
                if (Program.myReader == null)
                {
                    return;
                }

                MessageBox.Show("Đăng kí tài khoản thành công\n\nTài khoản: " + taikhoan + "\nMật khẩu: " + matKhau + "\n Mã Nhân Viên: " + maNhanVien + "\n Vai Trò: " + vaiTro, "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            cbChiNhanh.Enabled = true;
            cbUser.Enabled = true;
            if (Program.role == "CONGTY") {
                cbChiNhanh.Enabled = false;
                cbUser.Enabled = false;
            }
           
        }
    }
}
