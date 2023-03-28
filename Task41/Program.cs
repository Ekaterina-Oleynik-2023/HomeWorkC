// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = int.Parse(Console.ReadLine()); 
}

int CountNumbers(int[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите числа: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Введённые числа: [{string.Join(", ", array)}]");
Console.WriteLine(CountNumbers(array));