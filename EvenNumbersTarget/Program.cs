﻿using System;

namespace EvenNumbersTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Even Numbers Target app");
            
            Console.WriteLine("Enter your first Number:");
            int Start = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your Target Number:");
            int TargettNumber = int.Parse(Console.ReadLine());

            //for (int i = Start; i <= TargettNumber; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.WriteLine();
            while(Start <= TargettNumber)
            {
                if(Start % 2 == 0)
                Console.Write(Start+" ");
                Start += 1;
                
            }
        }
    }
}
