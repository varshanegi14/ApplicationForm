using ApplicationForm.Entity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ApplicationForm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Question> questions { get; set; }
        public DbSet<FormNumber> forms { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().Property(e => e.QuestionType).HasConversion(c => c.ToString(), c => Enum.Parse<QuestionType>(c));
            base.OnModelCreating(modelBuilder);
        }
    }

}
