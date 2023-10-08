// Внутри класса Answer напишите метод IsPalindrome, 
// который принимает на вход пятизначное число number 
// и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, 
// в противном случае - вывести Число не пятизначное 
// и False в следующей строке.

// Для остальных чисел вернуть True или False.

// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False


Console.Write("Введите число: ");
string num = Console.ReadLine();
int len = num.Length;
if (len == 5)
{
    if (num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine(true);
    }
    else
    {
        Console.WriteLine(false);
    }
}
else
{
    Console.WriteLine($"Число не пятизначное ");
    Console.WriteLine(false);
}


