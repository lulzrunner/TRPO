using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StreamReader file = new StreamReader("in.txt");
            StreamWriter fileOut = new StreamWriter("out.txt");
            string text = file.ReadToEnd();
            string[] words = text.Split(' ');
            Regex regex = new Regex(@"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d");
            foreach (string word in words)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine("Найдена дата: " + word);
                    fileOut.WriteLine(word);
                }
            }
            file.Close();
            fileOut.Close();
            Console.ReadLine();
        }
    }
}