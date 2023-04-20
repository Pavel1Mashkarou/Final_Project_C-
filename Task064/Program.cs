/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int GetNumber()
{
    System.Console.WriteLine("Введите N");
    return int.Parse(Console.ReadLine());
}
void PrintNum(int m, int n)
{
    
if (n>=m)
{
    PrintNum(m+1, n);
    Console.Write(m+" ");
}
}
int n =GetNumber();
PrintNum(1, n);