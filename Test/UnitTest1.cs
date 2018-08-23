using System;
using ConsoleAppTest.EndPoint;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var Cns = new ConsoleAppTest.Startup();
            Cns.LoadEndpoint(new ConsoleWebEndpoint());
        }
    }
}
