using System;
class Nimed{
   public static void Main(string[] arg){
      Console.WriteLine("Esimene arv:");
      double arv1=double.Parse(Console.ReadLine());
      Console.WriteLine("Teine arv:");
      double arv2=double.Parse(Console.ReadLine());
      Console.WriteLine((arv1 + arv2) / 2);
   }
}