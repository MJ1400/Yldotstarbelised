using System;
class Tykeldamine{
   public static void Main(string[] arg){
            Console.WriteLine("Sisesta nimi");
            String nimi=Console.ReadLine();
            int i = nimi.Length - 2;
            Console.WriteLine(i);
            Console.WriteLine(nimi[i]);
        }

   }

