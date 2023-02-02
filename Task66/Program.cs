// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int NaturSum(int m, int n)
{
    if (m == n)
        return n;
    else if (m > n)
        return 0;
    return n + NaturSum(m, n - 1);
}

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

