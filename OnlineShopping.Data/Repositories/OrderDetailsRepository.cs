﻿using OnlineShopping.Data.Infrastructure;
using OnlineShopping.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Repositories
{
    public interface IOrderDetailsRepository : IRepository<OrderDetail>
    {

    }
    public class OrderDetailsRepository : BaseRepository<OrderDetail>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
