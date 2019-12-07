using System.IO;
using System;

class Program
{
   public enum season{
       summer,
       winter,
       automn,
       
   }

    static void Main()
    {
        var sw=season.automn;
      switch(sw){
        case season.automn:
        case season.summer:
            Console.WriteLine("Checking or removing redundant statements from both the cases");
            break;
        default: Console.WriteLine("Default");
        break;
        
          
      }
    }
   
    
}
