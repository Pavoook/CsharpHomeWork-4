// Задача 29: Напишите программу, которая задаёт массив из N элементов и 
// выводит их на экран. (На входе N - длина массива, min и max - ограничения 
// для значений элементов массива, которые лежат в [min, max].)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int GetSize(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    while (number <= 0)
    {
        Console.WriteLine("Неверное значение. Введите целое число больше нуля:");
        number = int.Parse(Console.ReadLine());
    }
    return number;
}

int GetBound(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
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

int[] random = new int[GetSize("Введите размер массива:")];
PrintArray(FillArray(random, GetBound("Введите минимальное значение элемента массива:"), GetBound("Введите максимальное значение элемента массива:")));
