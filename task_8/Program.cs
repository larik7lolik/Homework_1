﻿//Задача 8: Показать чётные числа от 1 до N.

Console.Write("Введите число: ");

int N = int.Parse(Console.ReadLine());
int i = 2;
while(i <= N)
{
    Console.WriteLine( i );
    i+=2;
}
