//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
void LineOfDigits(int m, int n)
{
    if (n < m)
    {
        return;
    }
    Console.Write($"{m} ");
    LineOfDigits(m + 1, n);
    
}
Console.WriteLine("Введите первое число : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число : ");
int n = Convert.ToInt32(Console.ReadLine());

LineOfDigits(m, n);
