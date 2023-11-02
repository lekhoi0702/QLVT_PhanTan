using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormKho : Form
    {

        int viTri = 0;
        bool dangThemMoi = false;

        String maChiNhanh = "";

        Stack undoList = new Stack();
        public FormKho()
        {
            InitializeComponent();
        }

        private void kHOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormKho_Load(object sender, EventArgs e)
        {
           
            dataSet.EnforceConstraints = false;
         
            this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLVT_NHAPXUATDataSet.Kho' table. You can move, or remove it, as needed.
            this.KHOTableAdapter.Fill(this.dataSet.KHO);
            this.DDHTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dataSet.CTDDH' table. You can move, or remove it, as needed.
            this.DDHTableAdapter.Fill(this.dataSet.DDH);
            // TODO: This line of code loads data into the 'dataSet.CTHD' table. You can move, or remove it, as needed.
            this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOADONTableAdapter.Fill(this.dataSet.HOADON);
            // TODO: This line of code loads data into the 'dataSet.CTPN' table. You can move, or remove it, as needed.
            this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHIEUNHAPTableAdapter.Fill(this.dataSet.PHIEUNHAP);



            maChiNhanh = ((DataRowView)bdsKho[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;


            // phan quyen

            if (Program.role == "CONGTY")
            {


                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnSua.Enabled = false;

                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnChuyenChiNhanh.Enabled = false;
                this.btnThoat.Enabled = true;


                this.panelNhapLieu.Enabled = false;
            }

            if (Program.role == "CHINHANH" || Program.role == "USER")
            {


                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;

                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnChuyenChiNhanh.Enabled = true;
                this.btnThoat.Enabled = true;
                cmbChiNhanh.Enabled = false;


                this.panelNhapLieu.Enabled = true;

            }

        }


        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            /*Neu combobox khong co so lieu thi ket thuc luon*/
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbChiNhanh.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (cmbChiNhanh.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
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
                /*Do du lieu tu dataSet vao grid Control*/
                this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOTableAdapter.Fill(this.dataSet.KHO);

                this.DDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DDHTableAdapter.Fill(this.dataSet.DDH);

                this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHIEUNHAPTableAdapter.Fill(this.dataSet.PHIEUNHAP);

                this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HOADONTableAdapter.Fill(this.dataSet.HOADON);
                /*Tu dong lay maChiNhanh hien tai - phuc vu cho phan btnTHEM*/
                /*Cho dong nay chay thi bi loi*/
                //maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString().Trim();
            }
        }

        private void kHOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }



        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsKho.Position;
            this.panelNhapLieu.Enabled = true;
            dangThemMoi = true;


            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsKho.AddNew();
            txtChiNhanh.Text = maChiNhanh;

            /*Step 3*/
            this.txtMaKho.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = true;

            this.btnHoanTac.Enabled = true;
            this.btnLamMoi.Enabled = false;
            this.btnThoat.Enabled = false;


            this.gcKho.Enabled = false;
            this.panelNhapLieu.Enabled = true;
        }


        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.KHOTableAdapter.Fill(this.dataSet.KHO);
                this.gcKho.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private bool kiemTraDuLieuDauVao()
        {
            /*kiem tra txtMAKHO*/
            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }

            if (Regex.IsMatch(txtMaKho.Text, @"^[a-zA-Z0-9, ]+$") == false)
            {
                MessageBox.Show("Mã kho chỉ chấp nhận chữ và số", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }

            if (txtMaKho.Text.Length > 10)
            {
                MessageBox.Show("Mã kho không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }
            /*kiem tra txtTenKho*/
            if (txtTenKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }

            if (Regex.IsMatch(txtTenKho.Text, @"^[a-zA-Z0-9, ]+$") == false)
            {
                MessageBox.Show("Mã kho chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }

            if (txtTenKho.Text.Length > 30)
            {
                MessageBox.Show("Tên kho không thể quá 30 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }
            return true;
        }




        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            /*Step 1*/
            /*Lay du lieu truoc khi chon btnGHI - phuc vu btnHOANTAC*/
            String maKhoHang = txtMaKho.Text.Trim();// Trim() de loai bo khoang trang thua
            DataRowView drv = ((DataRowView)bdsKho[bdsKho.Position]);
            String tenKhoHang = drv["TENKHO"].ToString();
            String maChiNhanh = drv["MACN"].ToString();
            /*declare @returnedResult int
              exec @returnedResult = sp_KiemTraMaVatTu '20'
              select @returnedResult*/
            String cauTruyVan =
                    "DECLARE	@result nchar(10) " +
                    "EXEC @result = sp_KiemTraMaKho '" +
                    maKhoHang + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi Stored Procedure thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            //Console.WriteLine(result);
            Program.myReader.Close();

            /*Step 2*/
            int viTriConTro = bdsKho.Position;
            int viTriMaKhoHang = bdsKho.Find("MAKHO", txtMaKho.Text);

            if (result == 1 && viTriConTro != viTriMaKhoHang)
            {
                MessageBox.Show("Mã kho hàng này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        /*bật các nút về ban đầu*/
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        btnHoanTac.Enabled = true;

                        btnLamMoi.Enabled = true;
                        btnChuyenChiNhanh.Enabled = true;
                        btnThoat.Enabled = true;

                        this.txtMaKho.Enabled = false;
                        this.gcKho.Enabled = true;

                        /*lưu 1 câu truy vấn để hoàn tác yêu cầu*/
                        String cauTruyVanHoanTac = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                            cauTruyVanHoanTac = "" +
                                "DELETE DBO.KHO " +
                                "WHERE MAKHO = '" + txtMaKho.Text.Trim() + "'";
                        }
                        /*trước khi ấn btnGHI là sửa thông tin kho*/
                        else
                        {
                            cauTruyVanHoanTac =
                                "UPDATE DBO.KHO " +
                                "SET " +
                                "TENKHO = '" + tenKhoHang + "'," +
                               
                                "WHERE MAKHO = '" + maKhoHang + "'";
                        }
                        //Console.WriteLine("CAU TRUY VAN HOAN TAC");
                        //Console.WriteLine(cauTruyVanHoanTac);

                        /*Đưa câu truy vấn hoàn tác vào undoList 
                         * để nếu chẳng may người dùng ấn hoàn tác thì quất luôn*/
                        undoList.Push(cauTruyVanHoanTac);

                        this.bdsKho.EndEdit();
                        this.KHOTableAdapter.Update(this.dataSet.KHO);
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bdsKho.RemoveCurrent();
                        MessageBox.Show("Tên vật tư có thể đã được dùng !\n\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }


        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true && this.btnThem.Enabled == false)
            {
                dangThemMoi = false;

                this.txtMaKho.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;

                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnThoat.Enabled = true;


                this.gcKho.Enabled = true;
                this.panelNhapLieu.Enabled = true;

                bdsKho.CancelEdit();
                /*xoa dong hien tai*/
                bdsKho.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsKho.Position = viTri;
                return;
            }

            /*Step 1*/
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHoanTac.Enabled = false;
                return;
            }

            /*Step 2*/
            bdsKho.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            bdsKho.Position = viTri;
            this.KHOTableAdapter.Fill(this.dataSet.KHO);
        }



        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            if (bdsKho.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            if (bdsDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho hàng này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho hàng này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsHoaDon.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho hàng này vì đã lập hoá đơn", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            /* Phần này phục vụ tính năng hoàn tác
                    * Đưa câu truy vấn hoàn tác vào undoList 
                    * để nếu chẳng may người dùng ấn hoàn tác thì quất luôn*/


            string cauTruyVanHoanTac =
            "INSERT INTO DBO.KHO( MAKHO,TENKHO,MACN) " +
            " VALUES( '" + txtMaKho.Text + "','" +
                        txtTenKho.Text + "','" +
                      
                        txtChiNhanh.Text.Trim() + "' ) ";

            Console.WriteLine(cauTruyVanHoanTac);
            undoList.Push(cauTruyVanHoanTac);

            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bdsKho.Position;
                    bdsKho.RemoveCurrent();

                    this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KHOTableAdapter.Update(this.dataSet.KHO);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHoanTac.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.KHOTableAdapter.Fill(this.dataSet.KHO);
                    bdsKho.Position = viTri;
                    return;
                }
            }
            else
            {
                // xoa cau truy van hoan tac di
                undoList.Pop();
            }
        }

    }



}
