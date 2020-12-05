using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class QuanLyNhanVienTests
    {
        [TestMethod()]
        public void addAccountTest()
        {
            string firstname = "Nam";
            string lastname = "Nguyễn Hoàng";
            string address = "TP. Hồ Chí Minh";
            string phonenumber = "0762572819";
            string username = "nam";
            string role = "Quản lý";
            Assert.AreEqual(true, AccountDAO.Instance.insertAccount(firstname, lastname,
                address, phonenumber, username, role));
        }

        [TestMethod()]
        public void editAccountTest()
        {
            Assert.AreEqual(true, AccountDAO.Instance.updateAccount("Nam", "Nguyễn Hoàng",
                "Quảng Bình", "0152437718", "nam", "Nhân viên Bán vé"));
        }

        [TestMethod()]
        public void editAccountTest1()
        {
            Assert.AreEqual(false, AccountDAO.Instance.updateAccount("Nam", "Nguyễn Hoàng",
                "Quảng Ngãi", "0152437718", "nam111", "Nhân viên Kế toán"));
        }

        [TestMethod()]
        public void deleteAccountTest()
        {
            Assert.AreEqual(false, AccountDAO.Instance.deleteAccount("nam666"));
        }

        [TestMethod()]
        public void deleteAccountTest1()
        {
            Assert.AreEqual(true, AccountDAO.Instance.deleteAccount("nam"));
        }
    }
}