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
    public interface IOrderDetailsService
    {
        void Add(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void Delete(int id);
        IEnumerable<OrderDetail> GetAll();
        void SaveChanges();
    }
    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderDetailsService(IOrderDetailsRepository orderDetailsRepository, IUnitOfWork unitOfWork)
        {
            _orderDetailsRepository = orderDetailsRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(OrderDetail orderDetail)
        {
            _orderDetailsRepository.Add(orderDetail);
        }

        public void Delete(int id)
        {
            _orderDetailsRepository.Delete(id);
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _orderDetailsRepository.GetAll();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(OrderDetail orderDetail)
        {
            _orderDetailsRepository.Update(orderDetail);
        }
    }
}
