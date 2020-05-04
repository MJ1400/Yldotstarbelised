using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Yl5 {
  public static string changeLetter(string tekst) {
              char first = tekst[0];
              char second = tekst[tekst.Length - 1];
              StringBuilder tekst2 = new StringBuilder(tekst);
              tekst2[0] = second;
              tekst2[tekst2.Length - 1] = first;

              return tekst2.ToString();
    }

    public static void Main(string[] arg) {
            String[] enimed = {"Marten", "Karmo", "Rasmus", "Jon", "Martin", "Markus", "Mihkel", "Sven"};

        IEnumerable<string> vastus=enimed.Select(changeLetter);
        foreach(String element in vastus){
          Console.WriteLine(element);
        } 

            
}
}