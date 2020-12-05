using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class KeToan : Form
    {
        BindingSource accountList = new BindingSource();
        BindingSource tableSalary = new BindingSource();
        public KeToan()
        {
            InitializeComponent();
            load();
        }
        #region methods 
        void load()
        {
            dtgvStaff.DataSource = accountList;
            dtgvTableSalary.DataSource = tableSalary;
            loadAccount();
            //addAccountBinding();
            loadTableSalary();
            addTableSalaryBinding();
        }
        void loadAccount()
        {
            accountList.DataSource = SalaryDAO.Instance.getListAccountSalary();
        }
        void loadTableSalary()
        {
            tableSalary.DataSource = SalaryDAO.Instance.getListTableSalary();
        }
        void addAccountBinding()
        {
            //De k co chuyen doi du lieu tu Textbox ve datagridview
            txtFirstName.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
            txtLastName.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            txtPhoneNumber.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            txtRole.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "TheRole", true, DataSourceUpdateMode.Never));
            txtIDNhanvien.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }

        
        void addTableSalaryBinding()
        {
            txtFirstName.DataBindings.Add(new Binding("Text", dtgvTableSalary.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
            txtLastName.DataBindings.Add(new Binding("Text", dtgvTableSalary.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            txtPhoneNumber.DataBindings.Add(new Binding("Text", dtgvTableSalary.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            txtRole.DataBindings.Add(new Binding("Text", dtgvTableSalary.DataSource, "TheRole", true, DataSourceUpdateMode.Never));
            txtSalary.DataBindings.Add(new Binding("Text", dtgvTableSalary.DataSource, "Salary", true, DataSourceUpdateMode.Never));
            txtIDNhanvien.DataBindings.Add(new Binding("Text", dtgvTableSalary.DataSource, "IDAccount", true, DataSourceUpdateMode.Never));
            txtTrangThaiTienLuong.DataBindings.Add(new Binding("Text", dtgvTableSalary.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
        }
        
        void addSalary(string firstname, string lastname, string phonenumber, string role, string Salary, string IDAccount, string trangthai)
        {
            if (SalaryDAO.Instance.insertSalary(firstname, lastname, phonenumber, role, Salary, IDAccount, trangthai))
            {
                MessageBox.Show("Thêm tiền lương cho nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm tiền lương cho nhân viên thất bại");
            }
            loadTableSalary();
        }

        void editSalary(string firstname, string lastname, string phonenumber, string role, string Salary, string IDAccount, string trangthai)
        {
            if (SalaryDAO.Instance.updateSalary(firstname, lastname, phonenumber, role, Salary, IDAccount,trangthai))
            {
                MessageBox.Show("Sửa tiền lương thành công");
            }
            else
            {
                MessageBox.Show("Sửa tiền lương thất bại");
            }
            loadTableSalary();
        }

        void deleteSalary(string id)
        {
            if (SalaryDAO.Instance.deleteSalary(id))
            {
                MessageBox.Show("Xóa tiền lương nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Xóa tiền lương nhân viên thất bại");
            }
            loadTableSalary();
        }
        void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
            txtRole.Text = "";
            txtSalary.Text = "";
            txtIDNhanvien.Text = "";
            txtTrangThaiTienLuong.Text = "";
        }

        void loadListTicketByDate(DateTime startday, DateTime endday)
        {
            dtgvThongKeVeDaBan.DataSource =  DoanhThuDAO.Instance.GetListTicketByDate(startday, endday);
        }

        void loadDoanhThu(DateTime startday, DateTime endday)
        {
            dtgvDoanhThu.DataSource = DoanhThuDAO.Instance.getDoanhThu(startday, endday);
        }
        #endregion

        #region events

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string phonenumber = txtPhoneNumber.Text;
            string role = txtRole.Text;
            string salary = txtSalary.Text;
            string idnhanvien = txtIDNhanvien.Text;
            string trangthai = txtTrangThaiTienLuong.Text;
            addSalary(firstname, lastname, phonenumber, role, salary, idnhanvien, trangthai);
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string id = txtIDNhanvien.Text;
            deleteSalary(id);
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string phonenumber = txtPhoneNumber.Text;
            string role = txtRole.Text;
            string salary = txtSalary.Text;
            string idnhanvien = txtIDNhanvien.Text;
            string trangthai = txtTrangThaiTienLuong.Text;
            editSalary(firstname, lastname, phonenumber, role, salary, idnhanvien, trangthai);
        }

        private void btnReadStaff_Click(object sender, EventArgs e)
        {
            loadAccount();
            loadTableSalary();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(txtIDNhanvien.Text);
            string Trangthai = "Đã thanh toán";
            SalaryDAO.Instance.ThanhToan(id, Trangthai);
            MessageBox.Show("Thanh toán thành công");
            loadTableSalary();
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnThongKeVeDaBan_Click(object sender, EventArgs e)
        {
            loadListTicketByDate(dtpStartDay.Value, dtpEndDay.Value);
        }
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            loadDoanhThu(dtpStartDay.Value, dtpEndDay.Value);
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            //this.Hide();
            doiMatKhau.ShowDialog();
            //this.Show();
        }
        #endregion


    }
}

