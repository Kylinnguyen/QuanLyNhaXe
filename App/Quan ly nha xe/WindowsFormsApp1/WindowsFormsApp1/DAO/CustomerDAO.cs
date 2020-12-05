using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }

        private CustomerDAO() { }

        public bool SaveCustomer(string Name, string TheAddress, string PhoneNumber,string Email, string TimeLeave,string station, string CMND, string CityLeave, string cityArrival, string GiaVe)
        {
            string query = "INSERT Customer( Name ,TheAddress ,PhoneNumber ,Email ,TimeLeave ,station ,CMND, CityLeave, cityArrival, GiaVe) VALUES(N'" + Name + "', N'" + TheAddress + "', '" + PhoneNumber + "', '" + Email + "', '" + TimeLeave + "', N'" + station + "', '" + CMND + "', N'" + CityLeave + "', N'" + cityArrival + "','" + GiaVe + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ThanhToan(string Name, string trangthai)
        {
           
            string query = string.Format("Update Customer set TrangThai = N'{0}' where Name = N'{1}'", trangthai, Name);
            
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable getListCustomer()
        {
            return DataProvider.Instance.ExecuteQuery("Select Name, TheAddress, PhoneNumber, Email, TimeLeave, station, CMND, CityLeave, cityArrival, Giave, TrangThai from Customer");
        }
        

        public bool insertCustomer(string Name, string TheAddress, string PhoneNumber, string Email, string TimeLeave, string station, string CMND, string CityLeave, string cityArrival, string GiaVe)
        {
            string query = "INSERT Customer( Name ,TheAddress ,PhoneNumber ,Email ,TimeLeave ,station ,CMND, CityLeave, cityArrival, GiaVe) VALUES(N'" + Name + "', N'" + TheAddress + "', '" + PhoneNumber + "', '" + Email + "', '" + TimeLeave + "', N'" + station + "', '" + CMND + "', N'" + CityLeave + "', N'" + cityArrival + "','" + GiaVe + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateCustomer(string Name, string TheAddress, string PhoneNumber, string Email, string TimeLeave, string station, string CMND, string CityLeave, string cityArrival, string GiaVe, string TrangThai)
        {
            string query = string.Format("Update Customer set TheAddress = N'{1}', PhoneNumber = '{2}', " +
                "Email = '{3}', TimeLeave = '{4}', station = N'{5}', CMND = '{6}', " +
                "CityLeave = N'{7}', cityArrival = N'{8}', GiaVe = '{9}', TrangThai = N'{10}' where Name = N'{0}'", 
                Name, TheAddress, PhoneNumber, Email, TimeLeave, station, CMND, CityLeave, cityArrival, GiaVe, TrangThai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deleteCustomer(string Name)
        {
            string query = string.Format("Delete Customer where Name = N'{0}'", Name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
