using Do_an_co_so_2.DTO;
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
    public partial class frm_Chinh : Form
    {
        private Account loginAccount;


        public frm_Chinh(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        private void lblXinChao_Click(object sender, EventArgs e)
        {

        }

        private void frm_Chinh_Load(object sender, EventArgs e)
        {

        }

        //Thay đổi quyền truy cập tài khoản
        void ChangeAccount(int type)
        {
            //Nếu là admin là 1 là được đăng nhập vào
            btnDoanhThu.Enabled = type == 1;
            btnTrangThietBi.Enabled = type == 1;
            btnNhanSu.Enabled = type == 1;
            //Hiển thị tên tài khoản ngoài
            lblTen.Text += LoginAccount.DisplayName;

            if (type == 1)
            {
                lblChucVu.Text = "Quản lý";
            }
            else
            {
                lblChucVu.Text = "Nhân viên";
            }

            DateTime today = DateTime.Now;
            lblThoiGian.Text = today.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_BanHang frm_BanHang = new frm_BanHang();
            this.Hide();
            frm_BanHang.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_NhanSu frm_NhanSu = new frm_NhanSu();
            this.Hide();
            frm_NhanSu.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_DoanhThu frm_DoanhThu = new frm_DoanhThu();
            this.Hide();
            frm_DoanhThu.ShowDialog();
            this.Show();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            frm_ThongTinTaiKhoan frm_ThongTinTaiKhoan = new frm_ThongTinTaiKhoan(LoginAccount);
            this.Hide();
            frm_ThongTinTaiKhoan.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnTrangThietBi_Click(object sender, EventArgs e)
        {
            frm_ThucDon frm_Menu = new frm_ThucDon();
            this.Hide();
            frm_Menu.ShowDialog();
            this.Show();
        }
    }
}
