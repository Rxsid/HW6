// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите сторону b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите сторону k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите сторону b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double xcoord = 0.000;
double ycoord = 0.000;
if (Lines( k1, b1, k2, b2))
{
    double[] coord = FindCoord(k1, b1, k2, b2);
    Console.Write($"Точка пересечения уравнений y={k1}*x+{b1} и y={k2}*x+{b2}");
    Console.WriteLine($"Имеет координаты ({coord[xcoord]}, {coord[ycoord]})");
}

double[] FindCoord(double k1, double b1, double k2, double b2)
{
    double[] coord = new double [2];
    coord[xcoord] = (b2 - b1)/(k1 - k2);
    coord[ycoord] = k1 * coord[xcoord] + b1;
    return coord; 
}

bool Lines(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
             Console.WriteLine("Прямые паралельны");
            return false;
        }
    }
    return true;
}



