using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    class DoanhThuDAO
    {
        private static DoanhThuDAO instance;

        public static DoanhThuDAO Instance
        {
            get { if (instance == null) instance = new DoanhThuDAO(); return DoanhThuDAO.instance; }
            private set { DoanhThuDAO.instance = value; }
        }

        private DoanhThuDAO() { }

        public DataTable GetListTicketByDate(DateTime startday, DateTime endday)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC proc_getListTicketByDate @startday= '" + startday + "', @endday = '" + endday+ "'");
        }
        public DataTable getDoanhThu(DateTime startday, DateTime endday)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC proc_getDoanhThu @startday= '" + startday + "', @endday = '" + endday + "'");
        }
    }
}
