using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LLM.classes
{

    // -- Klasa do zapisywania plików --
    class FileSaver
    {
        public static void SaveToTxt(string path, List<string> words)
        {
            File.WriteAllLines(path, words);
        }

        public static void SaveWordStatsToJson(string path, List<WordStat> stats)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path) ?? ".");

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(stats, options);
            File.WriteAllText(path, json);
        }
    }
    
}
