/*Напишите программу, которая на вход приимает число (А) и выдает сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(GetSumNums(num));

int GetSumNums(int num)
{
    int sum = 0;
    //i = i + 1; i += 1
    for (int i = 1; i <= num; i++)
          {
            sum += i; // sum = sum + i
          }
          return sum;
}

