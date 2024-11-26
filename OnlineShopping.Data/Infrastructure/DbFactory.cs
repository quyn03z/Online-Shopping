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
        private OnlineShoppingContext _dbContext;

        public OnlineShoppingContext Init()
        {
            return _dbContext ??= new OnlineShoppingContext();
        }

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }

    }
}
