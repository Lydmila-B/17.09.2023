﻿// Задача 67: Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Factorial(int n)//453,45,4,0
{
	if(n == 0) return 0;
	return n % 10 + Factorial(n / 10);//453,45,4
    //4 % 10 + 45 % 10 + 453 % 10 + 0 = 12
}

Console.WriteLine(Factorial(453));

