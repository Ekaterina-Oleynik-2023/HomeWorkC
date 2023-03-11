// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100)
{
  Console.Write("Третьей цифры нет!\nВведите любую другую цифру: ");
  n = Convert.ToInt32(Console.ReadLine());
}
while (n >999)
{
  n = (n / 10);
}
n = (n % 10);
Console.WriteLine(n);
