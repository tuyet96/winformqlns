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
    public partial class Form1 : Form
    {
        private string ma;
        private DAL_KetNoiDB conn;

        public Form1()
        {
            conn = new DAL_KetNoiDB();
            InitializeComponent();

        }
        SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-I269IGU\SQLEXPRESS;Initial Catalog=N3;Integrated Security=True");
      //  Data Source = DESKTOP - I269IGU\SQLEXPRESS;Initial Catalog = N3; Integrated Security = True
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

            dataGridVXem.DataSource = dt;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void getDataFromDgv()
        {
            if (dataGridVXem.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa ch?n b?n ghi");
                return;
            }
            DataGridViewRow drv = dataGridVXem.SelectedRows[0];
            DataRowView drview = (DataRowView)drv.DataBoundItem;
            if (drview == null)
            {
                MessageBox.Show("Không lấy đư?c dữ liêu");
                return;
            }
            DataRow dr = drview.Row;
            if (dr == null)
            {
                MessageBox.Show("Không lấy được dữ liêu");
                return;
            }

            ma = dr["ma"].ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi();
            LoadData();

         //   txtMa.Text = "";
         //   txtTen.Text = "";
         //   txtPhongban.Text = "";
          //  txtTrinhdo.Text = "";
          //  txtLuong.Text = "";
           // txtQuequan.Text = "";
          //  txtDantoc.Text = "";
          //  txtDienthoai.Text = "";
          //  txtEmail.Text = "";
          //  txtChucvu.Text = "";
        }

        // private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        // {

        // }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("text", dataGridVXem.DataSource, "ma");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("text", dataGridVXem.DataSource, "ten");
            txtDantoc.DataBindings.Clear();
            txtDantoc.DataBindings.Add("text", dataGridVXem.DataSource, "dantoc");
            txtChucvu.DataBindings.Clear();
            txtChucvu.DataBindings.Add("text", dataGridVXem.DataSource, "chucvuma");
            txtDienthoai.DataBindings.Clear();
            txtDienthoai.DataBindings.Add("text", dataGridVXem.DataSource, "dienthoai");
            txtLuong.DataBindings.Clear();
            txtLuong.DataBindings.Add("text", dataGridVXem.DataSource, "bacluongma");
            txtPhongban.DataBindings.Clear();
            txtPhongban.DataBindings.Add("text", dataGridVXem.DataSource, "phongbanma");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("text", dataGridVXem.DataSource, "email");
            txtQuequan.DataBindings.Clear();
            txtQuequan.DataBindings.Add("text", dataGridVXem.DataSource, "quequan");
            txtTrinhdo.DataBindings.Clear();
            txtTrinhdo.DataBindings.Add("text", dataGridVXem.DataSource, "trinhdoma");
            dateTimePNgaysinh.DataBindings.Clear();
            dateTimePNgaysinh.DataBindings.Add("text", dataGridVXem.DataSource, "ngaysinh");
           
           
        }
        private void dataGridVXem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridVXem.CurrentRow.Selected = true;

            }
            catch
            {

            }

        }


        private class SqlHelper
        {
            internal static object ExecuteDataset(SqlConnection kn, string v)
            {
                throw new NotImplementedException();
            }

            internal static void ExecuteNonQuery(SqlConnection kn, string v, string ma, string ten, DateTime ngaysinh, string gioitinh, string email, string sodienthoai, string quequan, string trinhdoma, string bacluongma1, string chucvuma, string dantoc, string bacluongma2)
            {
                throw new NotImplementedException();
            }
        }
        string them;

        private void btnthem_Click(object sender, EventArgs e)

        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string phongbanma = txtPhongban.Text;
            string trinhdoma = txtTrinhdo.Text;
            string bacluongma = txtLuong.Text;
            string quequan = txtQuequan.Text;
            string dantoc = txtDantoc.Text;
            string dienthoai = txtDienthoai.Text;
            string email = txtEmail.Text;
            string chucvuma = txtChucvu.Text;
            string ngaysinh = dateTimePNgaysinh.Text;


            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;
            param = new SqlParameter("@ma", SqlDbType.VarChar);
            param.Value = ma;
            listParams.Add(param);

            param = new SqlParameter("@ten", SqlDbType.NVarChar);
            param.Value = ten;
            listParams.Add(param);

            param = new SqlParameter("@ngaysinh", SqlDbType.Date);
            param.Value = ngaysinh;
            listParams.Add(param);

            param = new SqlParameter("@email", SqlDbType.VarChar);
            param.Value = email;
            listParams.Add(param);

            param = new SqlParameter("@dienthoai", SqlDbType.VarChar);
            param.Value = dienthoai;
            listParams.Add(param);

            param = new SqlParameter("@dantoc", SqlDbType.VarChar);
            param.Value = dantoc;
            listParams.Add(param);

            param = new SqlParameter("@phongbanma", SqlDbType.NVarChar);
            param.Value = phongbanma;
            listParams.Add(param);

            param = new SqlParameter("@trinhdoma", SqlDbType.NVarChar);
            param.Value = trinhdoma;
            listParams.Add(param);

            param = new SqlParameter("@quequan", SqlDbType.NVarChar);
            param.Value = quequan;
            listParams.Add(param);

            param = new SqlParameter("@bacluongma", SqlDbType.BigInt);
            param.Value = bacluongma;
            listParams.Add(param);

            param = new SqlParameter("@chucvuma", SqlDbType.NVarChar);
            param.Value = chucvuma;
            listParams.Add(param);




            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = conn.doStoredProceduce("Add_Nhanvien", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi khi thêm", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    Form1_Load(sender, e);
                }
            }




        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            getDataFromDgv();
            string sqlxoa = "Delete from nhanvien where ma='" + ma + "'";
            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;
            param = new SqlParameter("@ma", SqlDbType.VarChar);
            param.Value = ma;
            listParams.Add(param);

            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = conn.doSQL(sqlxoa, listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi khi xoá", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    Form1_Load(sender, e);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void grbchucnang_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        string sua;
        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string phongbanma = txtPhongban.Text;
            string trinhdoma = txtTrinhdo.Text;
            string bacluongma = txtLuong.Text;
            string quequan = txtQuequan.Text;
            string dantoc = txtDantoc.Text;
            string dienthoai = txtDienthoai.Text;
            string email = txtEmail.Text;
            string chucvuma = txtChucvu.Text;
            string ngaysinh = dateTimePNgaysinh.Text;


            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;
            param = new SqlParameter("@ma", SqlDbType.VarChar);
            param.Value = ma;
            listParams.Add(param);

            param = new SqlParameter("@ten", SqlDbType.NVarChar);
            param.Value = ten;
            listParams.Add(param);

            param = new SqlParameter("@ngaysinh", SqlDbType.Date);
            param.Value = ngaysinh;
            listParams.Add(param);

            param = new SqlParameter("@email", SqlDbType.VarChar);
            param.Value = email;
            listParams.Add(param);

            param = new SqlParameter("@dienthoai", SqlDbType.VarChar);
            param.Value = dienthoai;
            listParams.Add(param);

            param = new SqlParameter("@dantoc", SqlDbType.VarChar);
            param.Value = dantoc;
            listParams.Add(param);

            param = new SqlParameter("@phongbanma", SqlDbType.NVarChar);
            param.Value = phongbanma;
            listParams.Add(param);

            param = new SqlParameter("@trinhdoma", SqlDbType.NVarChar);
            param.Value = trinhdoma;
            listParams.Add(param);

            param = new SqlParameter("@quequan", SqlDbType.NVarChar);
            param.Value = quequan;
            listParams.Add(param);

            param = new SqlParameter("@bacluongma", SqlDbType.BigInt);
            param.Value = bacluongma;
            listParams.Add(param);

            param = new SqlParameter("@chucvuma", SqlDbType.NVarChar);
            param.Value = chucvuma;
            listParams.Add(param);




            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = conn.doStoredProceduce("Edid_NV", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi khi sửa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    Form1_Load(sender, e);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtChucvu_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class rdbNu
    {
    }
}
