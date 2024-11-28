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
    public interface IPaymentService
    {
        void Add(Payment payment);
        void Update(Payment payment);
        void Delete(int id);
        IEnumerable<Payment> GetAll();
        void SaveChanges();
    }
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PaymentService(IPaymentRepository paymentRepository, IUnitOfWork unitOfWork)
        {
            _paymentRepository = paymentRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Payment payment)
        {
            _paymentRepository.Add(payment);
        }

        public void Delete(int id)
        {
            _paymentRepository.Delete(id);
        }

        public IEnumerable<Payment> GetAll()
        {
            return _paymentRepository.GetAll();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Payment payment)
        {
            _paymentRepository.Update(payment);
        }
    }
}
