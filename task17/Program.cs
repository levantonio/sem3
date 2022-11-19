// 17.дописать программу, которая
// 1. Принимает на вход координаты точки (Х и У),
// 2. причём Х!=0; и У!=0;
// 3. Выдаёт номер четверти плоскости, в которой находится эта точка
//                      ^У+
//                   2  |  1
//               _______|_______>Х+
//               -       |0
//                   3  |-  4


Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc) //название метода.xc, yc- название переменных(х и у)
{
    if (xc > 0 && yc > 0)
        return 1;
    if (xc < 0 && yc > 0)
        return 2;
    if (xc < 0 && yc < 0)
        return 3;
    if (xc > 0 && yc < 0)
        return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result =
    quarter > 0
        ? $"Указанные координаты соответствуют четверти -> {quarter}"
        : "Введены некоретные координаты";

Console.WriteLine(result);
