
using Microsoft.Extensions.DependencyInjection;
using System;

namespace consoleDI_App
{
    class Program
    {
        public Program()
        {

        }
        static void Main(string[] args)
        {
            var product = string.Empty;

            while (product != "exit")
            {
                Console.WriteLine("Enter product:");

            }
            Console.WriteLine("Hello World!");

        }

        private static void RegisterServices()
        {
            throw new NotImplementedException();
        }
    }
}
