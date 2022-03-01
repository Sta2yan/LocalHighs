using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalHighs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] array = new int[30];
            int localMaximumNumberArray = 0;
            int amountLocalMaximumNumberArray = 0;

            for (int currentIndex = 0; currentIndex < array.Length; currentIndex++)
            {
                array[currentIndex] = random.Next(1, 10);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("| ");
            foreach (int number in array)
            {
                Console.Write(number + " | ");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-----------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("| ");

            if (array[0] > array[1])
            {
                localMaximumNumberArray = array[0];
                amountLocalMaximumNumberArray += 1;
                Console.Write(localMaximumNumberArray + " | ");
            }

            for (int currentIndex = 1; currentIndex < array.Length - 1; currentIndex++)
            {
                if (array[currentIndex] > array[currentIndex - 1] && array[currentIndex] > array[currentIndex + 1])
                {
                    localMaximumNumberArray = array[currentIndex];
                    amountLocalMaximumNumberArray += 1;
                    Console.Write(localMaximumNumberArray + " | ");
                }
            }

            if (array[array.Length - 1] > array[array.Length - 2])
            {
                localMaximumNumberArray = array[array.Length - 1];
                amountLocalMaximumNumberArray += 1;
                Console.Write(localMaximumNumberArray + " | ");
            }

            Console.Write($"\nКол-во локальных максимумов: {amountLocalMaximumNumberArray}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-----------------");
        }
    }
}