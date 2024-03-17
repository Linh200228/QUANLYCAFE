using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DTO
{
    public class Bill
    {
        private int status;
        private DateTime? dateCheckOut;
        private DateTime? dateCheckIn;
        private int iD;
        private int discount;

        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckOut, int status, int discount = 0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
            this.discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["MAHD"];
            this.DateCheckIn = (DateTime?)row["NGAYVAO"];

            var dateCheckOutTemp = row["NGAYRA"];

            if (dateCheckOutTemp.ToString() != "")
            {
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            }

            this.Status = (int)row["TRANGTHAIHD"];

            if (row["GIAMGIA"].ToString() != "")
            {
                this.Discount = (int)row["GIAMGIA"];
            }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

    }
}
