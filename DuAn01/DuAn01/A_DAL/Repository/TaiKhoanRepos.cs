using DuAn01.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn01.A_DAL.Repository
{
    public class TaiKhoanRepos
    {
        DBContext _context;
        public TaiKhoanRepos()
        {
            _context = new DBContext();
        }
        public int Login(string username, string pass)
        {
            var account = _context.TaiKhoans.FirstOrDefault(tk => tk.UserName == username && tk.PassWord == pass);
            if (account != null)
            {
                return (int)account.Role;
            }
            return 0;
        }
    }
}
