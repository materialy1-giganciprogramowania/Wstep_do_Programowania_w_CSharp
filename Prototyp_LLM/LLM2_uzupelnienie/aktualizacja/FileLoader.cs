using System;
using System.Collections.Generic;
using System.IO;

namespace LLM.classes
{
    // -- Klasa do odczytywania plików --
    class FileLoader
    {
        public static List<string> LoadList(string path)
        {
            List<string> list = new List<string>();

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string value = line.Trim();

                if (value.Length > 0)
                    list.Add(value);
            }

            return list;
        }
    }
}