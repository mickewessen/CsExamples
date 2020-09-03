using System;
using System.Collections.Generic;
using System.Text;

namespace Test_WithAClass
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public void AskForName()
        {            
            Console.Write("Hi, what is your name? ");
            Name = Console.ReadLine();
            Console.WriteLine($"Welcome {Name}");
        }

        public void AskForAge()
        {
            Console.Write($"How old are you {Name}? ");            

            try
            {
                Age = Convert.ToInt32(Console.Read());
            }
            catch
            {
                Console.WriteLine("Sorry your age must be in digits! ");
                Console.Write("How old are you? ");
                Age = Convert.ToInt32(Console.Read());
            }
            finally
            {
                Console.Write("We are the same age! ");
            }
        }

        public void AskForCity()
        {
            Console.Write($"In which city do you live in {Name}? ");
            City = Console.ReadLine();
            Console.WriteLine("We live in the same city! ");
        }


    }
}
