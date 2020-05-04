using System;
namespace Liides1{
 class Inimene{
   protected int vanus;
   public Inimene(int uvanus){
      vanus=uvanus;
   }
   public virtual void YtleVanus(){
      Console.WriteLine("Minu vanus on "+vanus+" aastat");
   }

 }
 interface IViisakas{
   void Tervita(String tuttav);

   void KoputaUksele(String tuttav);
 }
 class Laps:Inimene, IViisakas {
   public Laps(int vanus):base(vanus){}
   public void Tervita(String tuttav){
     Console.WriteLine("Tere, "+tuttav);
   }
  public void KoputaUksele(String tuttav) {
     Console.WriteLine("Koputan " +tuttav + " uksele!");
   }
 }
 class Koer: IViisakas{
   public void Tervita(String tuttav){
      Console.WriteLine("Auh!");
   }

   public void KoputaUksele(String tuttav) {
     Console.WriteLine("Auh!");
   }
 }
 class InimTest{
  static void TuleSynnipaevale(IViisakas v){
     v.KoputaUksele("vanaema");
     v.Tervita("vanaema");
  }
  public static void Main(string[] arg){
     Laps juku=new Laps(6);
     juku.YtleVanus();
     Koer muki=new Koer();
     TuleSynnipaevale(juku);
     TuleSynnipaevale(muki);
  }
 }
}