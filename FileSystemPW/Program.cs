using System;
using System.Collections.Generic;
using System.IO;

namespace FileSystemPW
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> stat = new Dictionary<char, int>();
            string path = @"C:\Visual Studio 2019\Code Snippets\Visual C#\My Code Snippets\2.txt";
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                string data = System.Text.Encoding.Unicode.GetString(bytes);
                foreach (char symbol in data)
                {
                    if (stat.ContainsKey(symbol))
                    {
                        stat[symbol]++;
                    }
                    else
                    {
                        stat[symbol] = 0;
                    }
                }
            }
            foreach (KeyValuePair<char, int> item in stat)
            {
                Console.WriteLine(item.Key + "\t\t" + item.Value);
            }
            Console.ReadLine();
        }
    }
}
