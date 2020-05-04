using System;
using System.Collections.Generic;
class GeneerilineList{
        static void Main(string[] args)
        {
            LinkedList<int> loetelu = new LinkedList<int>();
            while(loetelu.Count < 5){
              Console.WriteLine("Sisesta arv");
              int arv = int.Parse(Console.ReadLine());
              loetelu.AddLast(arv);
            }
            LinkedList<int>.Enumerator ahel = loetelu.GetEnumerator();
            while (ahel.MoveNext()) {
                Console.WriteLine(ahel.Current);
            }
        }
}