using Do_an_co_so_2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_co_so_2.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT BAN.TRANGTHAI, BAN.TENBAN, MON.TENMON, HOADONCHITIET.SOLUONG, MON.GIA, MON.GIA*HOADONCHITIET.SOLUONG AS totalPrice FROM dbo.HOADONCHITIET, dbo.HOADON, dbo.MON, BAN WHERE HOADONCHITIET.MAHD = HOADON.MAHD AND HOADONCHITIET.MAMON = MON.MAMON AND BAN.MABAN = HOADON.MABAN AND HOADON.TRANGTHAIHD = 0 AND HOADON.TRANGTHAIHD = 0 AND HOADON.MABAN = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
