using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

class Yl7 {
    public static void Main(string[] arg) {
            string[] nimed = {"Marten", "Karmo", "Rasmus", "Jon",
            "Martin", "Eliis", "Mihkel", "Alex"
            };

            IEnumerable<string> names = nimed;
            var grupid=from name in names group name by name.Length;
            foreach(var grupp in grupid){
	   Console.WriteLine("Pikkus "+grupp.Key+" nimed "+String.Join(" ",grupp));
	 }
            
            
}
}