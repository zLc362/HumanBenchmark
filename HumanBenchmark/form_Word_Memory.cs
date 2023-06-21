using HumanBenchmark.Properties;
using Plasmoid.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanBenchmark
{

    public partial class form_Word_Memory : Form
    {
        public Color buttonColor { get; set; } = Color.FromArgb(0, 102, 204);
        public bool Started { get; set; } = false;
        public WordMemoryGame game { get; set; }
        public String currWord { get; set; }
        public int score { get; set; }
        public Font font_regular { get; set; }
        public Font font_large { get; set; }
        public form_Word_Memory()
        {
            score = 0;
            InitializeComponent();
            btn_New.Hide();
            btn_Seen.Hide();
            game = new WordMemoryGame();
            Form1.disableHoverColorChange(btn_Start);
            Form1.disableHoverColorChange(btn_Back);
            Form1.disableHoverColorChange(btn_New);
            Form1.disableHoverColorChange(btn_Seen);
            font_regular = lbl_Center.Font;
            font_large = new Font("Segoe UI", 40, FontStyle.Bold);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void drawButton(PaintEventArgs e, String text)
        {
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(buttonColor);
            e.Graphics.FillRoundedRectangle(brush, e.ClipRectangle, 15);
            brush = new SolidBrush(Color.White);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(text, btn_Start.Font, brush, e.ClipRectangle, format);
        }

        private void btn_Start_Paint(object sender, PaintEventArgs e)
        {
            drawButton(e, "Start");
        }

        private void btn_Seen_Paint(object sender, PaintEventArgs e)
        {
            drawButton(e, "SEEN");
        }

        private void btn_New_Paint(object sender, PaintEventArgs e)
        {
            drawButton(e, "NEW");
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            btn_Start.Hide();
            btn_Seen.Show();
            btn_New.Show();
            currWord = game.getRandomWord();
            lbl_Center.Font = font_large;
            lbl_Center.Text = currWord;
        }
        private void gameOver()
        {
            game.clearGuesses();
            lbl_Center.Font = font_regular;
            lbl_Center.Text = "You got " + score + " right!";
            HighScores.updateWord_Memory(score);
            score = 0;
            btn_New.Hide();
            btn_Seen.Hide();
            btn_Start.Show();
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            if (game.guessWord(currWord))
            {
                currWord = game.getRandomWord();
                lbl_Center.Text = currWord;
                score++;
            }
            else
            {
                gameOver();
            }
        }

        private void btn_Seen_Click(object sender, EventArgs e)
        {
            if (!game.guessWord(currWord))
            {
                currWord = game.getRandomWord();
                lbl_Center.Text = currWord;
                score++;
            }
            else
            {
                gameOver();
            }
        }

        private void form_Word_Memory_FormClosing(object sender, FormClosingEventArgs e)
        {
            HighScores.updateWord_Memory(score);
        }

        private void btn_Back_MouseEnter(object sender, EventArgs e)
        {
            btn_Back.BackgroundImage = Resources.Back_Active;
        }

        private void btn_Back_MouseLeave(object sender, EventArgs e)
        {
            btn_Back.BackgroundImage = Resources.Back_Normal;
        }
    }
}
