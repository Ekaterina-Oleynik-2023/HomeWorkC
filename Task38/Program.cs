﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void InputArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * 20 + 10, 2);
}
double Max(double[] array)
{
  double max = array[0]; 
  for (int i = 0; i < array.Length; i++)
  {
    if (max < array[i]) max = array[i];
  }
  return max; 
}
double Min(double[] array)
{
  double min = array [0];
  for (int i = 0; i < array.Length; i++)
  {
    if (min > array[i]) min = array[i];
  }
  return min;
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine((Max(array)-Min(array)));
