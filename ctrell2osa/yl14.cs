using System;
namespace Parilus2{
 class Inimene{
   protected int vanus;
   protected int pikkus;
   public Inimene(int uvanus, int upikkus){
      vanus=uvanus; pikkus = upikkus;
   }
   public void YtleVanus(){
      Console.WriteLine("Minu vanus on "+vanus+" aastat");
   }

   public void YtlePikkus(){
      Console.WriteLine("Minu pikkus on "+pikkus+" sentimeetrit");
   }
 }
 class Modell:Inimene {
   protected int ymberm66t;
   public Modell(int vanus,int pikkus, int uymberm66t):base(vanus, pikkus){
      ymberm66t=uymberm66t; 
   }
   public void Esitle(){
      YtleVanus();
      YtlePikkus();
      Console.WriteLine("Mu ymberm66duks on "+ymberm66t+" sentimeetrit");
   }
 }
 class InimTest{
  public static void Main(string[] arg){
     Modell m=new Modell(20, 90, 180);
     m.Esitle();
  }
 }
}