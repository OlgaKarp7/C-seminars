/* задать двумерный массив, написать прог, которая заменяет строки на столбцы.
Если это невозможно - вывести сообщение для пользователя.*/

int[,] NewArray(int[,] array)
{
    int[,] temp = new int[array.GetLength(0), array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                temp[i, j] = array[j, i];
        }
    }
    return temp;
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
Console.WriteLine();
if (myMatrix.GetLength(0) == myMatrix.GetLength(1))
{
   PrintArray(NewArray(myMatrix));
}
else
Console.Write("Кол-во столбцов не совпадает с кол-вом строк!");    