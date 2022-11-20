// Задача 22
// написать программу
// 1. принимает число на вход n
// 2. выдаёт таблицу квадратов

// 5 -> 1,4,9,16,25.
// 2 -> 1,4.

Console.WriteLine("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void Qaudro(int num)
{
    int num1 = 1;
    while (num1 <= num)
    {
        int result = num1 * num1;
        Console.Write($"{num1}  ");
        Console.WriteLine(result);
        num1++;
    }
}
if (N > 0)
    Qaudro(N);// ,без печати потому что метод void!!!
else
    Console.WriteLine("Некоректный ввод");
