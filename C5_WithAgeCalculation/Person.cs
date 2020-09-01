using System;
using System.Collections.Generic;
using System.Text;

namespace C5_WithAgeCalculation
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public DateTime DateOffBirth { get; set; }

        public void AskForName()
        {
            Console.Write("Welcome Dude! What's your name? ");
            Name = Console.ReadLine();
            Console.Write($"{Name} sweet :) ");
        }

        public void AskForAge()
        {
            Console.Write($"{Name} sweet :) How old are you man? ");


            try
            {
                Age = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Sorry dude! Your age must be in digits. Try again man.");
                Console.Write("How old are you man? ");
                Age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine($"Oh cool man! We are the same age. I am also {Age}.");
            }
        }

        public void NameContains()
        {
            Console.WriteLine($"Dude your name contains {Name.Length} characters.");
        }

        public void AskForCity()
        {
            Console.Write($"{Name} where do you live? ");
            City = Console.ReadLine();
            Console.WriteLine($"Sweet, my brother lives in {City} aswell");
        }

        public void AskForDateOfBirth()
        {
            Console.Write("When were you born? (yy-mm-dd) ");

            try
            {
                DateOffBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.Write("Sorry dude, I mean when, like 1999-01-01. So when were you born? ");
                try
                {
                    DateOffBirth = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You are so stupid man");
                }
            }

            Console.WriteLine($"Oh cool man! We are the same age. I am also {CalculateAge()}");
        }

        private int CalculateAge()
        {
            Age = DateTime.Now.Year - DateOffBirth.Year;
            if (DateTime.Now.DayOfYear < DateOffBirth.DayOfYear)
                Age = Age - 1;

            return Age;        

        }
    }
}
