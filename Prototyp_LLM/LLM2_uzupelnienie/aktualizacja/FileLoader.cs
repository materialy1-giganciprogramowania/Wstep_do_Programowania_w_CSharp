using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LLM.classes
{
    // -- Klasa do odczytywania plików --
    class FileLoader
    {
        public static List<string> LoadList(string path)
        {
            List<string> list = new List<string>();

            if (!File.Exists(path))
            {
                Console.WriteLine($"File not found: {path}");
                return list;
            }

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string value = line.Trim();

                if (value.Length > 0)
                    list.Add(value);
            }

            return list;
        }

        public static List<T> LoadJsonList<T>(string path)
        {
            if (!File.Exists(path))
            {
                // jeśli plik nie istnieje, zwracamy pustą listę (nie błąd)
                return new List<T>();
            }

            string json = File.ReadAllText(path);

            if (string.IsNullOrWhiteSpace(json))
                return new List<T>();

            List<T>? data = JsonSerializer.Deserialize<List<T>>(json);

            return data ?? new List<T>();
        }
    }
}