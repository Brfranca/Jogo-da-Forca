using JogoDaForca.Enums;
using JogoDaForca.Objects;
using System;
using System.Collections.Generic;

namespace HangmanGame.Logics
{
    class DataScreenService
    {
        public int MyProperty { get; set; }
        public List<WordsGame> WordsList { get; private set; } = new List<WordsGame>();

        public TypeValidation ValidateInitialization(string txtWord, string txtHelp)
        {
            if (string.IsNullOrWhiteSpace(txtWord) || txtWord.Length > 16 && string.IsNullOrWhiteSpace(txtHelp))
                return TypeValidation.ErrorAll;
            else if (string.IsNullOrWhiteSpace(txtWord) || txtWord.Length > 16)
                return TypeValidation.ErrorWord;
            else if (string.IsNullOrWhiteSpace(txtHelp))
                return TypeValidation.ErrorHelp;
            return TypeValidation.Success;
        }

        public WordsGame GenarateWord()
        {
            WordsList.Add(new WordsGame("LEGOLAS", "O SENHOR DOS ANEIS"));
            WordsList.Add(new WordsGame("CALL OF DUTY", "JOGO"));
            WordsList.Add(new WordsGame("DRAGON BALL", "ANIME"));
            WordsList.Add(new WordsGame("CAPITAO AMERICA", "MARVEL"));
            WordsList.Add(new WordsGame("PANTERA NEGRA", "MARVEL"));
            WordsList.Add(new WordsGame("DEATH NOTE", "ANIME"));
            WordsList.Add(new WordsGame("JAVA", "PALAVRA PROIBIDA"));
            WordsList.Add(new WordsGame("RAGNAROK", "MITOLOGIA NÓRDICA"));
            WordsList.Add(new WordsGame("ODIN", "MITOLOGIA NÓRDICA"));
            WordsList.Add(new WordsGame("DEADPOOL", "MARVEL"));
            WordsList.Add(new WordsGame("GANDALF", "O SENHOR DOS ANEIS"));
            Random random = new Random();
            return WordsList[random.Next(0, 10)];
        }

        public string ReplaceLetter(string word)
        {
            word = word.Replace("ç", "c")
                .Replace("ã", "a")
                .Replace("á", "a")
                .Replace("â", "a")
                .Replace("é", "e")
                .Replace("ê", "e")
                .Replace("í", "i")
                .Replace("õ", "o")
                .Replace("ó", "o")
                .Replace("ô", "o");
            return word;
        }
    }
}
