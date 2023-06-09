﻿//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.WriteLine("Задача 68");

int m = 3;
int n = 2;

int ackermannFunction(int m, int n) {
  if (m == 0) {
    return n + 1;
  }
  if (n == 0) {
    return ackermannFunction(m - 1, 1);
  }
  return ackermannFunction(m - 1, ackermannFunction(m, n - 1));
}

Console.Write($"M = {m}; N = {n} -> A(m,n) = ");
Console.WriteLine(ackermannFunction(m, n));
