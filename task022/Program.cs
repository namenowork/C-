﻿/*
22. 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
Console.Clear();
System.Console.WriteLine("Введите число: ");
int userNumber = int.Parse(Console.ReadLine());
for (int i = 1; i <= userNumber; i++)
{
    System.Console.WriteLine($"{i} * {i} = {Math.Pow(i, 2)}");
}