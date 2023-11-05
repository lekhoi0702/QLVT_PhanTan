using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QLVT
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connPublisher = new SqlConnection();

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
        public FormDangNhap()
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
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // đặt sẵn mật khẩu để đỡ nhập lại nhiều lần
            txtTaiKhoan.Text = "NC";// Tran Bao - chi nhanh
            txtMatKhau.Text = "123456";
            if (KetNoiDatabaseGoc() == 0)
                return;
            //Lấy 2 cái đầu tiên của danh sách
            layDanhSachPhanManh("SELECT TOP 2 * FROM view_DanhSachPhanManh");
            cmbChiNhanh.SelectedIndex = 0;
            cmbChiNhanh.SelectedIndex = 1;
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            /* Step 1*/
            if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            /* Step 2*/
            Program.loginName = txtTaiKhoan.Text.Trim();
            Program.loginPassword = txtMatKhau.Text.Trim();
            if (Program.KetNoi() == 0)
                return;
            /* Step 3*/
            Program.brand = cmbChiNhanh.SelectedIndex;
            Program.currentLogin = Program.loginName;
            Program.currentPassword = Program.loginPassword;


            /* Step 4*/
            String statement = "EXEC sp_DangNhap '" + Program.loginName + "'";// exec sp_DangNhap 'TP'
            Program.myReader = Program.ExecSqlDataReader(statement);
            if (Program.myReader == null)
                return;
            // đọc một dòng của myReader - điều này là hiển nhiên vì kết quả chỉ có 1 dùng duy nhất
            Program.myReader.Read();


            /* Step 5*/
            Program.userName = Program.myReader.GetString(0);// lấy userName
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", "Thông Báo", MessageBoxButtons.OK);
            }



            Program.staff = Program.myReader.GetString(1);
            Program.role = Program.myReader.GetString(2);
  

   

            Program.myReader.Close();
            Program.conn.Close();

            
            FormChinh formChinh = new FormChinh();
            formChinh.MaNhanVien.Text = "MÃ NHÂN VIÊN: " + Program.userName;
            formChinh.HoTen.Text = "HỌ TÊN: " + Program.staff;
            formChinh.Nhom.Text = "VAI TRÒ: " + Program.role;
            formChinh.Show();
            this.Hide();

           

            /*     Step 6*/
            /*  this.Visible = false;
              Program.formChinh.enableButtons();*/
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cmbChiNhanh.SelectedValue.ToString();
                //Console.WriteLine(cmbCHINHANH.SelectedValue.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}