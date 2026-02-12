using System;
using System.Collections.Generic;
using System.IO;

namespace LLM.classes
{
    class WordLearning
    {
        private Dictionary<string, WordStat> stats = new Dictionary<string, WordStat>();

        public void MarkCorrect(string word)
        {
            WordStat stat = GetOrCreate(word);
            stat.CorrectCount++;
        }

        public void MarkIncorrect(string word)
        {
            WordStat stat = GetOrCreate(word);
            stat.IncorrectCount++;
        }

        private WordStat GetOrCreate(string word)
        {
            if (!stats.ContainsKey(word))
            {
                stats[word] = new WordStat(word);
            }

            return stats[word];
        }

        public WordStat GetStat(string word)
        {
            if (stats.ContainsKey(word))
                return stats[word];

            return null;
        }

        public List<WordStat> GetAllStats()
        {
            return new List<WordStat>(stats.Values);
        }

        public void LoadStats(List<WordStat> loadedStats)
        {
            stats.Clear();

            foreach (WordStat s in loadedStats)
            {
                // zabezpieczenie na null/empty
                if (s != null && !string.IsNullOrWhiteSpace(s.Word))
                {
                    stats[s.Word] = s;
                }
            }
        }

        public void PrintStats()
        {
            Console.WriteLine("\n=== WORD LEARNING STATISTICS ===");

            if (stats.Count == 0)
            {
                Console.WriteLine("No statistics available.");
                return;
            }

            foreach (WordStat s in stats.Values)
            {
                int total = s.CorrectCount + s.IncorrectCount;

                int percent = total > 0
                    ? s.CorrectCount * 100 / total
                    : 0;

                Console.WriteLine(
                    $"{s.Word} | Correct: {s.CorrectCount} | Incorrect: {s.IncorrectCount} | Accuracy: {percent}%"
                );
            }
        }

    }


}
