using System;
using System.Collections.Generic;
using System.Linq;

class Yl2 {
    public static void Main(string[] arg) {
            int[] m1 = {44, 51, 22, 31};
            int[] m2 = {43, 25, 27, 44};
            int[] m3 = {60, 62, 67, 48};
            int[] m4 = m1.Concat(m2).ToArray();
            int[] m5 = m4.Concat(m3).ToArray();

            IEnumerable<int> erinevad = m5.Distinct();
            Console.WriteLine(string.Join(" ", erinevad));
}
}