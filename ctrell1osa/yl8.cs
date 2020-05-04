using System;
using System.IO;
class Failikirjutus{
  public static void Main(string[] arg){
            FileStream f = new FileStream("ruudud.txt", 
                            FileMode.Create, FileAccess.Write);
            StreamWriter valja = new StreamWriter(f);
            for(int nr=1; nr<=20; nr++){
                valja.WriteLine(nr + "-" + nr*nr);
            }
            valja.Close();     
  }
}