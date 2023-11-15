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

namespace QLVT.SubForm
{
    public partial class FormLoaiVatTu : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;

        String maChiNhanh = "";

        Stack undoList = new Stack();
        public FormLoaiVatTu()
        {
            InitializeComponent();
        }

        private void lOAIVATTUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormLoaiVatTu_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;
            this.LOAIVATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dataSet.LOAIVATTU' table. You can move, or remove it, as needed.
            this.LOAIVATTUTableAdapter.Fill(this.dataSet.LOAIVATTU);
            this.VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLVT_NHAPXUATDataSet.VATTU' table. You can move, or remove it, as needed.
            this.VATTUTableAdapter.Fill(this.dataSet.VATTU);




            if (Program.role == "CONGTY")
            {


                this.panelNhapLieu.Enabled = false;
                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnSua.Enabled = false;

                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnChuyenChiNhanh.Enabled = false;
                this.btnThoat.Enabled = true;


            }

            if (Program.role == "CHINHANH" || Program.role == "USER")
            {

                this.panelNhapLieu.Enabled = true;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;

                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnChuyenChiNhanh.Enabled = true;
                this.btnThoat.Enabled = true;



            }






        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            viTri = bdsLoaiVatTu.Position;
            this.panelNhapLieu.Enabled = true;
            dangThemMoi = true;      
            bdsLoaiVatTu.AddNew();
            this.panelNhapLieu.Enabled = true;

            this.txtMaLVT.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = true;

            this.btnHoanTac.Enabled = true;
            this.btnLamMoi.Enabled = false;
            this.btnThoat.Enabled = false;


            this.gcLoaiVatTu.Enabled = false;
            
        }

        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
            if (dangThemMoi == true && this.btnThem.Enabled == false)
            {
                dangThemMoi = false;

                this.txtMaLVT.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;

                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnThoat.Enabled = true;


                this.gcLoaiVatTu.Enabled = true;
                this.panelNhapLieu.Enabled = true;

                bdsLoaiVatTu.CancelEdit();
            
                bdsLoaiVatTu.RemoveCurrent();
             
                bdsLoaiVatTu.Position = viTri;
                return;
            }
          
        
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHoanTac.Enabled = false;
                return;
            }

  
            bdsLoaiVatTu.CancelEdit();
            String undoQuery = undoList.Pop().ToString();
            Console.WriteLine(undoQuery);
            int n = Program.ExecSqlNonQuery(undoQuery);
            this.LOAIVATTUTableAdapter.Fill(this.dataSet.LOAIVATTU);
        }


        private bool kiemTraDuLieuDauVao()
        {
         
            if (txtMaLVT.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã loại vật tư", "Thông báo", MessageBoxButtons.OK);
                txtMaLVT.Focus();
                return false;
            }

            if (Regex.IsMatch(txtMaLVT.Text, @"^[a-zA-Z0-9, ]+$") == false)
            {
                MessageBox.Show("Mã vật tư chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtMaLVT.Focus();
                return false;
            }

            if (txtMaLVT.Text.Length > 5)
            {
                MessageBox.Show("Mã laoị vật tư không quá 5 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaLVT.Focus();
                return false;
            }
     
            if (txtTenLVT.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên loại vật tư", "Thông báo", MessageBoxButtons.OK);
                txtTenLVT.Focus();
                return false;
            }

            if (Regex.IsMatch(txtTenLVT.Text, @"^[A-Za-zÀ-ỹ0-9, ]+$") == false)
            {
                MessageBox.Show("Tên vật tư chỉ chấp nhận chữ, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTenLVT.Focus();
                return false;
            }
            if (txtTenLVT.Text.Length > 30)
            {
                MessageBox.Show("Mã laoị vật tư không quá 5 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTenLVT.Focus();
                return false;
            }
            return true;
        }



        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            String maLoaiVatTu = txtMaLVT.Text.Trim();
            DataRowView drv = ((DataRowView)bdsLoaiVatTu[bdsLoaiVatTu.Position]);
            String tenLoaiVatTu = drv["TENLVT"].ToString();

            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaLoaiVatTu '" +
                    maLoaiVatTu + "' " +
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
            //Console.WriteLine(result);
            Program.myReader.Close();
            Console.WriteLine(result);

            int viTriConTro = bdsLoaiVatTu.Position;
            int viTriMaLoaiVatTu = bdsLoaiVatTu.Find("MALVT", txtMaLVT.Text);

            if (result == 1 && viTriConTro != viTriMaLoaiVatTu)
            {
                MessageBox.Show("Mã loại vật tư này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
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
                        btnThoat.Enabled = true;

                        this.txtMaLVT.Enabled = false;
                        this.gcLoaiVatTu.Enabled = true;

                        String undoQuery = "";
                
                        if (dangThemMoi == true)
                        {
                            undoQuery = "" +
                                "DELETE  from DBO.LOAIVATTU " +
                                "WHERE MALVT = '" + txtMaLVT.Text.Trim() + "'";
                        }
              
                        else
                        {
                            undoQuery =
                                "UPDATE DBO.LOAIVATTU " +
                                "SET " +
                                "TENLVT = '" + tenLoaiVatTu + "'" +

                                "WHERE MALVT = '" + maLoaiVatTu + "'";
                        }
           
                        undoList.Push(undoQuery);

                        this.bdsLoaiVatTu.EndEdit();
                        this.LOAIVATTUTableAdapter.Update(this.dataSet.LOAIVATTU);
                
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        if (dangThemMoi == true) {
                            bdsLoaiVatTu.RemoveCurrent();
                        }
                       
                        MessageBox.Show("Tên loại vật tư có thể đã được dùng !\n\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
        }
        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.LOAIVATTUTableAdapter.Fill(this.dataSet.LOAIVATTU);
                this.gcLoaiVatTu.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLoaiVatTu.Count == 0)
            {
                btnXoa.Enabled = false;
            }


            if (bdsVatTu.Count > 0)
            {
                MessageBox.Show("Không thể xóa loại vật tư này vì đã có vật tư", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string undoQuery =
            "INSERT INTO DBO.LOAIVATTU(MALVT,TENLVT) " +
            " VALUES( '" + txtMaLVT.Text.Trim() + "','" +
                        txtTenLVT.Text.Trim() + "')";

            Console.WriteLine(undoQuery);
            undoList.Push(undoQuery);

 
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                
                    viTri = bdsLoaiVatTu.Position;
                    bdsLoaiVatTu.RemoveCurrent();

                    this.LOAIVATTUTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOAIVATTUTableAdapter.Update(this.dataSet.LOAIVATTU);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHoanTac.Enabled = true;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Lỗi xóa vật tư. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.LOAIVATTUTableAdapter.Fill(this.dataSet.LOAIVATTU);
                  
                    bdsLoaiVatTu.Position = viTri;
                 
                    return;
                }
            }
            else
            {
              
                undoList.Pop();
            }

        }
        private void lOAIVATTUBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLoaiVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void panelNhapLieu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
