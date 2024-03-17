using Do_an_co_so_2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_co_so_2
{
    public partial class frm_DoanhThu : Form
    {
        public frm_DoanhThu()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
        }

        private void frm_DoanhThu_Load(object sender, EventArgs e)
        {

        }

        //Lấy danh sách bill trong phạm vi ngày thiết lập
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dgvDoanhThu.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);

        }

        // lấy ngày đầu và ngày cuối tháng hiện tại
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpDenNgay.Value = dtpTuNgay.Value.AddMonths(1).AddDays(-1);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpTuNgay.Value, dtpDenNgay.Value);
        }
    }
}
