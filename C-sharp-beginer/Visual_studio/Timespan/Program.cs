using System;

namespace Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timespan=new TimeSpan(1,2,3);
            var time1=TimeSpan.FromMinutes(2);
            System.Console.WriteLine(timespan.Add(time1));
            System.Console.WriteLine(timespan.TotalMinutes);
            var start=DateTime.Now.AddMinutes(2);
            var end=DateTime.Now;
            var diff=start-end;
            System.Console.WriteLine(diff);
            //parse
            System.Console.WriteLine(TimeSpan.Parse("01:20:31"));
        }
    }
}
