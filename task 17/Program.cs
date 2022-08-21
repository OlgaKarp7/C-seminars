//Написать задачу, которая принимает на вход координаты точки (X, Y), причем x!= 0 и y!= 0 и выдает номер четверти плоскост, в которой находится эта точка.

Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.Write("1");
}
if (x < 0 && y > 0)
{
    Console.Write("2");
}
if (x < 0 && y < 0)
{
    Console.Write("3");
}
if (x > 0 && y < 0)
{
    Console.Write("4");
}