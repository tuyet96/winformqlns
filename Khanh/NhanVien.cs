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
    public partial class NhanVien : Form
    {
        string strConnect= @"Data Source=DESKTOP-I269IGU\SQLEXPRESS;Initial Catalog=N3;Integrated Security=True";
        public NhanVien()
        {
            InitializeComponent();
            this.Load += NV_Load;
        }
        private void NV_Load(object sender, EventArgs e)
        {
            LoadNV();
            loadCBBphongban();
            loadCBBbacluong();
            loadCBBtrinhdo();
            loadCBBchucvu();
            
        }
        private void loadCBBchucvu()
        {
            DataTable dtcv;
            dtcv = SqlHelper.ExecuteDataset(strConnect, "LOAD_CV").Tables[0];
            cbbChucvu.DataSource = dtcv;
            cbbChucvu.DisplayMember = "tenchucvu";
            cbbChucvu.ValueMember = "tenchucvu";
        }
        private void loadCBBphongban()
        {
            DataTable dtpb;
            dtpb = SqlHelper.ExecuteDataset(strConnect, "LOAD_MA_PB").Tables[0];
            cbbPhongban.DataSource = dtpb;
            cbbPhongban.DisplayMember = "tenphongban";
            cbbPhongban.ValueMember = "tenphongban";
        }
        private void loadCBBbacluong()
        {
            DataTable dtl;
            dtl = SqlHelper.ExecuteDataset(strConnect, "LOAD_Luong").Tables[0];
            cbbLuong.DataSource = dtl;
            cbbLuong.DisplayMember = "luongcoban";
            cbbLuong.ValueMember = "luongcoban";
        }
        private void loadCBBtrinhdo()
        {
            DataTable dttd;
            dttd = SqlHelper.ExecuteDataset(strConnect, "LOAD_TRINHDO").Tables[0];
            cbbTrinhdo.DataSource = dttd;
            cbbTrinhdo.DisplayMember = "tentrinhdo";
            cbbTrinhdo.ValueMember = "tentrinhdo";
        }

        private void LoadData()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("text", NVNV.DataSource, "ma");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("text", NVNV.DataSource, "ten");
            txtDantoc.DataBindings.Clear();
            txtDantoc.DataBindings.Add("text", NVNV.DataSource, "dantoc");
            cbbChucvu.DataBindings.Clear();
            cbbChucvu.DataBindings.Add("text", NVNV.DataSource, "chucvuma");
            txtDienthoai.DataBindings.Clear();
            txtDienthoai.DataBindings.Add("text", NVNV.DataSource, "dienthoai");
            cbbLuong.DataBindings.Clear();
            cbbLuong.DataBindings.Add("text", NVNV.DataSource, "bacluongma");
           cbbPhongban.DataBindings.Clear();
            cbbPhongban.DataBindings.Add("text", NVNV.DataSource, "phongbanma");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("text", NVNV.DataSource, "email");
            txtQuequan.DataBindings.Clear();
            txtQuequan.DataBindings.Add("text", NVNV.DataSource, "quequan");
            cbbTrinhdo.DataBindings.Clear();
            cbbTrinhdo.DataBindings.Add("text", NVNV.DataSource, "trinhdoma");
            dateTimePNgaysinh.DataBindings.Clear();
            dateTimePNgaysinh.DataBindings.Add("text", NVNV.DataSource, "ngaysinh");


        }
        private void LoadNV()
        {
            NVNV.DataSource = SqlHelper.ExecuteDataset(strConnect, "UP_LOAD_NV").Tables[0];
        }

        private void NVNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void tsbTHem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                string ten = txtTen.Text.Trim();
                string phongbanma = cbbPhongban.Text.Trim();
                string trinhdoma = cbbTrinhdo.Text.Trim();
                string bacluongma = cbbLuong.Text.Trim();
                string quequan = txtQuequan.Text.Trim();
                string dantoc = txtDantoc.Text.Trim();
                string dienthoai = txtDienthoai.Text.Trim();
                string email = txtEmail.Text.Trim();
                string chucvuma = cbbChucvu.Text.Trim();
                string ngaysinh = dateTimePNgaysinh.Text.Trim();

                SqlHelper.ExecuteNonQuery(strConnect, "Add_Nhanvien", ma, ten, ngaysinh, quequan, dienthoai,
                    email, dantoc, phongbanma, chucvuma, bacluongma, trinhdoma);
                LoadNV();
            }
            catch (Exception)
            {

                MessageBox.Show("Thêm Lỗi");
            }
        }
    }
}
