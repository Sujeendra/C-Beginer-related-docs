using System;
using System.Collections.Generic;
namespace Visual_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays 2-D,Rectangular ,Jagged variable--array szies
            /*var array=new int[3,5];
            var aray=new int[3][];
            aray[0]=new int[2];
            aray[1]=new int[1];
            aray[2]=new int[5];*/
            /*1.IndexOf 2.Copy 3.Sort 4. Reverse 5.Clear 6. LastIndexOf */
            var array=new int[5]{1,8,9,10,1};
            Console.WriteLine( Array.IndexOf(array,1)+" "+Array.LastIndexOf(array,1));
            //var items=new int[3];
            //Array.Copy(array,items,3);
            Array.Clear(array,0,1);
            Array.Sort(array);
            foreach (var item in array)
            {
            Console.WriteLine(item);
            }
            //Dynamic add or remove with List
            var list=new List<int>(){1,2,3,4};
            list.Add(5);
            list.AddRange(array);
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
            
        }
    }
}
