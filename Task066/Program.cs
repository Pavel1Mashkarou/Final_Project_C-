/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int GetNumber(string arg)
{
    System.Console.WriteLine($"Введите {arg}");
    return int.Parse(Console.ReadLine());
}
int PrintNum(int m, int n)
{
    int summ=m;
    if (m<n)
    {
        return summ+PrintNum(m+1,n);
    }
    return summ;
    
}
int m =GetNumber("M");
int n =GetNumber("N");


System.Console.WriteLine(PrintNum(m,n));

