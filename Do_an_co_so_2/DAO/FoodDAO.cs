using Do_an_co_so_2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }
        private FoodDAO() { }


        public List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = new List<Food>();
            string query = string.Format("SELECT * FROM MON WHERE TENMON LIKE N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }
            return listFood;
        }


        //Hàm lấy danh sách món ăn từ mã danh mục
        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> listFood = new List<Food>();
            string query = "SELECT * FROM MON WHERE MADMON = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }
            return listFood;
        }

        //Hàm lấy danh sách món ăn
        public List<Food> GetListFood()
        {
            List<Food> listFood = new List<Food>();
            string query = "SELECT * FROM MON";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }
            return listFood;
        }

        public bool InsertFood(string name, int id, float price)
        {
            string query = string.Format("INSERT INTO MON (TENMON, MADMON, GIA) VALUES (N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateFood(int idFood, string name, int id, float price)
        {
            string query = string.Format("UPDATE MON SET TENMON = N'{0}', MADMON = {1}, GIA = {2} WHERE MAMON = {3}", name, id, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteFood(int idFood)
        {
            BillInfoDAO.Instance.DeleteBillInforByIDFood(idFood);
            string query = "DELETE MON WHERE MAMON = " + idFood;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
