﻿using System;
using System.Collections.Generic;
using System.Linq;

class Yl1 {
    public static void Main(string[] arg) {
            int[] m = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20, 19};
            Console.WriteLine("Tagurpidi: " + string.Join(" ", m.Reverse()));
            Console.WriteLine("Suurim: " + string.Join(" ", m.Max()));
}
}