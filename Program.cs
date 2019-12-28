using System;

namespace Lab04_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VALUE	                                 MEANING");
            Console.WriteLine("Less than zero   	    a precedes b in the sort order or a is null and b is not null.");
            Console.WriteLine("Zero	                    a is equal to b or a and b are both null.");
            Console.WriteLine("Greater than zero	    a follows b in the sort order or b is null and a is not null.\n");

            //Test CompareByName 
            Comparison comp = new Comparison();
            int result = comp.CompareByName("remus", "iftimie");
            Console.WriteLine(result);

            //Test CompareByLength
            Console.Write("Please enter the first string: ");
            string word1 = Console.ReadLine();
            Console.Write("Please enter the second string: ");
            string word2 = Console.ReadLine();

            comp.CompareByLength(word1, word2);
            Console.ReadKey();
        }
    }
}
