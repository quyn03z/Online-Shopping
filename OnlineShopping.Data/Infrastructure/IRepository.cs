using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        void Delete(Guid id);
        T? GetById(int id);

        T? GetById(Guid id);

        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();

        //Phương thức này trả về một truy vấn cơ bản (IQueryable<T>) cho tất cả các đối tượng kiểu T từ nguồn dữ liệu, mà không có bất kỳ điều kiện lọc hoặc sắp xếp nào.
        IQueryable<T> GetQuery();

        // Cho phép áp dụng một biểu thức điều kiện (predicate) để lọc dữ liệu ngay từ đầu.
        IQueryable<T> GetQuery(Expression<Func<T, bool>> predicate);

        IQueryable<T> Get(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, string includeProperties = "");

        int Count(Expression<Func<T, bool>> where);
        IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

    }
}
