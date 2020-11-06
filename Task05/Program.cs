using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 1.
 * В программе сформировать целочисленный массив,
 * содержащий N первых элементов последовательности Фибоначчи:
 * A[0] = 1, A[1] = 1, A[2] = A[0] + A[1], … A[K] = A[K-1] + A[K-2], …
 * 
 * Формирование массива организовать при помощи метода.
 * Элементы массива вывести на экран в обратном порядке.
 * Методы класса Array НЕ использовать.
 *
 * Пример входных данных:
 * 5
 *
 * Пример выходных данных:
 * 5 3 2 1 1
 */

namespace Task05
{
    class Program
    {
        static long[] GetArray(int N)
        {
            long[] array = new long[N];
            array[0] = 1;
            array[1] = 1;
            for (var i = 2; i < N; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            return array;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] array = GetArray(N);
            for (var i = N - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
                if ((N - i) % 5 == 0)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}