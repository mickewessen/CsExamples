using System;

namespace C8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many siblings do you have? ");
            var _numbersOfSiblings = Convert.ToInt32(Console.ReadLine());

            if (_numbersOfSiblings < 1)
                Console.WriteLine("Okay. That's cool man.");
            else
            {
                string[] siblings = new string[_numbersOfSiblings];

                if (_numbersOfSiblings == 1)
                {
                    Console.Write("What's your siblings name? ");
                    siblings[0] = Console.ReadLine();
                }
                else
                {
                    for (var i=0; i < _numbersOfSiblings; i++)
                    {
                        if (i == 0)
                            Console.Write("What's your first siblings name? ");
                        else
                            Console.Write("And your next siblings name is? ");

                        siblings[i] = Console.ReadLine();

                    }
                }

                if (_numbersOfSiblings == 1)
                    Console.Write("So correct me if I'm wrong. Your sibling is ");
                else
                    Console.Write("And your next siblings are? ");

                foreach(var sibling in siblings)
                {
                    Console.Write(@"{siblings} ");
                }
            }

        }
    }
}




    /* Operators (ska vi kunna utantill)
     
     = tilldela ett värde
     += lägg till på befintligt värde
     -= ta bort från befintligt värde
     == lika med
     != inte lika med
     <  mindre än
     > större än
     <= mindre eller lika med
     >= större eller lika med
     || eller
     && och
     ! inte
    // one-line comment
    /* multi-line comment 

    */