﻿int Method_1(int N)
{
   return N % 100 / 10;
}
Console.Write("Write a three-digit number N: ");
int n = int.Parse(Console.ReadLine());

if (n > 999 ^ n < 100)
{
    Console.Write("Invalid value N");
}
else
{
    Console.WriteLine(Method_1(n));
}
