﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.Write("Введите B1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите K1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите K2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = 0; double y =0; 
x = (b2-b1)/(k1-k2);
y = k1*x+b1;
Console.WriteLine($"координаты пересечения X: {x}, Y: {y}");