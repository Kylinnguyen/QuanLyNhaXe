using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InforAccount : Form
    {
        public InforAccount()
        {
            InitializeComponent();
        }

        private void btnExti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void UpdateAccount()
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string address = txtAddress.Text;
            string phonenumber = txtPhoneNumber.Text;
            string username = txtUserName.Text;
            string oldpassword = txtOldPassword.Text;
            string newpassword = txtNewPassword.Text;
            string role = txtRole.Text;
            string reEnterPass = txtReEnterPass.Text;
            if (!reEnterPass.Equals(newpassword))
            {
                MessageBox.Show("Vui lòng nhập đúng mật khẩu mới đã nhập trước đó");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
}
