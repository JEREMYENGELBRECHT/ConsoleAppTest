using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppTest.Interfaces;
using ConsoleAppTest.RepositoryLayer;

namespace ConsoleAppTest.TesterService
{
    public class TesterService1 : IService
    {
        public IRepository Repository;
        public TesterService1(IRepository repository)
        {
            Repository = repository;
        }

        public bool updatedata()
        {
            Repository.updatedata();
            return true;
        }

        public void updateData()
        {
            Repository.updatedata();
        }
    }
}
