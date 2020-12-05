using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        { 
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance;}
            private set { AccountDAO.instance = value; } 
        }
    
        private AccountDAO() {}


        public bool SignUp(string firstname, string lastname, string address, 
            string phonenumber, string username, string password, string role)
        {
            string query = "INSERT dbo.Account( FirstName ,LastName ,TheAddress ,PhoneNumber ,UserName ,ThePassword ,TheRole) VALUES(N'"+firstname+"', N'"+lastname+ "', N'"+address+ "', '"+phonenumber+ "', '"+username+ "', '"+password+ "', N'"+role+"')";
            //cach 2
            /*
            string query = string.Format("EXEC dbo.addUser @FirstName = N'{0}, " +
                "@LastName = N'{1}', @TheAddress = N'{2}', " +
                "@PhoneNumber = '{3}', @UserName = '{4}', " +
                "@ThePassword = '{5}', @TheRole = N'{6}' ", firstname,lastname,
                address,phonenumber,username,password,role);
            */
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Login(string username, string password)
        {
            string query = "proc_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{username, password});
            return result.Rows.Count > 0;
        }
        
        
        public string returnRole(string username, string password)
        {
            string query = "SELECT TheRole FROM dbo.Account WHERE UserName = '" + username + "' AND ThePassword = '" + password + "'";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result.ToString();
        }
                  

        public DataTable getListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("Select UserName, FirstName, LastName, TheAddress, PhoneNumber, TheRole from Account");
        }
        /*
        public Account getAccountFromUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Account where username = '"+ username+"' ");
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        */
       

        public bool insertAccount(string firstname, string lastname, string address, string phonenumber, string username, string role)
        {
            string query = string.Format("Insert Account (Username, FirstName, LastName, TheAddress, PhoneNumber, TheRole) Values('{0}', N'{1}', N'{2}', N'{3}', '{4}', N'{5}')", username, firstname, lastname, address, phonenumber, role);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateAccount(string firstname, string lastname, string address, string phonenumber, string username, string role)
        {
            string query = string.Format("Update Account set FirstName = N'{1}', LastName = N'{2}', TheAddress = N'{3}', PhoneNumber = '{4}', TheRole = N'{5}' where Username = '{0}'", username, firstname, lastname, address, phonenumber, role);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deleteAccount(string username)
        {
            string query = string.Format("Delete Account where UserName = '{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool changePassWord(string username, string newpassword)
        {
            string query = string.Format("Update Account set ThePassword = '{1}' where Username = '{0}'", username, newpassword);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public string returnPassWord(string username)
        {
            string query = "SELECT ThePassword FROM dbo.Account WHERE UserName = '" + username + "'";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result.ToString();
        }
    }
}
