using Do_an_co_so_2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        //Hàm lấy danh sách category
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "SELECT * FROM DANHMUCMON";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT INTO DANHMUCMON (TENDMON) VALUES (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("UPDATE DANHMUCMON SET TENDMON = N'{0}' WHERE MADMON = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            BillInfoDAO.Instance.DeleteBillInforByIDFood(id);
            string query = "DELETE DANHMUCMON WHERE MADMON= " + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "SELECT * FROM DANHMUCMON WHERE MADMON = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }
    }
}
