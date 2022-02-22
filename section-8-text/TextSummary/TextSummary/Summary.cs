using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSummary
{
    internal class Summary
    {
        public static string summarizeText(string sentences, int MaxLength = 20) {
            if (sentences.Length < MaxLength)
            {
                return sentences;
            }
            else
            {
                var totalCharacters = 0;
                var words = sentences.Split(' ');
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > MaxLength)
                        break;
                }

                var summary = String.Join(" ", summaryWords) + "...";
                return summary;
            }
        }
    }
}
