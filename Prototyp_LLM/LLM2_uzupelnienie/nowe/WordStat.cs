using System;

namespace LLM.classes
{

    class WordStat
    {
        public string Word { get; set; }

        public int CorrectCount { get; set; }

        public int IncorrectCount { get; set; }

        public WordStat(string word)
        {
            Word = word;
            CorrectCount = 0;
            IncorrectCount = 0;
        }

        public double Accuracy()
        {
            int total = CorrectCount + IncorrectCount;

            if (total == 0)
                return 0;

            return (double)CorrectCount / total;
        }
    }


}
