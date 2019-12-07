using System.IO;
using System;
namespace Hello{
class Program
{
    static void Main(string [] args)
    {
        var person=new Person();
        Console.WriteLine(person.add(2,3));
    }
}
public class Person{
    public int add(int a,int b)
    {
        return a+b;
    }
}
}
