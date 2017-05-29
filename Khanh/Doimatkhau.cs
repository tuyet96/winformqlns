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
    public partial class Doimatkhau : Form
    {
        public Doimatkhau()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-I269IGU\SQLEXPRESS;Initial Catalog=N3;Integrated Security=True");
            string sql = "update nguoidung set matkhau='" + txtMkmoi.Text + "' where(tennguoidung=N'" + txtTen.Text + "' and matkhau='" + txtMkcu.Text + "')";
          
            string ten = txtTen.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (txtMkcu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (txtMkmoi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (txtNhaplai.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if (txtMkmoi.Text == txtNhaplai.Text)
                            {
                                kn.Open();
                                SqlCommand cmd = new SqlCommand(sql, kn);
                                cmd.CommandType = CommandType.Text;
                               // SqlDataAdapter da = new SqlDataAdapter(cmd);
                                cmd.ExecuteNonQuery();
                                //    cls.thucthiketnoi(update);
                                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                this.Close();
                                kn.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
