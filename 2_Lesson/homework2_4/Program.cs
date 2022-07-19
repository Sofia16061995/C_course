Console.Write("Enter the number indicating the day of the week: ");
int n = int.Parse(Console.ReadLine());

if (n < 1 || n > 7)
{
    Console.WriteLine("Invalid value");
}
else
{
    if (n < 6)
    {
        Console.WriteLine("It`s a weekday");
    }
    else
    {
        Console.WriteLine("It`s a weekend");
    }
}