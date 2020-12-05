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
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class QuanLyNhanVien : Form
    {
        BindingSource accountList = new BindingSource();
        public Account loginAccount;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            load();
        }
        #region methods 
        void load()
        {
            dtgvStaff.DataSource = accountList;
            loadAccount();
            addAccountBinding();
            
        }


        void addAccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Username", true, DataSourceUpdateMode.Never)); //De k co chuyen doi du lieu tu Textbox ve datagridview
            txtFirstName.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
            txtLastName.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            txtAddress.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "TheAddress", true, DataSourceUpdateMode.Never));
            txtPhoneNumber.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            txtRole.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "TheRole"));
        }
        void loadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.getListAccount();
        }

        void addAccount(string firstname, string lastname, string address, string phonenumber, string username, string role)
        {
            if (AccountDAO.Instance.insertAccount(firstname, lastname, address, phonenumber, username, role))
            {
                MessageBox.Show("Thêm tài khoản nhân viên thành công");
            }
            else
            {     
                MessageBox.Show("Thêm tài khoản nhân viên không thành công");
            }
            loadAccount();
        }

        void editAccount(string firstname, string lastname, string address, string phonenumber, string username, string role)
        {
            if (AccountDAO.Instance.updateAccount(firstname, lastname, address, phonenumber, username, role))
            {
                MessageBox.Show("Sửa thông tin nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Sửa thông tin nhân viên không thành công");
            }
            loadAccount();
        }

        void deleteAccount(string username)
        {
            if (AccountDAO.Instance.deleteAccount(username))
            {
                MessageBox.Show("Xóa thông tin nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Xóa thông tin nhân viên không thành công");
            }
            loadAccount();
        }

        void clear() 
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtUserName.Text = "";
            txtRole.Text = "";
        }
        #endregion

        #region events

        private void btnAddStaff_Click_1(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string address = txtAddress.Text;
            string phonenumber = txtPhoneNumber.Text;
            string username = txtUserName.Text;
            string role = txtRole.Text;
            addAccount(firstname, lastname, address, phonenumber, username, role);
        }

        private void btnDeleteStaff_Click_1(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            deleteAccount(username);
        }

        private void btnReadStaff_Click_1(object sender, EventArgs e)
        {
            loadAccount();
        }

        private void btnEditStaff_Click_1(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string address = txtAddress.Text;
            string phonenumber = txtPhoneNumber.Text;
            string username = txtUserName.Text;
            string role = txtRole.Text;
            editAccount(firstname, lastname, address, phonenumber, username, role);
        }

        private void btnReadStaff_Click(object sender, EventArgs e)
        {
            loadAccount();
        }
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            //this.Hide();
            doiMatKhau.ShowDialog();
            //this.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }


        #endregion


    }
}
