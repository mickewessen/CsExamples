using System;

namespace C10_Struct
{
    // MINNESHANTERING   (RAM-HDD)
    // HEAP     = Långsammare   MALOC() FREE()      CLASS
    // STACK    = Snabbare                          STRUCT


    class ClassExample
    {
        public int Nr1 { get; set; }
        public int Nr2 { get; set; }

        public ClassExample(int nr1, int nr2)
        {
            Nr1 = nr1;
            Nr2 = nr2;
        }

        public void DisplayValues()
        {
            Console.WriteLine($"Display Values: {Nr1}, {Nr2}");
        }


        class Program
        { 
            private static void ModifyValues(dynamic d)
            {
                d.Nr1 += 1;
                d.Nr1 += 2;
                Console.WriteLine($"Modyfiying Values: {d.Nr1}, {d.Nr2} ");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Classexample - HEAP (GLOBAL");
            var classexample = new ClassExample(1, 1);

            classexample.DisplayValues();

            Console.WriteLine("\n------------------------\n");

            Console.WriteLine("Structexample - HEAP (LOCAL");
            var structexample = new ClassExample(1, 1);

            classexample.DisplayValues();


            Console.ReadKey();
        }


    }
}
