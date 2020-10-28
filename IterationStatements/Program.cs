using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int>();
            var myInt = 0;


            do
            {
                numbers.Add(myInt);
                myInt++;
            } while (myInt < 100);

            while (myInt < 200)
            {
                numbers.Add(myInt);
                myInt++;
            }

            Console.WriteLine("Increase:");

            foreach (var num in numbers)
            {
                Console.WriteLine("Increase: " + num);
            }

            Console.WriteLine("");

            for (int i = 199; i >= 0; i--)
            {
                Console.WriteLine("Decrease: " + numbers[i]);
            }
        }
    }
}
