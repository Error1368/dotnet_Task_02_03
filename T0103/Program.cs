using System;
using Microsoft.VisualBasic;
using System.IO;
using System.Collections.Generic;

namespace T0103
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input path to file: ");
            string file_path = Console.ReadLine();
            file_path = "D:/Work/projects/C#/sem5/T0103/T0103/texts/" + file_path;
            Console.Write("Input N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            string[] lines = File.ReadAllLines(file_path);
            
            List<string> new_lines = new List<string>();
            int counter = 0;
            foreach (string line in lines)
            {
                    if (Strings.GetChar(line, 1) == '\t')
                        counter++;
                    if (counter != N)
                        new_lines.Add(line);
                
            }
            
            StreamWriter file_output = new StreamWriter(file_path, false);
            foreach(string line in new_lines)
            {
                file_output.WriteLine(line);
            }
            file_output.Close();


        }
    }
}
