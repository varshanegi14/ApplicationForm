using ApplicationForm.Data;
using ApplicationForm.Entity;
using Microsoft.EntityFrameworkCore;

namespace ApplicationForm.Services
{
    public interface IFormService
    {
        public Task<FormNumber> Add(FormNumber formNumber);
        public Task<List<FormNumber>> GetAll();
        public Task<FormNumber> GetById(int id);
    }

    public class FormService : IFormService
    {
        private readonly ApplicationDbContext _dbContext;
        public FormService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<FormNumber> Add(FormNumber formNumber)
        {
            await _dbContext.forms.AddAsync(formNumber);
            foreach (var question in formNumber.Questions)
            {
                await _dbContext.questions.AddAsync(question);
            }
            await _dbContext.SaveChangesAsync();
            return formNumber;
        }
        public async Task<List<FormNumber>> GetAll()
        {
            return await _dbContext.forms.ToListAsync();
        }

        public async Task<FormNumber> GetById(int id)
        {
            return await _dbContext.forms.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}