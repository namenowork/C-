Console.Clear();
System.Console.WriteLine("Введите координаты точки A (x, y): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B (x, y): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());

//int squareX = (userBx - userAx) * (userBx - userAx);
//Math.Pow(a, 3) - Возводит в степень, (что возводим в степень, в какую степень)
double squareX = Math.Pow(userBx - userAx, 2);
double squareY = Math.Pow(userBy - userAy, 2);
double rootXY = Math.Sqrt(squareX + squareY);
//Math.Sqrt() - находит квадратный корень
//Math.Round(a, 2) - огругление числел после запятой, (число, сколько чисел после запятой поставить)
System.Console.WriteLine(Math.Round(rootXY, 2));