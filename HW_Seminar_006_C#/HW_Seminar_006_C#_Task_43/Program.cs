﻿// Задача № 43:
// Напишите программу, которая найдет точку пресечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2
// Значения b1, k1, b2, k2 задаются пользователем.

Console.Write("введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых: X: {x} и Y: {y}");