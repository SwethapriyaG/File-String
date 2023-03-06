using System;
using System.IO;

namespace FileStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHanterar TextFile = new FileHanterar();
            TextFile.InputFile();
            TextFile.ReadFile();

            //TextHanterar Txt = new TextHanterar();
            Console.WriteLine("Skriva din text..");
            string mintext = Console.ReadLine();
            TextHanterar Txt = new TextHanterar(mintext);
            Txt.UpperString();
            Txt.LowerString();
            Txt.IndexOf();
            Txt.SplitString();
        }
    }
}
