using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using KS.Authorization.Roles;
using KS.Authorization.Users;
using KS.Core.Models;
using KS.MultiTenancy;

namespace KS.EntityFrameworkCore
{
    public class KSDbContext : AbpZeroDbContext<Tenant, Role, User, KSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public KSDbContext(DbContextOptions<KSDbContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<QuestionCategory> QuestionCategories { get; set; }
        public virtual DbSet<Question> Questionses { get; set; }
        public virtual DbSet<QuestionsAnswer> QuestionsAnswers { get; set; }
        public virtual DbSet<QuestionsAnswerComment> QuestionsAnswerComments { get; set; }
        public virtual DbSet<QuestionViewCount> QuestionViewCounts { get; set; }        
    }
}
