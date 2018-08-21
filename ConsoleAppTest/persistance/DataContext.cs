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

        public DataContext(string connectionstring)
        {
            Connectiostring = connectionstring;
        }

        public DbSet<TesterModel> Tester { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
               optionsBuilder.UseSqlServer(Connectiostring);
        }
    }
}
