﻿using Microsoft.EntityFrameworkCore;
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
        public virtual DbSet<QuestionRating> QuestionRatings { get; set; }
        public virtual DbSet<QuestionViewCount> QuestionViewCounts { get; set; }

        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual DbSet<QuestionAnswerRating> QuestionAnswerRatings { get; set; }
        public virtual DbSet<QuestionAnswerViewCount> QuestionAnswerViewCounts { get; set; }
        public virtual DbSet<QuestionAnswerComment> QuestionAnswerComments { get; set; }        
    }
}
