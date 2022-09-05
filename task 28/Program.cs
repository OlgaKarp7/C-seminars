/* Написать программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
4 -> 24
5 -> 120*/

Console.Write(" Введите число: ");
int num = int.Parse(Console.ReadLine());

int MultiDigital(int N)
{
    int a = 1;
    
    for(int i = 2; i <= N; i++)
    {
         a = a * i;
    }
    return a;
}

Console.WriteLine(MultiDigital(num));