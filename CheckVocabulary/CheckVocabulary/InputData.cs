using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVocabulary
{
    class InputFile
    {
        public string inputFilePath = "C:\\Users\\" + Environment.UserName + "\\Desktop\\vocabulary.txt";
    }

    class InputData
    {
        public List<WordPair> WordPairs { get; private set; }

        public InputData()
        {
            //TODO: use the inputFileClass as a const
            string fileContent = System.IO.File.ReadAllText("C:\\Users\\" + Environment.UserName + "\\Desktop\\vocabulary.txt");
            string[] collectedWordPairs = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            WordPairs = new List<WordPair>();
            foreach (string currentWordPair in collectedWordPairs)
            {
                string[] words = currentWordPair.Split(new[] { " - " }, StringSplitOptions.None);
                WordPairs.Add(new WordPair(words[0], words[1]));
            }
        }
    }
}
