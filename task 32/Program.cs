/* Написать программу замены эл.массива: положительные заменить на соответствующие отрицательные и наоборот. */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0;i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);

    }
    return res;
}

int[] rev(int[] mas)
{
    for( int i = 0; i < mas.Length; i++)
    {
        mas[i] *= -1;
    }
    return mas;
}


int[] array = GetArray(5, -10, 11);
Console.WriteLine(String.Join(" ", array));

Console.WriteLine(String.Join(" ", rev(array)));