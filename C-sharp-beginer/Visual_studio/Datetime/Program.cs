using System;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            var now=DateTime.Now;
            var today=DateTime.Today;
            var datetime=new DateTime(2015,1,1);//to build datetime
            
            //Console.WriteLine(now.AddDays(1));
            //Console.WriteLine(now.AddDays(-1));//to get current time and date information
            System.Console.WriteLine(datetime.ToString());
            System.Console.WriteLine(today.ToString());
        }
    }
}
