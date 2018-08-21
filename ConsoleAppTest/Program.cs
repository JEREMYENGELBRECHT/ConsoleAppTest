using System.Threading;

namespace ConsoleAppTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var startup = new Startup();
            startup.Initialise();
            Thread.Sleep(Timeout.Infinite);
        }

    }
}
