//Задача 64: Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
Console.WriteLine("Задача 64");

Console.Write("Ведите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

bool isFirst = true;
int printLine(int n) {
  if (n == 0 ) {
    return 0;
  }
  string prefix = isFirst ? "" : ", ";
  if (isFirst) { isFirst = false; }
  Console.Write($"{prefix}{n}");
  return printLine(n-1);
}

Console.Write($"N = {n} -> ");
printLine(n);
Console.WriteLine();
