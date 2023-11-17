using DevExpress.CodeParser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLVT
{
    public partial class FormVatTu : Form

    {
        int viTri = 0;
        bool dangThemMoi = false;
        Stack undoList = new Stack();
        public FormVatTu()
        {
            InitializeComponent();
        }

        private void vATTUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);


        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {


            dataSet.EnforceConstraints = false;

            this.VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VATTUTableAdapter.Fill(this.dataSet.VATTU);

            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.dataSet.CTDDH);

            this.CTHDTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTHDTableAdapter.Fill(this.dataSet.CTHD);

            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.dataSet.CTPN);

            this.LOAIVATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOAIVATTUTableAdapter.Fill(this.dataSet.LOAIVATTU);




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


                this.panelNhapLieu.Enabled = true;
                this.txtMaVT.Enabled = false;
                this.cmbLoaiVT.Enabled = false;

            }





        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsVatTu.Position;
            dangThemMoi = true;

            bdsVatTu.AddNew();
            this.panelNhapLieu.Enabled = true;
            this.cmbLoaiVT.Enabled = true;
            this.txtMaVT.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = true;

            this.btnHoanTac.Enabled = true;
            this.btnLamMoi.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaLoaiVatTu.Enabled = false;
            this.gcVatTu.Enabled = false;

        }

        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsVatTu.Position;
            if (dangThemMoi == true && this.btnThem.Enabled == false)
            {
                dangThemMoi = false;

                this.txtMaVT.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;

                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnThoat.Enabled = true;


                this.gcVatTu.Enabled = true;
                this.panelNhapLieu.Enabled = true;

                bdsVatTu.CancelEdit();

                bdsVatTu.RemoveCurrent();
                bdsVatTu.Position = viTri - 1;
                return;
            }

            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHoanTac.Enabled = false;
                return;
            }
            String undoQuery = undoList.Pop().ToString();
            Console.WriteLine(undoQuery);
            int n = Program.ExecSqlNonQuery(undoQuery);
            bdsVatTu.Position = viTri;



            this.VATTUTableAdapter.Fill(this.dataSet.VATTU);
        }


        private bool kiemTraDuLieuDauVao()
        {

            if (txtMaVT.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã vật tư", "Thông báo", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return false;
            }

            if (Regex.IsMatch(txtMaVT.Text.Trim(), @"^[a-zA-Z0-9,]+$") == false)
            {
                MessageBox.Show("Mã vật tư chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return false;
            }



            if (txtMaVT.Text.Length > 5)
            {
                MessageBox.Show("Mã vật tư không quá 5 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return false;
            }

            if (txtTenVT.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên vật tư", "Thông báo", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return false;
            }

            if (Regex.IsMatch(txtTenVT.Text, @"^[A-Za-zÀ-ỹ0-9, ]+$") == false)
            {
                MessageBox.Show("Tên vật tư chỉ chấp nhận chữ, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return false;
            }

            if (txtTenVT.Text.Length > 30)
            {
                MessageBox.Show("Tên vật tư không quá 30 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return false;
            }

            if (txtDVT.Text == "")
            {
                MessageBox.Show("Không bỏ trống đơn vị tính", "Thông báo", MessageBoxButtons.OK);
                txtDVT.Focus();
                return false;
            }

            if (Regex.IsMatch(txtDVT.Text, @"^[A-Za-zÀ-ỹ ]+$") == false)
            {
                MessageBox.Show("Đơn vị vật tư chỉ có chữ cái", "Thông báo", MessageBoxButtons.OK);
                txtDVT.Focus();
                return false;
            }

            if (txtDVT.Text.Length > 15)
            {
                MessageBox.Show("Đơn vị vật tự không quá 15 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtDVT.Focus();
                return false;
            }
            if (spSTL.Value < 0)
            {
                MessageBox.Show("Số lượng tồn không được nhỏ hơn 0", "Thông báo", MessageBoxButtons.OK);
                spSTL.Focus();
                return false;
            }

            return true;
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            String maVatTu = txtMaVT.Text.Trim();
            DataRowView drv = ((DataRowView)bdsVatTu[bdsVatTu.Position]);
            drv["MALVT"] = cmbLoaiVT.SelectedValue.ToString().Trim();

            String cauTruyVan =
                    "DECLARE	@result nchar(5) " +
                    "EXEC @result = sp_KiemTraMaVatTu '" +
                    maVatTu + "' " +
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

            int viTriConTro = bdsVatTu.Position;
            int viTriMaVatTu = bdsVatTu.Find("MAVT", txtMaVT.Text);

            if (result == 1 && viTriConTro != viTriMaVatTu)
            {
                MessageBox.Show("Mã vật tư này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else

            {
                DialogResult dr = MessageBox.Show("Ghi dữ liệu?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {

                        String undoQuery = "";
                        if (dangThemMoi == true)
                        {
                            undoQuery = "" +
                                "DELETE FROM DBO.VATTU " +
                                "WHERE MAVT = '" + maVatTu + "'";
                        }

                        else
                        {
                            String tenVatTu = drv["TENVT"].ToString();
                            String donViTinh = drv["DVT"].ToString();
                            drv["MALVT"] = cmbLoaiVT.SelectedValue.ToString();

                            String slt = spSTL.Value.ToString();
                            String maLoaiVT = drv["MALVT"].ToString();
                            undoQuery =
                                "UPDATE DBO.VATTU " +
                                "SET " +
                                "TENVT = '" + tenVatTu + "'," +
                                "DVT = '" + donViTinh + "'," +
                                "MALVT = '" + maLoaiVT + "'," +
                                "SLT = '" + slt + "'," +
                                "WHERE MAVT = '" + maVatTu + "'";
                        }
                        Console.WriteLine(undoQuery);
                        undoList.Push(undoQuery);
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                        dangThemMoi = false;
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        btnHoanTac.Enabled = true;
                        btnLamMoi.Enabled = true;
                        btnThoat.Enabled = true;

                        this.bdsVatTu.EndEdit();
                        this.VATTUTableAdapter.Update(this.dataSet.VATTU);
                        this.VATTUTableAdapter.Fill(this.dataSet.VATTU);
                        this.gcVatTu.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        if (dangThemMoi == true)
                        {
                            bdsVatTu.RemoveCurrent();
                        }

                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.bdsVatTu.Position = viTri;
                }

            }
        }
        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.VATTUTableAdapter.Fill(this.dataSet.VATTU);
                this.gcVatTu.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsVatTu.Count == 0)
            {
                btnXoa.Enabled = false;
                MessageBox.Show("Vật tư trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTHD.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đã lập phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            String maVatTu = txtMaVT.Text.Trim();
            int ketQua = kiemTraVatTuChiNhanhKhac(maVatTu);

            if (ketQua == 1)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đang được sử dụng ở chi nhánh khác", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string undoQuery =
            "INSERT INTO DBO.VATTU( MAVT,TENVT,DVT,MALVT,SLT) " +
            " VALUES( '" + txtMaVT.Text.Trim() + "','" +
                        txtTenVT.Text.Trim() + "','" +
                        txtDVT.Text.Trim() + "', '" +
                        txtMaLoaiVatTu.Text.Trim() + "', " +
                        spSTL.Value + " ) ";

            Console.WriteLine(undoQuery);
            undoList.Push(undoQuery);


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {


                    bdsVatTu.RemoveCurrent();
                    this.VATTUTableAdapter.Update(this.dataSet.VATTU);
                    this.VATTUTableAdapter.Fill(this.dataSet.VATTU);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHoanTac.Enabled = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa vật tư. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.VATTUTableAdapter.Fill(this.dataSet.VATTU);

                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }


        private int kiemTraVatTuChiNhanhKhac(String maVatTu)
        {
            String cauTruyVan =
                    "DECLARE	@result NCHAR(5) ;" +
                    "EXEC @result = sp_KiemTraMaVatTuChiNhanhKhac '" +
                    maVatTu + "' ;" +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                if (Program.myReader == null)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return 1;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            int ketQua = (result == 1) ? 1 : 0;
            return ketQua;
        }

        private void vATTUBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void mAVTLabel_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*  private void fillByToolStripButton_Click(object sender, EventArgs e)
          {
              try
              {
                  this.LOAIVATTUTableAdapter.FillBy(this.dataSet.LOAIVATTU);
              }
              catch (System.Exception ex)
              {
                  System.Windows.Forms.MessageBox.Show(ex.Message);
              }

          }*/
    }

}