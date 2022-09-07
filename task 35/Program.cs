/* Задать одномерный массив из 123 случайных чмсел. Найти кол-во эл.массива, значения которых лежат в отрезке [10, 99]
*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0;i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);

    }
    return res;
}

int[] array = GetArray(123, 0, 200);
Console.WriteLine(String.Join(" ", array));

int checed(int[] mas)
{
    int  count = 0;
    for(int i = 0; i < mas.Length; i++)
    {
        if ((10 <= mas[i]) && (100 > mas[i]))
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($" {checed (array)}");