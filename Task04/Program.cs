﻿using System;

/*
 * Пользователем с клавиатуры вводятся целые числа N > 1, A и D.
 * В программе сформировать и вывести на экран целочисленный массив из N элементов.
 * Элементы вычисляются: A[0] = A, A[1] = A + D, A[2] = A + 2*D, … A[N-1] = A + (N-1)*D.
 * Формирование массива организовать при помощи метода.​
 *
 * Пример входных данных:
 * 5
 * 3
 * 4
 *
 * Пример выходных данных:
 * 3 7 11 15 19
 */

namespace Task04
{
    class Program
    {
        static int[] GetArray(int N, int A, int D)
        {
            int[] array = new int[N];
            for (var i = 0; i < N; i++)
            {
                array[i] = A + D * i;
            }
            return array;
        }
        static void Main(string[] args)
        {
            int N, A, D;
            N = int.Parse(Console.ReadLine());
            A = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            int[] array = GetArray(N, A, D);
            for (var i = 0; i < N; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}