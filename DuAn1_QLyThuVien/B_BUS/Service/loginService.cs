using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Service
{
    public class loginService
    {
        TaiKhoanRepos _repos;
        public loginService()
        {
            _repos = new TaiKhoanRepos();
        }
        public int DangNhap(string user, string pass)
        {
            return _repos.Login(user, pass);
        }
    }
}
