using System;
using System.Threading.Tasks;

namespace TestClrApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            await Task.Run(async () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{i}");
                    await Task.Delay(1000);
                }
            });

            Console.ReadKey();
        }
    }
}
