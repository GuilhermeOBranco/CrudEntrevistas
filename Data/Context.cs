using System;
using Microsoft.EntityFrameworkCore;
using ProjetoEstags.Models;

namespace ProjetoEstags.Data
{
    public class Context : DbContext
    {
        public DbSet<Entrevista> Entrevista { get; set; }
        public DbSet<Entrevistado> Entrevistado { get; set; }
        public DbSet<ProjetoEstags.Models.Entrevistador> Entrevistador { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=dbname;Trusted_Connection=Yes;");
        }

    }

}