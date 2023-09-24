// 10. Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру 
// этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondDigit(int number);
// {
//     int firstNumber = number % 100;
//     int lastNumber = number % 10;
//     int threeNumber = firstNumber - lastNumber;
//     int result = threeNumber / 10;
//     return threeNumber / 10;
//     //Console.WriteLine($"Вторая цифра -> {result}");
// }

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int result = SecondDigit(number);
// Console.WriteLine(result);


if (number >= 100 && number <= 999)
{
    int firstNumber = number % 100;
    int lastNumber = number % 10;
    int threeNumber = firstNumber - lastNumber;
    int result = threeNumber / 10;
    Console.WriteLine($"Вторая цифра -> {result}");
}
else
{
    Console.WriteLine("Ошибка ввода");
}
