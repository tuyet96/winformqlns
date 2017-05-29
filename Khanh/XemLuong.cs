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
    public partial class XemLuong : Form
    {
        SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-I269IGU\SQLEXPRESS;Initial Catalog=N3;Integrated Security=True");
        private readonly string ma;
        public XemLuong()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {

            kn.Open();
            string sql = @"Select a.ma,b.ten,a.luongcoban,a.luongthuong from luong a,nhanvien b where a.ma=b.bacluongma ";
            //  string sql = "SELECT ma as N'Mã HĐ', nhanvienma as N'Tên nhân viên', ngaybatdau as N'Ngày bắt đầu', ngayketthuc as N'Ngày kết thúc' FROM hopdonglaodong";
            SqlCommand com = new SqlCommand(sql, kn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            da.Fill(dt);
            kn.Close();

            dgvXem.DataSource = dt;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void XemLuong_Load(object sender, EventArgs e)
        {
            ketnoi();
            LoadData();
        }


        private void dgvXem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                dgvXem.CurrentRow.Selected = true;

            }
            catch
            {

            }
        }
        private void LoadData()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("text", dgvXem.DataSource, "ma");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("text", dgvXem.DataSource, "ten");
            txtLuongcoban.DataBindings.Clear();
            txtLuongcoban.DataBindings.Add("text", dgvXem.DataSource, "luongcoban");
            txtLuongThuong.DataBindings.Clear();
            txtLuongThuong.DataBindings.Add("text", dgvXem.DataSource, "luongthuong");
            
            
        }
    }
}
