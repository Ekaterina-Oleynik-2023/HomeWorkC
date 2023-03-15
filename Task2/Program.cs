//На вход принимает два числа и выдает какое больше, какое меньше.
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
Console.WriteLine($"{a} максимальное число, {b} минимальное число");
else if(a < b)
Console.WriteLine($"{b} максимальное число, {a} минимальное число");
else
Console.WriteLine("Вы ввели равные числа");
