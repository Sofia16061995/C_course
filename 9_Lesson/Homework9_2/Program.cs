void SumNum (int m, int n, int sum)
{
    if (n >= m) 
    {
        sum = sum + (m++);
        SumNum(m, n, sum);
        return;
    }
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
}

SumNum(1, 15, 0);
SumNum(4, 8, 0);

