using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    // Class to represent a scripture
    public class Scripture
    {
        private string reference; // The reference of the scripture
        private string text; // The text of the scripture
        private List<Word> words; // List of words in the scripture

        // Constructor to create a scripture with single verse
        public Scripture(string reference, string text)
        {
            this.reference = reference;
            this.text = text;
            words = new List<Word>();

            // Split the scripture text into words
            string[] wordArray = text.Split(' ');

            // Create Word objects for each word in the scripture
            foreach (string word in wordArray)
            {
                words.Add(new Word(word));
            }
        }

        // Constructor to create a scripture with verse range
        public Scripture(string reference, string startVerse, string endVerse)
        {
            this.reference = reference;
            words = new List<Word>();

            // Extract verse numbers from start and end verses
            int startVerseNum = int.Parse(startVerse);
            int endVerseNum = int.Parse(endVerse);

            // Generate scripture text using verse numbers
            text = GenerateText(startVerseNum, endVerseNum);

            // Split the scripture text into words
            string[] wordArray = text.Split(' ');

            // Create Word objects for each word in the scripture
            foreach (string word in wordArray)
            {
                words.Add(new Word(word));
            }
        }

        // Method to generate the scripture text using verse numbers
        private string GenerateText(int startVerseNum, int endVerseNum)
        {
            string generatedText = "";

            // Generate scripture text for each verse number
            for (int verseNum = startVerseNum; verseNum <= endVerseNum; verseNum++)
            {
                generatedText += "Verse " + verseNum + ": Lorem ipsum dolor sit amet, consectetur adipiscing elit. ";
            }

            return generatedText.Trim();
        }

        // Method to hide a few random words in the scripture
        public void HideRandomWords()
        {
            // Generate a random number of words to hide
            Random random = new Random();
            int numWordsToHide = random.Next(1, words.Count + 1);

            // Hide random words by setting their visibility to false
            for (int i = 0; i < numWordsToHide; i++)
            {
                int randomIndex = random.Next(words.Count);
                words[randomIndex].Visible = false;
            }
        }

        // Method to check if all words in the scripture are hidden
        public bool AllWordsHidden()
        {
            foreach (Word word in words)
            {
                if (word.Visible)
                {
                    return false;
                }
            }

            return true;
        }

        // Method to display the complete scripture, including reference and text
        public void DisplayScripture()
        {
            Console.WriteLine(reference + ":");
            Console.WriteLine(text);
        }

        // Method to display the scripture with hidden words
        public void DisplayScriptureWithHiddenWords()
        {
            Console.WriteLine(reference + ":");

            foreach (Word word in words)
            {
                if (word.Visible)
                {
                    Console.Write(word.Text + " ");
                }
                else
                {
                    Console.Write("***** ");
                }
            }

            Console.WriteLine();
        }
    }
}
