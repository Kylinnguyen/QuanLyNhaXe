using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Account
    {   
        public Account(string username, string firstname, string lastname, string address, string phonenumber, string role, string password = null)
        {
            this.Username = username;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Address = address;
            this.Phonenumber = phonenumber;
            this.Password = password;
            this.Role = role;
        }
        public Account(DataRow row)
        {
            this.Username = row["UserName"].ToString();
            this.Firstname = row["FirstName"].ToString();
            this.Lastname = row["LastName"].ToString();
            this.Address = row["TheAddress"].ToString();
            this.Phonenumber = row["PhoneNumber"].ToString();
            this.Password = row["ThePassword"].ToString();
            this.Role = row["TheRole"].ToString();
        }

        private string role;
        private string password;
        private string phonenumber;
        private string address;
        private string lastname;
        private string firstname;
        private string username;
    
        public string Firstname { get => firstname; set => firstname = value; }
        public string Username { get => username; set => username = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Address { get => address; set => address = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
