/* Задать двумерный массив. Найти сумму элем находящихся на главной диагонали (с индексами (0,0);(1,1) и т.д.*/

Console.Write("rows = ");
int rows = int.Parse(Console.ReadLine());
Console.Write("colums = ");
int colums = int.Parse(Console.ReadLine());

int[,] GetArray(int rows, int colums)
{
    int[,] result = new int[rows, colums];

    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = new Random().Next(1, 10);

            return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) {
        
        for (int j = 0; j < array.GetLength(1); j++)
           Console.Write($"{array[i, j]} ");
        Console.WriteLine();     
    }
}  

int SumDiagonalArray(int[,] array)
{
    int diagSum = 0;
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                diagSum += array[i, j];
            }
        }
    }
    return diagSum;
}

int[,] myArray = GetArray(rows, colums);
PrintArray(myArray);
Console.WriteLine();
int resultSum = SumDiagonalArray(myArray);
Console.WriteLine($"Сумма: {resultSum}");
