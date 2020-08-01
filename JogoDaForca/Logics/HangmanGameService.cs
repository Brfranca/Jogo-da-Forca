using System.IO;

namespace HangmanGame.Logics
{
    class HangmanGameService
    {
        public int LetterEmpty { get; set; }
        public char[] WordVector { get; set; }
        public int Error { get; set; }
        public int Success { get; set; }
        public bool ErrorLoop { get; set; } = true;
        public string[] Images { get; set; } = new string[7];

        public void CharVector()
        {
            WordVector = SharedService.WordGame.ToCharArray();
        }

        public void AddError()
        {
            if (ErrorLoop)
            {
                Error++;
            }
        }

        public void RestartErrorLoop()
        {
            ErrorLoop = true;
        }

        public void AddSuccess()
        {
            Success++;
            ErrorLoop = false;
        }

        public string CheckFinalGame()
        {
            if (Error == 6)
            {
                return "Você perdeu!";
            }
            else if (Success == WordVector.Length - LetterEmpty)
            {
                return "Você ganhou!";
            }
            return "";
        }

        public void ImageVector()
        {
            Images[0] = Directory.GetCurrentDirectory() + @"/images/startGame.PNG";
            Images[1] = Directory.GetCurrentDirectory() + @"/images/error1.PNG";
            Images[2] = Directory.GetCurrentDirectory() + @"/images/error2.PNG";
            Images[3] = Directory.GetCurrentDirectory() + @"/images/error3.PNG";
            Images[4] = Directory.GetCurrentDirectory() + @"/images/error4.PNG";
            Images[5] = Directory.GetCurrentDirectory() + @"/images/error5.PNG";
            Images[6] = Directory.GetCurrentDirectory() + @"/images/gameOver.PNG";
        }
    }
}
