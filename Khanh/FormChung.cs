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
    public partial class FormChung : Form
    {
        public FormChung()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nhanvien = new Form1();
            this.Hide();
            nhanvien.Show();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 timkiem = new Form2();
            this.Hide();
            timkiem.Show();

        }

        private void chínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tro_Giup trogiup = new Tro_Giup();
            this.Hide();
            trogiup.Show();
        }

        private void dSLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong();
            this.Hide();
            luong.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Chucvu cv = new Chucvu();
            this.Hide();
            cv.Show();

        }

        private void hơpĐồngLĐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hopdong hd = new Hopdong();
           // this.Hide();
            hd.Show();
        }
    }
}
