using Microsoft.VisualBasic;
using System;
using Test_WithAClass;

namespace C3_Test_WithAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            Console.Write("Hi, what is your name? ");
            person.Name = Console.ReadLine();

            Console.Write($"Hi {person.Name}, how old are you? ");

            try
            {
                person.Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine($"Sorry {person.Name}, your age must be in digits");
                Console.Write("How old are you? ");
                person.Age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine($"Cool {person.Name}, we are the same age! ");
            }

            Console.Write($"in which city do you live {person.Name}? ");
            person.City = Console.ReadLine();

            Console.WriteLine("Cool, we live in the same city! ");

        }
    }
}
