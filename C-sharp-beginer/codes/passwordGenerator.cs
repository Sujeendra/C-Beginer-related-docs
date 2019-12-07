using System.IO;
using System;

class Program
{
 

    static void Main()
    {
        
        //Random class
        const int PasswordLength=8;
        var buffer=new char[PasswordLength];
        var random=new Random();
        for(var i=0;i<PasswordLength;i++){
            buffer[i]=(char)('a'+random.Next(1,26));
        }
        var str=new string(buffer);
        Console.WriteLine(str);
    }
   
    
}
