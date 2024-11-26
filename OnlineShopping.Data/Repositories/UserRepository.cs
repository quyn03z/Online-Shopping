using OnlineShopping.Data.Infrastructure;
using OnlineShopping.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Repositories
{
    public interface IUserRepository
    {

    }
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
