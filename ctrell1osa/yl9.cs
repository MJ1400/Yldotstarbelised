using System;

public class Juhuarv{
   public static void Main(string[] arg){
      Random r=new Random();
      while(true){
      int arv = r.Next(10); //Täisarv alla 10
      Console.WriteLine("Arva suvaline number 2ra");
      int arvamus = int.Parse(Console.ReadLine());
      if(arvamus == arv) {
        Console.WriteLine("Arvasid õige numbri ära!");
        break;
      } else {
        Console.WriteLine("Vale number! Proovi uuesti");
      }
     }
   }
}