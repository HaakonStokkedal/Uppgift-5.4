using System;
using System.Collections.Immutable;

namespace Uppgift_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namnen = new string[] { "Håkon", "Emil", "Ivan", "Markus", "Theo" };
            string ord = "k";
            for (int i = 0; i < 5; i++)
            {
                if (namnen[i].CompareTo(ord) < 0)
                {
                    ord = namnen[i];
                }
            }
            Console.WriteLine($"Namnet som kommer först i bokstavsordning är {ord}.");
            Console.ReadKey();
        }
    }
}