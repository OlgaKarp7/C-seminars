/* Написать прог, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

Console.Write(" Введите число: ");
int number = int.Parse(Console.ReadLine());

int GetBinary(int num)
{
    string result = ""; /* или String.Empty - пустая строчка*/
    while(num > 0)
    {
        result = result + Convert.ToString(num % 2);
        num /= 2; // num=num/2
        
    }
    result. ToCharArray().Reverse(); //строку дробим на массив букв, а потом переворачиваем
    return int.Parse(result);//метод int.Parse преобразовывает из строки в число
}
Console.WriteLine($"{GetBinary(number)}");
