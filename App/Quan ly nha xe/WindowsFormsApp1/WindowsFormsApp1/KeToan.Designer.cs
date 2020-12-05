namespace WindowsFormsApp1
{
    partial class KeToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcQuanLyTienLuong = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblTableSalary = new System.Windows.Forms.Label();
            this.dtgvTableSalary = new System.Windows.Forms.DataGridView();
            this.lblListAccount = new System.Windows.Forms.Label();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTrangThaiTienLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtIDNhanvien = new System.Windows.Forms.TextBox();
            this.lblIDNhanVien = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnReadStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvThongKeVeDaBan = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnThongKeVeDaBan = new System.Windows.Forms.Button();
            this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.tcQuanLyTienLuong.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTableSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKeVeDaBan)).BeginInit();
            this.panel10.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuanLyTienLuong
            // 
            this.tcQuanLyTienLuong.Controls.Add(this.tabPage1);
            this.tcQuanLyTienLuong.Controls.Add(this.tabPage2);
            this.tcQuanLyTienLuong.Controls.Add(this.tabPage3);
            this.tcQuanLyTienLuong.Location = new System.Drawing.Point(13, 13);
            this.tcQuanLyTienLuong.Name = "tcQuanLyTienLuong";
            this.tcQuanLyTienLuong.SelectedIndex = 0;
            this.tcQuanLyTienLuong.Size = new System.Drawing.Size(1074, 521);
            this.tcQuanLyTienLuong.TabIndex = 0;
            this.tcQuanLyTienLuong.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1066, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý tiền lương";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblTableSalary);
            this.panel9.Controls.Add(this.dtgvTableSalary);
            this.panel9.Controls.Add(this.lblListAccount);
            this.panel9.Controls.Add(this.dtgvStaff);
            this.panel9.Location = new System.Drawing.Point(408, -9);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(662, 512);
            this.panel9.TabIndex = 6;
            // 
            // lblTableSalary
            // 
            this.lblTableSalary.AutoSize = true;
            this.lblTableSalary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableSalary.Location = new System.Drawing.Point(0, 261);
            this.lblTableSalary.Name = "lblTableSalary";
            this.lblTableSalary.Size = new System.Drawing.Size(101, 19);
            this.lblTableSalary.TabIndex = 3;
            this.lblTableSalary.Text = "Bảng lương";
            // 
            // dtgvTableSalary
            // 
            this.dtgvTableSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTableSalary.Location = new System.Drawing.Point(0, 283);
            this.dtgvTableSalary.Name = "dtgvTableSalary";
            this.dtgvTableSalary.Size = new System.Drawing.Size(651, 217);
            this.dtgvTableSalary.TabIndex = 2;
            // 
            // lblListAccount
            // 
            this.lblListAccount.AutoSize = true;
            this.lblListAccount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListAccount.Location = new System.Drawing.Point(0, 9);
            this.lblListAccount.Name = "lblListAccount";
            this.lblListAccount.Size = new System.Drawing.Size(170, 19);
            this.lblListAccount.TabIndex = 1;
            this.lblListAccount.Text = "Danh sách nhân viên";
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(0, 31);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.Size = new System.Drawing.Size(651, 217);
            this.dtgvStaff.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnReadStaff);
            this.panel1.Controls.Add(this.btnDeleteStaff);
            this.panel1.Controls.Add(this.btnAddStaff);
            this.panel1.Controls.Add(this.btnEditStaff);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 486);
            this.panel1.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtTrangThaiTienLuong);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(12, 315);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(383, 44);
            this.panel7.TabIndex = 7;
            // 
            // txtTrangThaiTienLuong
            // 
            this.txtTrangThaiTienLuong.Location = new System.Drawing.Point(157, 13);
            this.txtTrangThaiTienLuong.Name = "txtTrangThaiTienLuong";
            this.txtTrangThaiTienLuong.Size = new System.Drawing.Size(218, 20);
            this.txtTrangThaiTienLuong.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng thái:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(112, 430);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(275, 46);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtIDNhanvien);
            this.panel6.Controls.Add(this.lblIDNhanVien);
            this.panel6.Location = new System.Drawing.Point(12, 265);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(383, 44);
            this.panel6.TabIndex = 6;
            // 
            // txtIDNhanvien
            // 
            this.txtIDNhanvien.Location = new System.Drawing.Point(157, 13);
            this.txtIDNhanvien.Name = "txtIDNhanvien";
            this.txtIDNhanvien.Size = new System.Drawing.Size(218, 20);
            this.txtIDNhanvien.TabIndex = 6;
            // 
            // lblIDNhanVien
            // 
            this.lblIDNhanVien.AutoSize = true;
            this.lblIDNhanVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNhanVien.Location = new System.Drawing.Point(14, 12);
            this.lblIDNhanVien.Name = "lblIDNhanVien";
            this.lblIDNhanVien.Size = new System.Drawing.Size(106, 19);
            this.lblIDNhanVien.TabIndex = 0;
            this.lblIDNhanVien.Text = "IDNhanVien:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSalary);
            this.panel5.Controls.Add(this.lblSalary);
            this.panel5.Location = new System.Drawing.Point(12, 215);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(383, 44);
            this.panel5.TabIndex = 5;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(157, 12);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(218, 20);
            this.txtSalary.TabIndex = 5;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(14, 12);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(68, 19);
            this.lblSalary.TabIndex = 0;
            this.lblSalary.Text = "Lương:";
            // 
            // btnReadStaff
            // 
            this.btnReadStaff.Location = new System.Drawing.Point(312, 393);
            this.btnReadStaff.Name = "btnReadStaff";
            this.btnReadStaff.Size = new System.Drawing.Size(75, 23);
            this.btnReadStaff.TabIndex = 11;
            this.btnReadStaff.Text = "Xem";
            this.btnReadStaff.UseVisualStyleBackColor = true;
            this.btnReadStaff.Click += new System.EventHandler(this.btnReadStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(112, 393);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStaff.TabIndex = 9;
            this.btnDeleteStaff.Text = "Xóa";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(12, 393);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaff.TabIndex = 8;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Location = new System.Drawing.Point(213, 393);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(75, 23);
            this.btnEditStaff.TabIndex = 10;
            this.btnEditStaff.Text = "Sửa";
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtRole);
            this.panel8.Controls.Add(this.lblRole);
            this.panel8.Location = new System.Drawing.Point(12, 165);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(383, 44);
            this.panel8.TabIndex = 4;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(157, 12);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(218, 20);
            this.txtRole.TabIndex = 4;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(14, 12);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(63, 19);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Vai trò:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPhoneNumber);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 44);
            this.panel4.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(157, 13);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(218, 20);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số điện thoại:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtLastName);
            this.panel3.Controls.Add(this.lblLastName);
            this.panel3.Location = new System.Drawing.Point(12, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 44);
            this.panel3.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(157, 12);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(218, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(14, 12);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(81, 19);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Tên đệm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.lblFirstName);
            this.panel2.Location = new System.Drawing.Point(12, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 44);
            this.panel2.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(157, 12);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(218, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(14, 12);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(44, 19);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Tên:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel11);
            this.tabPage2.Controls.Add(this.panel10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1066, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý doanh thu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Location = new System.Drawing.Point(6, 62);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1054, 427);
            this.panel11.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label4);
            this.panel13.Controls.Add(this.dtgvDoanhThu);
            this.panel13.Location = new System.Drawing.Point(4, 287);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1047, 137);
            this.panel13.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doanh thu";
            // 
            // dtgvDoanhThu
            // 
            this.dtgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoanhThu.Location = new System.Drawing.Point(308, 35);
            this.dtgvDoanhThu.Name = "dtgvDoanhThu";
            this.dtgvDoanhThu.Size = new System.Drawing.Size(411, 99);
            this.dtgvDoanhThu.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.dtgvThongKeVeDaBan);
            this.panel12.Location = new System.Drawing.Point(4, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1047, 277);
            this.panel12.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng vé đã bán";
            // 
            // dtgvThongKeVeDaBan
            // 
            this.dtgvThongKeVeDaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongKeVeDaBan.Location = new System.Drawing.Point(3, 35);
            this.dtgvThongKeVeDaBan.Name = "dtgvThongKeVeDaBan";
            this.dtgvThongKeVeDaBan.Size = new System.Drawing.Size(1041, 234);
            this.dtgvThongKeVeDaBan.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnDoanhThu);
            this.panel10.Controls.Add(this.btnThongKeVeDaBan);
            this.panel10.Controls.Add(this.dtpEndDay);
            this.panel10.Controls.Add(this.dtpStartDay);
            this.panel10.Location = new System.Drawing.Point(7, 7);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1053, 48);
            this.panel10.TabIndex = 0;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Location = new System.Drawing.Point(567, 15);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(127, 24);
            this.btnDoanhThu.TabIndex = 3;
            this.btnDoanhThu.Text = "Thống kê doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnThongKeVeDaBan
            // 
            this.btnThongKeVeDaBan.Location = new System.Drawing.Point(434, 15);
            this.btnThongKeVeDaBan.Name = "btnThongKeVeDaBan";
            this.btnThongKeVeDaBan.Size = new System.Drawing.Size(127, 24);
            this.btnThongKeVeDaBan.TabIndex = 2;
            this.btnThongKeVeDaBan.Text = "Thống kê vé đã bán";
            this.btnThongKeVeDaBan.UseVisualStyleBackColor = true;
            this.btnThongKeVeDaBan.Click += new System.EventHandler(this.btnThongKeVeDaBan_Click);
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.Location = new System.Drawing.Point(219, 15);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDay.TabIndex = 1;
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Location = new System.Drawing.Point(3, 15);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDay.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnChangePass);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1066, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Đổi mật khẩu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(448, 210);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(151, 73);
            this.btnChangePass.TabIndex = 0;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // KeToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 546);
            this.Controls.Add(this.tcQuanLyTienLuong);
            this.Name = "KeToan";
            this.Text = "Quản lý nhà xe - Kế toán";
            this.tcQuanLyTienLuong.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTableSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKeVeDaBan)).EndInit();
            this.panel10.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuanLyTienLuong;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblTableSalary;
        private System.Windows.Forms.DataGridView dtgvTableSalary;
        private System.Windows.Forms.Label lblListAccount;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIDNhanvien;
        private System.Windows.Forms.Label lblIDNhanVien;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnReadStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtTrangThaiTienLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dtgvThongKeVeDaBan;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnThongKeVeDaBan;
        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvDoanhThu;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnChangePass;
    }
}