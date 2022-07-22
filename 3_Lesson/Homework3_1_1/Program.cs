Console.Write("Write a five-digit number N: ");
 string n = Console.ReadLine();

 if (n.Length != 5)
 {
     Console.WriteLine("You didn't write a five-digit number");
 }
 else
 {
     if (n[0] == n[4] && n[1] == n[3])
     {
        Console.WriteLine("The number is a palindrome");
     }
     else
     {
         Console.WriteLine("The number is not a palindrome");
     }
 }
