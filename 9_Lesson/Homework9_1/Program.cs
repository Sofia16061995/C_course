void Num2(int min, int max)
{
    max-=max%2;
    if (max<min) return;
    Num2(min,max-2);
    Console.Write($"{max}, ");
}

Num2(3,9);
