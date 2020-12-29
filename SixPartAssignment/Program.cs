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
                string result = names + userTxt;
                names[i] = result;
            }
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names + userTxt);
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
            while (r <= 10) ;
            {
                Console.WriteLine(r);
                r++;
            }

            List<string> newNames = new List<string> { "John", "Carl", "Liam", "Ian" };
            Console.WriteLine("Enter one of the following names: John, Carl, Liam, Ian");
            string nameResult = Console.ReadLine();
            foreach(string name in newNames)
            {
                if(newNames = nameResult)
                {
                    Console.WriteLine(newNames.LastIndexOf());
                }
                else
                {
                    Console.WriteLine("Your input is not in the list");
                }
            }
            
            List<string> Identical = new List<string> { "Cheese", "Cake", "Burger", "Cake", "Ham" };
            Console.WriteLine("Enter one of the following: Cheese, Cake, Burger, Ham");
            string IdenticalResult = Console.ReadLine();

            for (int i = 0; i < Identical.Count; i++) ;
            {
                Console.WriteLine(IdenticalResult.Length);
                Console.WriteLine("Your input is not in the list");
            }

            List<string> iceCream = new List<string> { "Chocolate", "Vanilla", "Chocolate", "Cookie Dough" };
            Console.WriteLine("Enter one of the following: Chocolate, Vanilla, Cookie Dough");
            string iceCreamResult = Console.ReadLine();

            foreach (string flavor in iceCream) 
            {
                if (iceCream = iceCream)
                {
                    Console.WriteLine("That's in the list");
                }
            }
        }
    }
}
