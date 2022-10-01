// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int PrintNumbers(int m, int n)
{ 
if (m == 0)
    return n + 1;
if (m > 0 && n == 0)    
    return PrintNumbers((m - 1), 1);
return PrintNumbers((m - 1), PrintNumbers(m, n - 1));
}
Console.WriteLine(PrintNumbers(3, 2));
