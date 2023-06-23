using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a scripture with a single verse
            Scripture scripture1 = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

            // Create a scripture with a verse range
            Scripture scripture2 = new Scripture("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

            bool quit = false;

            while (!quit)
            {
                // Display the complete scripture
                Console.Clear();
                scripture1.DisplayScripture();
                scripture2.DisplayScripture();

                Console.WriteLine("Press enter to hide some words or type 'quit' to exit:");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    quit = true;
                }
                else
                {
                    // Hide random words in the scripture
                    scripture1.HideRandomWords();
                    scripture2.HideRandomWords();
                }

                Console.Clear();

                // Display the scripture with hidden words
                scripture1.DisplayScriptureWithHiddenWords();
                scripture2.DisplayScriptureWithHiddenWords();

                // Check if all words in the scripture are hidden
                if (scripture1.AllWordsHidden() && scripture2.AllWordsHidden())
                {
                    quit = true;
                }
            }

            Console.WriteLine("All words in the scripture are hidden. Program ended.");
        }
    }
}
