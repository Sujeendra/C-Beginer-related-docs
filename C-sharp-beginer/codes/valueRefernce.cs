using System.IO;
using System;

class Program
{

    static void Main()
    {
        //value type primitive types vs Reference types
        var a=1;
        var b=a;
        b++;
        Console.WriteLine(String.Format("a: {0},b: {1}",a,b));
        
        //Reference type example
        
        var array1=new int[2]{1,2};
        var array2=array1;
        array2[0]=0;
        array2[1]=1;
        Console.WriteLine(array1[0]+" "+array1[1]);
    }
}
