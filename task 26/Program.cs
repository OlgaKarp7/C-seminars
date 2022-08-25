/*Написать программу, которая принимает на вход число и выдает кол-во цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

Console.Write(" Введите число: ");
int num = int.Parse(Console.ReadLine());

int DigitCount(int a)
{
    int count= 0;
    while(a > 0)
    {
        count++;
        a /= 10;  //a = a / 10; 
    }
    return count;
}

Console.Write(DigitCount(num));