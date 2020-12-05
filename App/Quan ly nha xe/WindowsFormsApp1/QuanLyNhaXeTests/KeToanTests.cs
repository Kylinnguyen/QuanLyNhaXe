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
    public class KeToanTests
    {
        [TestMethod()]
        public void addSalaryTest()
        {
            Assert.AreEqual(true, SalaryDAO.Instance.insertSalary("Hưng", "Đàm Vĩnh",
                "0898235488", "Nhân viên Kế toán", "7000000", "6", "Chưa thanh toán"));
        }

        [TestMethod()]
        public void editSalaryTest()
        {
            Assert.AreEqual(true, SalaryDAO.Instance.updateSalary("Hưng", "Đàm Vĩnh",
                "0898235488", "Nhân viên Kế toán", "6000000", "6", "Chưa thanh toán"));
        }

        [TestMethod()]
        public void editSalaryTest1()
        {
            Assert.AreEqual(false, SalaryDAO.Instance.updateSalary("Hưng", "Đàm Vĩnh",
                "0261152838", "Nhân viên Kế toán", "6000000", "6", "Chưa thanh toán"));
        }

        [TestMethod()]
        public void deleteSalaryTest()
        {
            Assert.AreEqual(false, SalaryDAO.Instance.deleteSalary("10"));
        }

        [TestMethod()]
        public void deleteSalaryTest1()
        {
            Assert.AreEqual(true, SalaryDAO.Instance.deleteSalary("6"));
        }
    }
}