// // 20.
// // написать программу
// // 1. принимает на вход координаты 2х точек
// // 2. находит между ними расстояние в 2D пространстве

// // A(3,6);B(2,1)->5,09
// // A(7,-5);B(1,-1)->7,21

// Console.WriteLine(Math.Sqrt(25));//корень квадратный
// double n = 5.0995145468431654;
// double res = Math.Round(n, 2, MidpointRounding.ToZero);//округление до 2х знаков после запятой
// Console.WriteLine(res);

Console.WriteLine("Введите координаты точки A:");
Console.Write("x1= : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1= : ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("x2= : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2= : ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int xb, int ya, int yb)
{
    double result = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
    return result;
}
double res = Distance(x1, x2, y1, y2);
double r = Math.Round(res, 2, MidpointRounding.ToZero); //округление до 2х знаков после запятой
Console.WriteLine(r);
