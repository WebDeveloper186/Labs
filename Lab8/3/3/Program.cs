﻿using System;
using System.Collections.Generic;
using System.IO;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"W:\C#\Labs\Labs\Lab8\file.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    List<string> sLine = new List<string>();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] split = line.Split(new char[] { ' ', ',', '.', ':', '\t' });
                        if (split[0].Length == 1)
                        {
                            Console.WriteLine(line);
                        }
                        else
                        {
                            sLine.Add(line);
                        }
                    }
                    foreach (string s in sLine)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
