void polindrome (string s )
 {
     for (int i = 0; i < s.Length / 2; ++i)
         if (s[i] != s[s.Length - 1 - i]) Console.WriteLine ("не палиндром");
         else Console.WriteLine ("палиндром");
 };
 var v = 14821;
 var s = v.ToString();
 polindrome (s);

