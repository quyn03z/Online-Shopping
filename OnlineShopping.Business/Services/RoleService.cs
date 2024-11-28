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
    public interface IRoleService
    {
        void Add(Role role);
        void Update(Role role);
        void Delete(int id);
        IEnumerable<Role> GetAll();
        void SaveChanges();
    }
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RoleService(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
        {
            _roleRepository = roleRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Role role)
        {
            _roleRepository.Add(role);
        }

        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }

        public IEnumerable<Role> GetAll()
        {
            return _roleRepository.GetAll();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Role role)
        {
            _roleRepository.Update(role);
        }
    }
}
