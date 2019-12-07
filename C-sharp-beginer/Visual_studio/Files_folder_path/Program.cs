using System;
using System.IO;
using System.Collections.Generic;
namespace Files_folder_path
{
    class Program
    {
        static void Main(string[] args)
        {
            //File-static FileInfo-instantiation-security check
            //using verbatim string principle
            var path=@"/home/sujeendra/Desktop/Visual_studio/Files_folder_path/file.txt";
            var read="";
            if (File.Exists(path)){
                read=File.ReadAllText(path);
                //System.Console.WriteLine(read);
            }
            else{
                System.Console.WriteLine("File doesnt exists");
            }
            //to find the number of words in a file
            var Splitted=read.Split(" ");
            
            //System.Console.WriteLine(Splitted.Length);
            var length=0;
            foreach (var item in Splitted)
            {   length++;
                //System.Console.WriteLine(item);
            }
            System.Console.WriteLine(length);
            //Displaying longest word in the file
            var len=new List<int>();
            foreach (var item in Splitted)
            {   
                len.Add(item.Length);
            }
            var max=len[0];
            var index=0;
            int i;
            for(i=0;i<len.Count;i++)
            {
                if(len[i]>max)
                {
                    max=len[i];
                    index=i;
                }
            }
            System.Console.WriteLine(Splitted[index]);
            //For directories also same rules
            System.Console.WriteLine(Path.GetDirectoryName(path));
            
        }
    }
}
