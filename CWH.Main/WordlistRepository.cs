using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CWH.Main
{
    public class WordlistRepository
    {


        private List<WordListEntry> wordList;

        public static WordlistRepository Create()
        {
            return new WordlistRepository();
        }

        public WordlistRepository()
        {
            this.wordList = new List<WordListEntry>();
        }

        public void AddWord(WordListEntry word)
        {
            if (wordList.Where(x => x.Word == word.Word).Any())
                throw new ArgumentException("word already exists");

            wordList.Add(word);
        }

        public WordListEntry GetWord(WordListEntry word)
        {
            return wordList.Where(x => x.Word == word.Word).FirstOrDefault();
        }

        public List<WordListEntry> FindWord(string word, bool searchPartial)
        {

            string pattern = "";
            if (searchPartial)
            {
                pattern = @"^.*" + word + ".*$";
            }
            else
            {
                pattern = @"^" + word + "$";
            }
            Regex regex = new Regex(pattern);

            var result = wordList.Where(x => regex.IsMatch(x.Word)).ToList();
            return wordList.Where(x => regex.IsMatch(x.Word)).ToList();
        }

        public List<WordListEntry> FindWord(string word, bool searchPartial, char wildcard)
        {
            string pattern = "";

            string wc = wildcard.ToString().Trim();

            if (string.IsNullOrEmpty(wc))
                throw new ArgumentException("invalid wildcard character");

            pattern = word.Replace(wildcard.ToString(), ".");

            if (searchPartial)
            {
                pattern = ".*" + pattern + ".*";
            }
            
            pattern = "^" + pattern + "$";

            var rex = new Regex(pattern);

            return wordList.Where(x => rex.IsMatch(x.Word)).ToList();

        }

        public void RemoveWord(WordListEntry wordentry)
        {
            wordList.Remove(wordentry);
        }

    }
}
