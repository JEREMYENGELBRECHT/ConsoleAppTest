using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ConsoleAppTest.EndPoint;
using ConsoleAppTest.Interfaces;
using ConsoleAppTest.persistance;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using SimpleInjector;

namespace ConsoleAppTest
{
    public class Startup
    {
        private IConfigurationRoot _configuration;
        private string _Connectiostring;
        private IServiceEndpoint _ServiceEndpoint;

        public Startup()
        {
        }

        public void Initialise()
        {
            Console.WriteLine("service started...");
            LoadSettings();
            SeedData();
            LoadEndpoint(new ConsoleWebEndpoint());

        }

        public IConfigurationRoot LoadSettings()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config" + Path.DirectorySeparatorChar + "settings.json");
            _configuration = configuration.Build();

            _Connectiostring = _configuration.GetSection("ConnectionString")["DefaultConnection"];

            return _configuration;
        }

        public void LoadEndpoint(IServiceEndpoint serviceEndpoint)
        {
            _ServiceEndpoint = serviceEndpoint;
            _ServiceEndpoint.Start();

        }

        public void SeedData()
        {

            var datacontext = new DataContext(_Connectiostring);
            datacontext.Database.Migrate();

        }

    }
}
