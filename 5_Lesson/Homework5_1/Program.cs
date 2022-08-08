void Print(int[] arr)
 {
     int size = arr.Length;

     for (int i = 0; i < size; i++)
     {
         Console.Write($"{arr[i]} ");
     }
     Console.WriteLine();
 }

 int[] MassNums(int size)
 {
     int[] arr = new int[size];

     for (int i = 0; i < size; i++)
     {
         arr[i] = new Random().Next(100, 999);
     }
     return arr;
 }

 int Even (int[] arr)
 {   
     int quontity = 0;
     for (int i = 0; i < arr.Length; i++)
     {
         if (arr[i] % 2 == 0)
         {
             quontity += 1;            
         }
     }
     return quontity;    
 }

 int[] arr_1 = MassNums(10);
 Print(arr_1);
 Console.WriteLine(Even(arr_1));

