using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormPhieuNhap : Form
    {
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void pHIEUNHAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUNHAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_NHAPXUATDataSet);

        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_NHAPXUATDataSet.KHO' table. You can move, or remove it, as needed.
            this.kHOTableAdapter.Fill(this.qLVT_NHAPXUATDataSet.KHO);
            // TODO: This line of code loads data into the 'qLVT_NHAPXUATDataSet.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.qLVT_NHAPXUATDataSet.CTPN);
            // TODO: This line of code loads data into the 'qLVT_NHAPXUATDataSet.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Fill(this.qLVT_NHAPXUATDataSet.PHIEUNHAP);

        }
    }
}
