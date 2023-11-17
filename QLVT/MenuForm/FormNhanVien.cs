using DevExpress.CodeParser;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormNhanVien : Form
    {
        String maChiNhanh = "";
        int viTri = 0;
        bool dangThemMoi = false;
        bool danhDauXoa = false;
        Stack undoList = new Stack();

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void NHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENTableAdapter.Fill(this.dataSet.NHANVIEN);

            this.DDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DDHTableAdapter.Fill(this.dataSet.DDH);

            this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHIEUNHAPTableAdapter.Fill(this.dataSet.PHIEUNHAP);

            this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOADONTableAdapter.Fill(this.dataSet.HOADON);

            maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;


            // phan quyen
            if (Program.role == "CONGTY" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = true;

                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnSua.Enabled = false;

                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnChuyenChiNhanh.Enabled = false;
                this.btnThoat.Enabled = true;

                this.panelNhapLieu.Enabled = false;
            }

            if (Program.role == "CHINHANH")
            {
                cmbChiNhanh.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;

                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnChuyenChiNhanh.Enabled = true;
                this.btnThoat.Enabled = true;

                this.panelNhapLieu.Enabled = true;
                this.txtMaNV.Enabled = false;
            }
           


        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            String cauTruyVan2 = "SELECT * FROM view_LayMaNVLonNhat";
            SqlCommand sqlCommand2 = new SqlCommand(cauTruyVan2, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan2);
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result2 = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            Console.WriteLine(result2);
            result2 += 1;

            viTri = bdsNhanVien.Position;
            this.panelNhapLieu.Enabled = true;
            dangThemMoi = true;
            bdsNhanVien.AddNew();
            txtChiNhanh.Text = maChiNhanh;
            txtMaNV.Text = result2.ToString().Trim();

            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = true;

            this.btnHoanTac.Enabled = true;
            this.btnLamMoi.Enabled = false;
            this.btnChuyenChiNhanh.Enabled = false;

            this.cbTrangThaiXoa.Checked = false;

            this.gcNhanVien.Enabled = false;
            this.panelNhapLieu.Enabled = true;
            this.btnThoat.Enabled = false;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsNhanVien.Position;
            if (dangThemMoi == true && this.btnThem.Enabled == false)
            {

                bdsNhanVien.CancelEdit();
                bdsNhanVien.RemoveCurrent();


                dangThemMoi = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLamMoi.Enabled = true;
                btnThoat.Enabled = true;
                this.panelNhapLieu.Enabled = true;
                this.gcNhanVien.Enabled = true;
                bdsNhanVien.Position = bdsNhanVien.Count - 1;
                return;
            }
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHoanTac.Enabled = false;
                return;
            }
            else
            {

                String undoQuery = undoList.Pop().ToString();

                if (dangThemMoi == false && danhDauXoa == false)
                {
                    this.gcNhanVien.Enabled = true;
                    this.panelNhapLieu.Enabled = true;

                    Console.WriteLine(undoQuery);
                    Program.ExecSqlNonQuery(undoQuery);
                }

                if (danhDauXoa == true && dangThemMoi == false)
                {
                    Console.WriteLine(undoQuery);
                    danhDauXoa = false;
                    Program.ExecSqlNonQuery(undoQuery);
                }
                if (undoQuery.Contains("sp_ChuyenChiNhanh"))
                {
                    try
                    {
                        String chiNhanhHienTai = Program.serverName;
                        String chiNhanhChuyenToi = Program.serverNameLeft;

                        Program.serverName = chiNhanhChuyenToi;
                        Program.loginName = Program.remoteLogin;
                        Program.loginPassword = Program.remotePassword;

                        if (Program.KetNoi() == 0)
                        {
                            return;
                        }

                        Program.ExecSqlNonQuery(undoQuery);

                        MessageBox.Show("Chuyển nhân viên trở lại thành công", "Thông báo", MessageBoxButtons.OK);
                        Program.serverName = chiNhanhHienTai;
                        Program.loginName = Program.currentLogin;
                        Program.loginPassword = Program.currentPassword;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Chuyển nhân viên thất bại \n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    bdsNhanVien.Position = viTri;

                }
                /* else
                 {
                     if (Program.KetNoi() == 0)
                     {
                         return;
                     }
                     int n = Program.ExecSqlNonQuery(undoQuery);

                 }*/

            }


            this.NHANVIENTableAdapter.Fill(this.dataSet.NHANVIEN);
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                this.NHANVIENTableAdapter.Fill(this.dataSet.NHANVIEN);
                this.gcNhanVien.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbChiNhanh.SelectedValue.ToString();


            if (cmbChiNhanh.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }

            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {

                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Fill(this.dataSet.NHANVIEN);

                this.DDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DDHTableAdapter.Fill(this.dataSet.DDH);

                this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHIEUNHAPTableAdapter.Fill(this.dataSet.PHIEUNHAP);

                this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HOADONTableAdapter.Fill(this.dataSet.HOADON);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maNV = ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString();
            String cauTruyVan2 =
                "EXEC [dbo].[sp_KiemTraRole] @MANV = '" + maNV + "';";
             
            Console.WriteLine(cauTruyVan2);
            SqlCommand sqlCommand2 = new SqlCommand(cauTruyVan2, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan2);
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            String result2 = "";
            if (Program.myReader.HasRows) {
                result2 = Program.myReader.GetValue(0).ToString().Trim();
            }
          
           
            Program.myReader.Close();
            Console.WriteLine(result2 + " " + Program.role);

            if (result2 == "CONGTY")
            {
                MessageBox.Show("Không thể xoá quyền công ty", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (Program.role == "USER" && result2 == "CHINHANH")
                {
                    MessageBox.Show("Không thể xoá quyền chi nhánh", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

            if (maNV == Program.userName)
            {
                MessageBox.Show("Không thể xóa chính tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsHoaDon.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            int trangThai = (cbTrangThaiXoa.Checked == true) ? 1 : 0;

            DateTime NGAYSINH = (DateTime)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["NGAYSINH"];

            string undoQuery =
              string.Format("INSERT INTO DBO.NHANVIEN( MANV,HO,TEN,NGAYSINH,DIACHI,SDT,MACN,TRANGTHAIXOA)" +
                "VALUES({0},N'{1}',N'{2}',CAST('{3}' AS DATE), N'{4}','{5}','{6}','{7}')", maNV, txtHo.Text.Trim(), txtTen.Text.Trim(), NGAYSINH.ToString("yyyy-MM-dd"), txtDiaChi.Text.Trim(), txtSDT.Text.Trim(), txtChiNhanh.Text.Trim(), trangThai);

            Console.WriteLine(undoQuery);
            undoList.Push(undoQuery);

            /*Step 2*/
            if (MessageBox.Show("Xoá nhân viên này?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    viTri = bdsNhanVien.Position;
                    bdsNhanVien.RemoveCurrent();

                    this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NHANVIENTableAdapter.Update(this.dataSet.NHANVIEN);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHoanTac.Enabled = true;
                    danhDauXoa = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.NHANVIENTableAdapter.Fill(this.dataSet.NHANVIEN);
                    bdsNhanVien.Position = viTri;
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }

        private bool kiemTraDuLieuDauVao()
        {


            if (txtHo.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ", "Thông báo", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }

            if (Regex.IsMatch(txtHo.Text, @"^[A-Za-zÀ-ỹ ]+$") == false)
            {
                MessageBox.Show("Họ của người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }
            if (txtHo.Text.Length > 40)
            {
                MessageBox.Show("Họ không thể lớn hơn 40 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }

            if (txtTen.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }
            if (Regex.IsMatch(txtTen.Text, @"^[A-Za-zÀ-ỹ ]+$") == false)
            {
                MessageBox.Show("Tên người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }

            if (txtTen.Text.Length > 10)
            {
                MessageBox.Show("Tên không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }

            if (deNgaySinh.EditValue == null)
            {
                MessageBox.Show("Không được bỏ trống ngày sinh", "Thông báo", MessageBoxButtons.OK);
                deNgaySinh.Focus();
                return false;
            }
            if (CalculateAge(deNgaySinh.DateTime) < 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK);
                deNgaySinh.Focus();
                return false;
            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            if (Regex.IsMatch(txtDiaChi.Text, @"^[A-Za-zÀ-ỹ0-9, ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }


            if (Regex.IsMatch(txtSDT.Text, @"^[0-9]{10}$") == false)
            {
                MessageBox.Show("Số điện thoại phải là 10 số", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Không được bỏ trống số điện thoại", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
                return false;
            }
            if (dangThemMoi == true)
            {
                String cauTruyVan2 = "DECLARE @RETURN INT ;" +
                  "EXEC @RETURN  = sp_KiemTraSDT " +
                  "@SDT ='" + txtSDT.Text.ToString().Trim() + "';" +
                  "SELECT 'RETURN_VALUE' = @RETURN";
                Console.WriteLine(cauTruyVan2);
                SqlCommand sqlCommand2 = new SqlCommand(cauTruyVan2, Program.conn);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(cauTruyVan2);
                    if (Program.myReader == null)
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    return false;
                }
                Program.myReader.Read();
                int result2 = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();
                Console.WriteLine(result2);
                if (result2 == 1)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng", "Thông báo", MessageBoxButtons.OK);
                    txtSDT.Focus();
                    return false;
                }
            }

            return true;
        }
        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiem tra du lieu
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            String maNhanVien = txtMaNV.Text.Trim();
            DataRowView drv = ((DataRowView)bdsNhanVien[bdsNhanVien.Position]);


            String maChiNhanh = drv["MACN"].ToString();
            int trangThai = (cbTrangThaiXoa.Checked == true) ? 1 : 0;
            if (Program.userName == maNhanVien)
                if (trangThai == 1)
                {
                    MessageBox.Show("Không được đổi trạng thái xoá của tài khoản đang đăng nhâp", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            {
                DialogResult dr = MessageBox.Show("Ghi thông tin vào database?", "Thông báo",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {

                    try
                    {
                        String undoQuery = "";
                        if (dangThemMoi == true)
                        {
                            undoQuery = "" +
                              "DELETE DBO.NHANVIEN " +
                              "WHERE MANV = " + maNhanVien;
                            drv["MANV"] = maNhanVien;
                        }
                        else
                        {
                            String ho = drv["HO"].ToString();
                            String ten = drv["TEN"].ToString();

                            String diaChi = drv["DIACHI"].ToString();

                            DateTime ngaySinh = ((DateTime)drv["NGAYSINH"]);

                            String sdt = drv["SDT"].ToString();
                            undoQuery =
                              "UPDATE DBO.NHANVIEN " +
                              "SET " +
                              "HO = N'" + ho + "'," +
                              "TEN = N'" + ten + "'," +
                              "NGAYSINH = CAST('" + ngaySinh.ToString("yyyy-MM-dd") + "' AS DATE)," +
                              "DIACHI = N'" + diaChi + "'," +
                              "SDT = '" + sdt + "'," +
                              "TRANGTHAIXOA = " + trangThai + " " +
                              "WHERE MANV = '" + maNhanVien + "'";
                            viTri = bdsNhanVien.Position;


                        }
                        Console.WriteLine(undoQuery);
                        undoList.Push(undoQuery);
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                        danhDauXoa = false;
                        dangThemMoi = false;
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        btnHoanTac.Enabled = true;

                        btnLamMoi.Enabled = true;
                        btnChuyenChiNhanh.Enabled = true;
                        btnThoat.Enabled = true;
                        if (Program.role == "USER") {
                            btnThem.Enabled = false;
                        }

                        this.bdsNhanVien.EndEdit();
                        this.NHANVIENTableAdapter.Update(this.dataSet.NHANVIEN);
                        this.NHANVIENTableAdapter.Fill(this.dataSet.NHANVIEN);
                        this.gcNhanVien.Enabled = true;

                    }
                    catch (Exception ex)
                    {

                        if (dangThemMoi == true)
                        {
                            bdsNhanVien.RemoveCurrent();
                        }
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.bdsNhanVien.Position = viTri;

                }

            }

        }

        public void chuyenChiNhanh(String chiNhanh)
        {

            if (Program.serverName == chiNhanh)
            {
                MessageBox.Show("Hãy chọn chi nhánh khác chi nhánh bạn đang đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            String maChiNhanhHienTai = "";
            String maChiNhanhMoi = "";
            int viTriHienTai = bdsNhanVien.Position;
            String maNhanVien = ((DataRowView)bdsNhanVien[viTriHienTai])["MANV"].ToString();

            if (chiNhanh.Contains("1"))
            {
                maChiNhanhHienTai = "CN2";
                maChiNhanhMoi = "CN1";
            }
            else if (chiNhanh.Contains("2"))
            {
                maChiNhanhHienTai = "CN1";
                maChiNhanhMoi = "CN2";
            }
            else
            {
                MessageBox.Show("Mã chi nhánh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Console.WriteLine("Ma chi nhanh hien tai : " + maChiNhanhHienTai);
            Console.WriteLine("Ma chi nhanh Moi : " + maChiNhanhMoi);


            String undoQuery = "EXEC sp_ChuyenChiNhanh @MANV =" + maNhanVien + ",@MACN='" + maChiNhanhHienTai.Trim() + "'";
            undoList.Push(undoQuery);
            Console.WriteLine(undoQuery);
            Program.serverNameLeft = chiNhanh;



            String cauTruyVan = "EXEC sp_ChuyenChiNhanh @MANV=" + maNhanVien + ",@MACN='" + maChiNhanhMoi.Trim() + "'";
            Console.WriteLine(cauTruyVan);
            SqlCommand sqlcommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.ExecSqlNonQuery(cauTruyVan);

                MessageBox.Show("Chuyển chi nhánh thành công", "thông báo", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("thực thi database thất bại!\n\n" + ex.Message, "thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            this.NHANVIENTableAdapter.Update(this.dataSet.NHANVIEN);

        }

        private void btnCHUYENCHINHANH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int viTriHienTai = bdsNhanVien.Position;
            int trangThaiXoa = Convert.ToInt32(((DataRowView)(bdsNhanVien[viTriHienTai]))["TrangThaiXoa"]);

            string maNhanVien = ((DataRowView)(bdsNhanVien[viTriHienTai]))["MANV"].ToString();

            if (maNhanVien == Program.userName)
            {
                MessageBox.Show("Không thể chuyển chính người đang đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (trangThaiXoa == 1)
            {
                MessageBox.Show("Nhân viên này không có ở chi nhánh này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Form f = this.CheckExists(typeof(FormChuyenChiNhanh));
            if (f != null)
            {
                f.Activate();
            }
            FormChuyenChiNhanh form = new FormChuyenChiNhanh();
            form.Show();

            form.branchTransfer = new FormChuyenChiNhanh.MyDelegate(chuyenChiNhanh);

            this.btnHoanTac.Enabled = true;
        }

        private void nHANVIENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void nHANVIENDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}