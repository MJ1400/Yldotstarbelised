using System;
namespace AbstraktseKlassiUuring{
 abstract class Kujund{   
   public abstract double KysiPohjaPindala();
   public abstract double KysiKorgus();
   public double KysiRuumala(){
      return KysiPohjaPindala()*KysiKorgus();
   }
 }
 class Tikutops:Kujund{
   public override double KysiPohjaPindala(){return 8;}
   public override double KysiKorgus(){return 1.5;}
 }

 class Risttahukas: Kujund {
     int pikkus, laius, k6rgus;
     public Risttahukas(int upikkus, int ulaius, int uk6rgus){
         pikkus = upikkus;
         laius = ulaius;
         k6rgus = uk6rgus;
     }

     public override double KysiKorgus(){
         return k6rgus;
     }
     public override double KysiPohjaPindala(){
         return pikkus*laius/2;
     }
 }
   
 
 class Vorstijupp: Kujund{
   int pikkus, raadius;
   public Vorstijupp(int upikkus, int uraadius){
      pikkus=upikkus;
      raadius=uraadius;
   }
   public override double KysiPohjaPindala(){
     return Math.PI*raadius*raadius;
   }
   public override double KysiKorgus(){
     return pikkus;
   }
 }
 class Test{
   public static void Main(string[] arg){
      Tikutops t=new Tikutops();
      Vorstijupp v=new Vorstijupp(10, 3);
      Risttahukas r = new Risttahukas(5, 3, 2);
      Console.WriteLine("Ruumalad {0} ja {1} ja risttahuka k6rgus on {2}", 
                t.KysiRuumala(), v.KysiRuumala(), r.KysiKorgus());
   }
 }
}