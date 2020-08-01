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
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            path = Directory.GetParent(path).FullName;

            Images[0] = path + @"/Images/startGame.PNG";
            Images[1] = path + @"/Images/error1.PNG";
            Images[2] = path + @"/Images/error2.PNG";
            Images[3] = path + @"/Images/error3.PNG";
            Images[4] = path + @"/Images/error4.PNG";
            Images[5] = path + @"/Images/error5.PNG";
            Images[6] = path + @"/Images/gameOver.PNG";
        }
    }
}
