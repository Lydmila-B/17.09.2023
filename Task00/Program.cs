﻿// 0. Демонстрация решения
// Напишите программу, которая на вход 
// принимает число и выдаёт его квадрат 
// (число умноженное на само себя).

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine(number + " -> " + square);
Console.WriteLine($"{number} -> {square}");
