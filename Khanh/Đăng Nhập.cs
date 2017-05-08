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
    public partial class Form3 : Form
    {
        public static bool isThanhcong = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtTendangnhap.Text == "admin" && txtMatkhau.Text == "admin")
            {
                isThanhcong = true;
                this.Close();
            }
        }
    }
}
