using Do_an_co_so_2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        //public void DeleteBillInfoByFoodID(int id)
        //{
        //    DataProvider.Instance.ExecuteQuery("delete dbo.BillInfo WHERE idFood = " + id);
        //}

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HOADONCHITIET WHERE MAHD = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertHOADONCHITIET @MAHD , @MAMON , @SOLUONG", new object[] { idBill, idFood, count });
        }

        public void DeleteBillInforByIDFood(int id)
        {
            string query = "DELETE HOADONCHITIET WHERE MAMON = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);

        }
    }
}
