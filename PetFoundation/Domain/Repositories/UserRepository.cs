using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UserRepository: IUserRepository
    {
        private readonly fundicanContext _context;
        public UserRepository(fundicanContext context)
        {
            _context = context;
        }

        public User GetUser(string userLogin, string password)
        {
            return _context.Users.Where(x => x.LoginUser == userLogin && x.PasswordUser == password).FirstOrDefault();
        }
    }
}
