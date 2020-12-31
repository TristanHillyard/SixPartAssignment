using System;
using System.Collections.Generic;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mickey", "Minnie", "Goofy", "Donald Duck" };
            Console.WriteLine("Describe something that all disney characters can do.");
            string userTxt = Console.ReadLine();


            for (int i = 0; i < names.Length; i++)
            {
                names[i] += userTxt;
            }
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            int j = 1;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            int t = 1;
            while (t < 10)
            {
                Console.WriteLine(t);
                t++;
            }

            int r = 1;
            while (r <= 10) 
            {
                Console.WriteLine(r);
                r++;
            }

            List<string> newNames = new List<string> { "John", "Carl", "Liam", "Ian" };
            Console.WriteLine("Enter one of the following names: John, Carl, Liam, Ian");
            string nameResult = Console.ReadLine();
            for(int i = 0; i < newNames.Count; i++)
            {
                if (newNames[i] == nameResult)
                {
                    Console.WriteLine("Match found for " + nameResult[i] + " at index" + i);
                }
            }
            
            List<string> Identical = new List<string> { "Cheese", "Cake", "Burger", "Cake", "Ham" };
            Console.WriteLine("Enter one of the following: Cheese, Cake, Burger, Ham");
            string IdenticalResult = Console.ReadLine();

            for (int i = 0; i < Identical.Count; i++) 
            {
                if (Identical[i] == (IdenticalResult))
                {
                    Console.WriteLine("Match found for " + IdenticalResult[i] + " at index " + i);
                }
            }
            if(!Identical.Contains(IdenticalResult))
            {
                Console.WriteLine("This item does not exist in the list.");
            }

            List<string> iceCream = new List<string> { "Chocolate", "Vanilla", "Chocolate", "Cookie Dough" };

            for (int i = 0; i < iceCream.Count; i++)
            {
                for(int k = 0; k < i; k++)
                {
                    if(iceCream[k] == iceCream[i])
                    {
                        Console.WriteLine(iceCream[k] + " has appeared in this list");
                    }
                }
            }
            
        }
    }
}
