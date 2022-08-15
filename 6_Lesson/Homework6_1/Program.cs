int m = 5;
Console.Write($"Введите {m} целых чисел через пробел: ");
string new_str = Console.ReadLine();

while (new_str.Split().Length != m)
{   
    Console.WriteLine($"Введено неверное количество чисел - {new_str.Split().Length} ");
    Console.WriteLine($"Пожалуйста, обратите внимание, что необходимо ввести {m} чисел: ");
    Console.Write($"Введите {m} целых чисел через пробел: ");
    new_str = Console.ReadLine();
}

int[] arr = Array.ConvertAll(new_str.Split(), int.Parse);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Из них {count} больше 0 ");
