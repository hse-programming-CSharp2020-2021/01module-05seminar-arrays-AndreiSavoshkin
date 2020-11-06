using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 0.
 * В программе сформировать и вывести на экран целочисленный массив из N элементов,
 * элементами которого являются нечетные числа от 1.
 * Заполнение массива нечётными числами организовать при помощи метода.​
 *
 * Пример входных данных:
 * 7
 *
 * Пример выходных данных:
 * 1 3 5 7 9 11 13
 */

namespace Task03
{
    class Program
    {
        static int[] GetArray(int n)
        {
            int numElem = n / 2;
            int[] array = new int[numElem];
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    array[count++] = i;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());
            int[] array = GetArray(inputN);
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}