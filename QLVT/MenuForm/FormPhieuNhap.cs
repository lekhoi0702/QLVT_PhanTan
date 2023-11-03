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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
                this.btnMenu.Enabled = false;
            }



        }
        private void btnCheDoPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.panelNhapLieu.Enabled = true;
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


            txtMaNV.Enabled = false;

            txtMaKho.Enabled = false;
            cmbKho.Enabled = true;

            /*Tat chuc nang cua chi tiet don hang*/
            txtMaVT.Enabled = false;

            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;

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

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsPhieuNhap.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = true;
                this.btnEXIT.Enabled = true;
                this.panelPhieuNhap.Enabled = true;
                this.txtMaPN.Enabled = false;

            }
        }


        private void btnCheDoCTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            /*Step 0*/
            btnMenu.Links[0].Caption = "Chi tiết phiếu nhập";

            /*Step 1*/
            bds = bdsCTPN;
            gc = gcCTPN;

            //MessageBox.Show("Chế Độ Làm Việc Chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Tat chuc nang don dat hang*/
            txtMaPN.Enabled = false;
            deNgayLap.Enabled = false;


            txtMaNV.Enabled = false;

            txtMaKho.Enabled = false;
            cmbKho.Enabled = false;



            /*Bat chuc nang cua chi tiet don hang*/
            txtMaVT.Enabled = false;

            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;


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

                this.panelCTPN.Enabled = false;


            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;

                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = true;
                this.btnEXIT.Enabled = true;

                this.txtMaPN.Enabled = false;
                this.cmbChiNhanh.Enabled = false;
                this.panelCTPN.Enabled = true;

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

        private void btnCTDDH_Click(object sender, EventArgs e)
        {
      //      Lay MasoDDH hien tai cua gcPhieuNhap de so sanh voi MasoDDH se duoc chon
            Program.maDonDatHangDuocChon = ((DataRowView)(bdsPhieuNhap.Current))["MADDH"].ToString().Trim();

            //Console.WriteLine(Program.maDonDatHangDuocChon);
            FormChonCTDDH form = new FormChonCTDDH();
            form.ShowDialog();



            this.txtMaVT.Text = Program.maVatTuDuocChon;
            this.txtSoLuong.Value = Program.soLuongVatTu;
            this.txtDonGia.Value = Program.donGia;
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

            if (btnMenu.Links[0].Caption == "Chi tiết phiếu nhập")
            {
                DataRowView drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Bạn không thêm chi tiết phiếu nhập trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    bdsCTPN.RemoveCurrent();
                    return;
                }

               /*Gan tu dong may truong du lieu nay*/
               ((DataRowView)(bdsCTPN.Current))["MAPN"] = ((DataRowView)(bdsPhieuNhap.Current))["MAPN"];
                ((DataRowView)(bdsCTPN.Current))["MAVT"] =
                    Program.maVatTuDuocChon;
                ((DataRowView)(bdsCTPN.Current))["SOLUONG"] =
                    Program.soLuongVatTu;
                ((DataRowView)(bdsCTPN.Current))["DONGIA"] =
                    Program.donGia;

                this.txtMaVT.Enabled = false;
                this.btnCTDDH.Enabled = true;

                this.txtSoLuong.Enabled = true;
                this.txtSoLuong.EditValue = 1;

                this.txtDonGia.Enabled = true;
                this.txtDonGia.EditValue = 1;

             //   this.txtSoLuongChiTietPhieuNhap.Enabled = true;
              //  this.txtDonGiaChiTietPhieuNhap.Enabled = true;
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
            /* Step 0 */
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                dangThemMoi = false;

                /*dang o che do Phiếu nhập*/
                if (btnMenu.Links[0].Caption == "Phiếu hập")
                {
                 
                    deNgayLap.Enabled = false;
                    txtDDH.Enabled = false;
                    txtMaKho.Enabled = false;

                }
                /*dang o che do Chi tiết phiếu nhập*/
                /*if (btnMENU.Links[0].Caption == "Chi tiết phiếu nhập")
                {
                    this.txtMaDonDatHang.Enabled = false;
                    this.btnChonChiTietDonHang.Enabled = false;

                    this.txtMaVatChiTietPhieuNhap.Enabled = false;
                    this.txtSoLuongChiTietPhieuNhap.Enabled = false;
                    this.txtDonGiaChiTietPhieuNhap.Enabled = false;

                    this.btnXOA.Enabled = false;
                }*/

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

                if (Regex.IsMatch(txtMaPN.Text, @"^[a-zA-Z0-9, ]+$") == false)
                {
                    MessageBox.Show("Mã Phiếu nhập chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                    txtMaVT.Focus();
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

            /*if (cheDo == "Chi tiết phiếu nhập")
            {
                *//*Do chung khoa chinh cua no la MAPN + MAVT*/
                /* tạo 2 Phiếu nhập cùng mã đơn hàng thì bị lỗi do maDonHang trong phiếu 
                 * nhập chỉ được xuất hiện 1 lần duy nhất
                 */
                /*
                if (bdsChiTietPhieuNhap.Count > 1)
                {
                    MessageBox.Show("Không thể thêm Chi tiết phiếu nhập quá 1 lần", "Thông báo", MessageBoxButtons.OK);
                    bdsChiTietPhieuNhap.RemoveCurrent();
                    return false;
                }*//*

                if (txtMaVatChiTietPhieuNhap.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã vật tư !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (txtSoLuongChiTietPhieuNhap.Value < 0 ||
                    txtSoLuongChiTietPhieuNhap.Value > Program.soLuongVatTu)
                {
                    MessageBox.Show("Số lượng vật tư không thể lớn hơn số lượng vật tư trong chi tiết đơn hàng !", "Thông báo", MessageBoxButtons.OK);
                    txtSoLuongChiTietPhieuNhap.Focus();
                    return false;
                }

                if (txtDonGiaChiTietPhieuNhap.Value < 1)
                {
                    MessageBox.Show("Đơn giá không thể nhỏ hơn 1 VND", "Thông báo", MessageBoxButtons.OK);
                    txtDonGiaChiTietPhieuNhap.Focus();
                    return false;
                }
            }*/

            return true;
        }


        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
            drv["MAKHO"] = cmbKho.SelectedValue.ToString();
            /*Step 1*/
            String cheDo = (btnMenu.Links[0].Caption == "Phiếu nhập") ? "Phiếu nhập" : "Chi tiết phiếu nhập";


            /*Step 2*/
            bool ketQua = kiemTraDuLieuDauVao(cheDo);
            if (ketQua == false) return;



            /*Step 3*/
            string cauTruyVanHoanTac = taoCauTruyVanHoanTac(cheDo);


            /*Step 4*/
            String maPhieuNhap = txtMaPN.Text.Trim();
            //Console.WriteLine(maPhieuNhap);
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
                        //Console.WriteLine(txtMaNhanVien.Text);
                        /*TH1: them moi phieu nhap*/
                        if (cheDo == "Phiếu nhập" && dangThemMoi == true)
                        {
                            drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                            drv["MAKHO"] = cmbKho.SelectedValue.ToString();

                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.PHIEUNHAP " +
                                "WHERE MAPN = '" + maPhieuNhap + "'";
                        }

                        /*TH2: them moi chi tiet don hang*/
                        /*if (cheDo == "Chi tiết phiếu nhập" && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.CTPN " +
                                "WHERE MAPN = '" + maPhieuNhap + "' " +
                                "AND MAVT = '" + Program.maVatTuDuocChon + "'";

                            string maVatTu = txtMaVatChiTietPhieuNhap.Text.Trim();
                            int soLuong = (int)txtSoLuongChiTietPhieuNhap.Value;

                            capNhatSoLuongVatTu(maVatTu, soLuong);
                        }
*/
                        /*TH3: chinh sua phieu nhap -> chang co gi co the chinh sua
                         * duoc -> chang can xu ly*/
                        /*TH4: chinh sua chi tiet phieu nhap - > thi chi can may dong lenh duoi la xong*/
                        undoList.Push(cauTruyVanHoanTac);
                        Console.WriteLine("cau truy van hoan tac");
                        Console.WriteLine(cauTruyVanHoanTac);

                        this.bdsPhieuNhap.EndEdit();
                   //     this.bdsChiTietPhieuNhap.EndEdit();
                        this.PHIEUNHAPTableAdapter.Update(this.dataSet.PHIEUNHAP);
                     //   this.chiTietPhieuNhapTableAdapter.Update(this.dataSet.CTPN);

                        this.btnTHEM.Enabled = true;
                        this.btnXOA.Enabled = true;
                        this.btnGHI.Enabled = true;
                        txtMaPN.Enabled = false;

                        this.btnHOANTAC.Enabled = true;
                        this.btnLAMMOI.Enabled = true;
                        this.btnMenu.Enabled = true;
                        this.btnEXIT.Enabled = true;

                     

                      //  this.txtSoLuongChiTietPhieuNhap.Enabled = false;
                       // this.txtDonGiaChiTietPhieuNhap.Enabled = false;
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


        private String taoCauTruyVanHoanTac(String cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;

            /*TH1: dang sua phieu nhap - nhung ko co truong du lieu nao co the cho sua duoc ca*/
            if (cheDo == "Phiếu nhập" && dangThemMoi == false)
            {
                // khong co gi ca
            }

            /*TH2: them moi phieu nhap*/
            if (cheDo == "Phiếu nhập" && dangThemMoi == true)
            {
                // tao trong btnGHI thi hon
            }

            /*TH3: them moi chi tiet phieu nhap*/
            if (cheDo == "Chi tiết phiếu nhập" && dangThemMoi == true)
            {
                // tao trong btnGHI thi hon
            }

            /*TH4: dang sua chi tiet phieu nhap*/
           /* if (cheDo == "Chi tiết phiếu nhập" && dangThemMoi == false)
            {
                drv = ((DataRowView)(bdsChiTietPhieuNhap.Current));
                int soLuong = int.Parse(drv["SOLUONG"].ToString().Trim());
                float donGia = float.Parse(drv["DONGIA"].ToString().Trim());
                String maPhieuNhap = drv["MAPN"].ToString().Trim();
                String maVatTu = drv["MAVT"].ToString().Trim();

                cauTruyVan = "UPDATE DBO.CTPN " +
                    "SET " +
                    "SOLUONG = " + soLuong + ", " +
                    "DONGIA = " + donGia + " " +
                    "WHERE MAPN = '" + maPhieuNhap + "' " +
                    "AND MAVT = '" + maVatTu + "' ";
            }*/

            return cauTruyVan;
        }




        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv;
            string cauTruyVanHoanTac = "";
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

                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);

                cauTruyVanHoanTac = "INSERT INTO DBO.PHIEUNHAP(MAPN, NGAYLAP, MADDH, MANV, MAKHO) " +
                    "VALUES( '" + drv["MAPN"].ToString().Trim() + "', '" +
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["MADDH"].ToString() + "', '" +
                    drv["MANV"].ToString() + "', '" +
                    drv["MAKHO"].ToString() + "')";

            }
/*
            if (cheDo == "Chi tiết phiếu nhập")
            {
                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Bạn không xóa Chi tiết phiếu nhập không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


                drv = ((DataRowView)bdsChiTietPhieuNhap[bdsChiTietPhieuNhap.Position]);
                cauTruyVanHoanTac = "INSERT INTO DBO.CTPN(MAPN, MAVT, SOLUONG, DONGIA) " +
                    "VALUES('" + drv["MAPN"].ToString().Trim() + "', '" +
                    drv["MAVT"].ToString().Trim() + "', " +
                    drv["SOLUONG"].ToString().Trim() + ", " +
                    drv["DONGIA"].ToString().Trim() + ")";
            }*/

            undoList.Push(cauTruyVanHoanTac);
            //Console.WriteLine("Line 842");
            //Console.WriteLine(cauTruyVanHoanTac);

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
                        bdsPhieuNhap.RemoveCurrent();
                    }
                    /*if (cheDo == "Chi tiết phiếu nhập")
                    {
                        bdsChiTietPhieuNhap.RemoveCurrent();
                    }*/


                    this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PHIEUNHAPTableAdapter.Update(this.dataSet.PHIEUNHAP);

                  //  this.chiTietPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                  //  this.chiTietPhieuNhapTableAdapter.Update(this.dataSet.CTPN);

                    //bdsPhieuNhap.Position = viTri;
                    /*Cap nhat lai do ben tren can tao cau truy van nen da dat dangThemMoi = true*/
                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa phiếu nhập. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PHIEUNHAPTableAdapter.Update(this.dataSet.PHIEUNHAP);

               //     this.chiTietPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
              //      this.chiTietPhieuNhapTableAdapter.Update(this.dataSet.CTPN);
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





    }
}
