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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        #region events
        private void btnSaveNewPass_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string oldpassword = txtOldPassword.Text;
            string newpassword = txtNewPass.Text;
            string confirmnewpass = txtConfirmNewPass.Text;
            if ((oldpassword == returnPassword(username)) && (newpassword == confirmnewpass))
            {
                changePassWord(username, newpassword);
                clear();
            }    
            else
            {
                MessageBox.Show("Sai mật khẩu cũ hoặc nhập lại mật khẩu không trùng khớp với mật khẩu mới");
            }
        }
        #endregion

        #region methods
        void changePassWord(string username, string password)
        {
            if (AccountDAO.Instance.changePassWord(username, password))
            {
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại");
            }
        }
        string returnPassword(string username)
        {
            return AccountDAO.Instance.returnPassWord(username);
        }

        void clear()
        {
            txtUserName.Text = "";
            txtOldPassword.Text = "";
            txtNewPass.Text = "";
            txtConfirmNewPass.Text = "";
        }
        #endregion



    }
}
