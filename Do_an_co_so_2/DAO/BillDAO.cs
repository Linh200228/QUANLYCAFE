using Do_an_co_so_2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DAO
{
    public class BillDAO
    {
        static private BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }

        public int GetUnCheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HOADON WHERE MABAN = " + id + " AND TRANGTHAIHD = 0");

            //kiểm tra điều kiện có bill hay không nếu có thi lấy idBill
            if (data.Rows.Count > 0)
            {
                //Lấy cái dòng idBill
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            //Ngược lại không có bill thì trả về -1
            return -1;
        }

        //Hàm thêm hóa đơn vô trong một table
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertHOADON @MABAN", new object[] { id });
        }

        //lấy bill list từ date trong database
        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_DSHDTHEONGAY @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        //Hàm thanh toán hóa đơn
        public void PayBill(int id, int discount, float totalPrice)
        {
            string query = "UPDATE HOADON SET NGAYRA = GETDATE(), TRANGTHAIHD = 1, TONGTIEN = " + totalPrice + ", GIAMGIA = " + discount + " WHERE MAHD = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(MAHD) FROM HOADON");
            }
            catch
            {
                return 1;
            }
        }
    }
}
