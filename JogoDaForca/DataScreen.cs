using System;
using HangmanGame.Logics;
using System.Windows.Forms;
using JogoDaForca.Enums;
using JogoDaForca.Objects;

namespace HangmanGame
{
    public partial class DataScreen : Form
    {
        private DataScreenService _dataScreenService;
        public DataScreen()
        {
            InitializeComponent();
            _dataScreenService = new DataScreenService();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TypeValidation validation = _dataScreenService.ValidateInitialization(txtWord.Text, txtHelp.Text);

            if (validation == TypeValidation.ErrorAll)
            {
                MessageBox.Show("Digite uma palavra válida e uma dica, ou clique em gerar.");
            }
            else if (validation == TypeValidation.ErrorWord)
            {
                MessageBox.Show("Digite uma palavra válida.");
            }
            else if (validation == TypeValidation.ErrorHelp)
            {
                MessageBox.Show("Digite uma dica.");
            }
            else
            {
                SharedService.WordGame = _dataScreenService.ReplaceLetter(txtWord.Text);
                SharedService.HelpWord = txtHelp.Text;
                HangmanGame hangmanGame = new HangmanGame();
                hangmanGame.ShowDialog();
                this.Close();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            WordsGame generatedWord = _dataScreenService.GenarateWord();
            txtWord.UseSystemPasswordChar = true;
            txtWord.Text = generatedWord.Word;
            txtHelp.Text = generatedWord.Help;
            txtWord.Enabled = false;
            txtHelp.Enabled = false;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtWord.Enabled = true;
            txtHelp.Enabled = true;
            txtWord.Text = null;
            txtHelp.Text = null;
            txtWord.UseSystemPasswordChar = false;
        }
    }
}
