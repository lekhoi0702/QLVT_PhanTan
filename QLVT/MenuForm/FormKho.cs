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

            

            cmbChiNhanh.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;
         


            if (bdsKho.Count == 0)
            {
                maChiNhanh = cmbChiNhanh.Text.ToString().Trim();
                String cauTruyVan =
                   "DECLARE	@MaCN nvarchar(10) ;" +
                   "EXEC sp_LayMaChiNhanh '" +
                   cmbChiNhanh.Text.ToString().Trim() + "',@MaCN OUTPUT; " +
                   "SELECT 'Value' = @MaCN";
                Console.WriteLine(cauTruyVan);
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
                String result = Program.myReader.GetValue(0).ToString().Trim();
                //Console.WriteLine(result);
                Program.myReader.Close();
                maChiNhanh = result;
                txtChiNhanh.Text = maChiNhanh;
                
            }
            else
            {
                maChiNhanh = ((DataRowView)bdsKho[0])["MACN"].ToString();
            }


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
                this.txtMaKho.Enabled = false;


                this.panelNhapLieu.Enabled = true;

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
              
                this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOTableAdapter.Fill(this.dataSet.KHO);

                this.DDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DDHTableAdapter.Fill(this.dataSet.DDH);

                this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHIEUNHAPTableAdapter.Fill(this.dataSet.PHIEUNHAP);

                this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HOADONTableAdapter.Fill(this.dataSet.HOADON);
            
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
           
            viTri = bdsKho.Position;
            this.panelNhapLieu.Enabled = true;
            dangThemMoi = true;


            bdsKho.AddNew();
            txtChiNhanh.Text = maChiNhanh.Trim() ;

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
    
            if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống mã kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }

            if (Regex.IsMatch(txtMaKho.Text.Trim(), @"^[a-zA-Z0-9]+$") == false)
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
         
            if (txtTenKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }

            if (Regex.IsMatch(txtTenKho.Text, @"^[A-Za-zÀ-ỹ0-9\s]+$") == false)
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
            if (bdsKho.Count == 0) {
                MessageBox.Show("Chưa có kho", "Thông báo", MessageBoxButtons.OK);
                btnSua.Enabled = false;
                return;
            }
            
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;


            String maKhoHang = txtMaKho.Text.ToString().Trim();
            DataRowView drv = ((DataRowView)bdsKho[bdsKho.Position]);
            String tenKho = drv["TENKHO"].ToString().Trim();
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

                    
                 
                    
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        btnHoanTac.Enabled = true;

                        btnLamMoi.Enabled = true;
                        btnChuyenChiNhanh.Enabled = true;
                        btnThoat.Enabled = true;

                        this.txtMaKho.Enabled = false;
                        this.gcKho.Enabled = true;

                      
                        String undoQuery = "";
                 
                        if (dangThemMoi == true)
                        {
                            undoQuery = "" +
                                "DELETE  from DBO.KHO " +
                                "WHERE MAKHO = '" + maKhoHang + "'";
                        }
                    
                        else
                        {
                            undoQuery =
                                "UPDATE DBO.KHO " +
                                "SET " +
                                "TENKHO = N'" + tenKho + "'" +
                               
                                "WHERE MAKHO = '" + maKhoHang + "'";
                        }
               
                        Console.WriteLine(undoQuery);

                        
                        undoList.Push(undoQuery);

                        this.bdsKho.EndEdit();
                        this.KHOTableAdapter.Update(this.dataSet.KHO);
                 
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        if (dangThemMoi == true) {
                            bdsKho.RemoveCurrent();
                        }
           
                        MessageBox.Show("Tên vật tư có thể đã được dùng !\n\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }


        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
        
                bdsKho.RemoveCurrent();
                return;


            }
            


            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHoanTac.Enabled = false;
                return;
            }
            bdsKho.CancelEdit();
            String undoQuery = undoList.Pop().ToString();
            Console.WriteLine(undoQuery);
            int n = Program.ExecSqlNonQuery(undoQuery);
             bdsKho.Position = viTri;
             this.KHOTableAdapter.Fill(this.dataSet.KHO);
             return;
            



        }



        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
            if (bdsKho.Count == 0)
            {
                btnXoa.Enabled = false;
                MessageBox.Show("Kho trống", "Thông báo", MessageBoxButtons.OK);
                return;

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


            string undoQuery =
            "INSERT INTO DBO.KHO( MAKHO,TENKHO,MACN) " +
            " VALUES( '" + txtMaKho.Text.ToString().Trim() + "',N'" +
                        txtTenKho.Text.Trim() + "','" +
                      
                        txtChiNhanh.Text.Trim() + "' ) ";

            Console.WriteLine(undoQuery);
            undoList.Push(undoQuery);

    
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
               
                    viTri = bdsKho.Position;
                    bdsKho.RemoveCurrent();

                    this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KHOTableAdapter.Update(this.dataSet.KHO);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHoanTac.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa kho. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.KHOTableAdapter.Fill(this.dataSet.KHO);
                    bdsKho.Position = viTri;
                    return;
                }
            }
            else
            {
         
                undoList.Pop();
            }
        }

    }



}
