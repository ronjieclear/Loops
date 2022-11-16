using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int ulit = 0;
            int ulitfor = 0;
            int ulitwhile=0;
            int ulitdo = 0;

            Console.WriteLine("Welcome to Loop Program");
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("How many times do you want to print your name: ");
            ulit = int.Parse(Console.ReadLine());

            ulitwhile = ulit;
            ulitfor = ulit;
            ulitdo = ulit;

            //While Loop
            Console.WriteLine();
            Console.WriteLine("===While Loop===");
            while(ulit > 0)
            {
                Console.WriteLine($"{name} - {ulit}");
                ulit--;
            }

            //For Loop
            Console.WriteLine();
            Console.WriteLine("===For Loop===");
            for (int i = 1; i <= ulitfor; i++)
            {
                Console.WriteLine($"{name} - {i}");
            }

            //Do Loop
            Console.WriteLine();
            Console.WriteLine("===Do Loop===");
            int x = 1;
            do
            {
                Console.WriteLine($"{name} - {x}");
                x++;
            }while (x <=ulitdo);


            Console.ReadLine();
        }
    }
}
