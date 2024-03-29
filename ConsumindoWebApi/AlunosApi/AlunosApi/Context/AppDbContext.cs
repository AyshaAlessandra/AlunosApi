﻿using AlunosApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlunosApi.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public virtual DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Maria Eduarda",
                    Email = "mariaEduarda@gmail.com",
                    Idade = 23
                },

                 new Aluno
                 {
                     Id = 2,
                     Nome = "Caio Rodrigues",
                     Email = "caioRodrigues@gmail.com",
                     Idade = 23
                 }

                );
        }
    }
}
