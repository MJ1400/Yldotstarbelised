using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class MainClass {
  public static void Main (string[] args) {
   List<int[]> tnds = new List<int[]>();
using(StreamReader reader = File.OpenText("tnd.txt"))
{
    while(!reader.EndOfStream)
    {
        string line = reader.ReadLine();
        tnds.Add(line.Split(' ')
            .Select(int.Parse).ToArray());
    }
}
var myArray = tnds.ToArray();

foreach(int[] l in myArray){
  Console.WriteLine(l[0]);
}
}
}

// http://minitorn.tlu.ee/~jaagup/kool/java/kursused/20/yldotstarbelised_arendusplatvormid/03ctrell/linq.txt