using System;
namespace Asendus{
 class Punkt{
   protected int x;
   protected int y;
   public Punkt(int ux, int uy){
      x=ux;
      y=uy;
   }

    public string TeataAndmed(){
       return ("(" + x.ToString() + ";" + y.ToString() + ")");
   }
   public string KaugusNullist(){
       x = x * -1;
       y = y * -1;
       return ("(" + x.ToString() + ";" + y.ToString() + ")");
   }

   ///public virtual void YtleVanus(){
   /// Console.WriteLine("Minu vanus on "+vanus+" aastat");
   ///}
 }
 class PunktiTest{
  public static void Main(string[] arg){
     Punkt p1 = new Punkt(2, 5);
     Console.WriteLine("Punkti kaugus nullist on: {1} ja punkti kordinaadid on {0}", 
                 p1.TeataAndmed(), p1.KaugusNullist());
  }
 }
}