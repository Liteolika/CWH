using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CWH.Main;
using System.Text.RegularExpressions;

namespace CWH.Tests
{
    [TestFixture]
    public class WordListRepo_Tests
    {

        private WordlistRepository wordlist;
        private WordListEntry wordentry;

        [SetUp]
        public void Setup()
        {
            wordlist = CWH.Main.WordlistRepository.Create();
            wordentry = new WordListEntry
            {
                Word = "starprogrammer"
            };
            wordlist.AddWord(wordentry);
        }

        [Test]
        public void CanCreateRepo()
        {
            //var repo = WordlistRepository.Create();
            Assert.IsInstanceOf(typeof(WordlistRepository), wordlist);
        }

        [Test]
        public void CanAddWordToRepo()
        {
            wordlist.AddWord(new WordListEntry { Word = "n" });

        }

        [Test]
        public void Add_Word_Throws_On_Empty_Word()
        {
            Assert.Throws<ArgumentNullException>(delegate
            {
                wordlist.AddWord(new WordListEntry { Word = "" });

            });
        }

        [Test]
        public void CanRetrieveWordFromRepo()
        {
            var retrievedWord = wordlist.GetWord(wordentry);
            Assert.AreEqual(wordentry, retrievedWord);
        }

        [Test]
        public void CannotAddDuplicateWord()
        {
            Assert.Throws(typeof(ArgumentException), delegate
            {
                wordlist.AddWord(wordentry);
            });
            
        }

        [Test]
        public void CanSearchWord_Complete()
        {
            var retrievedWords = wordlist.FindWord(wordentry.Word, searchPartial: false);

            Assert.Contains(wordentry, retrievedWords);

        }

        [Test]
        public void CanSearchWord_Partial()
        {
            var retrievedWords = wordlist.FindWord("ramm", searchPartial: true);
            Assert.Contains(wordentry, retrievedWords);
        }

        [Test]
        public void CanSearchWord_Wildcards_One()
        {
            char wildcardChar = '*';
            var retrievedWords = wordlist.FindWord(
                "*gr*mme*", 
                searchPartial: true,
                wildcard: wildcardChar);

            Assert.Contains(wordentry, retrievedWords);

        }

        [Test]
        public void CanSearchWord_Wildcards_Two()
        {
            char wildcardChar = '*';
            
            var retrievedWords = wordlist.FindWord(
                "starpr*gr*mme*",
                searchPartial: true,
                wildcard: wildcardChar);

            Assert.Contains(wordentry, retrievedWords);

        }

        [Test]
        public void ThrowsOnInvalidWildCardChar()
        {
            char wildcardChar = ' ';

            Assert.Throws(typeof(ArgumentException), delegate
            {
                var retrievedWords = wordlist.FindWord(
                "starpr*gr*mme*",
                searchPartial: true,
                wildcard: wildcardChar);
            });

        }

        [Test]
        public void CanRemoveWordFromList()
        {
            wordlist.RemoveWord(wordentry);
            Assert.IsNull(wordlist.GetWord(wordentry));
        }

        [Test]
        public void CanSearchDescription()
        {
            var list = wordlist.FindDescription("really");
            Assert.IsNotEmpty(list);
        }

        [Test]
        public void Can_Add_Description_To_Word()
        {
            wordlist.AddDescription(word: "starprogrammer", description: "A good programmer");

            Assert.IsNotEmpty(wordlist.FindWord("starprogrammer", false).First().Descriptions);
        }
        
    }
}
