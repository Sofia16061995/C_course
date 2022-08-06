int Nums (int a, int b)

 {
     int exponentiation = a;
     for(int i = 1; i<b; i++)
     exponentiation = exponentiation * a;
     return exponentiation;
 }

 Console.WriteLine(Nums(3, 5));
 Console.WriteLine(Nums(2, 4));

