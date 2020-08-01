using HangmanGame.Logics;
using System;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class HangmanGame : Form
    {
        private HangmanGameService _hangmanGameService;
        public HangmanGame()
        {
            InitializeComponent();
            _hangmanGameService = new HangmanGameService();
            _hangmanGameService.CharVector();
            LabelStart(_hangmanGameService.WordVector);
            _hangmanGameService.ImageVector();
            picture.ImageLocation = _hangmanGameService.Images[_hangmanGameService.Error];
            lblDica.Text = SharedService.HelpWord;
        }

        public void LabelStart(char[] wordGame)
        {

            for (int i = 0; i < wordGame.Length; i++)
            {
                if (wordGame[i] != ' ')
                {
                    WriteEachLabel('_', i);
                }
                else
                {
                    _hangmanGameService.LetterEmpty++;
                }
            }
        }

        public void LetterCompatibility(char letter)
        {
            _hangmanGameService.RestartErrorLoop();
            for (int i = 0; i < _hangmanGameService.WordVector.Length; i++)
            {
                if (_hangmanGameService.WordVector[i] == letter)
                {
                    WriteEachLabel(letter, i);
                    _hangmanGameService.AddSuccess();
                }
            }
            _hangmanGameService.AddError();
            picture.ImageLocation = _hangmanGameService.Images[_hangmanGameService.Error];
            string verification = _hangmanGameService.CheckFinalGame();
            if (verification != "")
            {
                DialogResult result;
                result = MessageBox.Show("Deseja jogar novamente?", verification, MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                }
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        public void WriteEachLabel(char write, int location)
        {
            switch (location)
            {
                case 0:
                    lbl0.Text = Convert.ToString(write);
                    break;
                case 1:
                    lbl1.Text = Convert.ToString(write);
                    break;
                case 2:
                    lbl2.Text = Convert.ToString(write);
                    break;
                case 3:
                    lbl3.Text = Convert.ToString(write);
                    break;
                case 4:
                    lbl4.Text = Convert.ToString(write);
                    break;
                case 5:
                    lbl5.Text = Convert.ToString(write);
                    break;
                case 6:
                    lbl6.Text = Convert.ToString(write);
                    break;
                case 7:
                    lbl7.Text = Convert.ToString(write);
                    break;
                case 8:
                    lbl8.Text = Convert.ToString(write);
                    break;
                case 9:
                    lbl9.Text = Convert.ToString(write);
                    break;
                case 10:
                    lbl10.Text = Convert.ToString(write);
                    break;
                case 11:
                    lbl11.Text = Convert.ToString(write);
                    break;
                case 12:
                    lbl12.Text = Convert.ToString(write);
                    break;
                case 13:
                    lbl13.Text = Convert.ToString(write);
                    break;
                case 14:
                    lbl14.Text = Convert.ToString(write);
                    break;
                case 15:
                    lbl15.Text = Convert.ToString(write);
                    break;
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            btnQ.Enabled = false;
            LetterCompatibility('Q');
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            btnW.Enabled = false;
            LetterCompatibility('W');
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            btnE.Enabled = false;
            LetterCompatibility('E');
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            btnR.Enabled = false;
            LetterCompatibility('R');
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            btnT.Enabled = false;
            LetterCompatibility('T');
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            btnY.Enabled = false;
            LetterCompatibility('Y');
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            btnU.Enabled = false;
            LetterCompatibility('U');
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            btnI.Enabled = false;
            LetterCompatibility('I');
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            btnO.Enabled = false;
            LetterCompatibility('O');
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            btnP.Enabled = false;
            LetterCompatibility('P');
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            LetterCompatibility('A');
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            btnS.Enabled = false;
            LetterCompatibility('S');
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.Enabled = false;
            LetterCompatibility('D');
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            btnF.Enabled = false;
            LetterCompatibility('F');
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            btnG.Enabled = false;
            LetterCompatibility('G');
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            btnH.Enabled = false;
            LetterCompatibility('H');
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            btnJ.Enabled = false;
            LetterCompatibility('J');
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            btnK.Enabled = false;
            LetterCompatibility('K');
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            btnL.Enabled = false;
            LetterCompatibility('L');
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            btnZ.Enabled = false;
            LetterCompatibility('Z');
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            btnX.Enabled = false;
            LetterCompatibility('X');
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.Enabled = false;
            LetterCompatibility('C');
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            btnV.Enabled = false;
            LetterCompatibility('V');
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.Enabled = false;
            LetterCompatibility('B');
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            btnN.Enabled = false;
            LetterCompatibility('N');
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            btnM.Enabled = false;
            LetterCompatibility('M');
        }
    }
}
