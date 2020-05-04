using System;
namespace Lapid2{
   struct Lapp{
       public int pikkus;
       public int laius;
       public string toon;
   }
   class Lappideproov{
     public static void Main(string[] arg){
         Lapp[] lapid=new Lapp[10];
         for(int i=0; i<3; i++){
         Console.WriteLine("Sisesta lapi pikkus");
         lapid[i].pikkus=int.Parse(Console.ReadLine());
         Console.WriteLine("Sisesta lapi laius");
         lapid[i].laius=int.Parse(Console.ReadLine());
         Console.WriteLine("Sisesta lapi toon");
         lapid[i].toon=Console.ReadLine();
         }
        Console.WriteLine("Sisesta mitmenda lapi kohta soovid informatsiooni");
        int mitmeslapp = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine(lapid[mitmeslapp].pikkus);
        Console.WriteLine(lapid[mitmeslapp].laius);
        Console.WriteLine(lapid[mitmeslapp].toon);
        
     }
   }
}