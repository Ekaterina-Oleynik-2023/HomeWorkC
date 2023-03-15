// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Clear();
Console.Write("Введите пятизначное число: ");
string s = Console.ReadLine()!;
int s1 = 0; int s2 = 0; int s3 = 0; int s4 = 0;
while (s.Length  !=  5)
{
  Console.Write("Ошибка!\nВведите пятизначное число: ");
  s = Console.ReadLine()!;
}
s1 = int.Parse(s[0].ToString());
s2 = int.Parse(s[1].ToString());
s3 = int.Parse(s[3].ToString());
s4 = int.Parse(s[4].ToString());
if (s1 == s4 && s2 == s3)
  Console.WriteLine("да");
else
  Console.WriteLine("нет"); 
  