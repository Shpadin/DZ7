// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




Console.WriteLine("Выберете задачу 47 / 50 / 52");
int task = int.Parse(Console.ReadLine());

switch (task)
{
    case 47:
        Task47();
        break;
    case 50:
        Task50();
        break;
    case 52:
        Task52();
        break;
    default:
        Console.WriteLine("Это нам не задавали! Это мы не проходили");
        break;
}
int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}


void Task47()
{
    Console.WriteLine("Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = int.Parse(Console.ReadLine());

    int[,] array = FillArray(rowCount, columnCount, 1, 10);
    PrintArray(array);
}
void Task50()
{
    Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,и возвращает значение этого элемента или же указание, что такого элемента нет.");

    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = int.Parse(Console.ReadLine());

    int[,] array = FillArray(rowCount, columnCount, 1, 10);
    PrintArray(array);

    Console.WriteLine("Введите позицию элемента в строке массива");
    int row = int.Parse(Console.ReadLine()) -1;
    Console.WriteLine("Введите позицию элемента в колонках массива");
    int colum = int.Parse(Console.ReadLine()) -1;

    if (row < array.GetLength(0) && colum  < array.GetLength(1))
    { Console.WriteLine(array[row , colum ]); }
    else
    { Console.WriteLine($"числа на позиции : ({row +1} ; {colum +1}) в массиве нет"); }

}
void Task52()
{
 Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = int.Parse(Console.ReadLine());

    int[,] array = FillArray(rowCount, columnCount, 1, 10);
    PrintArray(array);
    
    for (int j = 0; j <  array.GetLength(1); j++)
    {
        double summ = 0;
       
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ=summ+array[i,j] ;
        }
         summ = summ/ array.GetLength(0);
         Console.Write($"{summ}|");
    }
    
}
