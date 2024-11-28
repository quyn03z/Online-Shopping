using OnlineShopping.Data.Infrastructure;
using OnlineShopping.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetAllById(int id);

    }
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Product> GetAllById(int id)
        {
            return _context.Products.Where(p => p.Id == id).ToList();    
        }
    }
}
