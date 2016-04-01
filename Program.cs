using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace labka1
{
    class Program
    {
        static string File = @"C:\Users\Mike\Documents\Visual Studio 2015\Projects\lr1\321.txt";
        static string RReadFile()
        {
            string tmp = "";
            using (StreamReader sr = new StreamReader(File))
            {
                while (!sr.EndOfStream)
                {
                    tmp += sr.ReadLine();
                }
            }
            return (tmp);
        }
        static void Main(string[] args)
        {

            string pattern = @"\S+   \S+  ";
            string text = RReadFile();
            Console.WriteLine("Строка:");
            Console.WriteLine(text);
            RegexOptions option = RegexOptions.IgnoreCase;
            Regex newReg = new Regex(pattern, option);
            MatchCollection matches = newReg.Matches(text);
            foreach (Match mat in matches)
            {
                Console.WriteLine("Значение найденного обьекта: {0}", mat.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Число найденных совпадений:" + Convert.ToString(matches.Count));
            Console.ReadKey();
        }
    }
}
