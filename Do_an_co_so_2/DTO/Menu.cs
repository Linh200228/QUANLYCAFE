using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DTO
{
    public class Menu
    {
        private float totalPrice;
        private float price;
        private int count;
        private string foodName;
        private string tableName;
        private string trangThai;

        public Menu(string trangThai, string tableName, string foodName, int count, float price, float totalPrice = 0)
        {
            this.TrangThai = trangThai;
            this.TableName = tableName;
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.TrangThai = (string)row["TRANGTHAI"];
            this.TableName = (string)row["TENBAN"];
            this.FoodName = (string)row["TENMON"];
            this.Count = (int)row["SOLUONG"];
            this.Price = (float)Convert.ToDouble(row["GIA"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }

        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
    }
}
