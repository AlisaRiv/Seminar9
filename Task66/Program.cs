//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.Clear();
Console.WriteLine("Задача 66");

System.Random random = new System.Random();
int m = random.Next(0, 10);
int n = random.Next(m, 20);

int sumElement(int m, int n) {
  if (n < m ) {
    return 0;
  }
  return m + sumElement(m+1, n);
}

Console.Write($"M = {m}; N = {n} -> ");
int sum = sumElement(m, n);
Console.WriteLine(sum);