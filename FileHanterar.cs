using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileStrings
{
    class FileHanterar
    {
        string path;
        public FileHanterar()
        {
            path = "MyFile.txt";
        }
        public void InputFile()
        {
            if (!File.Exists(path))
              {
                Console.WriteLine("Creating file...\n");
                Console.WriteLine(Directory.GetCurrentDirectory() + "\n");
                using (StreamWriter streamWriter = File.CreateText(path))
                 {
                   streamWriter.WriteLine("***Ny FIL***\n");
                 }
              }
            
              Console.Write("vad vill du skriva in i filen? ");
            using (StreamWriter streamWriter = File.AppendText(path))
            {
                string minText = Console.ReadLine();
                streamWriter.WriteLine(minText);
            }
          

        }
        public void ReadFile()
        {
          

            if (File.Exists(path))
            {

                Console.WriteLine("Skriva ut Filen...\n" + Directory.GetCurrentDirectory()+"\n");
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string fileText = "";
                    while ((fileText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(fileText);
                    }
                }
            } 
            else
            {
                Console.WriteLine("Filen finns inte. ");
            }
        }
    }
}
