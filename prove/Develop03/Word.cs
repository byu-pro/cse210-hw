namespace ScriptureMemorizer
{
    // Class to represent a word in the scripture
    public class Word
    {
        private string text; // The text of the word
        private bool visible; // Indicates whether the word is visible or hidden

        // Constructor
        public Word(string text)
        {
            this.text = text;
            visible = true; // By default, all words are visible
        }

        // Property to get or set the visibility of the word
        public bool Visible
        {
            get { return visible; }
            set { visible = value; }
        }

        // Property to get the text of the word
        public string Text
        {
            get { return text; }
        }
    }
}
