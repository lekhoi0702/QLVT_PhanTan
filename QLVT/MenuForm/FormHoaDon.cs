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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormHoaDon : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        public string makho = "";
        string maChiNhanh = "";
        Stack undoList = new Stack();
        BindingSource bds = null;
        GridControl gc = null;
        string type = "";
        String maHoaDon = "";
        bool danhDauXoa = false;


        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
     

        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHoaDon.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.CTHDTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTHDTableAdapter.Fill(this.dataSet.CTHD);

            this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOADONTableAdapter.Fill(this.dataSet.HOADON);

            this.VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VATTUTableAdapter.Fill(this.dataSet.VATTU);


            this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOTableAdapter.Fill(this.dataSet.KHO);


            this.KHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHACHHANGTableAdapter.Fill(this.dataSet.KHACHHANG);



            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;
            bds = bdsHoaDon;
            gc = gcHoaDon;

            this.panelHD.Enabled = false;
            this.panelCTHD.Enabled = false;
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

            /*Step 0*/
            btnMenu.Links[0].Caption = "Hoá đơn";

            /*Step 1*/
            bds = bdsHoaDon;
            gc = gcHoaDon;
            //MessageBox.Show("Chế Độ Làm Việc Hoá đơn", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Bat chuc nang cua don dat hang*/
            txtMaHD.Enabled = false;
            deNgayLap.Enabled = false;

            txtMaKH.Enabled = true;
            txtMaNV.Enabled = false;

            txtMaKho.Enabled = false;
            cmbKho.Enabled = true;
            this.panelHD.Enabled = false;


            /*Tat chuc nang cua chi tiet don hang*/
            txtMaVT.Enabled = false;
            cmbVatTu.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;


            /*Bat cac grid control len*/
            gcHoaDon.Enabled = true;
            gcCTHD.Enabled = true;


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

                this.panelHD.Enabled = false;


            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsHoaDon.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;


                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = true;
                this.btnEXIT.Enabled = true;
                this.panelHD.Enabled = true;
                this.txtMaHD.Enabled = false;
                this.txtMaKH.Enabled = false;
                this.cmbKho.Enabled = true;
                this.cmbKhachHang.Enabled = false;
                this.btnGHI.Enabled = true;

            }
        }


        private void btnCheDoCTHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            /*Step 0*/
            btnMenu.Links[0].Caption = "Chi tiết hoá đơn";

            /*Step 1*/
            bds = bdsCTHD;
            gc = gcCTHD;

            //MessageBox.Show("Chế Độ Làm Việc Chi tiết hoá đơn", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Tat chuc nang don dat hang*/
            this.panelHD.Enabled = false;
      

            /*Bat chuc nang cua chi tiet don hang*/
            txtMaVT.Enabled = false;
            this.cmbVatTu.Enabled = false;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            this.btnGHI.Enabled = true;
            cmbVatTu.Enabled = false;

            /*Bat cac grid control len*/
            gcHoaDon.Enabled = true;
            gcCTHD.Enabled = true;
         
          

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




            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;

                this.btnXOA.Enabled = true;
             

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = true;
                this.btnEXIT.Enabled = true;
                this.panelCTHD.Enabled = true;
                this.panelHD.Enabled = false;

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
       
            if (btnMenu.Links[0].Caption == "Hoá đơn")
            {
                bdsHoaDon.AddNew();
                this.txtMaHD.Enabled = true;
                //this.txtMaKho.Text = "";
                this.deNgayLap.EditValue = DateTime.Now;
                this.deNgayLap.Enabled = false;
                this.txtMaKH.Enabled = false;
                this.txtMaNV.Text = Program.userName;
                this.cmbKho.Enabled = true;
                this.cmbKhachHang.Enabled = true;
                /*Gan tu dong may truong du lieu nay*/
                ((DataRowView)(bdsHoaDon.Current))["MANV"] = Program.userName;
                ((DataRowView)(bdsHoaDon.Current))["NGAYLAP"] = DateTime.Now;
            }

            if (btnMenu.Links[0].Caption == "Chi tiết hoá đơn")
            {
                bdsCTHD.AddNew();
                DataRowView drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                String MaNV = drv["MANV"].ToString();

                

                if (Program.userName != MaNV)
                {
                    MessageBox.Show("Bạn không thể thêm chi tiết hoá đơn trên phiếu này!!!", "Thông báo", MessageBoxButtons.OK);
                    bdsCTHD.RemoveCurrent();
                    return;
                }
                drv = ((DataRowView)bdsCTHD[bdsCTHD.Position]);
                drv["MAHD"] = this.txtMaHD.Text.ToString().Trim();
                this.panelCTHD.Enabled = true;
                this.txtMaVT.Enabled = false;
                this.cmbVatTu.Enabled = true;
                this.txtSoLuong.Enabled = true;
                this.txtDonGia.Enabled = true;
                this.cmbKho.Enabled = false;
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
            if (cheDo == "Hoá đơn")
            {
                if (Regex.IsMatch(txtMaHD.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") == false)
                {
                    MessageBox.Show("Mã Đơn hàng chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                    txtMaHD.Focus();
                    return false;
                }

                if (txtMaHD.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã hoá đơn", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMaHD.Text.Length > 10)
                {
                    MessageBox.Show("Mã Hoá đơn không quá 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            }
            if (cheDo == "Chi tiết hoá đơn")
            {

                if (txtSoLuong.Value <= 0 || txtDonGia.Value <= 0)
                {
                    MessageBox.Show("Số lượng và đơn giá không thể bé hơn 0", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

            }
            return true;
        }



        private String taoCauTruyVanHoanTac(String cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;


            /*Dang chinh sua don dat hang*/
            if (cheDo == "Hoá đơn" && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                /*Ngay can duoc xu ly dac biet hon*/
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);

                cauTruyVan = "UPDATE DBO.HOADON " +
                    "SET " +
                    "NGAYLAP = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATE), " +
                    "MAKH = '" + drv["MAKH"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "' " +
                    "WHERE MAHD = '" + drv["MAHD"].ToString().Trim() + "'";
            }
            /*Dang xoa don dat hang*/
            if (cheDo == "Hoá đơn" && dangThemMoi == false && danhDauXoa == true)
            {
                drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);
                cauTruyVan = "INSERT INTO DBO.HOADON(MAHD, NGAYLAP, MAKH, MANV, MAKHO) " +
                    "VALUES('" + drv["MAHD"].ToString().Trim() + "', '" +
                    ngay.ToString("yyyy-MM-dd").Trim() + "', '" +
                    drv["MAKH"].ToString().Trim() + "', '" +
                    drv["MaNV"].ToString().Trim() + "', '" +
                    drv["MAKHO"].ToString().Trim() + "' )";

            }

            /*Dang chinh sua chi tiet don dat hang*/
            if (cheDo == "Chi tiết hoá đơn" && dangThemMoi == false && danhDauXoa == false)
            {
                drv = ((DataRowView)bdsCTHD[bdsCTHD.Position]);
                cauTruyVan = "UPDATE DBO.CTHD " +
                    "SET " +
                    "SOLUONG = " + drv["SOLUONG"].ToString() + " , " +
                    "DONGIA = " + drv["DONGIA"].ToString() + " " +
                    "WHERE MAHD = '" + drv["MAHD"].ToString().Trim() + "'" +
                    " AND MAVT = '" + drv["MAVT"].ToString().Trim() + "'";

            }
            if (cheDo == "Chi tiết hoá đơn" && dangThemMoi == false && danhDauXoa == true)
            {
                drv = ((DataRowView)bdsCTHD[bdsCTHD.Position]);

                cauTruyVan = "INSERT INTO DBO.CTHD(MAHD,MAVT,SOLUONG,DONGIA) " +
                    "VALUES('" + drv["MAHD"].ToString().Trim() + "', '" +
                    drv["MAVT"].ToString().Trim() + "', '" +
                    drv["SOLUONG"].ToString().Trim() + "', '" +
                    drv["DONGIA"].ToString().Trim() + "' )";

            }


            return cauTruyVan;
        }


        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsCTHD.Count == 0 && dangThemMoi == false)
            {
                MessageBox.Show("Chi tiết hoá đơn trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }



            if (bdsHoaDon.Count == 0 && dangThemMoi == false)
            {
                MessageBox.Show("Hoá đơn trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            else
            {

                viTri = bdsHoaDon.Position;
                DataRowView drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                String maNhanVien = drv["MANV"].ToString();
                String maHoaDon = drv["MAHD"].ToString().Trim();
                


                if (Program.userName != maNhanVien && dangThemMoi == false)
                {
                    MessageBox.Show("Bạn không thể sửa phiếu do người khác lập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                /*Step 2*/
                String cheDo = (btnMenu.Links[0].Caption == "Hoá đơn") ? "Hoá đơn" : "Chi tiết hoá đơn";
                bool ketQua = kiemTraDuLieuDauVao(cheDo);
                if (ketQua == false) return;

                String cauTruyVanHoanTac = "";

                /*Step 3*/
                String maHoaDonMoi = txtMaHD.Text.Trim();
                String cauTruyVan =
                        "DECLARE	@result int " +
                        "EXEC @result = sp_KiemTraMaHoaDon '" +
                        maHoaDonMoi.Trim() + "' " +
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
                int viTrimaHoaDon = bdsHoaDon.Find("MaHD", txtMaHD.Text.Trim());




                /******************************************************************
                 * truong hop them moi don dat hang moi quan tam xem no ton tai hay
                 * chua ?
                 ******************************************************************/
                if (result == 1 && cheDo == "Hoá đơn" && viTriHienTai != viTrimaHoaDon)
                {
                    MessageBox.Show("Mã hoá đơn này đã được sử dụng !\n\n", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        
                            /*TH1: them moi don dat hang*/
                            if (cheDo == "Hoá đơn" && dangThemMoi == true)

                            {
                                drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                                drv["MAHD"] = txtMaHD.Text.Trim().ToString();
                                drv["MAKHO"] = cmbKho.SelectedValue.ToString();
                                drv["MAKH"] = cmbKhachHang.SelectedValue.ToString();
                              
                                maHoaDon = drv["MAHD"].ToString().Trim();
                                cauTruyVanHoanTac =
                                    "DELETE FROM DBO.HoaDon " +
                                    "WHERE MAHD = '" + maHoaDon.Trim() + "'";
                                undoList.Push(cauTruyVanHoanTac);
                                Console.WriteLine(cauTruyVanHoanTac);
                                btnMenu.Links[0].Caption = "Chi tiết hoá đơn";

                            }


                            if (cheDo == "Hoá đơn" && dangThemMoi == false)
                            {


                                danhDauXoa = false;
                                String query = taoCauTruyVanHoanTac(cheDo);
                                undoList.Push(query);
                                String test = undoList.Peek() as string;
                                Console.WriteLine(test);
                                drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                                drv["MAKHO"] = cmbKho.SelectedValue.ToString();






                            }

                            /*TH2: them moi chi tiet don hang*/
                            if (cheDo == "Chi tiết hoá đơn" )

                            {
                                DataRowView drv3 = ((DataRowView)bdsCTHD[bdsCTHD.Position]);
                                int soLuong = (int)txtSoLuong.Value;
                                String maVT = "";
                                String maVatTu = cmbVatTu.SelectedValue.ToString().Trim();
                              /*  Console.WriteLine(maVatTu);
                                Console.WriteLine(dangThemMoi);*/

                                String cauTruyVan3 =
                                                "DECLARE	@result int ;" +
                                                "EXEC @result = sp_KiemTraSoLuong " +
                                                "@MAVT ='" + maVatTu + "'," +
                                                "@SOLUONG = '" + txtSoLuong.Value +

                                                "'SELECT 'return value' = @result";
                                Console.WriteLine("kiem tra so luong vat tu=" + cauTruyVan3);
                                SqlCommand sqlCommand3= new SqlCommand(cauTruyVan3, Program.conn);
                                try
                                {
                                    Program.myReader = Program.ExecSqlDataReader(cauTruyVan3);
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
                                int result3 = int.Parse(Program.myReader.GetValue(0).ToString());
                                Program.myReader.Close();
                                if (result3 != 1)
                                {
                                    MessageBox.Show("Số lượng vật tư hiện có là "+result3, "Thông báo", MessageBoxButtons.OK);
                                    return;
                                }

                                if (dangThemMoi == true)
                                { 
                                        String cauTruyVan2 =
                                                "DECLARE	@result int " +
                                                "EXEC @result = sp_KiemTraMaVTTrongCTHD " +
                                                "@MAHD ='" + maHoaDon + "'," +
                                                "@MAVT = '" + cmbVatTu.SelectedValue.ToString().Trim() +

                                                "'SELECT 'return value' = @result";
                                        SqlCommand sqlCommand2 = new SqlCommand(cauTruyVan2, Program.conn);
                                        try
                                        {
                                            Program.myReader = Program.ExecSqlDataReader(cauTruyVan2);
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
                                        MessageBox.Show("Vật tư này đã có rồi!!!", "Thông báo", MessageBoxButtons.OK);
                                        return;
                                    }
                                    maVT = cmbVatTu.SelectedValue.ToString().Trim();


                                    
                                    
                                        cauTruyVanHoanTac =
                                     "DELETE FROM DBO.CTHD " +
                                     "WHERE MAHD = '" + txtMaHD.Text.Trim() + "' " +
                                     "AND MAVT = '" + cmbVatTu.SelectedValue.ToString().Trim() + "'";
                                        undoList.Push(cauTruyVanHoanTac);
                                        String test = undoList.Peek() as string;
                                        Console.WriteLine("Cau hoan tac: " + test);
                                        DataRowView drv2 = ((DataRowView)bdsCTHD[bdsCTHD.Position]);
                                        drv2["MAVT"] = maVatTu;
                                        drv2["SOLUONG"] = (int)txtSoLuong.Value;
                                        drv2["DONGIA"] = (int)txtDonGia.Value;
                                   
                                    
                                }

                                if (dangThemMoi == false)
                                {



                                    maVT = txtMaVT.Text.ToString().Trim();                                    
                                        danhDauXoa = false;
                                        String query = taoCauTruyVanHoanTac(cheDo);
                                        undoList.Push(query);
                                        String test = undoList.Peek() as string;
                                        Console.WriteLine("Cau hoan tac: " + test);
                                        drv = ((DataRowView)bdsCTHD[bdsCTHD.Position]);
                                   
                                        drv["SOLUONG"] = txtSoLuong.Value.ToString();
                                        drv["DONGIA"] = txtDonGia.Value.ToString();
                                    
                                }
                                capNhatSLT(maVT, soLuong);


                            }
                            
                            this.bdsHoaDon.EndEdit();
                            this.bdsCTHD.EndEdit();
                            this.CTHDTableAdapter.Update(this.dataSet.CTHD);
                            this.HOADONTableAdapter.Update(this.dataSet.HOADON);


                            this.btnTHEM.Enabled = true;
                            this.btnXOA.Enabled = true;
                            this.btnGHI.Enabled = true;
                            this.cmbKhachHang.Enabled = false;
                            this.cmbVatTu.Enabled = false;

                            this.btnHOANTAC.Enabled = true;
                            this.btnLAMMOI.Enabled = true;
                            this.btnMenu.Enabled = true;
                            this.btnEXIT.Enabled = true;
                            this.txtMaHD.Enabled = false;
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


        }


        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsHoaDon.Position;
            /* Step 0 */
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                /*Console.WriteLine(bdsCTHD.Count);
                Console.WriteLine(bdsCTHD.Position);*/
                dangThemMoi = false;

                /*dang o che do Don Dat Hang*/
                if (btnMenu.Links[0].Caption == "Hoá đơn")
                {
                    bdsHoaDon.CancelEdit();
                    /*xoa dong hien tai*/
                    bdsHoaDon.RemoveCurrent();
                    /* trở về lúc đầu con trỏ đang đứng*/

                    bdsHoaDon.Position = viTri;
                    this.txtMaHD.Enabled = false;

                    //this.dteNGAY.EditValue = DateTime.Now;
                    this.deNgayLap.Enabled = false;
                    this.txtMaKH.Enabled = false;
                    //this.txtMaNhanVien.Text = Program.userName;
                    this.cmbKho.Enabled = true;
                    this.btnHOANTAC.Enabled = false;
                }
                /*dang o che do Chi Tiet Don Dat Hang*/
                if (btnMenu.Links[0].Caption == "Chi tiết hoá đơn")
                {
                    if (bdsCTHD.Count > 1)
                    {
                        bdsCTHD.CancelEdit();
                        bdsCTHD.RemoveCurrent();
                    }
                    bdsCTHD.Position = viTri;
                    this.txtMaVT.Enabled = false;
                    this.cmbVatTu.Enabled = false;
                }

                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                //this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMenu.Enabled = true;
                this.btnEXIT.Enabled = true;



                return;
            }


            if (dangThemMoi == false && btnTHEM.Enabled == true && danhDauXoa == false)

            {

                if (undoList.Count == 0)
                {
                    MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                    btnHOANTAC.Enabled = false;
                    return;
                }
                String query = undoList.Pop() as string;
                Program.ExecSqlDataTable(query);
                this.btnHOANTAC.Enabled = false;
            }
            if (dangThemMoi == false && danhDauXoa == true)

            {

                String query = undoList.Pop() as string;
                Program.ExecSqlDataTable(query);
                btnHOANTAC.Enabled = false;
            }

            /*Step 1*/
            /*       if (undoList.Count == 0)
                   {
                       MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                       btnHOANTAC.Enabled = false;
                       return;
                   }*/

            /*Step 2*/
            /* bdsCTHD.CancelEdit();
            *//* String cauTruyVanHoanTac = undoList.Pop().ToString();*//*

             Console.WriteLine(cauTruyVanHoanTac);
             int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);*/

            this.HOADONTableAdapter.Fill(this.dataSet.HOADON);
            this.CTHDTableAdapter.Fill(this.dataSet.CTHD);
            bdsHoaDon.Position = viTri;


        }


        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.HOADONTableAdapter.Fill(this.dataSet.HOADON);
                this.CTHDTableAdapter.Fill(this.dataSet.CTHD);

                this.gcHoaDon.Enabled = true;
                this.gcCTHD.Enabled = true;

                bdsHoaDon.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }


        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
            String maNhanVien = drv["MANV"].ToString();
            if (Program.userName != maNhanVien)
            {
                MessageBox.Show("Không thể xoá đơn không phải do mình tạo!!!", "Thông báo", MessageBoxButtons.OK);
                //bdsChiTietDonDatHang.RemoveCurrent();
                return;
            }

            string cauTruyVan = "";
            string cheDo = (btnMenu.Links[0].Caption == "Hoá đơn") ? "Hoá đơn" : "Chi tiết hoá đơn";

            // dangThemMoi = true;// bat cai nay len de ung voi dieu kien tao cau truy van

            if (cheDo == "Hoá đơn")
            {
                /*Cái bdsChiTietDonHangHang là đại diện cho binding source riêng biệt của CTHD
                 *Còn CTHDBindingSource là lấy ngay từ trong data source DATHANG
                 */
                if (bdsCTHD.Count > 0)
                {
                    MessageBox.Show("Không thể xóa Hoá đơn này vì có Chi tiết hoá đơn", "Thông báo", MessageBoxButtons.OK);
                    return;
                }



            }

            if (cheDo == "Chi tiết hoá đơn")
            {

                if (bdsCTHD.Count == 0)
                {
                    MessageBox.Show("Chi tiết đơn hàng trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
               
            }

            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bds.Position;
                    if (cheDo == "Hoá đơn")
                    {
                        danhDauXoa = true;
                        dangThemMoi = false;
                        String queryHoanTac = taoCauTruyVanHoanTac(cheDo);
                        undoList.Push(queryHoanTac);
                        String cauHoanTac = undoList.Peek() as string;
                        Console.WriteLine(cauHoanTac);
                        bdsHoaDon.RemoveCurrent();


                    }
                    if (cheDo == "Chi tiết hoá đơn")
                    {
                        viTri = bdsCTHD.Position;
                        danhDauXoa = true;
                        dangThemMoi = false;
                        String queryHoanTac = taoCauTruyVanHoanTac(cheDo);
                        undoList.Push(queryHoanTac);
                        String cauHoanTac = undoList.Peek() as string;
                        Console.WriteLine(cauHoanTac);
                        bdsCTHD.RemoveCurrent(); ;
                    }


                    this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.HOADONTableAdapter.Update(this.dataSet.HOADON);

                    this.CTHDTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTHDTableAdapter.Update(this.dataSet.CTHD);

                    /*Cap nhat lai do ben tren can tao cau truy van nen da dat dangThemMoi = true*/
                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                    this.btnGHI.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa CTHD Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.HOADONTableAdapter.Update(this.dataSet.HOADON);

                    this.CTHDTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTHDTableAdapter.Update(this.dataSet.CTHD);
                    // tro ve vi tri cua nhan vien dang bi loi

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
                this.CTHDTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTHDTableAdapter.Fill(this.dataSet.CTHD);

                this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HOADONTableAdapter.Fill(this.dataSet.HOADON);

            }
        }

        private void capNhatSLT(string maVatTu, int soLuong)
        {
            string cauTruyVan = "DECLARE @RETURN INT; " +
                "EXEC @RETURN = sp_CapNhatSLT @CHEDO = 'XUAT'" +
                ",@MAVT = '" + maVatTu + "'," +
                "@SOLUONG='" + soLuong + "';" +
                "SELECT'RETURN VALUE' = @RETURN";
            int n = Program.ExecSqlNonQuery(cauTruyVan);
            Console.WriteLine("cap nhat so luong ton = " + cauTruyVan);
        }






    }
}

