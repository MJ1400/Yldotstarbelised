using System;
class Abivahendiproov{
   public static void Main(string[] arg){
       while(true) {
            Console.WriteLine("Sisesta arv mida soovid astendada");
            int arv1=int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta astendaja");
            int arv2=int.Parse(Console.ReadLine());
            Console.WriteLine(yl6abi.astenda(arv1, arv2));
            Console.WriteLine("Kas soovid j2tkata? (j/e)");
            String j2tka=Console.ReadLine();
            if(j2tka != "j") {
                break;
            }

        }

   }
}
