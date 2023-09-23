﻿// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 99 + 1);
Console.WriteLine($"Случайное число из отрезка [10, 99] -> {number}");

int firstDigit = number / 10; // 78/10=7
int secondDigit = number % 10;

if (firstDigit > secondDigit) Console.WriteLine($"Наибольшую цифру числа [10, 99] -> {firstDigit}");
else Console.WriteLine($"Наибольшую цифру числа [10, 99] -> {secondDigit}");

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшую цифру числа [10, 99] -> {maxDigit}");