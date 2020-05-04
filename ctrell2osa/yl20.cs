using System;
namespace Indekseering1{
 class Kuubiarvutus{
   public int this[int nr]{
      get{return nr*nr*nr;}
   }
 }
 class Test{
  public static void Main(string[] arg){
     Kuubiarvutus r=new Kuubiarvutus();
     Console.WriteLine(r[3]);
  }
 }
}