/*Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т. д. Результат запишите в новом массиве.*/

int[] GetArray(int size)
{
    int[] res = new int[size];

    for(int i = 0; i < res.Length; i++)
    {
      res[i] = new Random().Next(1, 100);
    }

    return res;
}

int[] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        
        result[i] = array[i] * array[array.Length - 1 - i]; //array.Length - 1 означает последний элемент, -i значит, что двигаемся от последнего эл. в сторону первого. 5-1=4-i
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
    return result;
}


int[] array = GetArray(5);
int[] GroupArr = ResultArray(array);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", GroupArr));