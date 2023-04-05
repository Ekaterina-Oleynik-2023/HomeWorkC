// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
int AkkermanF(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AkkermanF(m - 1, 1);
  else return AkkermanF(m - 1, AkkermanF(m, n - 1));
}

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
while (m <= 0)
{
    Console.Write("Вы ошиблись!\nВведите число M: ");
    m = int.Parse(Console.ReadLine()!);
}
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
while (n <= 0)
{
    Console.Write("Вы ошиблись!\nВведите число N: ");
    n = int.Parse(Console.ReadLine()!);
}
Console.Write($"A(m,n) = {AkkermanF(m,n)} ");