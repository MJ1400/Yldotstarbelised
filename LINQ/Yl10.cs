using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {
    foreach(var path in Directory.GetFiles(@"C:\Test\"))
{
   Console.WriteLine(System.IO.Path.GetFileName(path));
}
  }
}