using System;
class Erind5{
   public static int LoeArv(){
     while(true){
      Console.WriteLine("Palun arv:");
      string s=Console.ReadLine();
      int a=int.Parse(s);
      if(a>100){
        Console.WriteLine("Liiga suur arv!");
      } else {
        return a;
      }
     }
   }
   public static void Main(string[] arg){
     try{
      int arv1=LoeArv();
      Console.WriteLine("Kirjutati: "+arv1);
     }catch(FormatException probleem){
        Console.WriteLine("Viga teisendusel: "+probleem.Message);
     }
   }
}