using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Yl4 {
    public static void Main(string[] arg) {
            int[] m1 = File.ReadAllLines("pikkused.txt").Select(int.Parse).ToArray();
            Console.WriteLine("Suurim: " + string.Join(" ", m1.Max()));
            
            
}
}