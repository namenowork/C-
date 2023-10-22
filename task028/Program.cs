// 28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
using System;
Console.Clear();

System.Console.WriteLine("Please, enter the number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int multiplayer(int a)
{
    result = 1
    if (a < 0 && a%2 == 0) a = a * -1;
        for (int i = 1; i < a+1; i++)
            {
                result = result * i;
            }
        return result;

    if (a < 0 && a%2 != 0 )    
        for (int i = 1; i < a + 1; i++)
            {
                result = result * i;
            }
        return = result * -1; 
        return result;
    if (a > 0)
    for (int i = 0; i < length; i++)
    {
        
    }

}

System.Console.WriteLine($"Sum of all natural numbers from 1 to your entered number {userNumber} is: {multiplayer(userNumber)}");