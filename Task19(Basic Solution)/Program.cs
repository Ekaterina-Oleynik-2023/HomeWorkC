// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Clear();
Console.Write("Введите пятизначное число: ");
string a = Console.ReadLine()!;
int a0 = int.Parse(a[0].ToString());
while(a.Length != 5)
{
  Console.Write("Ошибка!\nВведите пятизначное число: ");
  a = Console.ReadLine()!;
}
if (a[0] == a[4] && a[1] == a[3])
  Console.WriteLine("ДА - число является палиандром");
else
  Console.WriteLine("НЕТ - число не является палиандром");
