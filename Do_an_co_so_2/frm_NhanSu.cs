using Do_an_co_so_2.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_co_so_2
{
    public partial class frm_NhanSu : Form
    {

        BindingSource accountList = new BindingSource();
        public frm_NhanSu()
        {
            InitializeComponent();
            dgvNhanVien.DataSource = accountList;
            LoadListAccount();
            AddAccountBinding();
        }

        void AddAccountBinding()
        {
            txtTenDangNhap.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "TENTK", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "TENHT"));
            txtChucVu.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "LOAITK"));
        }

        private void frm_NhanSu_Load(object sender, EventArgs e)
        {

        }

        //public void LoadDanhSachNhanVien()
        //{
        //    string query = "select * from TAIKHOAN";

        //    dgvNhanVien.DataSource = DataProvider.Instance.ExecuteQuery(query);

        //}

        void LoadListAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }



        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            string userName = txtTenDangNhap.Text;
            string displayName = txtHoTen.Text;
            string passWord = txtMatKhau.Text;
            int Type = Convert.ToInt32(txtChucVu.Text);

            if (AccountDAO.Instance.InsertAccount(userName, displayName, passWord, Type))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Thêm tài khoản không thành công!");
            }
        }

        private void btnCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            string displayName = txtHoTen.Text;
            string passWord = txtMatKhau.Text;
            int type = Convert.ToInt32(txtChucVu.Text);
            string userName = txtTenDangNhap.Text;


            if (AccountDAO.Instance.UpdateAccount2(displayName, passWord, type, userName))
            {
                MessageBox.Show("Sửa tài khoản thành công!");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Sửa tài khoản không thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string userName = txtTenDangNhap.Text;

            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản không thành công!");
            }
        }
    }
}
