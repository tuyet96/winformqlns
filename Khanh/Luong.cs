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
    public partial class Luong : Form
    {
        private string ma;
        private DAL_KetNoiDB conn;
        public Luong()
        {
            conn = new DAL_KetNoiDB();
            InitializeComponent();
        }
        SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-I269IGU\SQLEXPRESS;Initial Catalog=N3;Integrated Security=True");

        private void ketnoi()
        {

            kn.Open();

            string sql = "SELECT *FROM luong";
            SqlCommand com = new SqlCommand(sql, kn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kn.Close();
            dataGridView1.DataSource = dt;
        }

        private void getDataFromDgv()
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa ch?n b?n ghi");
                return;
            }
            DataGridViewRow drv = dataGridView1.SelectedRows[0];
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Luong_Load(object sender, EventArgs e)
        {
            ketnoi();
            LoadData();

        }
        private void LoadData()
        {
           
            txtMaluong.DataBindings.Clear();
            txtMaluong.DataBindings.Add("text", dataGridView1.DataSource, "ma");
            txtLuong.DataBindings.Clear();
            txtLuong.DataBindings.Add("text", dataGridView1.DataSource, "luongcoban");
            txtLuongthuong.DataBindings.Clear();
            txtLuongthuong.DataBindings.Add("text", dataGridView1.DataSource, "luongthuong");
            

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

        private void txtMaluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            string ma = txtMaluong.Text;
            string luongcoban = txtLuong.Text;
            string luongthuong = txtLuongthuong.Text;


            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;
            param = new SqlParameter("@ma", SqlDbType.BigInt);
            param.Value = ma;
            listParams.Add(param);

            param = new SqlParameter("@luongcoban", SqlDbType.BigInt);
            param.Value = luongcoban;
            listParams.Add(param);

            param = new SqlParameter("@luongthuong", SqlDbType.BigInt);
            param.Value = luongthuong;
            listParams.Add(param);

          
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = conn.doStoredProceduce("Add_Luong", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi khi thêm", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    Luong_Load(sender, e);
                }
            }



        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma = txtMaluong.Text;
            string luongcoban = txtLuong.Text;
            string luongthuong = txtLuongthuong.Text;


            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;
            param = new SqlParameter("@ma", SqlDbType.BigInt);
            param.Value = ma;
            listParams.Add(param);

            param = new SqlParameter("@luongcoban", SqlDbType.BigInt);
            param.Value = luongcoban;
            listParams.Add(param);

            param = new SqlParameter("@luongthuong", SqlDbType.BigInt);
            param.Value = luongthuong;
            listParams.Add(param);


            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa", "Thông Báo",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = conn.doStoredProceduce("Edid_Luong", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi khi sửa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    Luong_Load(sender, e);
                }
            }


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            getDataFromDgv();
            string sqlxoa = "Delete from luong where ma='" + ma + "'";
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
                    Luong_Load(sender, e);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
