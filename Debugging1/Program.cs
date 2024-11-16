using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Abdulkadir";
            int age; //0
            age = 23;

            if (1 = = 1)
                Console.WriteLine("True");
            PrintDetails(names, age);
            string message = ReadFromConsole("Enter anything: ");
            Console.WriteLine(message);

            Console.ReadLine();
        }

        static string ReadFromConsole(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }

    static void PrintDetails(string name, int age)
    {
        Console.WriteLine($"{name} - {age}");
        Console.WriteLine($"{name} - {age}");
        Console.WriteLine($"{name} - {age}");
        Console.WriteLine($"{name} - {age}");
        Console.WriteLine($"{name} - {age}");

    }
} 
}
