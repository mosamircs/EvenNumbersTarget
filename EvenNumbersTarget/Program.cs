using System;

namespace EvenNumbersTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserChoice = "";
            do
            {

                Console.WriteLine("Hello Even Numbers Target app");

                Console.WriteLine("Enter your first Number:");
                int Start = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your Target Number:");
                int TargettNumber = int.Parse(Console.ReadLine());
                /*
                //for (int i = Start; i <= TargettNumber; i++)
                //{
                //    if (i % 2 == 0)
                //    {
                //        Console.Write(i + " ");
                //    }
                //}
                //Console.WriteLine();
                */
                while (Start <= TargettNumber)
                {
                    if (Start % 2 == 0)
                        Console.Write(Start + " ");
                    Start += 1;
                }
                Console.WriteLine();
                do
                {
                    Console.WriteLine("Do you want to Continue ? Yes or No");
                    UserChoice = Console.ReadLine().ToLower();
                    if (UserChoice != "yes" && UserChoice != "no")
                    {
                        Console.WriteLine("You entered invalid choice try again...");
                    }
                } while (UserChoice != "yes" && UserChoice != "no");


            } while (UserChoice == "yes");
        }
    }
}
