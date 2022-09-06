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

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));