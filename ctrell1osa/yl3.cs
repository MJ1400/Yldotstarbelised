using System;
public class Valik1{
   public static void Main(string[] arg){
      int normtemp=12;
      Console.WriteLine("Sisesta toatemperatuur: ");
      int temp=int.Parse(Console.ReadLine());
      if(temp < normtemp){
         Console.WriteLine("Teie toatemperatuur on väiksem kui soovitatav toasoojus talvel!");
      } else if(temp > normtemp) {
        Console.WriteLine("Teie toatemperatuur on kõrgem kui soovitatav toasoojus talvel!");
      } else if(temp == normtemp) {
        Console.WriteLine("Teie toatemperatuur on perfektne!");
      } 
      
   }
}