using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.DAO;
using System.CodeDom.Compiler;

namespace WindowsFormsApp1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát quá trình đăng ký không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string address = txtAddress.Text;
            string phonenumber = txtPhoneNumber.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string role = txtRole.Text;
            string confirmpassword = txtConfirmPassword.Text;

            if (firstname == "")
            {
                MessageBox.Show("Vui lòng điền tên");
            }
            else if (lastname == "")
            {
                MessageBox.Show("Vui lòng điền tên đệm");
            }
            else if (address == "")
            {
                MessageBox.Show("Vui lòng điền địa chỉ");
            }
            else if (phonenumber == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại");
            }
            else if (phonenumber.Length > 10)
            {
                MessageBox.Show("Số điện thoại chỉ gồm 10 số");
            }
            else if (username == "")
            {
                MessageBox.Show("Vui lòng điền tên đăng nhập");
            }
            else if (password == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu");
            }
            else if (role == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu");
            }
            else if (password != confirmpassword)
            {
                MessageBox.Show("Vui lòng xác nhận đúng mật khẩu đã nhập");
            }
            else
            {
                /*
                using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Quanlynhaxe;Integrated Security=True"))
                {
                    conn.Open(); //mo ket noi DB
                    SqlCommand cmd = new SqlCommand("addUser", conn); // ket noi proc addUser tren ket noi conn va thuc thi proc
                    cmd.CommandType = CommandType.StoredProcedure;// chon loai dong lenh la Proceduce
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@TheAddress", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ThePassword", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@TheRole", txtRole.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công");
                    Clear();
                    conn.Close(); //Dong ket noi DB
                }
                */
                if(AccountDAO.Instance.SignUp(firstname,lastname,address
                    , phonenumber, username, password, role))
                {
                    MessageBox.Show("Đăng ký thành công");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại");
                    Clear();
                }
            }
        }
        void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtRole.Text = "";
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassWord_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
