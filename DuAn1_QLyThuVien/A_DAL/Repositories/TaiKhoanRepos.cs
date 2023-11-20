using A_DAL.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class TaiKhoanRepos
    {
        ThuVienContext _context;
        public TaiKhoanRepos()
        {
            _context = new ThuVienContext();
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
