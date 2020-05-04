using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace linq2 {
    class Andmed {
        string x;
        int y;
        public Andmed(string ux, int uy) {
            x = ux; y = uy;
        }
        public string KysiX() { return x; }
        public int KysiY() { return y; }
        public override String ToString() { return "(" + x + " " + y + ")"; }
    }
    
    class Klassid {
        public static void Main(string[] arg) {
            Andmed[] data = { 
                new Andmed("Marten", 186),
                new Andmed("Karmo", 188),
                new Andmed("Jon", 182),
                new Andmed("Eliis", 168),
             };
            IEnumerable<Andmed> vastus = 
			     from p in data where p.KysiY() < 180 select p;
           Console.WriteLine(string.Join(" ", vastus));

            IEnumerable<Andmed> vastus2 = 
			     from p in data where p.KysiY() > 0 select p;
             Console.WriteLine("Kasvavalt sorditult "+ 
               string.Join(" ",vastus2.OrderBy(p => p.KysiY())));
            //

        }
    }
}