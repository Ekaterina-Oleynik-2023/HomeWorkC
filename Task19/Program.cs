// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число");
x = 0;
y =0;
d =0;
c = 0;
string s = Console.ReadLine()!;
x = int.Parse (s[0].ToString());
y = int.Parse (s[1].ToString());
d = int.Parse (s[3].ToString());
c = int.Parse (s[4].ToString());
if (x == c && y == d )
Console.WriteLine("да");
else 
Console.WriteLine("нет");