using System;
using System.Collections;
class Kollektsioon1a{
   public static void Main(string[] arg){
      ArrayList arvud=new ArrayList();
      while(true) {
        Console.WriteLine("Sisesta arv: ");
        int arv = int.Parse(Console.ReadLine());
        if(arv == 0){
          break;
        } else {
          arvud.Add(arv);
        }
      }
      for(int i=arvud.Count-1; i>=0; i--){
          Console.WriteLine(arvud[i]);
      }
   }
}