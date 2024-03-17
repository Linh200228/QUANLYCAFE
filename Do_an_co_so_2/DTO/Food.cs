using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DTO
{
    public class Food
    {
        private int id;
        private string name;
        private int idcategory;
        private float price;


        public Food(int id, string name, int idcategory, float price)
        {
            this.Id = id;
            this.Name = name;
            this.Idcategory = idcategory;
            this.Price = price;
        }


        public Food(DataRow row)
        {
            this.Id = (int)row["MAMON"];
            this.Name = (string)row["TENMON"];
            this.Idcategory = (int)row["MADMON"];
            this.Price = (float)Convert.ToDouble(row["GIA"].ToString());
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Idcategory
        {
            get { return idcategory; }
            set { idcategory = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
