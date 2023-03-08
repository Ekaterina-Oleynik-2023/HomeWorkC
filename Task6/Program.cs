// Напишите программу, которая принимает на вход число и выдаёт является ли число чётным или нет
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
  Console.WriteLine($"{n} - чётное число");
if (n % 2 == 1)
  Console.WriteLine($"{n} - нечётное число");

