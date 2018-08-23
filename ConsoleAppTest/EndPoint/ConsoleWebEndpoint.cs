using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppTest.Interfaces;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleAppTest.EndPoint
{

    public class ConsoleWebEndpoint : IServiceEndpoint
    {
        private IWebHost _host;
        public void Start()
        {
            _host = new WebHostBuilder()
                .UseUrls("http://*:8000")
                .UseKestrel()
                .UseStartup<WebService>()
                .Build();
            _host.Start();
            
        }

        public void Stop()
        {
            _host.StopAsync().Wait();
        }

        private void tester()
        {
           Console.WriteLine("im here to check ");
        }
    }
}
