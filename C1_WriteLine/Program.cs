using System;

namespace C1_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Michael";
            int age = 34;
            var city = "Örebro";

            var text1 = "Welcome Michael, you are 34 years old right? Michael do you live in Örebro?";
            var text2 = "Welcome "+ name +", you are " + age + "years old right?"  + name + " do you live in " + city + "?";
            var text3 = String.Format("Welcome {0}, you are {1} years old right? {0} do you live in {2}?", name, age, city);
            var text4 = $"Welcome {name}, you are {age} years old right? {name} do you live in {city}?";

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4);
        }
    }
}
