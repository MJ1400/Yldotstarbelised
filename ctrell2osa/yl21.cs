using System;
class Kellaaeg{
   int tund, minut, sekund; 
   public Kellaaeg(int utund, int uminut, int usekund){
      tund=utund; 
      minut=uminut;
      sekund=usekund;
      aegKorda();
   }
   void aegKorda(){
      while(minut>60){
         tund++;
         minut-=60;
      }
      while(sekund>60){
        minut++;
        sekund-=60;
      }
   }
   public int Tund(){return tund;}
   public int Minut(){return minut;}
   public int Sekund(){return sekund;}
   public void tryki(){
      Console.WriteLine("{0}:{1}:{2}", tund, minut, sekund);
   }
   public static Kellaaeg operator+(Kellaaeg k1, Kellaaeg k2){
      return new Kellaaeg(k1.tund+k2.Tund(), k1.minut+k2.Minut(), k1.sekund+k2.Sekund());
   }
}
class Test{
   public static void Main(string[] arg){
      Kellaaeg k1=new Kellaaeg(12, 10, 30);
      Kellaaeg k2=new Kellaaeg(1,  4, 20);
      Kellaaeg k3=k1+k2;
      k3.tryki();      
   }
}