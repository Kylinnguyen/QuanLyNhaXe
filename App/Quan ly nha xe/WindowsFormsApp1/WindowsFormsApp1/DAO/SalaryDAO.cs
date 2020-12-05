using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    class SalaryDAO
    {
        private static SalaryDAO instance;

        public static SalaryDAO Instance
        {
            get { if (instance == null) instance = new SalaryDAO(); return SalaryDAO.instance; }
            private set { SalaryDAO.instance = value; }
        }

        private SalaryDAO() { }


        public bool ThanhToan(int id, string trangthai)
        {

            string query = string.Format("Update Salary set TrangThai = N'{0}' where IDAccount = {1}", trangthai, id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable getListAccountSalary()
        {
            return DataProvider.Instance.ExecuteQuery("Select ID, FirstName, LastName, PhoneNumber, TheRole from Account");
        }
        
        public DataTable getListTableSalary()
        {
            return DataProvider.Instance.ExecuteQuery("Select * from Salary");
        }

        public bool insertSalary(string firstname, string lastname, string phonenumber, string role, string Salary, string IDAccount, string trangthai)
        {
            string query = string.Format("Insert Salary (FirstName, LastName, PhoneNumber, TheRole, Salary, IDAccount, TrangThai) Values(N'{0}', N'{1}', '{2}', N'{3}', '{4}', '{5}', N'{6}')", firstname, lastname,  phonenumber, role, Salary, IDAccount, trangthai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

        public bool updateSalary(string firstname, string lastname, string phonenumber, string role, string Salary, string IDAccount, string trangthai)
        {
            string query = string.Format("Update Salary set FirstName = N'{1}', LastName = N'{2}', IDAccount = '{3}', TheRole = N'{4}', Salary = '{5}', TrangThai = N'{6}' where PhoneNumber = '{0}'", phonenumber, firstname, lastname, IDAccount, role, Salary, trangthai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deleteSalary(string id)
        {
            string query = string.Format("Delete Salary where IDAccount = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
