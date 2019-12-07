using System;
using System.Collections.Generic;
namespace summarizingThetext
{
    class Program
    {
        static void Main(string[] args)
        {
            var text="It is ready to rock rock rock rock rock and roll roll roll roll";
            if(text.Length<5){
                System.Console.WriteLine("Invalid");
            }
            else{
                var list=new List<string>();
                var split=text.Split(" ");
                var textLength=0;
                foreach (var item in split)
                {
                    list.Add(item);
                    if(textLength>5){
                        break;
                    }
                    textLength++;
                }
                System.Console.WriteLine(String.Join(" ",list)+"....");
            }
            
        }
    }
}
