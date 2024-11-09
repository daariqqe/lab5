using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            {
                //task 1 
                Console.WriteLine("Завдання 1");
                int n = 9;
                int[,] matrix = new int[n, n];
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = random.Next(100);
                    }
                }
                Console.WriteLine("Початкова матриця");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j].ToString().PadLeft(4));
                    }
                    Console.WriteLine();
                }
                int maxElement = matrix[0, 0];
                int maxIndex = 0;
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, i] >= maxElement)
                    {
                        maxElement = matrix[i, i];
                        maxIndex = i;
                    }
                }
                Console.WriteLine($"\nМаксимальний елемент на головній діагоналі: {maxElement}");
                Console.WriteLine($"Індекси: [{maxIndex}, {maxIndex}]");
                Console.WriteLine("\nПеретворена матриця");
                int temp;
                for (int i = 0; i < n; i++)
                {
                    temp = matrix[maxIndex, i];
                    matrix[maxIndex, i] = matrix[i, maxIndex];
                    matrix[i, maxIndex] = temp;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j].ToString().PadLeft(4));
                    }
                    Console.WriteLine();
                }
            }
            {
                //task 2
                Console.WriteLine("\nЗавдання 2");
                int[] array = new int[20];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 21);
                }
                Console.WriteLine("Початковий масив: " + string.Join(", ", array));
                List<int> array1 = new List<int>();
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        array1.Add(array[i]);
                    }
                }
                int temp;
                for (int i = 0; i < array1.Count - 1; i++)
                {
                    for (int j = 0; j < array1.Count - i - 1; j++)
                    {
                        if (array1[j] < array1[j + 1])
                        {
                            temp = array1[j];
                            array1[j] = array1[j + 1];
                            array1[j + 1] = temp;
                        }
                    }
                }
                int index = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        array[i] = array1[index];
                        index++;
                    }
                }
                Console.WriteLine("Перетворений масив: " + string.Join(", ", array));
                Console.ReadLine();
            }

        }
    }
}

