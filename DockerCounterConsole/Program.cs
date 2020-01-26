using System;
using System.Threading.Tasks;

namespace DockerCounterConsole
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Start App.");

            var counter = 0;
            var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
            while (max == -1 || counter < max)
            {
                counter++;
                Console.WriteLine($"Counter: {counter}");
                Task.Delay(5000).Wait();
            }
        }
    }
}