using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel.Channels;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormPhieuNhap : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        public string makho = "";
        string maChiNhanh = "";
        Stack undoList = new Stack();
        BindingSource bds = null;
        GridControl gc = null;
        string type = "";
        String MAPNDuocChon = "";
        String MADDHDuocChon = "";
        bool danhDauXoa = false;
        public FormPhieuNhap()
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

        private void pHIEUNHAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuNhap.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            /*Step 1*/
            dataSet.EnforceConstraints = false;

            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.dataSet.CTPN);

            this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHIEUNHAPTableAdapter.Fill(this.dataSet.PHIEUNHAP);




            this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOTableAdapter.Fill(this.dataSet.KHO);
            this.VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VATTUTableAdapter.Fill(this.dataSet.VATTU);





            /*van con ton tai loi chua sua duoc*/
            //maChiNhanh = ((DataRowView)bdsVatTu[0])["MACN"].ToString();

            /*Step 2*/
            cmbChiNhanh.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;
            bds = bdsPhieuNhap;
            gc = gcPhieuNhap;

            this.panelPhieuNhap.Enabled = false;
            this.panelCTPN.Enabled = false;
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
                this.cmbChiNhanh.Enabled = true;
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

                this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPNTableAdapter.Fill(this.dataSet.CTPN);

                this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHIEUNHAPTableAdapter.Fill(this.dataSet.PHIEUNHAP);




                this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOTableAdapter.Fill(this.dataSet.KHO);
                this.VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
                this.VATTUTableAdapter.Fill(this.dataSet.VATTU);


            }
        }
        private void btnCheDoPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.panelNhapLieu.Enabled = true;
            this.panelCTPN.Enabled = false;
            /*Step 0*/
            btnMenu.Links[0].Caption = "Phiếu nhập";

            /*Step 1*/
            bds = bdsPhieuNhap;
            gc = gcPhieuNhap;
            //MessageBox.Show("Chế Độ Làm Việc Đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Bat chuc nang cua don dat hang*/
            txtMaPN.Enabled = false;
            deNgayLap.Enabled = false;
            txtDDH.Enabled = false;
            txtMaNV.Enabled = false;
            txtMaKho.Enabled = false;
            cmbKho.Enabled = true;
            panelCTPN.Enabled = false;

            /*Bat cac grid control len*/
            gcPhieuNhap.Enabled = true;
            gcCTPN.Enabled = true;

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

                this.panelPhieuNhap.Enabled = false;



            }


            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsPhieuNhap.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = true;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = true;
                this.btnEXIT.Enabled = true;
                this.panelPhieuNhap.Enabled = true;

            }
        }


        private void btnCheDoCTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            /*Step 0*/
            btnMenu.Links[0].Caption = "Chi tiết phiếu nhập";

            /*Step 1*/
            bds = bdsCTPN;
            gc = gcCTPN;

            panelPhieuNhap.Enabled = false;
            panelCTPN.Enabled = true;
            txtMaVT.Enabled = false;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = false;
            gcPhieuNhap.Enabled = true;
            gcCTPN.Enabled = true;
            btnXOA.Enabled = false;
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnTHEM.Enabled = false;

                this.btnGHI.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = true;
                this.btnEXIT.Enabled = true;
                this.panelCTPN.Enabled = false;


            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {

                cmbChiNhanh.Enabled = false;
                this.btnGHI.Enabled = true;
                this.btnHOANTAC.Enabled = true;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = true;
                this.btnEXIT.Enabled = true;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }


        /*  private void btnChonDonHang_Click(object sender, EventArgs e)
          {
              FormChonDDH form = new FormChonDDH();
              form.ShowDialog();

              this.txtDDH.Text = Program.maDonDatHangDuocChon;
              this.txtMaKho.Text = Program.maKhoDuocChon;

          }




  */





        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            viTri = bds.Position;
            dangThemMoi = true;
            bds.AddNew();
            if (btnMenu.Links[0].Caption == "Phiếu nhập")
            {
                FormChonDDH form = new FormChonDDH();
                form.ShowDialog();
                this.txtDDH.Text = Program.maDonDatHangDuocChon;
                this.txtMaKho.Text = Program.maKhoDuocChon;
                this.txtMaPN.Enabled = true;

                this.deNgayLap.EditValue = DateTime.Now;
                this.deNgayLap.Enabled = false;

                this.txtDDH.Enabled = false;

                this.txtMaNV.Text = Program.userName;
                this.txtMaKho.Text = Program.maKhoDuocChon;


                /*Gan tu dong may truong du lieu nay*/
                ((DataRowView)(bdsPhieuNhap.Current))["NGAYLAP"] = DateTime.Now;
                ((DataRowView)(bdsPhieuNhap.Current))["MADDH"] = Program.maDonDatHangDuocChon;
                ((DataRowView)(bdsPhieuNhap.Current))["MANV"] = Program.userName;
                ((DataRowView)(bdsPhieuNhap.Current))["MAKHO"] = Program.maKhoDuocChon;

            }
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = true;

            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnMenu.Enabled = false;
            this.btnEXIT.Enabled = false;
        }


        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.PHIEUNHAPTableAdapter.Fill(this.dataSet.PHIEUNHAP);
                this.CTPNTableAdapter.Fill(this.dataSet.CTPN);
                if (btnMenu.Links[0].Caption == "Phiếu nhập")
                {
                    cmbKho.Enabled = true;
                }
                if (btnMenu.Links[0].Caption == "Chi tiết phiếu nhập")
                {
                    txtSoLuong.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mời dữ liệu\n\n" + ex.Message, "Thông Báo", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message);
                return;
            }
        }


        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPhieuNhap.Position;
            /* Step 0 */
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                dangThemMoi = false;

                /*dang o che do Phiếu nhập*/
                if (btnMenu.Links[0].Caption == "Phiếu nhập")
                {

                    deNgayLap.Enabled = false;
                    txtDDH.Enabled = false;
                    txtMaKho.Enabled = false;
                    btnTHEM.Enabled = true;
                    btnXOA.Enabled = true;
                    btnMenu.Enabled = true;
                    btnLAMMOI.Enabled = true;
                    btnThoat.Enabled = true;

                }

                /* if (btnMenu.Links[0].Caption == "Chi tiết phiếu nhập")
                 {
                     this.txtDDH.Enabled = false;
                     this.btnCTDDH.Enabled = false;

                     this.txtMaVT.Enabled = false;
                     this.txtSoLuong.Enabled = false;
                     this.txtDonGia.Enabled = false;

                     this.btnXOA.Enabled = false;
                 }*/

                this.btnHOANTAC.Enabled = false;
                bds.CancelEdit();
                /*xoa dong hien tai*/
                bds.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsPhieuNhap.Position = viTri;
                return;
            }

            /*Step 1*/
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                return;
            }
            if (danhDauXoa == true)
            {
                danhDauXoa = false;

            }
            String queryHoanTac = undoList.Pop().ToString();
            Console.WriteLine(queryHoanTac);
            int n = Program.ExecSqlNonQuery(queryHoanTac);




            this.PHIEUNHAPTableAdapter.Fill(this.dataSet.PHIEUNHAP);
            this.CTPNTableAdapter.Fill(this.dataSet.CTPN);

            bdsPhieuNhap.Position = viTri;
        }

        private bool kiemTraDuLieuDauVao(String cheDo)
        {
            if (cheDo == "Phiếu nhập")
            {
                if (txtMaPN.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã Phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPN.Focus();
                    return false;
                }

                if (Regex.IsMatch(txtMaPN.Text.Trim(), @"^[a-zA-Z0-9]+$") == false)
                {
                    MessageBox.Show("Mã Phiếu nhập chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                    txtMaPN.Focus();
                    return false;
                }


                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã nhân viên !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (txtMaKho.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã kho !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (txtDDH.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã đơn đặt hàng !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            }

            if (cheDo == "Chi tiết phiếu nhập")
            {

                if ((int)txtSoLuong.Value < 0
                       )
                {

                    MessageBox.Show("Số lượng vật tư không được nhỏ hơn 0 !", "Thông báo", MessageBoxButtons.OK);
                    txtSoLuong.Focus();
                    return false;

                }

                /* if ((int)txtDonGia.Value < 1000)
                 {
                     MessageBox.Show("Đơn giá không thể nhỏ hơn 1000Đ", "Thông báo", MessageBoxButtons.OK);
                     txtDonGia.Focus();
                     return false;
                 }*/
            }

            return true;
        }


        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsPhieuNhap.Count == 0 && btnMenu.Links[0].Caption == "Phiếu nhập")
            {
                MessageBox.Show("Phiếu nhập trống", "Thông báo", MessageBoxButtons.OK);
            }


            else
            {


                DataRowView drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNhanVien = drv["MANV"].ToString();
                String maDDH = drv["MADDH"].ToString().Trim();


                if (Program.userName != maNhanVien && dangThemMoi == false)
                {
                    MessageBox.Show("Bạn không thể sửa phiếu do người khác lập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                String cheDo = (btnMenu.Links[0].Caption == "Phiếu nhập") ? "Phiếu nhập" : "Chi tiết phiếu nhập";


                bool ketQua = kiemTraDuLieuDauVao(cheDo);
                if (ketQua == false) return;

                String cauTruyVanHoanTac = "";

                String maPhieuNhap = txtMaPN.Text.Trim();
                String cauTruyVan =
                        "DECLARE	@result int " +
                        "EXEC @result = sp_KiemTraMaPN '" +
                        maPhieuNhap + "' " +
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


                /*Step 5*/
                int viTriConTro = bdsPhieuNhap.Position;
                int viTriMaPhieuNhap = bdsPhieuNhap.Find("MAPN", maPhieuNhap);

                /*Dang them moi phieu nhap*/
                if (result == 1 && cheDo == "Phiếu nhập" && viTriMaPhieuNhap != viTriConTro)
                {
                    MessageBox.Show("Mã Phiếu nhập đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPN.Focus();
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

                            if (cheDo == "Phiếu nhập")

                            {
                                if (dangThemMoi == true)
                                {
                                    drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                                    drv["MAKHO"] = cmbKho.SelectedValue.ToString();
                                    drv["MAPN"] = maPhieuNhap;
                                    Console.WriteLine("ma phieu nhap = " + maPhieuNhap);
                                    MADDHDuocChon = drv["MADDH"].ToString();

                                    cauTruyVanHoanTac =
                                        "DELETE FROM DBO.PHIEUNHAP " +
                                        "WHERE MAPN = '" + maPhieuNhap + "'";
                                    undoList.Push(cauTruyVanHoanTac);
                                    String test = undoList.Peek() as string;
                                    Console.WriteLine("query hoan tac:" + test);

                                    this.bdsPhieuNhap.EndEdit();
                                    this.PHIEUNHAPTableAdapter.Update(this.dataSet.PHIEUNHAP);
                                    int ketqua = taoPhieuNhapvaChiTietPhieuNhap(maPhieuNhap, MADDHDuocChon);
                                    Console.WriteLine("ket tao phieu nhap = " + ketqua);
                                    if (ketqua == 0)
                                    {
                                        MessageBox.Show("Lỗi đưa chi tiết đơn hàng vào chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                                        return;
                                    }


                                    this.btnMenu.Links[0].Caption = "Chi tiết Phiếu Nhập";
                                    panelCTPN.Enabled = true;
                                    panelPhieuNhap.Enabled = false;

                                    dangThemMoi = false;
                                    txtSoLuong.Enabled = true;
                                    txtMaVT.Enabled = false;
                                    txtDonGia.Enabled = false;
                                    this.btnTHEM.Enabled = false;
                                    this.btnXOA.Enabled = false;
                                    this.btnHOANTAC.Enabled = false;
                                    this.btnGHI.Enabled = true;
                                    this.btnLAMMOI.Enabled = true;
                                    this.btnMenu.Enabled = true;
                                    this.CTPNTableAdapter.Fill(this.dataSet.CTPN);


                                }
                                if (dangThemMoi == false)
                                {
                                    danhDauXoa = false;
                                    String query = taoqueryHoanTac(cheDo);
                                    undoList.Push(query);
                                    String test = undoList.Peek() as string;
                                    Console.WriteLine("query hoan tac:" + test);
                                    drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                                    drv["MAKHO"] = cmbKho.SelectedValue.ToString();

                                }



                            }
                            if (cheDo == "Chi tiết phiếu nhập")
                            {
                                String hoantac = taoqueryHoanTac(cheDo);
                                undoList.Push(hoantac);
                                String test = undoList.Peek() as string;
                                Console.WriteLine("Cau hoan tac = " + test);

                                drv = ((DataRowView)bdsCTPN[bdsCTPN.Position]);

                                drv["SOLUONG"] = txtSoLuong.Value;
                                string maVatTu = txtMaVT.Text.Trim();
                                int soLuong = (int)txtSoLuong.Value;

                                int n = kiemTraSoLuongVatTu(maPhieuNhap, maVatTu, soLuong);
                                if (n == 0)
                                {
                                    MessageBox.Show("Số lượng nhập không được lớn hơn số lượng trong đơn đặt!!!", "Thông báo", MessageBoxButtons.OK);
                                    return;
                                }
                                capNhatSLT(maVatTu, soLuong);
                                this.btnHOANTAC.Enabled = true;
                            }

                            this.bdsPhieuNhap.EndEdit();
                            this.PHIEUNHAPTableAdapter.Update(this.dataSet.PHIEUNHAP);
                            this.bdsCTPN.EndEdit();
                            this.CTPNTableAdapter.Update(this.dataSet.CTPN);



                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            if (cheDo == "Phiếu nhập")
                            {
                                bdsPhieuNhap.RemoveCurrent();
                            }
                            MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }


        }

        private int taoPhieuNhapvaChiTietPhieuNhap(String mapn, String maddh)
        {

            String query = "DECLARE	@result int; " +
                        "EXEC @result = sp_TaoPhieuNhap @MADDH = '" +
                        maddh + "'," + " @MAPN = '" +
                         mapn + "';" +
                        "SELECT 'return_value' = @result";
            Console.WriteLine("Query tạo phiếu nhập: " + query);
            Program.myReader = Program.ExecSqlDataReader(query);
            try
            {

                if (Program.myReader == null)
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return 0;
            }
            Program.myReader.Read();
            int result2 = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            Console.WriteLine("ket qua them ctpn = " + result2);
            return result2;


        }






        private String taoqueryHoanTac(String cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;


            if (cheDo == "Phiếu nhập" && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                /*Ngay can duoc xu ly dac biet hon*/
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);

                cauTruyVan = "UPDATE DBO.PHIEUNHAP " +
                    "SET " +
                    "NGAYLAP = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATE), " +
                    "MANDDH = '" + drv["MADDH"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "' " +
                    "WHERE MAPN = '" + drv["MAPN"].ToString().Trim() + "'";
            }


            if (cheDo == "Phiếu nhập" && dangThemMoi == false && danhDauXoa == true)
            {
                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);
                cauTruyVan = "INSERT INTO DBO.PhieuNhap(MAPN, NGAYLAP, MADDH, MANV, MAKHO) " +
                    "VALUES('" + drv["MAPN"].ToString().Trim() + "', '" +
                    ngay.ToString("yyyy-MM-dd").Trim() + "', '" +
                    drv["MADDH"].ToString().Trim() + "', '" +
                    drv["MaNV"].ToString().Trim() + "', '" +
                    drv["MAKHO"].ToString().Trim() + "' )";

            }



            if (cheDo == "Chi tiết phiếu nhập" && dangThemMoi == false && danhDauXoa == false)
            {
                drv = ((DataRowView)bdsCTPN[bdsCTPN.Position]);
                cauTruyVan = "UPDATE DBO.CTPN " +
                    "SET " +
                    "SOLUONG = " + drv["SOLUONG"].ToString() + " , " +
                    "DONGIA = " + drv["DONGIA"].ToString() + " " +
                    "WHERE MAPN = '" + drv["MAPN"].ToString().Trim() + "'" +
                    " AND MAVT = '" + drv["MAVT"].ToString().Trim() + "'";

            }
            return cauTruyVan;
        }




        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv;
            string cheDo = (btnMenu.Links[0].Caption == "Phiếu nhập") ? "Phiếu nhập" : "Chi tiết phiếu nhập";



            if (cheDo == "Phiếu nhập")
            {
                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Không xóa chi tiết phiếu xuất không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsCTPN.Count > 0)
                {
                    MessageBox.Show("Không thể xóa Phiếu nhập vì có Chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }





            }

            /*   if (cheDo == "Chi tiết phiếu nhập")
               {
                   drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                   String maNhanVien = drv["MANV"].ToString();
                   if (Program.userName != maNhanVien)
                   {
                       MessageBox.Show("Bạn không xóa Chi tiết phiếu nhập không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                       return;
                   }


                   drv = ((DataRowView)bdsCTPN[bdsCTPN.Position]);
                   queryHoanTac = "INSERT INTO DBO.CTPN(MAPN, MAVT, SOLUONG, DONGIA) " +
                       "VALUES('" + drv["MAPN"].ToString().Trim() + "', '" +
                       drv["MAVT"].ToString().Trim() + "', " +
                       drv["SOLUONG"].ToString().Trim() + ", " +
                       drv["DONGIA"].ToString().Trim() + ")";
               }
   */



            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bds.Position;
                    if (cheDo == "Phiếu nhập")
                    {
                        danhDauXoa = true;
                        dangThemMoi = false;
                        String queryHoanTac = taoqueryHoanTac(cheDo);
                        undoList.Push(queryHoanTac);
                        String cauHoanTac = undoList.Peek() as string;
                        Console.WriteLine(cauHoanTac);
                        bdsPhieuNhap.RemoveCurrent();

                    }
                    /*  if (cheDo == "Chi tiết phiếu nhập")
                      {
                          bdsCTPN.RemoveCurrent();
                      }*/


                    this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PHIEUNHAPTableAdapter.Update(this.dataSet.PHIEUNHAP);

                    /*  this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                      this.CTPNTableAdapter.Update(this.dataSet.CTPN);
  */
                    //bdsPhieuNhap.Position = viTri;
                    /*Cap nhat lai do ben tren can tao cau truy van nen da dat dangThemMoi = true*/
                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                    danhDauXoa = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa phiếu nhập. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PHIEUNHAPTableAdapter.Update(this.dataSet.PHIEUNHAP);

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



        private void capNhatSLT(string maVatTu, int soLuong)
        {
            string cauTruyVan = "DECLARE @RETURN INT; " +
                "EXEC @RETURN = sp_CapNhatSLT @CHEDO = 'NHAP'" +
                ",@MAVT = '" + maVatTu + "'," +
                "@SOLUONG='" + soLuong + "';" +
                "SELECT'RETURN VALUE' = @RETURN";


            int n = Program.ExecSqlNonQuery(cauTruyVan);
            Console.WriteLine("cap nhat so luong ton = " + cauTruyVan);
        }

        private int kiemTraSoLuongVatTu(string mapn, string mavt, int soluong)
        {
            string cauTruyVan = "DECLARE @RETURN INT " +
               "EXEC @RETURN = sp_KiemTraSoLuongVatTuTrongDDH " +
               "@MAPN = '" + mapn + "'," +
               "@SOLUONG=" + soluong + "," +
               "@MAVT='" + mavt + "'" +
               " SELECT 'RETURN' = @RETURN";
            Console.WriteLine("cau truy van = " + cauTruyVan);

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi Stored Procedure thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return 0;

            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Console.WriteLine("kiem tra so luong vat tu = " + result);
            Program.myReader.Close();
            return result;



        }



    }
}