// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
string s = Console.ReadLine()!;
int sum = 0;
for (int i = 0; i < s.Length; i++)
    sum = sum + int.Parse(s[i].ToString());
Console.WriteLine(sum);
