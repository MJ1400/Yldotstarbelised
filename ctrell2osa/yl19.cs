using System;
namespace Omadused2{
 class Ilmaandmed{
   private int temper;
   private int muudetud=0;
   private int loetud=0;
   public int Temperatuur{
      get{
        loetud++;
        return temper;
      }
      set{
        muudetud++;
        temper=value;
      }

   }
   public override string ToString(){
      if(temper > 35) {
          return "Hoiatus! Temperatuur on yle 35!";
      } else {
      return "Muudetud: "+muudetud+", loetud:"+ loetud+
                                     ", temperatuur:"+temper;
      }
   }
    
 }
 class Test{
   public static void Main(string[] arg){
      Ilmaandmed jaam1=new Ilmaandmed();
      jaam1.Temperatuur=36;
      Console.WriteLine(jaam1.Temperatuur);
      Console.WriteLine(jaam1.Temperatuur);
      Console.WriteLine(jaam1);
   }
 }
}