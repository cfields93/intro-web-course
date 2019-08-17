using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());
            int max = 220 - age;
            Console.WriteLine("Your maximum heart rate should be " + max + " beats per minute.");
            Console.WriteLine("Your target HR Zone is " + .5 * max + " - " + .85 * max + " beats per minute");
            Console.ReadLine();
        }
    }
}
