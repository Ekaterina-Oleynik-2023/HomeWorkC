// Программа принимает на ввод число N, а на выводе показывает все чётные числа от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()!);
for(int i = 1; i < n; i++) {
if(i%2==0)
Console.Write($"{i} ");
}

 
