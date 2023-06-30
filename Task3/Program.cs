// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

double[] GenerateArray(int len, int min, int max)          //Задаёт начальные условия
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1) + rnd.NextDouble();
    }
    return array;
}

void ShowArray(double[] arr)                       //Функция вывода массива
{
    foreach (double item in arr)                   
    {
        System.Console.Write($"{item}   ");
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

double GetMaximum (double[] array)                //Определение Максимума в массиве
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

double GetMinimum (double[] array)                //Определение Минимума в массиве
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}

int length = ReadInt("Введите длинну массива ->");
// double minNum = ReadInt("Введите минимальный элемент массива для заполнения ->");          
// double maxNum = ReadInt("Введите максимальный элемент массива для заполнения ->");         
// double[] arr = GenerateArray(length, minNum, maxNum);                       
double[] arr = GenerateArray(length, 0, 99);                       
ShowArray(arr);
double max = GetMaximum(arr);
double min = GetMinimum(arr);
System.Console.WriteLine();
double result = max - min;
System.Console.WriteLine($"Разница между Максимумом => {max} и Минимумом => {min} равна => {result}");