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
    public interface IPaymentMethodService
    {
        void Add(PaymentMethod paymentMethod);
        void Update(PaymentMethod category);
        void Delete(int id);
        IEnumerable<PaymentMethod> GetAll();
        void SaveChanges();
    }
    public class PaymentMethodService : IPaymentMethodService
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PaymentMethodService(IPaymentMethodRepository paymentMethodRepository, IUnitOfWork unitOfWork)
        {
            _paymentMethodRepository = paymentMethodRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(PaymentMethod paymentMethod)
        {
            _paymentMethodRepository.Add(paymentMethod);
        }

        public void Delete(int id)
        {
            _paymentMethodRepository.Delete(id);
        }

        public IEnumerable<PaymentMethod> GetAll()
        {
            return _paymentMethodRepository.GetAll();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(PaymentMethod paymentMethod)
        {
            _paymentMethodRepository.Update(paymentMethod);
        }
    }
}
