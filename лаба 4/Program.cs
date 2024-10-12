using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("task 1");
            Console.OutputEncoding = Encoding.UTF8;
            int[] array = new int[8];
            Random rand1 = new Random();
            //Вихідний масив
            Console.WriteLine("Вихідний масив");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand1.Next(-10, 10);

                Console.WriteLine($"array[{i}] = {array[i]}");
            }

            int amount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                    amount++;

            }
            Console.WriteLine("Кількість елементів,кратних 3: " + amount);
            Console.WriteLine("--------------------------------------------");

            //task 2
            Console.WriteLine("task 2");
            Console.WriteLine("Введіть довжину масиву");
            int length = int.Parse(Console.ReadLine());
            int[] array1 = new int[length];
            for (int j = 0; j < array1.Length; j++)
            {
                array1[j] = rand1.Next(-10, 25);

                //Вихідний масив

                Console.WriteLine($"array1[{j}] = {array1[j]}");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Непарні елементи:");
            for (int j = 0; j < array1.Length; j++)
            {
                if (array1[j] % 2 != 0)
                {
                    Console.WriteLine($"array1[{j}] =  {array1[j]}");
                }
            }
        }
    }
}
