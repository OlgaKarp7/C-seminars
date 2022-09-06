/* Задать массив. Написать прог. которая определяет. присутствует ли заданное число в массиве.*/

/*int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0;i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);

    }
    return res;
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));*/

bool FindArray(int[] arr, int num)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return true;
        }
    }

    return false;
}

int[] GetArr(int num)
{
    int[] arr = new int[num];

    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите значение элемента массива  ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

Console.Write("Размер массива ");
int num = int.Parse(Console.ReadLine());
int[] array = GetArr(num);//задаем массив

Console.Write("Число для поиска ");
int number = int.Parse(Console.ReadLine());
if (FindArray(array, number))
{
    Console.WriteLine("Да");
}

else
    Console.WriteLine("Нет");
