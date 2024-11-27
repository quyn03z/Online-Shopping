using OnlineShopping.Data.Infrastructure;
using OnlineShopping.Data.Repositories;
using OnlineShopping.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Business.Services
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
        IEnumerable<Category> GetAll();
        void SaveChanges();
    }
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Category category)
        {
            _categoryRepository.Add(category);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public void SaveChanges()
        {
           _unitOfWork.Commit();
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
