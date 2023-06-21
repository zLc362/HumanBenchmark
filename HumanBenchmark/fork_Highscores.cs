using HumanBenchmark.Properties;
using Plasmoid.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanBenchmark
{
    public partial class fork_Highscores : Form
    {
        public fork_Highscores()
        {
            InitializeComponent();

            Form1.disableHoverColorChange(btn_clear_number_memory);
            Form1.disableHoverColorChange(btn_clear_reaction_time);
            Form1.disableHoverColorChange(btn_clear_Sequence_memory);
            Form1.disableHoverColorChange(btn_clear_word_memory);

            updateLabels();
        }
        private void updateLabels()
        {
            if (HighScores.Reaction_Time == HighScores.MAXREACT)
            {
                lbl_reaction_time.Text = "None";
            }
            else lbl_reaction_time.Text = HighScores.Reaction_Time + "ms";

            if (HighScores.Number_Memory == 0)
            {
                lbl_Number_Memory.Text = "None";
            }
            else lbl_Number_Memory.Text = "Level " + HighScores.Number_Memory.ToString();

            if (HighScores.Sequence_Memory == 0)
            {
                lbl_Sequence_Memory.Text = "None";
            }
            else lbl_Sequence_Memory.Text = HighScores.Sequence_Memory.ToString();

            if (HighScores.Word_Memory == 0)
            {
                lbl_Word_Memory.Text = "None";
            }
            else lbl_Word_Memory.Text = HighScores.Word_Memory.ToString() + " Words";
        }
        private void drawButton(PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.LightBlue);
            e.Graphics.FillRoundedRectangle(brush, e.ClipRectangle, 15);
            brush = new SolidBrush(Color.Black);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("Clear\r\nScore", lbl_reaction_time.Font, brush, e.ClipRectangle, format);
            brush.Dispose();
        }

        private void btn_clear_reaction_time_Paint(object sender, PaintEventArgs e)
        {
            drawButton(e);
        }

        private void btn_clear_Sequence_memory_Paint(object sender, PaintEventArgs e)
        {
            drawButton(e);
        }

        private void btn_clear_word_memory_Paint(object sender, PaintEventArgs e)
        {
            drawButton(e);
        }

        private void btn_clear_number_memory_Paint(object sender, PaintEventArgs e)
        {
            drawButton(e);
        }

        private void btn_clear_reaction_time_Click(object sender, EventArgs e)
        {
            HighScores.resetReaction_time();
            updateLabels();
        }

        private void btn_clear_Sequence_memory_Click(object sender, EventArgs e)
        {
            HighScores.resetSequence_Memory();
            updateLabels();
        }

        private void btn_clear_word_memory_Click(object sender, EventArgs e)
        {
            HighScores.resetWord_Memory();
            updateLabels();
        }

        private void btn_clear_number_memory_Click(object sender, EventArgs e)
        {
            HighScores.resetNumber_Memory();
            updateLabels();
        }

        private void btn_Back_MouseEnter(object sender, EventArgs e)
        {
            btn_Back.BackgroundImage = Resources.Back_Active;
        }

        private void btn_Back_MouseLeave(object sender, EventArgs e)
        {
            btn_Back.BackgroundImage = Resources.Back_Normal;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
