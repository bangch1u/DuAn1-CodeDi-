using DuAn01.B_BUS;
using DuAn01.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn01.C_PRL
{
    public partial class fLogin : Form
    {
        LoginService _service = new LoginService();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var result = _service.DangNhap(txt_UserName.Text, txt_PassWord.Text);
            var obj = new TaiKhoan();
            if (result == 0)
            {
                MessageBox.Show("Login Failed!");

            }
            else if (result == 1)
            {
                MessageBox.Show("Tài khoản admin!");
            

            }
            else if (result == 2)
            {
                MessageBox.Show("Tài khoản nhân viên");
            }
        }
    }
}
