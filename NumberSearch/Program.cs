using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace NumberSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter target sum:");
            double targetSum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter path to text file:");

            //Путь к txtшнику
            string filePath = "C:/nums.txt";

            List<double> numbers = ReadNumbersFromFile(filePath);

            FindIndices(targetSum, numbers);
        }

        private static List<double> ReadNumbersFromFile(string filePath)
        {
            return File.ReadAllLines(filePath)
                        .SelectMany(line => line.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries))
                        .Select(str => double.Parse(str, CultureInfo.InvariantCulture))
                        .ToList();
        }

        /// <summary>
        /// Метод для поиска индексов чисел с заданной суммой.
        /// </summary>
        /// <param name="targetSum">Заданное значение юзером</param>
        /// <param name="numbers">Коллекция значений из txt</param>
        static void FindIndices(double targetSum, List<double> numbers)
        {
            HashSet<int> usedIndices = new HashSet<int>();
            List<int> indices = new List<int>();
            double currentSum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (usedIndices.Contains(i))
                {
                    continue;
                }

                currentSum += numbers[i];
                indices.Add(i);
                usedIndices.Add(i);

                if (currentSum == targetSum)
                {
                    break;
                }
                else if (currentSum > targetSum)
                {
                    currentSum -= numbers[i];
                    indices.RemoveAt(indices.Count - 1);
                    usedIndices.Remove(i);
                }
            }

            if (currentSum == targetSum)
            {
                Console.WriteLine("Indices: " + string.Join(", ", indices));
            }
            else
            {
                Console.WriteLine("No combination found.");
            }
        }
    }
}