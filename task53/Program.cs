// Задать двумерный массив, написать прог, которая поменяет местами первую и последнюю строку массива

void ChangeMatrixRows(int[,] matrix)
{
    int temp;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp = matrix[0, i];
            matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
            matrix[matrix.GetLength(0) - 1, i] = temp;
        }
}
 

int[,] GetArray(int row, int col, int beginNum, int endNum)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(beginNum, endNum + 1);
        }
    }    
            return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) {
        
        for (int j = 0; j < array.GetLength(1); j++)
           Console.Write($"{array[i, j]} ");
        Console.WriteLine();     
    }
}  

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine());
Console.Write("Введите первое число диапазона: ");
int beginNum = int.Parse(Console.ReadLine());
Console.Write("Введите первое число диапазона: ");
int endNum = int.Parse(Console.ReadLine());

int[,] myMatrix = GetArray(row, col, beginNum, endNum);
PrintArray(myMatrix);
ChangeMatrixRows(myMatrix);
Console.WriteLine();
PrintArray(myMatrix);