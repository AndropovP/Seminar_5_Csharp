// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

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

int CountSumNonEvenElement(int[] array)               // Подсчёт суммы элементов стоящих на нечётных позициях массива
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int length = ReadInt("Введите длинну массива ->");
int minNum = ReadInt("Введите минимальный элемент массива ->");          
int maxNum = ReadInt("Введите максимальный элемент массива ->");         
int[] arr = GenerateArray(length, minNum, maxNum);                       
ShowArray(arr);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма нечётных элементов {CountSumNonEvenElement(arr)}");
