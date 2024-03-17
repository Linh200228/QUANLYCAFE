using Do_an_co_so_2.DAO;
using Do_an_co_so_2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_co_so_2
{
    public partial class frm_BanHang : Form
    {
        public frm_BanHang()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
            LoadcbXChuyenban(cbxChuyenBan);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //In hóa đơn
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Table table = lsvHoaDon.Tag as Table;

            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(table.ID);

            e.Graphics.DrawString("=============  HÓA ĐƠN  ==============", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(250, 50));
            e.Graphics.DrawString("Tên món", new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString("Số lượng", new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new PointF(400, 100));
            e.Graphics.DrawString("Đơn giá", new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new PointF(500, 100));
            e.Graphics.DrawString("Thành tiền", new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new PointF(600, 100));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 1), new Point(50, 150), new Point(800, 150));
            int number = 0;
            float totalPrice = 0;
            foreach (DTO.Menu item in listBillInfo)
            {
                e.Graphics.DrawString(item.FoodName.ToString(), new Font("Times New Roman", 13), Brushes.Black, new PointF(100, 190 + number));
                e.Graphics.DrawString(item.Count.ToString(), new Font("Times New Roman", 13), Brushes.Black, new PointF(400, 190 + number));
                e.Graphics.DrawString(item.Price.ToString(), new Font("Times New Roman", 13), Brushes.Black, new PointF(500, 190 + number));
                e.Graphics.DrawString(item.TotalPrice.ToString(), new Font("Times New Roman", 13), Brushes.Black, new PointF(600, 190 + number));
                totalPrice += item.TotalPrice;
                number = number + 50;
            }

            e.Graphics.DrawLine(new Pen(Brushes.Black, 1), new Point(50, 190 + number), new Point(800, 190 + number));
            CultureInfo culture = new CultureInfo("vi-VN");
            e.Graphics.DrawString(totalPrice.ToString("c", culture), new Font("Times New Roman", 13), Brushes.Black, new PointF(600, 200 + number));
            e.Graphics.DrawString("Tổng tiền: ", new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new PointF(500, 200 + number));
            e.HasMorePages = false;
        }



        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThucDon menu = new frm_ThucDon();
            this.Hide();
            menu.ShowDialog();
            this.Show();

        }


        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbDanhMucMonAn.DataSource = listCategory;
            cbDanhMucMonAn.DisplayMember = "Name";
        }

        void LoadFoodListCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbMonAn.DataSource = listFood;
            cbMonAn.DisplayMember = "Name";
        }

        void LoadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                //Hiển thị chữ lên trên Button
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                if (item.Status == "Trống")
                {
                    txtHienThiTenBan.Text = "CHƯA CHỌN BÀN";
                    btn.BackColor = Color.Cyan;
                }
                else
                {
                    btn.BackColor = Color.LightYellow;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsvHoaDon.Items.Clear();
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (DTO.Menu item in listBillInfo)
            {

                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvHoaDon.Items.Add(lsvItem);
                txtHienThiTenBan.Text = item.TableName.ToString();
            }

            //CultureInfo culture = new CultureInfo("en-US");
            txtTongHoaDon.Text = totalPrice.ToString();

        }


        void btn_Click(object? sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvHoaDon.Tag = (sender as Button).Tag;
            if (((sender as Button).Tag as Table).Status == "Trống")
            {
                txtHienThiTenBan.Text = "BÀN CHƯA ĐƯỢC ĐẶT";
            }

            ShowBill(tableID);
        }

        private void lsvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDanhMucMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListCategoryID(id);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            Table table = lsvHoaDon.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn!");
                return;
            }

            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
            int foodID = (cbMonAn.SelectedItem as Food).Id;
            int count = (int)numericUpDown1.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);

            LoadTable();
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            //Lấy table hiện tại cần thanh toán
            Table table = lsvHoaDon.Tag as Table;

            //Lấy idBill của table hiện tại
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);

            //Lấy % giảm giá
            int discount = (int)nudGiamGia.Value;

            double totalPrice = Convert.ToDouble(txtTongHoaDon.Text.Split(',')[0]);

            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }

            //Nếu có bill có trong table 
            if (idBill != -1)
            {
                //Hiện ra hộp thoại thông báo có thannh toán hay không?
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\n Tổng tiền - (Tổng tiền / 100) * Giảm giá\n = {1} - ({1} / 100) * {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    //Thanh toán hóa đơn của table
                    BillDAO.Instance.PayBill(idBill, discount, (float)finalTotalPrice);

                    //Hiện thị cái table theo id
                    ShowBill(table.ID);

                    //load lại table
                    LoadTable();
                }
            }

        }

        private void txtTongHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        void LoadcbXChuyenban(ComboBox combo)
        {
            combo.DataSource = TableDAO.Instance.LoadTableList();
            combo.DisplayMember = "Name";
        }

        // Hàm chuyển bàn
        private void buttonChuyenBan_Click(object sender, EventArgs e)
        {
            //Lấy id cần chuyển của bàn đang được chọn
            int id1 = (lsvHoaDon.Tag as Table).ID;

            //Lấy id bị chuyển đến từ combobox
            int id2 = (cbxChuyenBan.SelectedItem as Table).ID;

            if (MessageBox.Show(string.Format("Bạn có muốn chuyển bàn {0} thành bàn {1} hay không?", (lsvHoaDon.Tag as Table).Name, (cbxChuyenBan.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                //Chuyển từ bàn nầy đến bàng kia
                TableDAO.Instance.ConvertTable(id1, id2);

                //load lại table
                LoadTable();
            }
        }

        private void cbMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
