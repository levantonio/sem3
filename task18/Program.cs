// 17.дописать программу, которая
// 1. Принимает на вход четверть,
// 2. причём Х!=0; и У!=0;
// 3. Выдаёт диапазон возможных координат
//                      ^У+
//                   2  |  1
//               _______|_______>Х+
//               -       |0
//                   3  |-  4


Console.WriteLine("Введите номер четверти: ");

string number = Console.ReadLine();

string Diapason(string num)
{
    if (num == "1")
        return "Координата Х > 0 и координата У > 0 ";
    if (num == "2")
        return "Координата Х < 0 и координата У > 0 ";
    if (num == "3")
        return "Координата Х < 0 и координата У < 0 ";
    if (num == "4")
        return "Координата Х > 0 и координата У < 0 ";

    return "Введены некоретные данные";
}

string diapason = Diapason(number);

Console.WriteLine(diapason);
