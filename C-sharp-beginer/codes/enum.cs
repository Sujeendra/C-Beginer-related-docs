using System;

class program
{
    public enum ShippingMethod{
        Express=3,
        something,
        special
        
    }
    static void Main()
    {
        //verbatim strings and format,join etc
        var method=@"sujee
        ndra
        R";
        //create an array
        int[] array=new int[3]{1,2,3};
        var st="something";
        Console.WriteLine((int)ShippingMethod.special+" "+method);
        var s=String.Format("{0},{1}","Yes",String.Join(",",array));
        
        Console.WriteLine(s);
        Console.WriteLine((ShippingMethod)Enum.Parse(typeof(ShippingMethod),st));
    }
}
