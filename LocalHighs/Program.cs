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
            int numberArray;
            int localMaximumNumberArray = 0;
            int amountLocalMaximumNumberArray = 0;
            int lastIndexArray = array.Length - 1;
            int firstIndexArray = 0;
            int previousNumberArray;
            int nextNumberArray;

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
            for (int currentIndex = 0; currentIndex < array.Length; currentIndex++)
            {
                if (currentIndex != firstIndexArray && currentIndex != lastIndexArray)
                {
                    numberArray = array[currentIndex];
                    nextNumberArray = array[currentIndex + 1];
                    previousNumberArray = array[currentIndex - 1];
                    if (numberArray > previousNumberArray && numberArray > nextNumberArray)
                    {
                        localMaximumNumberArray = numberArray;
                        amountLocalMaximumNumberArray += 1;
                        Console.Write(localMaximumNumberArray + " | ");
                    }
                }
                else if (currentIndex == lastIndexArray)
                {
                    numberArray = array[currentIndex];
                    previousNumberArray = array[currentIndex - 1];
                    if (numberArray > previousNumberArray)
                    {
                        localMaximumNumberArray = numberArray;
                        amountLocalMaximumNumberArray += 1;
                        Console.Write(localMaximumNumberArray + " | ");
                    }
                }
                else
                {
                    numberArray = array[currentIndex];
                    previousNumberArray = array[currentIndex];
                    nextNumberArray = array[currentIndex + 1];
                    if (array[currentIndex] > nextNumberArray)
                    {
                        localMaximumNumberArray = numberArray;
                        amountLocalMaximumNumberArray += 1;
                        Console.Write(localMaximumNumberArray + " | ");
                    }
                }
            }
            Console.Write($"       Кол-во локальных максимумов: {amountLocalMaximumNumberArray}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-----------------");
        }
    }
}