using DevExpress.XtraReports.UI;
using QLVT.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.ReportForm
{
    public partial class FormDanhSachNhanVien : Form
    {

        private SqlConnection connPublisher = new SqlConnection();
        private string chiNhanh = "";



        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
    
        public FormDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void nHANVIENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }


        private void layDanhSachPhanManh(String cmd)
        {
            if (connPublisher.State == ConnectionState.Closed)
            {
                connPublisher.Open();
            }
            DataTable dt = new DataTable();
            // adapter dùng để đưa dữ liệu từ view sang database
            SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher);
            // dùng adapter thì mới đổ vào data table được
            da.Fill(dt);


            connPublisher.Close();
            Program.bindingSource.DataSource = dt;


            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";

        }


        private int KetNoiDatabaseGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstrPublisher;
                connPublisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
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

            chiNhanh = cmbChiNhanh.SelectedValue.ToString().Contains("1") ? "Chi nhánh 1" : "Chi nhánh 2";

            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENTableAdapter.Fill(this.dataSet.NHANVIEN);
        }


        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_NHAPXUATDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.NHANVIENTableAdapter.Fill(this.dataSet.NHANVIEN);
            dataSet.EnforceConstraints = false;

            


            if (Program.role == "CONGTY")
            {
                this.cmbChiNhanh.Enabled = true;
            }
          

            if (KetNoiDatabaseGoc() == 0)
                return;

            layDanhSachPhanManh("SELECT TOP 2 * FROM view_DanhSachPhanManh");
            cmbChiNhanh.SelectedIndex = 0;
            cmbChiNhanh.SelectedIndex = 1;
            cmbChiNhanh.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;
            this.barButtonItem1.Enabled = false;
            this.barButtonItem2.Enabled = false;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            String cheDo = (Menu.Links[0].Caption == "Danh sách nhân viên") ? "Danh sách nhân viên" : "Tình hình hoạt động nhân viên";

            if (cheDo == "Danh sách nhân viên")
            {
                SubForm.ReportDanhSachNhanVien report = new SubForm.ReportDanhSachNhanVien();
                //report.txtChiNhanh.Text = chiNhanh.ToUpper();
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
            }
            else {
                if (bdsNhanVien.Count != 0)
                {
                    DataRowView drv = ((DataRowView)bdsNhanVien[bdsNhanVien.Position]);
                    Program.maNV = (int)drv["MANV"];
                    Program.Ho = drv["HO"].ToString().Trim();
                    Program.Ten = drv["TEN"].ToString().Trim();
                    Program.maCN = drv["MACN"].ToString().Trim();
                    Program.SDT = drv["SDT"].ToString().Trim();
                    Program.diaChi = drv["DIACHI"].ToString().Trim();
                    Program.ngaySinh = drv["NGAYSINH"].ToString().Trim();



                    FormChonCheDo f = new FormChonCheDo();
                    f.Show();
                }

            }



        }


        private void button2_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ReportDanhSachNhanVien report = new ReportDanhSachNhanVien();

                // Gán tên chi nhánh cho báo cáo
                //report.txtChiNhanh.Text = chiNhanh.ToUpper();

                // Đường dẫn đến thư mục ExportReport trong dự án
                string exportFolderPath = System.IO.Path.Combine(Application.StartupPath, "ExportReport");

                // Kiểm tra xem thư mục ExportReport có tồn tại không, nếu không thì tạo nó
                if (!System.IO.Directory.Exists(exportFolderPath))
                {
                    System.IO.Directory.CreateDirectory(exportFolderPath);
                }

                string filePath = System.IO.Path.Combine(exportFolderPath, "ReportDanhSachNhanVien.pdf");

                if (File.Exists(filePath))
                {
                    DialogResult dr = MessageBox.Show("File ReportDanhSachNhanVien.pdf tại thư mục ExportReport đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(filePath);
                        MessageBox.Show("File ReportDanhSachNhanVien.pdf đã được ghi thành công tại thư mục ExportReport",
                            "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string startupPath = Application.StartupPath;
                        MessageBox.Show($"Thư mục gốc của ứng dụng: {startupPath}");
                    }
                }
                else
                {
                    report.ExportToPdf(filePath);
                    MessageBox.Show("File ReportDanhSachNhanVien.pdf đã được ghi thành công tại thư mục ExportReport",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportDanhSachNhanVien.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }

        private void gcNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Menu.Links[0].Caption = "Danh sách nhân viên";
            this.barButtonItem1.Enabled = true;
            this.barButtonItem2.Enabled = true;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Menu.Links[0].Caption = "Tình hình hoạt động nhân viên";
            this.barButtonItem1.Enabled = true;
            this.barButtonItem2.Enabled = true;
        }

        private void btnEXIT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }


        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                
                this.NHANVIENTableAdapter.Fill(this.dataSet.NHANVIEN);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

       
    }

}

