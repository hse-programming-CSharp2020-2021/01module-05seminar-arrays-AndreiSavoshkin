using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 0
 * В программе сформировать и вывести на экран целочисленный массив из N элементов
 * Значениями элементов являются степени числа 2 от нулевой до N-1 (1, 2, … 2^(N-1)).
 * Заполнение массива степенями числа 2 организовать при помощи метода.
 *
 * Пример входных данных:
 * 4
 *
 * Пример выходных данных:
 * 1 2 4 8
 */

namespace Task02
{
    class Program
    {
        static ulong[] GetArray(int n)
        {
            ulong[] array = new ulong[n];
            for (var i = 0; i < n; i++)
            {
                array[i] = (ulong)Math.Pow(2, i);
            }
            return array;
        }
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());
            ulong[] array = GetArray(inputN);
            for (var i = 0; i < inputN; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}