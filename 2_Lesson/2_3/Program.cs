void Checking (int a, int b)
{
    if (a % b == 0)
    Console.WriteLine($"{a} multiple {b}");
    else
    Console.WriteLine($"{a} not multiple {b}, remainder of the division {a % b}");
}
Checking (15,4);
