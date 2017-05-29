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
    public partial class Hopdong : Form
    {
        SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-I269IGU\SQLEXPRESS;Initial Catalog=N3;Integrated Security=True");
        private readonly string ma;
       

        public Hopdong()
        {
            
            InitializeComponent();
        }
        private void ketnoi()
        {

            kn.Open();
            string sql = @"Select a.ma,b.ten,a.ngaybatdau,a.ngayketthuc from hopdonglaodong a,nhanvien b where a.nhanvienma=b.ma ";
          //  string sql = "SELECT ma as N'Mã HĐ', nhanvienma as N'Tên nhân viên', ngaybatdau as N'Ngày bắt đầu', ngayketthuc as N'Ngày kết thúc' FROM hopdonglaodong";
            SqlCommand com = new SqlCommand(sql, kn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            da.Fill(dt);
            kn.Close();

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;

            }
            catch
            {

            }
        }
       

        private void Hopdong_Load(object sender, EventArgs e)
        {
            ketnoi();
            LoadData();
        }
        private void LoadData()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("text", dataGridView1.DataSource, "ma");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("text", dataGridView1.DataSource, "ten");
            dateTimePickerBD.DataBindings.Clear();
            dateTimePickerBD.DataBindings.Add("text", dataGridView1.DataSource, "Ngaybatdau");
            dateTimePickerKT.DataBindings.Clear();
            dateTimePickerKT.DataBindings.Add("text", dataGridView1.DataSource, "ngayketthuc");
            dataGridView1.Columns[0].HeaderText = "Mã HĐ";
            dataGridView1.Columns[0].HeaderText = "Tên nhân viên";
            dataGridView1.Columns[0].HeaderText = "Ngày bắt đầu ";
            dataGridView1.Columns[0].HeaderText = "Ngày kết thúc";




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

       
        
    }
}
