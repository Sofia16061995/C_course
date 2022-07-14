Console.Clear();
Console.WriteLine("Задача 7 ");
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("последняя цифра этого числа -> "+stringNumber[1]);
