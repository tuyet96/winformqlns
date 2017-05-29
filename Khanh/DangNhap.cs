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

namespace Khanh
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-I269IGU\SQLEXPRESS;Initial Catalog=N3;Integrated Security=True");
            try
            {
                kn.Open();
                string tk = txtTendangnhap.Text;
                string mk = txtMatkhau.Text;
                string sql= "SELECT *FROM nguoidung where tennguoidung= '" +tk+ "' and matkhau= '"+mk+"' ";
                SqlCommand cmd = new SqlCommand(sql, kn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    FormChung chung = new FormChung();
                    this.Hide();
                    chung.Show();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập thất bại");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
