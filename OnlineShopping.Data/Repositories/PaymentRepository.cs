using OnlineShopping.Data.Infrastructure;
using OnlineShopping.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Repositories
{
    public interface IPaymentRepository
    {

    }
    public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
