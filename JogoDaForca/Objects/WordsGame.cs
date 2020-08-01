namespace JogoDaForca.Objects
{
    class WordsGame
    {
        public string Word { get; set; }
        public string Help { get; set;}

        public WordsGame(string word, string help)
        {
            Word = word;
            Help = help;
        }
    }
}
