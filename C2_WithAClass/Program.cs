using System;

namespace C2_WithAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            Console.Write("Welcome Dude! What's your name? ");
            person.Name = Console.ReadLine();

            Console.Write($"{person.Name} sweet :) How old are you man? ");
            //age = Convert.ToInt32(Console.ReadLine());            
            //age = int.Parse(Console.ReadLine());

            try
            {
                person.Age = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Sorry dude! Your age must be in digits. Try again man.");
                Console.Write("How old are you man? ");
                person.Age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine($"Oh cool man! We are the samge age. I am also {person.Age}.");
            }

            Console.WriteLine($"Dude your name contains {person.Name.Length} characters.");
            Console.Write($"{person.Name} where do you live? ");
            person.City = Console.ReadLine();

            Console.WriteLine($"Sweet, my brother lives in {person.City} aswell");
        }
    }
}
