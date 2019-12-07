using System;

namespace TextEditing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Note string is immuable
            1.parsing of string to int and viceversa 
            2.trimming and substring 
            3.replace character or string
            4.Splitting based on space using two approaches-->one using split(),other using indexof with substring
            5.Checking null or whitespace in the string 
             */
            var str="12";
            var nu=Convert.ToInt32(str);//doesnt throw exception if empty string
            System.Console.WriteLine(nu);
            var no=int.Parse(str);
            var Str=no.ToString("C");
            System.Console.WriteLine(Str);

            var Trim="Sujeendra R :";//immutabe string
            System.Console.WriteLine(Trim.Trim());
            var names=Trim.Split(" ");
            System.Console.WriteLine(names[0]+":"+names[1]);

            System.Console.WriteLine(Trim.Replace('S','s'));
            System.Console.WriteLine(Trim.Substring(0,5));

            System.Console.WriteLine(String.IsNullOrWhiteSpace(" "));
        }
    }
}
