using System;
using System.IO;

namespace FileDataRetrieve
{
    class Program
    {
        static void showdata(string fileName)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            foreach (var item in arrLine)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your File Name:\n");
            string sourceFile = Console.ReadLine();
           // var myfile = File.Create(sourceFile);
         //   Console.WriteLine("CREATED...\n");
           // myfile.Close();
            if (!(File.Exists(sourceFile)))
            {
                Console.WriteLine("FILE DO NOT EXIST...\n");
            }
            else
            {
                Console.WriteLine("\nFILE DATA:\n");
                showdata(sourceFile);
            }
        }
    }
}
