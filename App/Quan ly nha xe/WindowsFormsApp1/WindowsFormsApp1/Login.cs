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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtboxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtboxUserName.Text;
            string password = txtPassword.Text;
            if (checkLogin(username, password)) 
            {
                if (returnrole(username, password) == "Quản lý")
                {
                    QuanLyNhanVien QLNhanVien = new QuanLyNhanVien();
                    this.Hide();
                    QLNhanVien.ShowDialog();
                    this.Show();
                }
                else if(returnrole(username, password) == "Nhân viên Bán vé")
                {
                    BanVe NVBV = new BanVe();
                    this.Hide();
                    NVBV.ShowDialog();
                    this.Show();
                }    
                else if(returnrole(username, password) == "Nhân viên Kế toán")
                {
                    KeToan ketoanForm = new KeToan();
                    this.Hide();
                    ketoanForm.ShowDialog();
                    this.Show();
                }    
            }
            else
            {   if (username == "")
                    MessageBox.Show("Vui lòng nhập tên đăng nhập");
                else if (password == "")
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                }
            }

        }

        bool checkLogin(string username, string password)
        {
            return AccountDAO.Instance.Login(username,password);
        }

        
        string returnrole(string username, string password)
        {
            return AccountDAO.Instance.returnRole(username, password);
        }
        

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát chương trình không?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
            this.Show();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
