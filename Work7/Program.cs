Console.WriteLine("Zadacha47 \t");
void Zadacha47()
{
    // Задача 47. Задача 47: Задайте двумерный массив размером m×n,
    // заполненный случайными вещественными числами, округлёнными до одного знака.
    // m = 3, n = 4.
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9
    int rows = 3;
    int columns = 4;
    double[,] numbers = new double[rows, columns];
    FillDoubleArray(numbers, -100, 100);
    PrintDoubleArray(numbers);
}

void FillDoubleArray(double[,] numbers, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    double divider = 10;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue) / divider;
        }
    }
}

void PrintDoubleArray(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Zadacha47();

Console.WriteLine("Zadacha50 \t");
void Zadacha50()
{
    // Задача 50. Напишите программу, которая на вход принимает 
    // индексы элемента в двумерном массиве, и возвращает значение этого 
    // элемента или же указание, что такого элемента нет.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 1, 3 -> 3
    int rows = 5;
    int columns = 7;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    Console.WriteLine("Введите индекс строки: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i < rows && j < columns && i >= 0 && j >= 0)
    {
        Console.WriteLine($"Значение элемента с индексом [{i},{j}] = {numbers[i, j]}");
    }
    if (i >= rows || j >= columns || i < 0 || j < 0)
    {
        Console.WriteLine("Элемента с указанным индексом нет ");
    }
}

void FillArray(int[,] numbers, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Zadacha50();

void Zadacha52()
{
    // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
    // арифметическое элементов в каждом столбце.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 5 3
    // 8 4 6 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.
    int rows = 3;
    int columns = 3;
    double[,] numbers = new double[rows, columns];
    FillDoubleArray(numbers, 0, 10);
    PrintArrayDouble(numbers);
    double sum = 0;
    double sum1 = 0;
    double sum2 = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += (numbers[i, 0]) * 10;
        sum1 += (numbers[i, 1]) * 10;
        sum2 += (numbers[i, 2]) * 10;
    }
    double resalt = Math.Round((sum / rows), 1);
    double resalt1 = Math.Round((sum1 / rows), 1);
    double resalt2 = Math.Round((sum2 / rows), 1);
    Console.WriteLine($"сред.арифм.кажд.столбца: {resalt}; {resalt1}; {resalt2}");

}


void PrintArrayDouble(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j] * 10}\t");
        }
        Console.WriteLine();
    }
}
Zadacha52();



