using System.Text;
using System;

namespace stringbuffer
{
    class Program
    {
        static void Main(string[] args)
        {
            var buff=new StringBuilder();
            buff.Append('-',20)
            .AppendLine()
            .Append("Hello Sujeendra R")
            .AppendLine()
            .Append('-',20);
            System.Console.WriteLine(buff);

        }
    }
}
