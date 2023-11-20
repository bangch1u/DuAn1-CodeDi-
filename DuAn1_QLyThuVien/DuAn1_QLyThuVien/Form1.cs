using A_DAL.Model;
using B_BUS.Service;

namespace DuAn1_QLyThuVien
{
    public partial class Form1 : Form
    {
        loginService _service = new loginService();
        public Form1()
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