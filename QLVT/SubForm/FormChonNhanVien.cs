using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.SubForm
{
    public partial class FormChonNhanVien : Form
    {
        String maChiNhanh = "";
        public FormChonNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormChonNhanVien_Load(object sender, EventArgs e)
        {

            dataSet.EnforceConstraints = false;

            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENTableAdapter.Fill(this.dataSet.NHANVIEN);
           
            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
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

                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Fill(this.dataSet.NHANVIEN);
            }
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)bdsNhanVien[bdsNhanVien.Position]);
            Program.manvDuocChon = (int)drv["MANV"];
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
