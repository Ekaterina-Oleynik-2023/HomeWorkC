// Программа принимает на ввод число N, а на выводе показывает все чётные числа от 1 до N
Console.Clear();
Console.WriteLine($"Ввест чмсло (n1)");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ввест чмсло (n2)");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 * n1 ==n2 || n2 * n2 ==n1)
Console.WriteLine("верно");
else 
Console.WriteLine("не верно");
