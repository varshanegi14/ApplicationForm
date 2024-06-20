using ApplicationForm.Data;
using ApplicationForm.Entity;
using Microsoft.EntityFrameworkCore;

namespace ApplicationForm.Services
{
    public interface IQuestionService
    { 
        public void Add(Question question);
    }

    public class QuestionService : IQuestionService
    {
        private readonly ApplicationDbContext _dbContext;
        public QuestionService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Question question)
        {
            _dbContext.questions.Add(question);
            _dbContext.SaveChanges();
        }

        public Question GetById(int id)
        {
            return _dbContext.questions.FirstOrDefault(q => q.Id == id);
        }

        public IEnumerable<Question> GetAll()
        {
            return _dbContext.questions.ToList();
        }

        public void Update(Question question)
        {
            _dbContext.Entry(question).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var question = _dbContext.questions.Find(id);
            if (question != null)
            {
                _dbContext.questions.Remove(question);
                _dbContext.SaveChanges();
            }
        }
    }
}
