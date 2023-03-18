// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()), count = 1;
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < b; i++)
  count *= a;
Console.WriteLine(count);
