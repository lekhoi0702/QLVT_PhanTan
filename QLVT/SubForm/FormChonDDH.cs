using System;
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
    public partial class FormChonDDH : Form
    {
        public FormChonDDH()
        {
            InitializeComponent();
        }

        private void dDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormChonDDH_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.DDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DDHTableAdapter.Fill(this.dataSet.DDH);

        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private int kiemTraDonHangCoPhieuNhap(String maDonHang)
        {


            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraPhieuNhapCuaDDH '" +
                    maDonHang + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi Stored Procedure thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return 1;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            //Console.WriteLine(result);
            Program.myReader.Close();
            return result;
        }





        private void btnCHON_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsDDH.Current));
            string maNhanVien = drv["MANV"].ToString().Trim();
            string maDonHang = drv["MADDH"].ToString().Trim();
            string maKho = drv["MAKHO"].ToString().Trim();

            if (Program.userName != maNhanVien)
            {
                MessageBox.Show("Bạn không thể lập phiếu trên đơn đặt hàng do người khác tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            int ketQua = kiemTraDonHangCoPhieuNhap(maDonHang);

            if (ketQua == 1)
            {
                MessageBox.Show("Đơn hàng này đã có phiếu nhập không thể tạo thêm", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Program.maDonDatHangDuocChon = maDonHang;
            Program.maKhoDuocChon = maKho;

            //Console.WriteLine("Don dat hang duoc chon");
            //Console.WriteLine(maDonHang);
            //Console.WriteLine(maKho);

            this.Close();
        }




    }
}
