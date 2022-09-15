/* Задать двумерный массив. Найти элем, у которых оба индекса четные, и заменить эти элементы на их квадраты.*/

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

int[,] CorrectArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
}

int[,] myArray = GetArray(rows, colums);
PrintArray(myArray);
Console.WriteLine();
myArray = CorrectArray(myArray);
PrintArray(myArray);