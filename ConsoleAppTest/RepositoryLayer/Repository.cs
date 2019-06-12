using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppTest.Interfaces;
using ConsoleAppTest.persistance;
using ConsoleAppTest.persistance.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppTest.RepositoryLayer
{
    class Repository : IRepository
    {
        private DataContext Context;
        public Repository(DataContext context)
        {
            Context = context;
        }

        public void updatedata()
        {

            Context.Add(new TesterModel
                {
                    name = "jeremy",
                    surname = "engelbrecht"
                }

            );

            Context.SaveChanges();
            //throw new NotImplementedException();
        }


        public bool deletedata()
        {
            throw new NotImplementedException();
        }
    }
}
