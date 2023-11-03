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
    public partial class FormChuyenChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        public FormChuyenChiNhanh()
        {
            InitializeComponent();
        }
        private void FormChuyenChiNhanh_Load(object sender, EventArgs e)
        {
            /*Lấy dữ liệu từ form đăng nhập đổ vào nhưng chỉ lấn đúng danh sách
             phân mảnh mà thôi*/
            cmbChiNhanh.DataSource = Program.bindingSource.DataSource;
            /*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "tencn";
            cmbChiNhanh.ValueMember = "tenserver";
            cmbChiNhanh.SelectedIndex = Program.brand;

        }


        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        public delegate void MyDelegate(string chiNhanh);
        public MyDelegate branchTransfer;
        private void btnXACNHAN_Click(object sender, EventArgs e)
        {
            if (cmbChiNhanh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            /*Step 2*/
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chuyển nhân viên này đi ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                branchTransfer(cmbChiNhanh.SelectedValue.ToString());
            }

            this.Dispose();
        }
    }


   


   
}