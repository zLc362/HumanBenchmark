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
    public partial class form_Highscores : System.Windows.Forms.Form
    {
        private List<Brush> buttonBrushes = new List<Brush>();
        public form_Highscores()
        {
            InitializeComponent();

            buttonBrushes.Add(new SolidBrush(Color.FromKnownColor(KnownColor.MenuHighlight)));
            buttonBrushes.Add(new SolidBrush(Color.FromKnownColor(KnownColor.MenuHighlight)));
            buttonBrushes.Add(new SolidBrush(Color.FromKnownColor(KnownColor.MenuHighlight)));
            buttonBrushes.Add(new SolidBrush(Color.FromKnownColor(KnownColor.MenuHighlight)));

            form_Main_Menu.disableHoverColorChange(btn_clear_number_memory);
            form_Main_Menu.disableHoverColorChange(btn_clear_reaction_time);
            form_Main_Menu.disableHoverColorChange(btn_clear_Sequence_memory);
            form_Main_Menu.disableHoverColorChange(btn_clear_word_memory);

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
            else lbl_Sequence_Memory.Text = "Level " + HighScores.Sequence_Memory.ToString();

            if (HighScores.Word_Memory == 0)
            {
                lbl_Word_Memory.Text = "None";
            }
            else lbl_Word_Memory.Text = HighScores.Word_Memory.ToString() + " Words";
        }
        private void drawButton(PaintEventArgs e,int buttonIndex)
        {
            Brush brush = buttonBrushes[buttonIndex];
            e.Graphics.FillRoundedRectangle(brush, e.ClipRectangle, 15);
            brush = new SolidBrush(Color.White);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("Clear\r\nScore", lbl_reaction_time.Font, brush, e.ClipRectangle, format);
            brush.Dispose();
        }

        private void btn_clear_reaction_time_Paint(object sender, PaintEventArgs e)
        {
            drawButton(e,0);
        }

        private void btn_clear_Sequence_memory_Paint(object sender, PaintEventArgs e)
        {
            drawButton(e,1);
        }

        private void btn_clear_word_memory_Paint(object sender, PaintEventArgs e)
        {
            drawButton(e,2);
        }

        private void btn_clear_number_memory_Paint(object sender, PaintEventArgs e)
        {
            drawButton(e,3);
        }

        private void btn_clear_reaction_time_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the highscore for Reaction Time?", "Reset Highscore?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HighScores.resetReaction_time();
                updateLabels();
            }

        }

        private void btn_clear_Sequence_memory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the highscore for Sequence Memory?", "Reset Highscore?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HighScores.resetSequence_Memory();
                updateLabels();
            }

        }

        private void btn_clear_word_memory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the highscore for Word Memory?", "Reset Highscore?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HighScores.resetWord_Memory();
                updateLabels();
            }

        }

        private void btn_clear_number_memory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the highscore for Number Memory?", "Reset Highscore?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HighScores.resetNumber_Memory();
                updateLabels();
            }

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

        private void panel_Reaction_time_background_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.White);
            e.Graphics.FillRoundedRectangle(brush, e.ClipRectangle, 15);
            brush.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.White);
            e.Graphics.FillRoundedRectangle(brush, e.ClipRectangle, 15);
            brush.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.White);
            e.Graphics.FillRoundedRectangle(brush, e.ClipRectangle, 15);
            brush.Dispose();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.White);
            e.Graphics.FillRoundedRectangle(brush, e.ClipRectangle, 15);
            brush.Dispose();
        }

        private void btn_clear_reaction_time_MouseEnter(object sender, EventArgs e)
        {
            buttonBrushes[0] = new SolidBrush(Color.FromKnownColor(KnownColor.HotTrack));
        }

        private void btn_clear_reaction_time_MouseLeave(object sender, EventArgs e)
        {
            buttonBrushes[0] = new SolidBrush(Color.FromKnownColor(KnownColor.MenuHighlight));
        }

        private void btn_clear_Sequence_memory_MouseEnter(object sender, EventArgs e)
        {
            buttonBrushes[1] = new SolidBrush(Color.FromKnownColor(KnownColor.HotTrack));
        }

        private void btn_clear_Sequence_memory_MouseLeave(object sender, EventArgs e)
        {
            buttonBrushes[1] = new SolidBrush(Color.FromKnownColor(KnownColor.MenuHighlight));
        }

        private void btn_clear_word_memory_MouseEnter(object sender, EventArgs e)
        {
            buttonBrushes[2] = new SolidBrush(Color.FromKnownColor(KnownColor.HotTrack));
        }

        private void btn_clear_word_memory_MouseLeave(object sender, EventArgs e)
        {
            buttonBrushes[2] = new SolidBrush(Color.FromKnownColor(KnownColor.MenuHighlight));
        }

        private void btn_clear_number_memory_MouseEnter(object sender, EventArgs e)
        {
            buttonBrushes[3] = new SolidBrush(Color.FromKnownColor(KnownColor.HotTrack));
        }

        private void btn_clear_number_memory_MouseLeave(object sender, EventArgs e)
        {
            buttonBrushes[3] = new SolidBrush(Color.FromKnownColor(KnownColor.MenuHighlight));
        }
    }
}
