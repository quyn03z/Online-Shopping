using Microsoft.EntityFrameworkCore;
using OnlineShopping.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private readonly DbContextOptions<OnlineShoppingContext> _options;
        private OnlineShoppingContext _dbContext;


        public DbFactory(DbContextOptions<OnlineShoppingContext> options)
        {
            _options = options;
        }

        public OnlineShoppingContext Init()
        {
            return _dbContext ??= new OnlineShoppingContext(_options);
        }

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }

    }
}
