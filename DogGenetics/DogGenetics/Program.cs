using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName;
            Console.Write("What is the name of your dog? ");
            dogName = Console.ReadLine();
            Console.Write($"\nWell then, I have this highly reliable report on {dogName}'s prestigious background right here.");
            Random random = new Random(); 
            int a, b, c, d, e;
            a = random.Next(0, 100);
            b = random.Next(0, 100 - a);
            c = random.Next(0, 100 - (a + b));
            d = random.Next(0, 100 - (a + b + c));
            e = 100 - (a + b + c + d);

            Console.WriteLine($"\n{dogName} is:");
            Console.WriteLine($"{a}% St. Bernard");
            Console.WriteLine($"{b}% Chihuahua");
            Console.WriteLine($"{c}% Cavalier King Charles Spaniel");
            Console.WriteLine($"{d}% Golden Retriever");
            Console.WriteLine($"{e}% Labrador");
            Console.WriteLine("\n WOW! That's QUITE the dog!");
            Console.ReadLine();
        }
    }
}
