using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class ManagerPage : Form
    {
        
        public ManagerPage()
        {
            InitializeComponent();
           
        }

        
        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanlynhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien QLNhanVien = new QuanLyNhanVien();
            this.Hide();
            QLNhanVien.ShowDialog();
            this.Show();
        }
    }
}
