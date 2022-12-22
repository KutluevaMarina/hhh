/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
/*int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
          newArray[i,j] = new Random().Next(minValue, maxValue+1);
       }
    }
    return newArray;
}
void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
          Console.Write(array[i,j]+" ");
       }
       Console.WriteLine();
    }
}
int[,] WaneElements (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
      {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int f = 0; f < array.GetLength(1)-1; f++)
        {
            if (array[i, f] < array[i, f + 1])
                {
                    int temp = array[i, f + 1];
                    array[i, f + 1] = array[i, f];
                    array[i, f] = temp;
                }
        }
        }
        
      }
      return array;
}
Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(rows, columns, min, max);
Show2DArray(myArray);
Console.WriteLine();
myArray = WaneElements(myArray);
Show2DArray(myArray);*/




/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
/*int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
          newArray[i,j] = new Random().Next(minValue, maxValue+1);
       }
    }
    return newArray;
}
void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
          Console.Write($"{array[i, j]} ");
       }
       Console.WriteLine();
    }
}
int[,] RowMinValue(int[,] array)
{
    int row = 0;
    int sum = 0;
    int minSum = array[row,sum];
    for(int i = 0; i < array.GetLength(1); i++)
    {
       row = array[0,i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
        if (sum < row)
        {
            row = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.Write($"{minSum + 1} строка");
    return array;
}
Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(rows, columns, min, max);
Show2DArray(myArray);
Console.WriteLine();
myArray = RowMinValue(myArray);*/
