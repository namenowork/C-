﻿System.Console.WriteLine("Введите номер четверти: ");
int userCvoter = Convert.ToInt32(Console.ReadLine());
if(userCvoter == 1)
{
    System.Console.WriteLine("Все X и Y больше 0");
}
if(userCvoter == 2)
{
    System.Console.WriteLine("Все X меньше 0, Y больше 0");
}
if(userCvoter == 3)
{
    System.Console.WriteLine("Все X и Y меньше 0");
}
if(userCvoter == 4)
{
    System.Console.WriteLine("Все X больше и Y меньше 0");
}