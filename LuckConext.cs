
using Microsoft.EntityFrameworkCore;
using System;

namespace Prototipe.Luck.EF
{
    internal class LuckConext: DbContext
    {
        public DbSet<Luck> Lucks { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }

        //protected override void OnModelCreating(ModelBuilder model)
        //{
        //    modelBuilder
        //            .Entity<>
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=mydbteste;Trusted_Connection=true;");
        }

    }

}