using System;
using System.Collections.Generic;

namespace DominoSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Domino> dominoes = new List<Domino>
            {
                new Domino(3, 4),
                new Domino(2, 6),
                new Domino(5, 1),
                new Domino(4, 3),
                new Domino(6, 2)
            };

            Console.WriteLine("Unsorted Dominoes:");
            foreach (Domino domino in dominoes)
            {
                Console.WriteLine(domino.Side1 + " - " + domino.Side2);
            }

            dominoes.Sort();

            Console.WriteLine("\nSorted Dominoes:");
            foreach (Domino domino in dominoes)
            {
                Console.WriteLine(domino.Side1 + " - " + domino.Side2);
            }
        }
    }
}