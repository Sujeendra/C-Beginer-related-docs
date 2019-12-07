using System.IO;
using System;

class Program
{
    public class Person{
        public int age;
    }

    static void Main()
    {
       //Reference pass the object
       var person=new Person(){age=10};
       Age(person);
       Console.WriteLine(person.age);
    }
    static void Age(Person person){
        person.age+=20;
    }
}
