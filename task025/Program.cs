// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16
// Exponentation - возведение в степень 
void Exponentation(int a, int b)
{
    //double result = Math.Pow(a, b);
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    System.Console.WriteLine(result);
}