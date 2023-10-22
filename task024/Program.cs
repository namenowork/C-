// 24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// Console.Clear();
// // Взять число, найти его квадрат и вчислить корень квадратный из получившегося числа
// int usera = 4;

// double Num(int a)
// {
//     double result = Math.Pow(a, 2);
//     return result;
// }

// void Num1(int a)
// {
//     double result = Math.Pow(a, 2);
//     System.Console.WriteLine(result);
// }

// double userresult = Num(usera);
// double root = Math.Sqrt(userresult);
// System.Console.WriteLine(root);
// System.Console.WriteLine(userresult);

// Num1(usera);
using System;
Console.Clear();

System.Console.WriteLine("Please, enter the number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Sum(int a)
{
    int result = 0;
    for (int i = 1; i < a+1; i++)
    {
        result = result + i;
    }
    return result;
}

System.Console.WriteLine($"Sum of all natural numbers from 1 to your entered number {userNumber} is: {Sum(userNumber)}");