﻿using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext: DbContext
    {

        public StudentSystemContext():base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StudentSystem;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<Student>()
                .Property(s => s.RegisteredOn)
                .HasColumnType("datetime2");
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .HasMaxLength(100)
                .IsUnicode(true);
            modelBuilder.Entity<Student>()
                .Property(s => s.PhoneNumber)
                .IsFixedLength(true)
                .IsUnicode(false)
                .IsRequired(false)
                .HasColumnType("char(10)");
            modelBuilder.Entity<Student>()
                .Property(s => s.RegisteredOn)
                .HasColumnType("datetime2");
            modelBuilder.Entity<Student>()
               .Property(s => s.Birthday)
               .HasColumnType("datetime2")
               .IsRequired(false);

            modelBuilder.Entity<Course>()
                .Property(s => s.Name)
                .HasMaxLength(80)
                .IsUnicode(true);
            modelBuilder.Entity<Course>()
                .Property(s => s.Description)
                .IsUnicode(true)
                .IsRequired(false);

            modelBuilder.Entity<Resource>()
                .Property(r=>r.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            modelBuilder.Entity<Resource>()
                .Property(r => r.Url)
                .IsUnicode(false);
            modelBuilder.Entity<Resource>()
             .Property(r => r.ResourceType)
             .HasColumnType("nvarchar(15)");
            modelBuilder.Entity<Homework>()
             .Property(r => r.ContentType)
             .HasColumnType("nvarchar(15)");


        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }



    }
}
