using DevExpress.XtraGrid;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
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

            Console.WriteLine(Program.maDonDatHangDuocChon);
            Console.WriteLine(Program.soLuongVatTu);
            Console.WriteLine(Program.donGia);
            this.txtMaVT.Text = Program.maVatTuDuocChon.ToString();
            this.txtSoLuong.Value = Program.soLuongVatTu;
            this.txtDonGia.Value = Program.donGia;

            bds.AddNew();
            DataRowView drv = ((DataRowView)bdsCTPN[bdsCTPN.Position]);
            drv["MAVT"] = txtMaVT.Text.ToString();
            drv["SOLUONG"] = txtSoLuong.Value;
            drv["DONGIA"] = txtDonGia.Value;
            drv["MAPN"] = txtMaPN.Text.ToString();
             

        }



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

                if (btnMenu.Links[0].Caption == "Chi tiết phiếu nhập")
                {
                    this.txtDDH.Enabled = false;
                    this.btnCTDDH.Enabled = false;

                    this.txtMaVT.Enabled = false;
                    this.txtSoLuong.Enabled = false;
                    this.txtDonGia.Enabled = false;

                    this.btnXOA.Enabled = false;
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

                if (Regex.IsMatch(txtMaPN.Text, @"^[a-zA-Z0-9,]+$") == false)
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

            if (cheDo == "Chi tiết phiếu nhập")
            {

             if ((int)txtSoLuong.Value < 0 ||
                    txtSoLuong.Value > Program.soLuongVatTu)
                {
                    MessageBox.Show("Số lượng vật tư không thể lớn hơn số lượng vật tư trong chi tiết đơn hàng !", "Thông báo", MessageBoxButtons.OK);
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
            
            else
            {

                
                /*Step 1*/
                String cheDo = (btnMenu.Links[0].Caption == "Phiếu nhập") ? "Phiếu nhập" : "Chi tiết phiếu nhập";


                /*Step 2*/
                bool ketQua = kiemTraDuLieuDauVao(cheDo);
                if (ketQua == false) return;

                DataRowView drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                drv["MAKHO"] = cmbKho.SelectedValue.ToString();



                /*Step 3*/
                string queryHoanTac = taoqueryHoanTac(cheDo);


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

                            if (cheDo == "Phiếu nhập" && dangThemMoi == true)
                            {
                                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                                drv["MAKHO"] = cmbKho.SelectedValue.ToString();
                                MAPNDuocChon = drv["MAPN"].ToString();
                                MADDHDuocChon = drv["MADDH"].ToString();

                                queryHoanTac =
                                    "DELETE FROM DBO.PHIEUNHAP " +
                                    "WHERE MAPN = '" + maPhieuNhap + "'";
                            }


                            if (cheDo == "Chi tiết phiếu nhập" && dangThemMoi == true)
                            {
                                queryHoanTac =
                                    "DELETE FROM DBO.CTPN " +
                                    "WHERE MAPN = '" + maPhieuNhap + "' " +
                                    "AND MAVT = '" + Program.maVatTuDuocChon + "'";

                                string maVatTu = txtMaVT.Text.Trim();
                                int soLuong = (int)txtSoLuong.Value;

                                capNhatSLT(maVatTu, soLuong);
                            }


                            undoList.Push(queryHoanTac);


                            this.bdsPhieuNhap.EndEdit();
                            //     this.bdsChiTietPhieuNhap.EndEdit();
                            this.PHIEUNHAPTableAdapter.Update(this.dataSet.PHIEUNHAP);
                            String query = "DECLARE	@result int; " +
                        "EXEC @result = sp_TaoPhieuNhap @MADDH = '" +
                        MADDHDuocChon +"',"+ " @MAPN = '" +
                         MAPNDuocChon +"';"+
                        "SELECT  = @result";
                            Console.WriteLine(query);

                            Program.myReader = Program.ExecSqlDataReader(query);
                            try
                            {
                                Program.myReader = Program.ExecSqlDataReader(query);
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
                            int result2 = int.Parse(Program.myReader.GetValue(0).ToString());
                            Program.myReader.Close();
                            if (result2 == 1)
                            {
                                MessageBox.Show("Ghi thành công ", "Thông báo", MessageBoxButtons.OK);
                            }
                            else {
                                MessageBox.Show("Da xay ra loi !" , "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bdsPhieuNhap.RemoveCurrent();
                                bdsPhieuNhap.Position = viTri;
                     
                            }


                            //   this.chiTietPhieuNhapTableAdapter.Update(this.dataSet.CTPN);

                            this.btnTHEM.Enabled = true;
                            this.btnXOA.Enabled = true;
                            this.btnGHI.Enabled = true;
                            txtMaPN.Enabled = false;

                            this.btnHOANTAC.Enabled = true;
                            this.btnLAMMOI.Enabled = true;
                            this.btnMenu.Enabled = true;
                            this.btnEXIT.Enabled = true;



                            this.txtSoLuong.Enabled = false;
                            this.txtDonGia.Enabled = false;
                            /*cập nhật lại trạng thái thêm mới cho chắc*/
                            dangThemMoi = false;

                            
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
            

        }


        private String taoqueryHoanTac(String cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;


            if (cheDo == "Phiếu nhập" && dangThemMoi == false)
            {

            }



            if (cheDo == "Chi tiết phiếu nhập" && dangThemMoi == false)
            {
                drv = ((DataRowView)(bdsCTPN.Current));
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
            }

            return cauTruyVan;
        }




        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv;
            string queryHoanTac = "";
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

                queryHoanTac = "INSERT INTO DBO.PHIEUNHAP(MAPN, NGAYLAP, MADDH, MANV, MAKHO) " +
                    "VALUES( '" + drv["MAPN"].ToString().Trim() + "', '" +
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["MADDH"].ToString() + "', '" +
                    drv["MANV"].ToString() + "', '" +
                    drv["MAKHO"].ToString() + "')";

            }

            if (cheDo == "Chi tiết phiếu nhập")
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

            undoList.Push(queryHoanTac);


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
                    if (cheDo == "Chi tiết phiếu nhập")
                    {
                        bdsCTPN.RemoveCurrent();
                    }


                    this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PHIEUNHAPTableAdapter.Update(this.dataSet.PHIEUNHAP);

                    this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPNTableAdapter.Update(this.dataSet.CTPN);

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

                    this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPNTableAdapter.Update(this.dataSet.CTPN);
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
            string cauTruyVan = "DECLARE @RETURN INT" +
                "EXEC @RETURN = sp_CapNhatSLT @CHEDO = 'NHAP'" +
                ",@MAVT = '" + maVatTu + "'," +
                "@SOLUONG='" + soLuong + "'" +
                "SELECT'RETURN VALUE = @RETURN'";


            int n = Program.ExecSqlNonQuery(cauTruyVan);
            Console.WriteLine(cauTruyVan);
        }

    }
}
