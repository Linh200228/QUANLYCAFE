using Do_an_co_so_2.DAO;
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
    public partial class frm_ThongTinTaiKhoan : Form
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public frm_ThongTinTaiKhoan(Account account)
        {
            InitializeComponent();
            LoginAccount = account;
        }

        void ChangeAccount(Account account)
        {
            txtTenDangNhap.Text = LoginAccount.UserName;
            txtTenHienThi.Text = LoginAccount.DisplayName;
        }

        void UpdateAccount()
        {
            string userName = txtTenDangNhap.Text;
            string displayName = txtTenHienThi.Text;
            string passWord = txtMatKhau.Text;
            string newPassWord = txtMatKhauMoi.Text;
            string resetPassWord = txtNhapLai.Text;

            if (!newPassWord.Equals(resetPassWord))
            {
                MessageBox.Show("Mật khẩu bạn vừa nhập không trùng khớp với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, passWord, newPassWord))
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Nhập sai mật khẩu vui lòng kiểm tra lại!");
                }
            }
        }

        private void frm_ThongTinDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
}
