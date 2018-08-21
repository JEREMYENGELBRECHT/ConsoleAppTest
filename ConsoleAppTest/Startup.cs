using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using ConsoleAppTest.EndPoint;
using ConsoleAppTest.persistance;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppTest
{
    public class Startup
    {
        private IConfigurationRoot _configuration;
        private string _Connectiostring;
        public Startup()
        {
            
        }

        public void Initialise()
        {
            Console.WriteLine("service started...");
            LoadSettings();
            SeedData();
            LoadEndpoint();

        }

        public IConfigurationRoot LoadSettings()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config" + Path.AltDirectorySeparatorChar + "settings.json");
            _configuration = configuration.Build();

            _Connectiostring = _configuration.GetSection("ConnectionString")["DefaultConnection"];

            return _configuration;
        }

        public void LoadEndpoint()
        {



            var webservice = new ConsoleWebEndpoint();
            webservice.Start();
        }

        public void SeedData()
        {

            var datacontext = new DataContext(_Connectiostring);
            datacontext.Database.Migrate();

        }

    }
}
