﻿/* написать программу, которая выводит случайное число из интервала [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8

23 / 10 = 2
23 % 10 = 3
*/

int num = new Random().Next(10, 100); // в num запишется новое случ.число в заданном диапазоне до 99 включ.
int a1 = num % 10;
int a2 = num / 10;

int max = a1;
if (a1 > max) {
    max = a2;
}

Console.Write($"Максимальная цифра {max} числа {num}");
