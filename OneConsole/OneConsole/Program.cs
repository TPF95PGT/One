using System;
using System.Threading;

namespace OneConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int max_value = 100000000;

            DateTime start_time = DateTime.Now;

            for (int i = 0; i < max_value; i++)
            {
                if ((i % 100000) == 0)
                {
                    Console.WriteLine(i);
                }
            }

            DateTime finish_time = DateTime.Now;

            Console.WriteLine("Run time : " + Math.Round((finish_time - start_time).TotalSeconds), 2);

            Console.WriteLine("");

            Console.WriteLine("Press any key to exit.");

            ConsoleKeyInfo keyPressed = Console.ReadKey();

            if (!keyPressed.Equals(null))
            {
                Console.WriteLine("Exiting");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Oups");
            }
        }
    }
}
