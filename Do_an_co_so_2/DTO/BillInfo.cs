using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DTO
{
    public class BillInfo
    {
        private int count;
        private int foodID;
        private int billID;
        private int iD;

        public BillInfo(int id, int billID, int foodID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["MAHDCT"];
            this.BillID = (int)row["MAHD"];
            this.FoodID = (int)row["MAMON"];
            this.Count = (int)row["SOLUONG"];
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
