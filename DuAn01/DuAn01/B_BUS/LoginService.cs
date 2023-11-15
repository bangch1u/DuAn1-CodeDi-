using DuAn01.A_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn01.B_BUS
{
    public class LoginService
    {
        TaiKhoanRepos _repos;
        public LoginService()
        {
            _repos = new TaiKhoanRepos();
        }
        public int DangNhap(string user, string pass) 
        { 
            return _repos.Login(user, pass);    
        }
    }
}
