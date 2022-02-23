using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInstance = Singleton.GetInstance();
            Console.WriteLine(firstInstance.Description);

            var secondInstance = Singleton.GetInstance();
            Console.WriteLine(secondInstance.Description);

            Console.ReadKey();
        }
    }
}
