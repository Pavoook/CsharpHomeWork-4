// Задача 29: Напишите программу, которая задаёт массив из N элементов и 
// выводит их на экран. (На входе N - длина массива, min и max - ограничения 
// для значений элементов массива, которые лежат в [min, max].)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int GetSize(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    if (number > 0) return number;
    else 
    {
        Console.WriteLine("Неверное значение.");
        return 1;
    }
}

int GetBound(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

bool ValidNumber(int value)
{
    if (value < 0) return false;
    return true;
}

int[] FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

int size = GetSize("Введите размер массива:");
int[] random = new int[size];
if (ValidNumber(size)) PrintArray(FillArray(random, GetBound("Введите минимальное значение элемента массива:"), GetBound("Введите максимальное значение элемента массива:")));
