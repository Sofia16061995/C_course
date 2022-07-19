int DeleteSecondDigit(int Number)
{
    int FirstN = Number / 100;
    int ThirdN = Number % 10;
    return FirstN * 10 + ThirdN;
}

int a = new Random().Next(100,1000);
Console.WriteLine(a);

Console.WriteLine(DeleteSecondDigit(a));