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
    public interface IFeedbackService
    {
        void Add(Feedback feedback);
        void Update(Feedback feedback);
        void Delete(int id);
        IEnumerable<Feedback> GetAll();
        void SaveChanges();
    }
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepository _feedbackRepository;
        private readonly IUnitOfWork _unitOfWork;

        public FeedbackService(IFeedbackRepository feedbackRepository, IUnitOfWork unitOfWork)
        {
            _feedbackRepository = feedbackRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Feedback feedback)
        {
            _feedbackRepository.Add(feedback);
        }

        public void Delete(int id)
        {
            _feedbackRepository.Delete(id);
        }

        public IEnumerable<Feedback> GetAll()
        {
            return _feedbackRepository.GetAll();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Feedback feedback)
        {
            _feedbackRepository.Update(feedback);
        }
    }

}
