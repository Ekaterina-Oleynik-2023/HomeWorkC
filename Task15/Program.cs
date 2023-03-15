// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Clear();
Console.Write("Введите число от (1 до 7): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите число от 1 до 7: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5)
Console.Write("Будний день");
if (n == 6 || n == 7)
Console.Write("Выходной день");