using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Text;
using ConsoleAppTest.persistance.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppTest.persistance
{
    public class DataContext : DbContext
    {
        public string Connectiostring;

        public DataContext(DbContextOptions<DataContext> options)
            : base(options){ }

        public DataContext(string connectiostring)
        {
            Connectiostring = connectiostring;
        }

        public DbSet<TesterModel> Tester { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("User ID = sa; password = Password123; Database = tester; Pooling = true; ");
        }

    }
}
