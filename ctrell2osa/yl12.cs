using System;
namespace Punktid5{
   class Punkt{
       private int x;
       private int y;
       public Punkt(int ux, int uy){
         x=ux; y=uy;
       }
       public int GetX(){
         return x;
       }
       public int GetY(){
         return y.Value;
       }
   }
   class Punktiproov{
     public static void Main(string[] arg){
         Console.WriteLine("Sisesta mitu lappi tahad lisada");
         int lapiarv = int.Parse(Console.ReadLine());
         Punkt[] pd=new Punkt[lapiarv];
         for(int i=0; i<lapiarv; i++){
            Console.WriteLine("Sisesta lapi pikkus");
            int lapipikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta lapi laius");
            int lapilaius = int.Parse(Console.ReadLine());
            pd[i]=new Punkt(lapipikkus, lapilaius);
         }
        double pindalad = 0;
         for(int j=0; j<lapiarv; j++){
            pindalad = pindalad + (pd[j].GetX.Value * pd[j].GetY.Value / 2);
     }
   }
}
}