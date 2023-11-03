using DevExpress.XtraGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormDDH : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        public string makho = "";
        string maChiNhanh = "";
        Stack undoList = new Stack();
        BindingSource bds = null;
        GridControl gc = null;
        string type = "";


        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormDDH()
        {
            InitializeComponent();
        }

        private void dDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormDDH_Load(object sender, EventArgs e)
        {
            /*Step 1*/
            dataSet.EnforceConstraints = false;

            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.dataSet.CTDDH);

            this.DDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DDHTableAdapter.Fill(this.dataSet.DDH);

            this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHIEUNHAPTableAdapter.Fill(this.dataSet.PHIEUNHAP);


            this.VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VATTUTableAdapter.Fill(this.dataSet.VATTU);


            this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOTableAdapter.Fill(this.dataSet.KHO);
            /*van con ton tai loi chua sua duoc*/
            //maChiNhanh = ((DataRowView)bdsVatTu[0])["MACN"].ToString();

            /*Step 2*/
            cmbChiNhanh.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;
            bds = bdsDDH;
            gc = gcDDH;

            this.panelDDH.Enabled = false;
            this.panelCTDDH.Enabled = false;
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = false;
            this.btnHOANTAC.Enabled = false;        
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                this.cmbChiNhanh.Enabled = false;
            }
            if (Program.role == "CONGTY")
            {
                this.btnMenu.Enabled = false;
            }



        }
        private void btnCheDoDonDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.panelNhapLieu.Enabled = true;
            /*Step 0*/
            btnMenu.Links[0].Caption = "Đơn Đặt Hàng";

            /*Step 1*/
            bds = bdsDDH;
            gc = gcDDH;
            //MessageBox.Show("Chế Độ Làm Việc Đơn Đặt Hàng", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Bat chuc nang cua don dat hang*/
            txtMaDDH.Enabled = false;
            deNgayLap.Enabled = false;

            txtMaNCC.Enabled = true;
            txtMaNV.Enabled = false;

            txtMaKho.Enabled = false;
            cmbKho.Enabled = true;

            /*Tat chuc nang cua chi tiet don hang*/
            txtMaVT.Enabled = false;
            cmbVatTu.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;

            /*Bat cac grid control len*/
            gcDDH.Enabled = true;
            gcCTDDH.Enabled = true;


            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnGHI.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = false;
                this.btnEXIT.Enabled = true;

                this.panelDDH.Enabled = false;


            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsDDH.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = true;
                this.btnEXIT.Enabled = true;

                this.txtMaDDH.Enabled = false;

            }
        }


        private void btnCheDoCTDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0*/
            btnMenu.Links[0].Caption = "Chi Tiết Đơn Đặt Hàng";

            /*Step 1*/
            bds = bdsCTDDH;
            gc = gcCTDDH;
            //MessageBox.Show("Chế Độ Làm Việc Chi Tiết Đơn Đặt Hàng", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Tat chuc nang don dat hang*/
            txtMaDDH.Enabled = false;
            deNgayLap.Enabled = false;

            txtMaNCC.Enabled = false;
            txtMaNV.Enabled = false;

            txtMaKho.Enabled = false;
            cmbKho.Enabled = false;

            /*Bat chuc nang cua chi tiet don hang*/
            txtMaVT.Enabled = false;
            cmbVatTu.Enabled = false;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;


            /*Bat cac grid control len*/
            gcDDH.Enabled = true;
            gcCTDDH.Enabled = true;

            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnGHI.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = false;
                this.btnEXIT.Enabled = true;

                this.panelCTDDH.Enabled = false;


            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsCTDDH.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = true;
                this.btnEXIT.Enabled = true;

                this.txtMaDDH.Enabled = false;
                this.cmbChiNhanh.Enabled = false;

            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }


        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bds.Position;
            dangThemMoi = true;


            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bds.AddNew();
            if (btnMenu.Links[0].Caption == "Đơn Đặt Hàng")
            {
                this.txtMaDDH.Enabled = true;
                //this.txtMaKho.Text = "";
                this.deNgayLap.EditValue = DateTime.Now;
                this.deNgayLap.Enabled = false;
                this.txtMaNCC.Enabled = true;
                this.txtMaNV.Text = Program.userName;
                this.cmbKho.Enabled = true;

                /*Gan tu dong may truong du lieu nay*/
                ((DataRowView)(bdsDDH.Current))["MANV"] = Program.userName;
                ((DataRowView)(bdsDDH.Current))["NGAY"] = DateTime.Now;
            }

            if (btnMenu.Links[0].Caption == "Chi Tiết Đơn Đặt Hàng")
            {
                DataRowView drv = ((DataRowView)bdsDDH[bdsDDH.Position]);
                String MaNV = drv["MANV"].ToString();
                if (Program.userName != MaNV)
                {
                    MessageBox.Show("Bạn không thêm chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    bdsCTDDH.RemoveCurrent();
                    return;
                }



                this.txtMaVT.Enabled = false;
                this.cmbVatTu.Enabled = true;

                this.txtSoLuong.Enabled = true;
                this.txtSoLuong.EditValue = 1;

                this.txtDonGia.Enabled = true;
                this.txtDonGia.EditValue = 1;
            }


            /*Step 3*/
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = true;

            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnMenu.Enabled = false;
            this.btnEXIT.Enabled = false;
        }

        private bool kiemTraDuLieuDauVao(String cheDo)
        {
            if (cheDo == "Đơn Đặt Hàng")
            {
                if (txtMaDDH.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã đơn hàng", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMaDDH.Text.Length > 8)
                {
                    MessageBox.Show("Mã đơn đặt hàng không quá 8 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMaNCC.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMaNCC.Text.Length > 100)
                {
                    MessageBox.Show("Tên nhà cung cấp không quá 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMaKho.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã kho", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            }
            if (cheDo == "Chi Tiết Đơn Đặt Hàng")
            {
                if (txtMaVT.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã vật tư", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtSoLuong.Value < 0 || txtDonGia.Value < 0)
                {
                    MessageBox.Show("Không thể nhỏ hơn 1", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                /*
                if( txtSoLuong.Value > Program.soLuongVatTu)
                {
                    MessageBox.Show("Sô lượng đặt mua lớn hơn số lượng vật tư hiện có", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }*/
            }
            return true;
        }


        private String taoCauTruyVanHoanTac(String cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;


            /*Dang chinh sua don dat hang*/
            if (cheDo == "Đơn Đặt Hàng" && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsDDH[bdsDDH.Position]);
                /*Ngay can duoc xu ly dac biet hon*/
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);

                cauTruyVan = "UPDATE DBO.DDH " +
                    "SET " +
                    "NGAYLAP = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATE), " +
                    "MANCC = '" + drv["MANCC"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "' " +
                    "WHERE MADDH = '" + drv["MADDH"].ToString().Trim() + "'";
            }
            /*Dang xoa don dat hang*/
            if (cheDo == "Đơn Đặt Hàng" && dangThemMoi == true)
            {
                drv = ((DataRowView)bdsDDH[bdsDDH.Position]);
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);
                cauTruyVan = "INSERT INTO DBO.DDH(MADDH, NGAYLAP, MANCC, MANV, MAKHO) " +
                    "VALUES('" + drv["MADDH"] + "', '" +
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["MANCC"].ToString() + "', '" +
                    drv["MaNV"].ToString() + "', '" +
                    drv["MAKHO"].ToString() + "' )";

            }

            /*Dang chinh sua chi tiet don dat hang*/
            if (cheDo == "Chi Tiết Đơn Đặt Hàng" && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsCTDDH[bdsCTDDH.Position]);

                cauTruyVan = "UPDATE DBO.CTDDH " +
                    "SET " +
                    "SOLUONG = " + drv["SOLUONG"].ToString() + " , " +
                    "DONGIA = " + drv["DONGIA"].ToString() + " " +
                    "WHERE MADDH = '" + drv["MADDH"].ToString().Trim() + "'" +
                    " AND MAVT = '" + drv["MAVT"].ToString().Trim() + "'";

            }
            return cauTruyVan;
        }


        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDDH.Position;
            /*Step 1*/
            DataRowView drv = ((DataRowView)bdsDDH[bdsDDH.Position]);
            /*lay maNhanVien & maDonDatHang de phong truong hop them chi tiet don hang thi se co ngay*/
            String maNhanVien = drv["MANV"].ToString();
            String maDonDatHang = drv["MADDH"].ToString().Trim();

            if (Program.userName != maNhanVien && dangThemMoi == false)
            {
                MessageBox.Show("Bạn không thể sửa phiếu do người khác lập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
           

            



            /*Step 2*/
            String cheDo = (btnMenu.Links[0].Caption == "Đơn Đặt Hàng") ? "Đơn Đặt Hàng" : "Chi Tiết Đơn Đặt Hàng";

            bool ketQua = kiemTraDuLieuDauVao(cheDo);
            if (ketQua == false) return;

            String cauTruyVanHoanTac = taoCauTruyVanHoanTac(cheDo);
            //Console.WriteLine(cauTruyVanHoanTac);


            /*Step 3*/
            String maDonDatHangMoi = txtMaDDH.Text;
            String cauTruyVan =
                    "DECLARE	@result NCHAR(10) " +
                    "EXEC @result = sp_KiemTraMaDDH '" +
                    maDonDatHangMoi + "' " +
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
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();



            /*Step 4*/
            //Console.WriteLine(txtMaNhanVien.Text);
            int viTriHienTai = bds.Position;
            int viTriMaDonDatHang = bdsDDH.Find("MasoDDH", txtMaDDH.Text);
            /******************************************************************
             * truong hop them moi don dat hang moi quan tam xem no ton tai hay
             * chua ?
             ******************************************************************/
            if (result == 1 && cheDo == "Đơn Đặt Hàng" && viTriHienTai != viTriMaDonDatHang)
            {
                MessageBox.Show("Mã đơn hàng này đã được sử dụng !\n\n", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*****************************************************************
             * tat ca cac truong hop khac ko can quan tam !!
             *****************************************************************/

            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        //Console.WriteLine(txtMaNhanVien.Text);
                        /*TH1: them moi don dat hang*/
                        if (cheDo == "Đơn Đặt Hàng" && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.DDH " +
                                "WHERE MADDH = '" + maDonDatHang + "'";
                        }

                        /*TH2: them moi chi tiet don hang*/
                        if (cheDo == "Chi Tiết Đơn Đặt Hàng" && dangThemMoi == true)
                        {
                            /*Gan tu dong may truong du lieu nay*/
                            ((DataRowView)(bdsCTDDH.Current))["MADDH"] = ((DataRowView)(bdsDDH.Current))["MADDH"];
                            ((DataRowView)(bdsCTDDH.Current))["MAVT"] = Program.maVatTuDuocChon;
                            ((DataRowView)(bdsCTDDH.Current))["SOLUONG"] =
                                txtSoLuong.Value;
                            ((DataRowView)(bdsCTDDH.Current))["DONGIA"] =
                                (int)txtDonGia.Value;

                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.CTDDH " +
                                "WHERE MaDDH = '" + maDonDatHang + "' " +
                                "AND MAVT = '" + txtMaVT.Text.Trim() + "'";
                        }

                        /*TH3: chinh sua don hang */
                        /*TH4: chinh sua chi tiet don hang - > thi chi can may dong lenh duoi la xong*/
                        undoList.Push(cauTruyVanHoanTac);
                        //Console.WriteLine("cau truy van hoan tac");
                        //Console.WriteLine(cauTruyVanHoanTac);

                        this.bdsDDH.EndEdit();
                        this.bdsCTDDH.EndEdit();
                        this.DDHTableAdapter.Update(this.dataSet.DDH);
                        this.CTDDHTableAdapter.Update(this.dataSet.CTDDH);

                        this.btnTHEM.Enabled = true;
                        this.btnXOA.Enabled = true;
                        this.btnGHI.Enabled = true;

                        this.btnHOANTAC.Enabled = true;
                        this.btnLAMMOI.Enabled = true;
                        this.btnMenu.Enabled = true;
                        this.btnEXIT.Enabled = true;
                       

                        //this.groupBoxDonDatHang.Enabled = false;

                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bds.RemoveCurrent();
                        MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

        }


        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                dangThemMoi = false;

                /*dang o che do Don Dat Hang*/
                if (btnMenu.Links[0].Caption == "Đơn Đặt Hàng")
                {
                    this.txtMaDDH.Enabled = false;

                    //this.dteNGAY.EditValue = DateTime.Now;
                    this.deNgayLap.Enabled = false;
                    this.txtMaNCC.Enabled = true;
                    //this.txtMaNhanVien.Text = Program.userName;
                    this.cmbKho.Enabled = true;
                }
                /*dang o che do Chi Tiet Don Dat Hang*/
                if (btnMenu.Links[0].Caption == "Chi Tiết Đơn Đặt Hàng")
                {
                    this.txtMaVT.Enabled = false;
                    this.cmbVatTu.Enabled = true;

                    this.txtSoLuong.Enabled = true;
                    this.txtSoLuong.EditValue = 1;

                    this.txtDonGia.Enabled = true;
                    this.txtDonGia.EditValue = 1;
                }

                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                //this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = true;
                this.btnEXIT.Enabled = true;


                bds.CancelEdit();
                /*xoa dong hien tai*/
                bds.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bds.Position = viTri;
                return;
            }

            /*Step 1*/
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                return;
            }

            /*Step 2*/
            bds.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.DDHTableAdapter.Fill(this.dataSet.DDH);
            this.CTDDHTableAdapter.Fill(this.dataSet.CTDDH);

            bdsDDH.Position = viTri;
        }


        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.DDHTableAdapter.Fill(this.dataSet.DDH);
                this.CTDDHTableAdapter.Fill(this.dataSet.CTDDH);

                this.gcDDH.Enabled = true;
                this.gcCTDDH.Enabled = true;

                bdsDDH.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }


        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cauTruyVan = "";
            string cheDo = (btnMenu.Links[0].Caption == "Đơn Đặt Hàng") ? "Đơn Đặt Hàng" : "Chi Tiết Đơn Đặt Hàng";

            dangThemMoi = true;// bat cai nay len de ung voi dieu kien tao cau truy van

            if (cheDo == "Đơn Đặt Hàng")
            {
                /*Cái bdsChiTietDonHangHang là đại diện cho binding source riêng biệt của CTDDH
                 *Còn cTDDHBindingSource là lấy ngay từ trong data source DATHANG
                 */
                if (bdsCTDDH.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsPhieuNhap.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


            }
            if (cheDo == "Chi Tiết Đơn Đặt Hàng")
            {
                DataRowView drv = ((DataRowView)bdsDDH[bdsDDH.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Bạn không xóa chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    //bdsChiTietDonDatHang.RemoveCurrent();
                    return;
                }
            }

            cauTruyVan = taoCauTruyVanHoanTac(cheDo);
            //Console.WriteLine("Line 753");
            //Console.WriteLine(cauTruyVan);
            undoList.Push(cauTruyVan);

            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bds.Position;
                    if (cheDo == "Đơn Đặt Hàng")
                    {
                        bdsDDH.RemoveCurrent();
                    }
                    if (cheDo == "Chi Tiết Đơn Đặt Hàng")
                    {
                        bdsCTDDH.RemoveCurrent();
                    }


                    this.DDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.DDHTableAdapter.Update(this.dataSet.DDH);

                    this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTDDHTableAdapter.Update(this.dataSet.CTDDH);

                    /*Cap nhat lai do ben tren can tao cau truy van nen da dat dangThemMoi = true*/
                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.DDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.DDHTableAdapter.Update(this.dataSet.DDH);

                    this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTDDHTableAdapter.Update(this.dataSet.CTDDH);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bds.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            else
            {
                // xoa cau truy van hoan tac di
                undoList.Pop();
            }
        }
        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
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
                this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTDDHTableAdapter.Fill(this.dataSet.CTDDH);

                this.DDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DDHTableAdapter.Fill(this.dataSet.DDH);

                this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHIEUNHAPTableAdapter.Fill(this.dataSet.PHIEUNHAP);
            }
        }





    }

}
