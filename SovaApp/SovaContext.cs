using Microsoft.EntityFrameworkCore;
using SovaApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SovaApp
{
    class SovaContext : DbContext
    {

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public DbSet<Owner> Owners { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
               
                .UseNpgsql("host=localhost;db=stackoverflow;uid=postgres;pwd=password");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().ToTable("question");
            modelBuilder.Entity<Question>().HasKey(m => m.Id);
            modelBuilder.Entity<Question>().Property(m => m.Id).HasColumnName("id");
            modelBuilder.Entity<Question>().Property(m => m.AcceptedAnswerId).HasColumnName("accepted_answer");
            modelBuilder.Entity<Question>().Property(m => m.CreationDate).HasColumnName("creation_date");
            modelBuilder.Entity<Question>().Property(m => m.Score).HasColumnName("score");
            modelBuilder.Entity<Question>().Property(m => m.Body).HasColumnName("body");
            modelBuilder.Entity<Question>().Property(m => m.ClosedDate).HasColumnName("closed_date");
            modelBuilder.Entity<Question>().Property(m => m.Title).HasColumnName("title");
            modelBuilder.Entity<Question>().Property(m => m.Tags).HasColumnName("tags");
            modelBuilder.Entity<Question>().Property(m => m.OwnerId).HasColumnName("owner_id");

            modelBuilder.Entity<Answer>().ToTable("answer");
            modelBuilder.Entity<Answer>().HasKey(m => m.Id);
            modelBuilder.Entity<Answer>().Property(m => m.Id).HasColumnName("id");
            modelBuilder.Entity<Answer>().Property(m => m.QuestionId).HasColumnName("question_id");
            modelBuilder.Entity<Answer>().Property(m => m.CreationDate).HasColumnName("creation_date");
            modelBuilder.Entity<Answer>().Property(m => m.Score).HasColumnName("score");
            modelBuilder.Entity<Answer>().Property(m => m.Body).HasColumnName("body");
            modelBuilder.Entity<Answer>().Property(m => m.OwnerId).HasColumnName("owner_id");

            modelBuilder.Entity<Owner>().ToTable("owner");
            modelBuilder.Entity<Owner>().HasKey(m => m.Id);
            modelBuilder.Entity<Owner>().Property(m => m.Id).HasColumnName("id");
            modelBuilder.Entity<Owner>().Property(m => m.OwnerDisplayName).HasColumnName("owner_display_name");
            modelBuilder.Entity<Owner>().Property(m => m.OwnerCreationDate).HasColumnName("owner_creation_date");
            modelBuilder.Entity<Owner>().Property(m => m.Location).HasColumnName("owner_location");
            modelBuilder.Entity<Owner>().Property(m => m.Age).HasColumnName("owner_age");

            modelBuilder.Entity<AnswerComments>().ToTable("answer_comments");
            modelBuilder.Entity<AnswerComments>().HasKey(m => m.Id);
            modelBuilder.Entity<AnswerComments>().Property(m => m.Id).HasColumnName("id");
            modelBuilder.Entity<AnswerComments>().Property(m => m.Body).HasColumnName("body");
            modelBuilder.Entity<AnswerComments>().Property(m => m.CreationDate).HasColumnName("creation_date");
            modelBuilder.Entity<AnswerComments>().Property(m => m.AnswerId).HasColumnName("answer_id");
            modelBuilder.Entity<AnswerComments>().Property(m => m.OwnerId).HasColumnName("owner_id");
            modelBuilder.Entity<AnswerComments>().Property(m => m.Score).HasColumnName("score");

            modelBuilder.Entity<QuestionComments>().ToTable("question_comments");
            modelBuilder.Entity<QuestionComments>().HasKey(m => m.Id);
            modelBuilder.Entity<QuestionComments>().Property(m => m.Id).HasColumnName("id");
            modelBuilder.Entity<QuestionComments>().Property(m => m.Body).HasColumnName("body");
            modelBuilder.Entity<QuestionComments>().Property(m => m.CreationDate).HasColumnName("creation_date");
            modelBuilder.Entity<QuestionComments>().Property(m => m.QuestionId).HasColumnName("question_id");
            modelBuilder.Entity<QuestionComments>().Property(m => m.OwnerId).HasColumnName("owner_id");
            modelBuilder.Entity<QuestionComments>().Property(m => m.Score).HasColumnName("score");








        }
    }
}