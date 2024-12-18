﻿using OnlineShopping.Data.Infrastructure;
using OnlineShopping.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User Login(string userName, string password);   
    }
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public User Login(string userName, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Username == userName 
                                    && u.PasswordHash == HashPassword(password));
        }
    }
}
