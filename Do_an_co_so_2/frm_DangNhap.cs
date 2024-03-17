using Do_an_co_so_2.DAO;
using Do_an_co_so_2.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Do_an_co_so_2
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ứng dụng sẽ thoát nếu bạn nhấn ok!!!", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ứng dụng sẽ thoát nếu bạn nhấn ok!!!", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string accountName = textBoxTenDangNhap.Text;
            string password = textBoxMatKhau.Text;
            if (Login(accountName, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(accountName);
                frm_Chinh frm_Chinh = new frm_Chinh(loginAccount);
                this.Hide();
                frm_Chinh.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Hiển thị sai tên hoặc mật khẩu");
            }


        }

        bool Login(string accountName, string password)
        {
            return AccountDAO.Instance.Login(accountName, password);
        }

    }
}