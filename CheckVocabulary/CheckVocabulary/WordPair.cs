using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVocabulary
{
    class WordPair
    {
        public string EnglishWord { get; set; }
        public string HungarianWord { get; set; }
        public DateTime CheckDate { get; set; }

        public WordPair(string englishWord, string hungarianWord)
        {
            this.EnglishWord = englishWord;
            this.HungarianWord = hungarianWord;
        }
    }
}
