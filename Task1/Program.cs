// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int len, int min, int max)          //Задаёт начальные условия
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] arr)                       //Функция вывода массива
{
    foreach (int item in arr)                   
    {
        System.Console.Write($"{item} ");
    }
}

int ReadInt(string message)
{
    Console.Write($"{message} ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число!");
    Environment.Exit(0);
    return 0;
}

int CountEvenElement(int[] array)               // Подсчёт чётных элементов массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

int length = ReadInt("Введите длинну массива ->");
// int minNum = ReadInt("Введите минимальный элемент массива ->");          //Для любых нижних и верхних знамений
// int maxNum = ReadInt("Введите максимальный элемент массива ->");         //массива
// int[] arr = GenerateArray(length, minNum, maxNum);                       //
int[] arr = GenerateArray(length, 100, 999);
ShowArray(arr);
System.Console.WriteLine();
System.Console.WriteLine($"Количество чётных элементов {CountEvenElement(arr)}");
