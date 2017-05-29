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
    public partial class XemChucVu : Form
    {
        SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-I269IGU\SQLEXPRESS;Initial Catalog=N3;Integrated Security=True");
        private readonly string ma;
        public XemChucVu()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {

            kn.Open();
            string sql = @"Select a.ma,b.ten,a.tenchucvu from chucvu a,nhanvien b where a.ma=b.chucvuma";
            //  string sql = "SELECT ma as N'Mã HĐ', nhanvienma as N'Tên nhân viên', ngaybatdau as N'Ngày bắt đầu', ngayketthuc as N'Ngày kết thúc' FROM hopdonglaodong";
            SqlCommand com = new SqlCommand(sql, kn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            da.Fill(dt);
            kn.Close();

            dgvXem.DataSource = dt;
        }
        private void XemChucVu_Load(object sender, EventArgs e)
        {
            ketnoi();
            LoadData();
        }
        private void LoadData()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("text", dgvXem.DataSource, "ma");
            txtTennv.DataBindings.Clear();
            txtTennv.DataBindings.Add("text", dgvXem.DataSource, "ten");
            txtTencv.DataBindings.Clear();
            txtTencv.DataBindings.Add("text", dgvXem.DataSource, "tenchucvu");
           
         
        }

        private void dgvXem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
