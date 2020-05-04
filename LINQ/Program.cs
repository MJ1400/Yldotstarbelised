using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class MainClass {
  public static void Main (string[] args) {
   double totaltemp = 0;
   double avgtemp;
   int maxtemp = 0;
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
  totaltemp = totaltemp + l[1];
  if(maxtemp < l[1]){
    maxtemp = l[1];
  }
}
avgtemp = totaltemp / tnds.Count;
string[] lines = {avgtemp.ToString(), maxtemp.ToString()};
System.IO.File.WriteAllLines(@"output.txt", lines);
Console.WriteLine(maxtemp);

}
}

// http://minitorn.tlu.ee/~jaagup/kool/java/kursused/20/yldotstarbelised_arendusplatvormid/03ctrell/linq.txt