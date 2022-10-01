// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int PrintNumbers(int n, int m)
{
   
if (n == m)
    return m;
return PrintNumbers(n - 1, m) + n;
}


Console.WriteLine(PrintNumbers(8, 4));
