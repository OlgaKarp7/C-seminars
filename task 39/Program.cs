/* Написать прог, которая перевернет одномерный массив (последний эл будет на 1 месте, а 1 - на последнем и т.д.) 
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0;i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] ReversArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i]; //если result[0] = array[GetArray.Length - 1] - присваиваем нулевому значение последнего, если не нулевому, а всем последующим, то result[0 + i] = array[GetArray.Length - 1 - i]
        Console.WriteLine($"{array.Length - 1 - i}: {array[array.Length - 1 - i]}");
        Console.WriteLine($"{i}: {result[i]}");
        Console.WriteLine("-------");
    }

    return result;

}  

int[] myArray = GetArray(5, 0, 10);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine(String.Join(" ", ReversArray(myArray)));


int[] ReversArray2(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
                                             
}


Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine(String.Join(" ", ReversArray(myArray)));
Console.WriteLine(String.Join(" ", ReversArray2(myArray)));
