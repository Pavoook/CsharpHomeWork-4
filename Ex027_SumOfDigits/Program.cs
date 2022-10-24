// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int number = Math.Abs(int.Parse(Console.ReadLine()));
    return number;
}

int CalculateSum(int value)
{
    int sum = 0;
    while (value != 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}

int Number = GetNumber("Введите целое число:");
Console.WriteLine("Сумма цифр равна " + CalculateSum(Number));
