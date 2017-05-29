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
    public partial class PhongBancs : Form
    {
        private string ma;
        private DAL_KetNoiDB conn;
        public PhongBancs()
        {
            conn = new DAL_KetNoiDB();
            InitializeComponent();
        }
        SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-I269IGU\SQLEXPRESS;Initial Catalog=N3;Integrated Security=True");
        //  Data Source = DESKTOP - I269IGU\SQLEXPRESS;Initial Catalog = N3; Integrated Security = True
        private void ketnoi()
        {

            kn.Open();

            string sql = "SELECT *FROM phongban";
            SqlCommand com = new SqlCommand(sql, kn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kn.Close();

           dgvxem.DataSource = dt;
        }
        private void getDataFromDgv()
        {
            if (dgvxem.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa ch?n b?n ghi");
                return;
            }
            DataGridViewRow drv =dgvxem.SelectedRows[0];
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
        private void btnxoa_Click(object sender, EventArgs e)
        {
            getDataFromDgv();
            string sqlxoa = "Delete from phongban where ma='" + ma + "'";
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
                    PhongBancs_Load(sender, e);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void PhongBancs_Load(object sender, EventArgs e)
        {
            ketnoi();
            LoadData();
        }
        private void LoadData()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("text",dgvxem.DataSource, "ma");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("text",dgvxem.DataSource, "tenphongban");
            txtDiachi.DataBindings.Clear();
           txtDiachi.DataBindings.Add("text",dgvxem.DataSource, "diachi");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("text",dgvxem.DataSource, "sodienthoai");
            txtGhichu.DataBindings.Clear();
            txtGhichu.DataBindings.Add("text",dgvxem.DataSource, "ghichu");
           


        }

        private void dgvxem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvxem.CurrentRow.Selected = true;

            }
            catch
            {

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string diachi = txtDiachi.Text;
            string sodienthoai = txtSdt.Text;
            string ghichu = txtGhichu.Text;
           


            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;
            param = new SqlParameter("@ma", SqlDbType.NVarChar);
            param.Value = ma;
            listParams.Add(param);

            param = new SqlParameter("@tenphongban", SqlDbType.NVarChar);
            param.Value = ten;
            listParams.Add(param);

            param = new SqlParameter("@diachi", SqlDbType.NVarChar);
            param.Value = diachi;
            listParams.Add(param);

            param = new SqlParameter("@sodienthoai", SqlDbType.VarChar);
            param.Value = sodienthoai;
            listParams.Add(param);

            param = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            param.Value = ghichu;
            listParams.Add(param);

           
          


            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = conn.doStoredProceduce("Add_Phongban", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi khi thêm", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    PhongBancs_Load(sender, e);
                }
            }



        }

        private void grbchucnang_Enter(object sender, EventArgs e)
        {

        }
    }
}
