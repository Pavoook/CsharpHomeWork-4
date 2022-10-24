// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B. Применять Math.Pow нельзя!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double GetBasis(string msg)
{
    Console.WriteLine(msg);
    double a = double.Parse(Console.ReadLine());
    return a;
}

int GetPower(string msg)
{
    Console.WriteLine(msg);
    int b = int.Parse(Console.ReadLine());
    return b;
}

bool ValidPower(int b)
{
    if (b < 0)
    {
        Console.WriteLine("Неверное значение показателя степени.");
        return false;
    }
    return true;
}

double CalculatePower(double a, int b)
{
    double result = a;
    if (b == 0)
    {
        result = 1;
        return result;
    }
    for (int i = 2; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

double A = GetBasis("Введите значение основания степени:");
int B = GetPower("Введите натуральное значение показателя степени:");
if (ValidPower(B)) Console.WriteLine($"{A} в степени {B} равно {CalculatePower(A, B)}");
