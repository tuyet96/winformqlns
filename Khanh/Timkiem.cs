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
    public partial class Form2 : Form
    {
        private DAL_KetNoiDB conn;
        public Form2()
        {
            conn = new DAL_KetNoiDB();
            InitializeComponent();
        }
        SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-I269IGU\SQLEXPRESS;Initial Catalog=N3;Integrated Security=True");

        private void ketnoi()
        {

            kn.Open();

            string sql = "SELECT *FROM nhanvien";
            SqlCommand com = new SqlCommand(sql, kn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kn.Close();

            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           ketnoi();
        }
        int i = 0;
        private void radTheophong_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if((txtTimkiem.Text=="")||(txtTimkiem.Text=="Nhập ào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhap từ khóa ","Nhập từ Khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        conn.loaddatagridview(dataGridView1, "select * from nhanvien where phongbanma='" + txtTimkiem.Text + "'");

                    }
                    if (i==2)
                    {
                        conn.loaddatagridview(dataGridView1, "select * from nhanvien where ma='"+txtTimkiem.Text+"'");

                    }
                   
                }
            }
            catch
            {
                MessageBox.Show("tìm kiếm sai");
            }
          
        }

        private void radTheoma_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }
    }
}
