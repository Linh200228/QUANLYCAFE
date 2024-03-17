using Do_an_co_so_2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DAO
{
    internal class AccountDAO
    {
        static private AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }

        public bool Login (string accountName, string password)
        {
            string query = "select * from TAIKHOAN where TENTK = '" + accountName + "' and MATKHAU = '" + password + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TAIKHOAN WHERE TENTK = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                //Nếu có userName thì lấy được account ngược lại thì trả về null
                return new Account(item);
            }
            return null;
        }

        public bool UpdateAccount(string userName, string displayName, string passWord, string newPassWord)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateTAIKHOAN @userName , @displayName , @passWord , @newPassWord ", new object[] { userName, displayName, passWord, newPassWord });
            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT TENTK, TENHT, LOAITK FROM TAIKHOAN");
        }

        public bool InsertAccount(string userName, string displayName, string passWord, int type)
        {
            string query = string.Format("INSERT INTO TAIKHOAN (TENTK, TENHT, MATKHAU, LOAITK) VALUES (N'{0}', N'{1}', {2}, {3})", userName, displayName, passWord, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateAccount2(string displayName, string passWord, int type, string userName)
        {
            string query = string.Format("UPDATE TAIKHOAN SET TENHT = N'{0}' , MATKHAU = N'{1}' , LOAITK = {2}  WHERE  TENTK = N'{3}' ", displayName, passWord, type, userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccount(string userName)
        {
            string query = "DELETE TAIKHOAN WHERE TENTK = N'" + userName + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
