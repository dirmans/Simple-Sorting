using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Total Array : ");
            int totalArray = int.Parse(Console.ReadLine());
            int[] array = new int[totalArray];

            for (int i = 0; i < totalArray; i++)
            {
                Console.Write("Dimensi ke - " + (i + 1) + " : ");
                int dimensiArray = int.Parse(Console.ReadLine());
                array[i] = dimensiArray;
            }

            int reserve = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        reserve = array[i];
                        array[i] = array[j];
                        array[j] = reserve;
                    }
                }
                
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString());
            }
        }
    }
}