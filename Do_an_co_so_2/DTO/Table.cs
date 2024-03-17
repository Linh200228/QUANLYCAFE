using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DTO
{
    public class Table
    {
        //private string status;
        //private string name;
        //private int iD;

        public Table(int TableID, string TableName, string Status)
        {
            this.ID = TableID;
            this.Name = TableName;
            this.Status = Status;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["MABAN"];
            this.Name = (string)row["TENBAN"];
            this.Status = (string)row["TRANGTHAI"];
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}