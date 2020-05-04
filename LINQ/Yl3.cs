using System;
using System.Collections.Generic;
using System.Linq;

class Yl3 {
    public static void Main(string[] arg) {
            int[] m = {160, 165, 181, 178, 170, 179, 180, 182, 190, 167, 179, 200, 110, 156, 177, 170};
            Console.WriteLine("Pikemad kui 180: " + m.Count(a => a > 180));
            Console.WriteLine("Pikkusted j2rjekorras "+ 
               string.Join(" ",m.OrderBy(a => a)));
}
}