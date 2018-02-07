using System;

namespace UserAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainService = new MainService();
            mainService.Start();
            Console.ReadKey();
        }
    }
}