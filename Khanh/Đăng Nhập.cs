using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khanh
{
    public partial class Form3 : Form
    {
        public static bool isThanhcong = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        public bool checkObject()
        {
            if (string.IsNullOrWhiteSpace(txtTendangnhap.Text))
            {
                MessageBox.Show("bạn chưa nhâp ten người dùng", "Cảnh báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendangnhap.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtMatkhau.Text))
            {
                MessageBox.Show("bạn chưa nhập mật khẩu ", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatkhau.Focus();
                return false;

            }
            return true;

           
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (checkObject())
            {
                if(txtTendangnhap.Text.Equals("admin")&&txtMatkhau.Text.Equals("admin"))
                {
                    FormChung chung = new FormChung();
                    this.Hide();
                    chung.Show();
                    

                }
                else
                {
                    MessageBox.Show("lỗi đăng nhập");
                }
                   
               
            }

           // if (txtTendangnhap.Text == "admin" && txtMatkhau.Text == "admin")
           // {
           //     isThanhcong = true;
           //     this.Close();
           // }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
