using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DTO
{
    public class Category
    {
        private string name;
        private int iD;

        public Category(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public Category(DataRow row)
        {
            this.ID = (int)row["MADMON"];
            this.Name = (string)row["TENDMON"];
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
