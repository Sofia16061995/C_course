Console.WriteLine("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

// double x = ((b2-b1) / (k1 - k2));
// почему-то вышеприведенную формулу считает как 0, а не - 0,5

double q=b2-b1;
double w = k1-k2;
double x = q/w;

double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения [{x}, {y}]");
