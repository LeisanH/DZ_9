﻿/*   Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29   */

using System.Timers;

int m = 3, n = 2;

Console.Write($"{Accerman (m,n)}");

int Accerman (int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Accerman(m - 1, 1);
    else
        return Accerman(m - 1, Accerman(m, n - 1));
}

