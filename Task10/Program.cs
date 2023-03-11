// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите любое трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 1000)
{
    Console.Write("Вы ошиблись!\nВведите другое число(от 100 до 999): ");
    n = Convert.ToInt32(Console.ReadLine());
}
int n1 = (n / 10);
int n2 = (n1 % 10);
Console.WriteLine(n2);

