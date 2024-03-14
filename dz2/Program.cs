//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
static int ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return ackermann(m - 1, ackermann(m, n - 1));
    }
    return -1;
}
Console.WriteLine("Введите число m : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число n : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(ackermann(m, n));
