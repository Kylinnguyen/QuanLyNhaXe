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
    public partial class BanVe : Form
    {
        BindingSource customerList = new BindingSource();
        public BanVe()
        {
            InitializeComponent();
            load();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        #region methods
        void load()
        {
            dtgvKhachHang.DataSource = customerList;
            loadCustomer();
            addCustomerBinding();

        }
        void addCustomerBinding()
        {
            txtHoTenQLKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "Name", true, DataSourceUpdateMode.Never)); //De k co chuyen doi du lieu tu Textbox ve datagridview
            txtDiaChiQLKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "TheAddress", true, DataSourceUpdateMode.Never));
            txtSDTQLKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            txtEmailQLKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtCMNDQLKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            comboBoxDiemDiQLKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "CityLeave", true, DataSourceUpdateMode.Never));
            comboBoxDiemDenQLKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "cityArrival", true, DataSourceUpdateMode.Never));
            comboBoxBenXeDiQLKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "station", true, DataSourceUpdateMode.Never));
            dateTimePickerQLKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "TimeLeave", true, DataSourceUpdateMode.Never));
            comboBoxGiaVeQLKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "GiaVe", true, DataSourceUpdateMode.Never));
            txtTrangThaiQLKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
        }
        
        void loadCustomer()
        {
            customerList.DataSource = CustomerDAO.Instance.getListCustomer();
        }

        void addCustomer(string Name, string TheAddress, string PhoneNumber, string Email, string TimeLeave, string station, string CMND, string CityLeave, string cityArrival, string GiaVe)
        {
            if (CustomerDAO.Instance.insertCustomer(Name, TheAddress, PhoneNumber, Email, TimeLeave, station, CMND, CityLeave, cityArrival, GiaVe))
            {
                MessageBox.Show("Thêm khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại");
            }
            loadCustomer();
        }

        void editCustomer(string Name, string TheAddress, string PhoneNumber, string Email, string TimeLeave, string station, string CMND, string CityLeave, string cityArrival, string GiaVe, string TrangThai)
        {
            if (CustomerDAO.Instance.updateCustomer(Name, TheAddress, PhoneNumber, Email, TimeLeave, station, CMND, CityLeave, cityArrival, GiaVe, TrangThai))
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Sửa thông tin khách hàng thất bại");
            }
            loadCustomer();
        }

        void deleteCustomer(string Name)
        {
            if (CustomerDAO.Instance.deleteCustomer(Name))
            {
                MessageBox.Show("Xóa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            loadCustomer();
        }

        void Clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";

            comboBoxBenXeDi.Text = "";
            txtCMND.Text = "";
            comboBoxDiemDi.Text = "";
            comboBoxDiemDen.Text = "";
            comboBoxGiaVe.Text = "";

        }

        void clearQLKH()
        {
            txtHoTenQLKH.Text = "";
            txtDiaChiQLKH.Text = "";
            txtSDTQLKH.Text = "";
            txtEmailQLKH.Text = "";
            txtCMNDQLKH.Text = "";
            comboBoxDiemDiQLKH.Text = "";
            comboBoxDiemDenQLKH.Text = "";
            comboBoxBenXeDiQLKH.Text = "";
            dateTimePickerQLKH.Text = "";
            comboBoxGiaVeQLKH.Text = "";
            txtTrangThaiQLKH.Text = "";
        }
        #endregion


        #region events

        private void comboBoxDiemDi_SelectedIndexChanged(object sender, EventArgs e)
        {

            //------------------------
            if ((comboBoxDiemDi.Text == "TP. HCM" && comboBoxDiemDen.Text == "TP. Đà Lạt")
                || (comboBoxDiemDi.Text == "TP. Đà Lạt" && comboBoxDiemDen.Text == "TP. HCM"))
            {
                comboBoxGiaVe.Text = "250000";
            }
            else if ((comboBoxDiemDi.Text == "TP. HCM" && comboBoxDiemDen.Text == "TP. Nha Trang")
                || (comboBoxDiemDi.Text == "TP. Nha Trang" && comboBoxDiemDen.Text == "TP. HCM"))
            {
                comboBoxGiaVe.Text = "225000";
            }
            else if ((comboBoxDiemDi.Text == "TP. HCM" && comboBoxDiemDen.Text == "TP. Đà nẵng")
                || (comboBoxDiemDi.Text == "TP. Đà Nẵng" && comboBoxDiemDen.Text == "TP. HCM"))
            {
                comboBoxGiaVe.Text = "375000";
            }
            else if ((comboBoxDiemDi.Text == "TP. HCM" && comboBoxDiemDen.Text == "TP. Huế")
                || (comboBoxDiemDi.Text == "TP. Huế" && comboBoxDiemDen.Text == "TP. HCM"))
            {
                comboBoxGiaVe.Text = "380000";
            }

            else if ((comboBoxDiemDi.Text == "TP. Đà Lạt" && comboBoxDiemDen.Text == "TP. Nha Trang")
                || (comboBoxDiemDi.Text == "TP. Nha Trang" && comboBoxDiemDen.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVe.Text = "135000";
            }
            else if ((comboBoxDiemDi.Text == "TP. Đà Lạt" && comboBoxDiemDen.Text == "TP. Đà nẵng")
                || (comboBoxDiemDi.Text == "TP. Đà nẵng" && comboBoxDiemDen.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVe.Text = "285000";
            }
            else if ((comboBoxDiemDi.Text == "TP. Đà Lạt" && comboBoxDiemDen.Text == "TP. Huế")
                || (comboBoxDiemDi.Text == "TP. Huế" && comboBoxDiemDen.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVe.Text = "345000";
            }

            //------------------------
            else if ((comboBoxDiemDi.Text == "TP. Nha Trang" && comboBoxDiemDen.Text == "TP. Đà nẵng")
                || (comboBoxDiemDi.Text == "TP. Đà nẵng" && comboBoxDiemDen.Text == "TP. Nha Trang"))
            {
                comboBoxGiaVe.Text = "240000";
            }
            else if ((comboBoxDiemDi.Text == "TP. Nha Trang" && comboBoxDiemDen.Text == "TP. Huế")
                || (comboBoxDiemDi.Text == "TP. Huế" && comboBoxDiemDen.Text == "TP. Nha Trang"))
            {
                comboBoxGiaVe.Text = "250000";
            }

            //------------------------
            else if ((comboBoxDiemDi.Text == "TP. Đà nẵng" && comboBoxDiemDen.Text == "TP. Huế")
                || (comboBoxDiemDi.Text == "TP. Huế" && comboBoxDiemDen.Text == "TP. Đà nẵng"))
            {
                comboBoxGiaVe.Text = "80000";
            }
            else if ((comboBoxDiemDi.Text == "TP. HCM" && comboBoxDiemDen.Text == "TP. HCM")
                 || (comboBoxDiemDi.Text == "TP. HCM" && comboBoxDiemDen.Text == "TP. HCM"))
            {
                comboBoxGiaVe.Text = "";
            }
            else if ((comboBoxDiemDi.Text == "TP. Đà Lạt" && comboBoxDiemDen.Text == "TP. Đà Lạt")
                 || (comboBoxDiemDi.Text == "TP. Đà Lạt" && comboBoxDiemDen.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVe.Text = "";
            }
            else if ((comboBoxDiemDi.Text == "TP. Nha Trang" && comboBoxDiemDen.Text == "TP. Nha Trang")
                 || (comboBoxDiemDi.Text == "TP. Nha Trang" && comboBoxDiemDen.Text == "TP. Nha Trang"))
            {
                comboBoxGiaVe.Text = "";
            }
            else if ((comboBoxDiemDi.Text == "TP. Đà Nẵng" && comboBoxDiemDen.Text == "TP. Đà Nẵng")
                 || (comboBoxDiemDi.Text == "TP. Đà Nẵng" && comboBoxDiemDen.Text == "TP. Đà Nẵng"))
            {
                comboBoxGiaVe.Text = "";
            }
            else if ((comboBoxDiemDi.Text == "TP. Huế" && comboBoxDiemDen.Text == "TP. Huế")
                 || (comboBoxDiemDi.Text == "TP. Huế" && comboBoxDiemDen.Text == "TP. Huế"))
            {
                comboBoxGiaVe.Text = "";
            }
        }

        private void btnThanhtoan_Click_1(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Trangthai = "Đã thanh toán";
            CustomerDAO.Instance.ThanhToan(Name, Trangthai);
            MessageBox.Show("Thanh toán thành công");
            Clear();
        }
        private void comboBoxDiemDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboBoxDiemDi.Text == "TP. HCM" && comboBoxDiemDen.Text == "TP. Đà Lạt")
                || (comboBoxDiemDi.Text == "TP. Đà Lạt" && comboBoxDiemDen.Text == "TP. HCM"))
            {
                comboBoxGiaVe.Text = "250000";
            }
            else if ((comboBoxDiemDi.Text == "TP. HCM" && comboBoxDiemDen.Text == "TP. Nha Trang")
                || (comboBoxDiemDi.Text == "TP. Nha Trang" && comboBoxDiemDen.Text == "TP. HCM"))
            {
                comboBoxGiaVe.Text = "225000";
            }
            else if ((comboBoxDiemDi.Text == "TP. HCM" && comboBoxDiemDen.Text == "TP. Đà nẵng")
                || (comboBoxDiemDi.Text == "TP. Đà Nẵng" && comboBoxDiemDen.Text == "TP. HCM"))
            {
                comboBoxGiaVe.Text = "375000";
            }
            else if ((comboBoxDiemDi.Text == "TP. HCM" && comboBoxDiemDen.Text == "TP. Huế")
                || (comboBoxDiemDi.Text == "TP. Huế" && comboBoxDiemDen.Text == "TP. HCM"))
            {
                comboBoxGiaVe.Text = "380000";
            }

            else if ((comboBoxDiemDi.Text == "TP. Đà Lạt" && comboBoxDiemDen.Text == "TP. Nha Trang")
                || (comboBoxDiemDi.Text == "TP. Nha Trang" && comboBoxDiemDen.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVe.Text = "135000";
            }
            else if ((comboBoxDiemDi.Text == "TP. Đà Lạt" && comboBoxDiemDen.Text == "TP. Đà nẵng")
                || (comboBoxDiemDi.Text == "TP. Đà nẵng" && comboBoxDiemDen.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVe.Text = "285000";
            }
            else if ((comboBoxDiemDi.Text == "TP. Đà Lạt" && comboBoxDiemDen.Text == "TP. Huế")
                || (comboBoxDiemDi.Text == "TP. Huế" && comboBoxDiemDen.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVe.Text = "345000";
            }

            //------------------------
            else if ((comboBoxDiemDi.Text == "TP. Nha Trang" && comboBoxDiemDen.Text == "TP. Đà nẵng")
                || (comboBoxDiemDi.Text == "TP. Đà nẵng" && comboBoxDiemDen.Text == "TP. Nha Trang"))
            {
                comboBoxGiaVe.Text = "240000";
            }
            else if ((comboBoxDiemDi.Text == "TP. Nha Trang" && comboBoxDiemDen.Text == "TP. Huế")
                || (comboBoxDiemDi.Text == "TP. Huế" && comboBoxDiemDen.Text == "TP. Nha Trang"))
            {
                comboBoxGiaVe.Text = "250000";
            }

            //------------------------
            else if ((comboBoxDiemDi.Text == "TP. Đà nẵng" && comboBoxDiemDen.Text == "TP. Huế")
                || (comboBoxDiemDi.Text == "TP. Huế" && comboBoxDiemDen.Text == "TP. Đà nẵng"))
            {
                comboBoxGiaVe.Text = "80000";
            }
            else if ((comboBoxDiemDi.Text == "TP. HCM" && comboBoxDiemDen.Text == "TP. HCM")
                 || (comboBoxDiemDi.Text == "TP. HCM" && comboBoxDiemDen.Text == "TP. HCM"))
            {
                comboBoxGiaVe.Text = "";
            }
            else if ((comboBoxDiemDi.Text == "TP. Đà Lạt" && comboBoxDiemDen.Text == "TP. Đà Lạt")
                 || (comboBoxDiemDi.Text == "TP. Đà Lạt" && comboBoxDiemDen.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVe.Text = "";
            }
            else if ((comboBoxDiemDi.Text == "TP. Nha Trang" && comboBoxDiemDen.Text == "TP. Nha Trang")
                 || (comboBoxDiemDi.Text == "TP. Nha Trang" && comboBoxDiemDen.Text == "TP. Nha Trang"))
            {
                comboBoxGiaVe.Text = "";
            }
            else if ((comboBoxDiemDi.Text == "TP. Đà Nẵng" && comboBoxDiemDen.Text == "TP. Đà Nẵng")
                 || (comboBoxDiemDi.Text == "TP. Đà Nẵng" && comboBoxDiemDen.Text == "TP. Đà Nẵng"))
            {
                comboBoxGiaVe.Text = "";
            }
            else if ((comboBoxDiemDi.Text == "TP. Huế" && comboBoxDiemDen.Text == "TP. Huế")
                 || (comboBoxDiemDi.Text == "TP. Huế" && comboBoxDiemDen.Text == "TP. Huế"))
            {
                comboBoxGiaVe.Text = "";
            }

        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string TheAddress = txtAddress.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            string Email = txtEmail.Text;
            dateTimePickerLeave.CustomFormat = "dd-MM-yyyy";
            string TimeLeave = dateTimePickerLeave.Value.ToString();
            string station = comboBoxBenXeDi.Text;
            string CMND = txtCMND.Text;
            string CityLeave = comboBoxDiemDi.Text;
            string cityArrival = comboBoxDiemDen.Text;
            string GiaVe = comboBoxGiaVe.Text;

            if (Name == "")
            {
                MessageBox.Show("Vui lòng điền họ tên");
            }
            else if (TheAddress == "")
            {
                MessageBox.Show("Vui lòng điền địa chỉ");
            }
            else if (PhoneNumber == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại");
            }
            else if (PhoneNumber.Length > 10)
            {
                MessageBox.Show("Số điện thoại chỉ gồm 10 số");
            }
            else if (Email == "")
            {
                MessageBox.Show("Vui lòng điền địa chỉ mail");
            }
            else if (station == "")
            {
                MessageBox.Show("Vui lòng điền bến xe đi");
            }
            else if (CMND == "")
            {
                MessageBox.Show("Vui lòng điền chứng minh nhân dân");
            }
            else if (CityLeave == "")
            {
                MessageBox.Show("Vui lòng điền điểm đi");
            }
            else if (CityLeave == "")
            {
                MessageBox.Show("Vui lòng điền điểm đến");
            }
            else if (GiaVe == "")
            {
                MessageBox.Show("Vui lòng điền giá vé");
            }
            else
            {
                if (CustomerDAO.Instance.SaveCustomer(Name, TheAddress, PhoneNumber, Email,
                    TimeLeave, station, CMND, CityLeave, cityArrival, GiaVe))
                {
                    MessageBox.Show("Lưu thông tin khách hàng thành công");

                }
                else
                {
                    MessageBox.Show("Lưu thông tin khách hàng thất bại");

                }
            }
        }

        private void btnXemKhachHang_Click(object sender, EventArgs e)
        {
            loadCustomer();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            string Name = txtHoTenQLKH.Text;
            string TheAddress = txtDiaChiQLKH.Text;
            string PhoneNumber = txtSDTQLKH.Text;
            string Email = txtEmailQLKH.Text;
            dateTimePickerLeave.CustomFormat = "dd-MM-yyyy";
            string TimeLeave = dateTimePickerQLKH.Value.ToString();
            string station = comboBoxBenXeDiQLKH.Text;
            string CMND = txtCMNDQLKH.Text;
            string CityLeave = comboBoxDiemDiQLKH.Text;
            string cityArrival = comboBoxDiemDenQLKH.Text;
            string GiaVe = comboBoxGiaVeQLKH.Text;

            if (Name == "")
            {
                MessageBox.Show("Vui lòng điền họ tên");
            }
            else if (TheAddress == "")
            {
                MessageBox.Show("Vui lòng điền địa chỉ");
            }
            else if (PhoneNumber == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại");
            }
            else if (PhoneNumber.Length > 10)
            {
                MessageBox.Show("Số điện thoại chỉ gồm 10 số");
            }
            else if (Email == "")
            {
                MessageBox.Show("Vui lòng điền địa chỉ mail");
            }
            else if (station == "")
            {
                MessageBox.Show("Vui lòng điền bến xe đi");
            }
            else if (CMND == "")
            {
                MessageBox.Show("Vui lòng điền chứng minh nhân dân");
            }
            else if (CityLeave == "")
            {
                MessageBox.Show("Vui lòng điền điểm đi");
            }
            else if (CityLeave == "")
            {
                MessageBox.Show("Vui lòng điền điểm đến");
            }
            else if (GiaVe == "")
            {
                MessageBox.Show("Vui lòng điền giá vé");
            }
            else
            {
                addCustomer(Name, TheAddress, PhoneNumber, Email, TimeLeave, station, CMND, CityLeave, cityArrival, GiaVe);
            }
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            string name = txtHoTenQLKH.Text;
            deleteCustomer(name);
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            string Name = txtHoTenQLKH.Text;
            string TheAddress = txtDiaChiQLKH.Text;
            string PhoneNumber = txtSDTQLKH.Text;
            string Email = txtEmailQLKH.Text;
            dateTimePickerLeave.CustomFormat = "dd-MM-yyyy";
            string TimeLeave = dateTimePickerQLKH.Value.ToString();
            string station = comboBoxBenXeDiQLKH.Text;
            string CMND = txtCMNDQLKH.Text;
            string CityLeave = comboBoxDiemDiQLKH.Text;
            string cityArrival = comboBoxDiemDenQLKH.Text;
            string GiaVe = comboBoxGiaVeQLKH.Text;
            string TrangThai = txtTrangThaiQLKH.Text;
            editCustomer(Name, TheAddress, PhoneNumber, Email, TimeLeave, station, CMND, CityLeave, cityArrival, GiaVe, TrangThai);
        }

        private void comboBoxDiemDiQLKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //------------------------
            if ((comboBoxDiemDiQLKH.Text == "TP. HCM" && comboBoxDiemDenQLKH.Text == "TP. Đà Lạt")
                || (comboBoxDiemDiQLKH.Text == "TP. Đà Lạt" && comboBoxDiemDenQLKH.Text == "TP. HCM"))
            {
                comboBoxGiaVeQLKH.Text = "250000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. HCM" && comboBoxDiemDenQLKH.Text == "TP. Nha Trang")
                || (comboBoxDiemDiQLKH.Text == "TP. Nha Trang" && comboBoxDiemDenQLKH.Text == "TP. HCM"))
            {
                comboBoxGiaVeQLKH.Text = "225000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. HCM" && comboBoxDiemDenQLKH.Text == "TP. Đà nẵng")
                || (comboBoxDiemDiQLKH.Text == "TP. Đà Nẵng" && comboBoxDiemDenQLKH.Text == "TP. HCM"))
            {
                comboBoxGiaVeQLKH.Text = "375000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. HCM" && comboBoxDiemDenQLKH.Text == "TP. Huế")
                || (comboBoxDiemDiQLKH.Text == "TP. Huế" && comboBoxDiemDenQLKH.Text == "TP. HCM"))
            {
                comboBoxGiaVeQLKH.Text = "380000";
            }

            else if ((comboBoxDiemDiQLKH.Text == "TP. Đà Lạt" && comboBoxDiemDenQLKH.Text == "TP. Nha Trang")
                || (comboBoxDiemDiQLKH.Text == "TP. Nha Trang" && comboBoxDiemDenQLKH.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVeQLKH.Text = "135000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Đà Lạt" && comboBoxDiemDenQLKH.Text == "TP. Đà nẵng")
                || (comboBoxDiemDiQLKH.Text == "TP. Đà nẵng" && comboBoxDiemDenQLKH.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVeQLKH.Text = "285000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Đà Lạt" && comboBoxDiemDenQLKH.Text == "TP. Huế")
                || (comboBoxDiemDiQLKH.Text == "TP. Huế" && comboBoxDiemDenQLKH.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVeQLKH.Text = "345000";
            }

            //------------------------
            else if ((comboBoxDiemDiQLKH.Text == "TP. Nha Trang" && comboBoxDiemDenQLKH.Text == "TP. Đà nẵng")
                || (comboBoxDiemDiQLKH.Text == "TP. Đà nẵng" && comboBoxDiemDenQLKH.Text == "TP. Nha Trang"))
            {
                comboBoxGiaVeQLKH.Text = "240000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Nha Trang" && comboBoxDiemDenQLKH.Text == "TP. Huế")
                || (comboBoxDiemDiQLKH.Text == "TP. Huế" && comboBoxDiemDenQLKH.Text == "TP. Nha Trang"))
            {
                comboBoxGiaVeQLKH.Text = "250000";
            }

            //------------------------
            else if ((comboBoxDiemDiQLKH.Text == "TP. Đà nẵng" && comboBoxDiemDenQLKH.Text == "TP. Huế")
                || (comboBoxDiemDiQLKH.Text == "TP. Huế" && comboBoxDiemDenQLKH.Text == "TP. Đà nẵng"))
            {
                comboBoxGiaVeQLKH.Text = "80000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. HCM" && comboBoxDiemDenQLKH.Text == "TP. HCM")
                 || (comboBoxDiemDiQLKH.Text == "TP. HCM" && comboBoxDiemDenQLKH.Text == "TP. HCM"))
            {
                comboBoxGiaVeQLKH.Text = "";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Đà Lạt" && comboBoxDiemDenQLKH.Text == "TP. Đà Lạt")
                 || (comboBoxDiemDiQLKH.Text == "TP. Đà Lạt" && comboBoxDiemDenQLKH.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVeQLKH.Text = "";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Nha Trang" && comboBoxDiemDenQLKH.Text == "TP. Nha Trang")
                 || (comboBoxDiemDiQLKH.Text == "TP. Nha Trang" && comboBoxDiemDenQLKH.Text == "TP. Nha Trang"))
            {
                comboBoxGiaVeQLKH.Text = "";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Đà Nẵng" && comboBoxDiemDenQLKH.Text == "TP. Đà Nẵng")
                 || (comboBoxDiemDiQLKH.Text == "TP. Đà Nẵng" && comboBoxDiemDenQLKH.Text == "TP. Đà Nẵng"))
            {
                comboBoxGiaVeQLKH.Text = "";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Huế" && comboBoxDiemDenQLKH.Text == "TP. Huế")
                 || (comboBoxDiemDiQLKH.Text == "TP. Huế" && comboBoxDiemDenQLKH.Text == "TP. Huế"))
            {
                comboBoxGiaVeQLKH.Text = "";
            }
        }

        private void comboBoxDiemDenQLKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //------------------------
            
            if ((comboBoxDiemDiQLKH.Text == "TP. HCM" && comboBoxDiemDenQLKH.Text == "TP. Đà Lạt")
                || (comboBoxDiemDiQLKH.Text == "TP. Đà Lạt" && comboBoxDiemDenQLKH.Text == "TP. HCM"))
            {
                comboBoxGiaVeQLKH.Text = "250000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. HCM" && comboBoxDiemDenQLKH.Text == "TP. Nha Trang")
                || (comboBoxDiemDiQLKH.Text == "TP. Nha Trang" && comboBoxDiemDenQLKH.Text == "TP. HCM"))
            {
                comboBoxGiaVeQLKH.Text = "225000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. HCM" && comboBoxDiemDenQLKH.Text == "TP. Đà nẵng")
                || (comboBoxDiemDiQLKH.Text == "TP. Đà Nẵng" && comboBoxDiemDenQLKH.Text == "TP. HCM"))
            {
                comboBoxGiaVeQLKH.Text = "375000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. HCM" && comboBoxDiemDenQLKH.Text == "TP. Huế")
                || (comboBoxDiemDiQLKH.Text == "TP. Huế" && comboBoxDiemDenQLKH.Text == "TP. HCM"))
            {
                comboBoxGiaVeQLKH.Text = "380000";
            }

            else if ((comboBoxDiemDiQLKH.Text == "TP. Đà Lạt" && comboBoxDiemDenQLKH.Text == "TP. Nha Trang")
                || (comboBoxDiemDiQLKH.Text == "TP. Nha Trang" && comboBoxDiemDenQLKH.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVeQLKH.Text = "135000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Đà Lạt" && comboBoxDiemDenQLKH.Text == "TP. Đà nẵng")
                || (comboBoxDiemDiQLKH.Text == "TP. Đà nẵng" && comboBoxDiemDenQLKH.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVeQLKH.Text = "285000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Đà Lạt" && comboBoxDiemDenQLKH.Text == "TP. Huế")
                || (comboBoxDiemDiQLKH.Text == "TP. Huế" && comboBoxDiemDenQLKH.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVeQLKH.Text = "345000";
            }

            //------------------------
            else if ((comboBoxDiemDiQLKH.Text == "TP. Nha Trang" && comboBoxDiemDenQLKH.Text == "TP. Đà nẵng")
                || (comboBoxDiemDiQLKH.Text == "TP. Đà nẵng" && comboBoxDiemDenQLKH.Text == "TP. Nha Trang"))
            {
                comboBoxGiaVeQLKH.Text = "240000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Nha Trang" && comboBoxDiemDenQLKH.Text == "TP. Huế")
                || (comboBoxDiemDiQLKH.Text == "TP. Huế" && comboBoxDiemDenQLKH.Text == "TP. Nha Trang"))
            {
                comboBoxGiaVeQLKH.Text = "250000";
            }

            //------------------------
            else if ((comboBoxDiemDiQLKH.Text == "TP. Đà nẵng" && comboBoxDiemDenQLKH.Text == "TP. Huế")
                || (comboBoxDiemDiQLKH.Text == "TP. Huế" && comboBoxDiemDenQLKH.Text == "TP. Đà nẵng"))
            {
                comboBoxGiaVeQLKH.Text = "80000";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. HCM" && comboBoxDiemDenQLKH.Text == "TP. HCM")
                 || (comboBoxDiemDiQLKH.Text == "TP. HCM" && comboBoxDiemDenQLKH.Text == "TP. HCM"))
            {
                comboBoxGiaVeQLKH.Text = "";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Đà Lạt" && comboBoxDiemDenQLKH.Text == "TP. Đà Lạt")
                 || (comboBoxDiemDiQLKH.Text == "TP. Đà Lạt" && comboBoxDiemDenQLKH.Text == "TP. Đà Lạt"))
            {
                comboBoxGiaVeQLKH.Text = "";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Nha Trang" && comboBoxDiemDenQLKH.Text == "TP. Nha Trang")
                 || (comboBoxDiemDiQLKH.Text == "TP. Nha Trang" && comboBoxDiemDenQLKH.Text == "TP. Nha Trang"))
            {
                comboBoxGiaVeQLKH.Text = "";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Đà Nẵng" && comboBoxDiemDenQLKH.Text == "TP. Đà Nẵng")
                 || (comboBoxDiemDiQLKH.Text == "TP. Đà Nẵng" && comboBoxDiemDenQLKH.Text == "TP. Đà Nẵng"))
            {
                comboBoxGiaVeQLKH.Text = "";
            }
            else if ((comboBoxDiemDiQLKH.Text == "TP. Huế" && comboBoxDiemDenQLKH.Text == "TP. Huế")
                 || (comboBoxDiemDiQLKH.Text == "TP. Huế" && comboBoxDiemDenQLKH.Text == "TP. Huế"))
            {
                comboBoxGiaVeQLKH.Text = "";
            }
        }

        #endregion

        private void btnClearQLKH_Click(object sender, EventArgs e)
        {
            clearQLKH();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            //this.Hide();
            doiMatKhau.ShowDialog();
            //this.Show();
        }
    }
}
