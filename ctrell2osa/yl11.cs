using System;
namespace Lapid2{
   class Lapp{
       private int x;
       private int y;
       private string z;
       public Lapp(int ux, int uy, string uz){
         x=ux; y=uy; z=uz;
       }
       public string GetColor(){
         return z;
       }
       public double Pindala(){
         if(x == y) {
           return (x*y);
         } else {
           return (x*y/2);
         }
       }
   }
   class Lapiproov{
     public static void Main(string[] arg){
         Lapp l1=new Lapp(5, 5, "sinine");
         Console.WriteLine("Lapi pindala on " + l1.Pindala() + " ja v2rv on " + l1.GetColor());
     }
   }
}