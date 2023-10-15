/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
using System.Security.Cryptography;
int userNumber = 0;
while (userNumber < 1 || userNumber > 7)
{
    System.Console.WriteLine("Enter your number");
    userNumber = Convert.ToInt32(Console.ReadLine());
}
switch (userNumber)
{
    case 1:
        System.Console.WriteLine("No");
        break;
    case 2:
        System.Console.WriteLine("No");
        break;
    case 3:
        System.Console.WriteLine("No");
        break;
    case 4:
        System.Console.WriteLine("No");
        break;
    case 5:
        System.Console.WriteLine("No");
        break;
    case 6:
        System.Console.WriteLine("Yes");
        break;
    case 7:
        System.Console.WriteLine("Yes");
        break;
}