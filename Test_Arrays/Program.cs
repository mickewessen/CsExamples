using System;

namespace Test_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi, how many friends do you have? ");
            var _numberOfFriends = Convert.ToInt32(Console.ReadLine());

            if (_numberOfFriends < 1)
                Console.WriteLine("Thats very sad ");

            else
            {
                string[] friends = new string[_numberOfFriends];

                if (_numberOfFriends == 1)
                {
                    Console.Write("What is your friends name? ");
                    friends[0] = Console.ReadLine();
                }

                else
                {
                    for (var i = 0; i < _numberOfFriends; i++)
                    {
                        if (i == 0)
                            Console.Write("What is your first friends name? ");

                        else
                            Console.Write("And your next friends name is? ");

                        friends[i] = Console.ReadLine();
                    }
                }

                if (_numberOfFriends == 1)
                    Console.Write("So your friend is ");
                else
                    Console.Write("So your friends are ");

                foreach (var friend in friends)
                {
                    Console.Write($"{friend} ");
                }
                    


            }

        }
    }
}
