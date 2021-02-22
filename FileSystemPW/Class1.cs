using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileSystemPW
{
    class Class1
    {
        static void Main(string[] args)
        {
            string path = @"C:\Visual Studio 2019\Code Snippets\Visual C#\My Code Snippets\pwtask2.txt";
            using (StreamWriter stream = new StreamWriter(path))
            {
                stream.WriteLine("Farhat");
                stream.WriteLine("Bolatuly");
                stream.WriteLine("35");
            }
        }
    }
}
