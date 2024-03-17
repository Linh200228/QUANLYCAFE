using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DTO
{
    public class Account
    {
        private int type;
        private string password;
        private string displayName;
        private string userName;

        public Account(string userName, string displayName, int type, string password = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Password = password;
            this.Type = type;
        }

        public Account(DataRow row)
        {
            this.UserName = (string)row["TENTK"];
            this.DisplayName = (string)row["TENHT"];
            this.Password = (string)row["MATKHAU"];
            this.Type = (int)row["LOAITK"];
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
