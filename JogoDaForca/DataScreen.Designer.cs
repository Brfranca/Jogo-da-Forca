namespace HangmanGame
{
    partial class DataScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(77, 211);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(113, 24);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "GERAR PALAVRA";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtHelp
            // 
            this.txtHelp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHelp.Location = new System.Drawing.Point(36, 164);
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(317, 20);
            this.txtHelp.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Escreva uma dica:";
            // 
            // txtWord
            // 
            this.txtWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWord.Location = new System.Drawing.Point(36, 95);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(317, 20);
            this.txtWord.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Escreva uma palavra de até 16 letras, incluindo espaços vazios:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jogo da Forca";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStart.Location = new System.Drawing.Point(112, 252);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 56);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "JOGAR";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(196, 211);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(113, 24);
            this.btnClean.TabIndex = 13;
            this.btnClean.Text = "APAGAR";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // DataScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 356);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DataScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClean;
    }
}