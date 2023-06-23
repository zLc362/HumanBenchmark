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
    public partial class form_Sequence_Memory : System.Windows.Forms.Form
    {
        private SequenceMemoryGame game { get; set; }
        private List<Brush> brushes { get; set; }
        private int sqareindex { get; set; } = 0;
        private int sqareToHide { get; set; } = 0;
        public int level { get; set; } = 0;
        public Color backgroundColor { get; set; } = Color.FromArgb(0, 102, 204);
        public bool started { get; set; }
        private Brush brushStartbtn { get; set; } = new SolidBrush(Color.FromArgb(0, 102, 204));
        public form_Sequence_Memory()
        {
            InitializeComponent();
            game = new SequenceMemoryGame();
            brushes = new List<Brush>();
            started = false;
            buttonsEnabled(false);
            buttonsShown(false);

            //game.addToOriginalSequence();
            //game.addToOriginalSequence();
            //game.addToOriginalSequence();
            lbl_level.Text = "";
            colorBrushes();
            label_debug.Text = game.getStringSequence();
        }
        private void buttonsShown(bool show)
        {
            if (show)
            {
                btn_1.Show();
                btn_2.Show();
                btn_3.Show();
                btn_4.Show();
                btn_5.Show();
                btn_6.Show();
                btn_7.Show();
                btn_8.Show();
                btn_9.Show();
            }
            else
            {
                btn_1.Hide();
                btn_2.Hide();
                btn_3.Hide();
                btn_4.Hide();
                btn_5.Hide();
                btn_6.Hide();
                btn_7.Hide();
                btn_8.Hide();
                btn_9.Hide();
            }

        }

        private void colorBrushes()
        {
            brushes.Clear();
            for (int i = 0; i < 9; i++)
            {
                brushes.Add(new SolidBrush(backgroundColor));
            }
        }
        private void endGame()
        {
            game = new SequenceMemoryGame();
            HighScores.updateSequence_memory(level);

            lbl_Center.Text = "You reached\r\nLevel: " + level;
            level = 0;
            lbl_Center.Show();
            buttonsShown(false);
            label_debug.Text = game.getStringSequence();
            btn_Start.Show();
        }
        private void buttonPressed(int guess)
        {
            guess -= 1;

            game.playerGuess(guess);
            if (game.Failed)
            {
                endGame();
            }
            else if (game.Completed)
            {
                game.reset();
                game.addToOriginalSequence();
                buttonsEnabled(false);
                tmr_sequence_show.Start();
                level++;
                lbl_level.Text = "Level: " + level;
            }
            label_debug.Text = game.getStringSequence();
        }
        private void tmr_sequence_show_Tick(object sender, EventArgs e)
        {
            if (game.OriginalSequence.Count > sqareindex)
            {
                int square = game.OriginalSequence[sqareindex];
                sqareindex++;
                sqareToHide = square;
                brushes[square] = new SolidBrush(Color.White);
                invalidateButtons();
                tmr_hide_square.Start();
            }
            else
            {
                sqareindex = 0;
                buttonsEnabled(true);
                tmr_sequence_show.Stop();
            }
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            btn_Start.Hide();
            buttonsEnabled(false);
            buttonsShown(true);
            lbl_Center.Hide();
            tmr_sequence_show.Start();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmr_hide_square_Tick(object sender, EventArgs e)
        {
            brushes[sqareToHide] = new SolidBrush(backgroundColor);
            invalidateButtons();
            tmr_hide_square.Stop();
        }
        private void buttonsEnabled(bool enabled)
        {
            btn_1.Enabled = enabled;
            btn_2.Enabled = enabled;
            btn_3.Enabled = enabled;
            btn_4.Enabled = enabled;
            btn_5.Enabled = enabled;
            btn_6.Enabled = enabled;
            btn_7.Enabled = enabled;
            btn_8.Enabled = enabled;
            btn_9.Enabled = enabled;
        }
        private void invalidateButtons()
        {
            btn_1.Invalidate();
            btn_2.Invalidate();
            btn_3.Invalidate();
            btn_4.Invalidate();
            btn_5.Invalidate();
            btn_6.Invalidate();
            btn_7.Invalidate();
            btn_8.Invalidate();
            btn_9.Invalidate();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            buttonPressed(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            buttonPressed(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            buttonPressed(3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            buttonPressed(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            buttonPressed(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            buttonPressed(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            buttonPressed(7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            buttonPressed(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            buttonPressed(9);
        }

        private void btn_1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRoundedRectangle(brushes[0], e.ClipRectangle, 15);
        }

        private void btn_2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRoundedRectangle(brushes[1], e.ClipRectangle, 15);
        }

        private void btn_3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRoundedRectangle(brushes[2], e.ClipRectangle, 15);
        }

        private void btn_4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRoundedRectangle(brushes[3], e.ClipRectangle, 15);
        }

        private void btn_5_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRoundedRectangle(brushes[4], e.ClipRectangle, 15);
        }

        private void btn_6_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRoundedRectangle(brushes[5], e.ClipRectangle, 15);
        }

        private void btn_7_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRoundedRectangle(brushes[6], e.ClipRectangle, 15);
        }

        private void btn_8_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRoundedRectangle(brushes[7], e.ClipRectangle, 15);
        }

        private void btn_9_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRoundedRectangle(brushes[8], e.ClipRectangle, 15);
        }

        private void btn_1_MouseDown(object sender, MouseEventArgs e)
        {
            brushes[0] = new SolidBrush(Color.White);
            btn_1.Invalidate();
        }

        private void btn_1_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MouseUp_btn1.Start();
            //brushes[0] = new SolidBrush(backgroundColor);
            //btn_1.Invalidate();
        }

        private void btn_2_MouseDown(object sender, MouseEventArgs e)
        {
            brushes[1] = new SolidBrush(Color.White);
            btn_2.Invalidate();
        }

        private void btn_2_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MouseUp_btn2.Start();
            //brushes[1] = new SolidBrush(backgroundColor);
            //btn_2.Invalidate();
        }

        private void btn_3_MouseDown(object sender, MouseEventArgs e)
        {
            brushes[2] = new SolidBrush(Color.White);
            btn_3.Invalidate();
        }

        private void btn_3_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MouseUp_btn3.Start();
            //brushes[2] = new SolidBrush(backgroundColor);
            //btn_3.Invalidate();
        }

        private void btn_4_MouseDown(object sender, MouseEventArgs e)
        {
            brushes[3] = new SolidBrush(Color.White);
            btn_4.Invalidate();
        }

        private void btn_4_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MouseUp_btn4.Start();
            //brushes[3] = new SolidBrush(backgroundColor);
            //btn_4.Invalidate();
        }

        private void btn_5_MouseDown(object sender, MouseEventArgs e)
        {
            brushes[4] = new SolidBrush(Color.White);
            btn_5.Invalidate();
        }

        private void btn_5_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MouseUp_btn5.Start();
            //brushes[4] = new SolidBrush(backgroundColor);
            //btn_5.Invalidate();
        }

        private void btn_6_MouseDown(object sender, MouseEventArgs e)
        {
            brushes[5] = new SolidBrush(Color.White);
            btn_6.Invalidate();
        }

        private void btn_6_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MouseUp_btn6.Start();
            //brushes[5] = new SolidBrush(backgroundColor);
            //btn_6.Invalidate();
        }

        private void btn_7_MouseDown(object sender, MouseEventArgs e)
        {
            brushes[6] = new SolidBrush(Color.White);
            btn_7.Invalidate();
        }

        private void btn_7_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MouseUp_btn7.Start();
            //brushes[6] = new SolidBrush(backgroundColor);
            //btn_7.Invalidate();
        }

        private void btn_8_MouseDown(object sender, MouseEventArgs e)
        {
            brushes[7] = new SolidBrush(Color.White);
            btn_8.Invalidate();
        }

        private void btn_8_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MouseUp_btn8.Start();
            //brushes[7] = new SolidBrush(backgroundColor);
            //btn_8.Invalidate();
        }

        private void btn_9_MouseDown(object sender, MouseEventArgs e)
        {
            brushes[8] = new SolidBrush(Color.White);
            btn_9.Invalidate();
        }

        private void btn_9_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MouseUp_btn9.Start();
            //brushes[8] = new SolidBrush(backgroundColor);
            //btn_9.Invalidate();
        }

        private void tmr_MouseUp_btn1_Tick(object sender, EventArgs e)
        {
            brushes[0] = new SolidBrush(backgroundColor);
            btn_1.Invalidate();
            tmr_MouseUp_btn1.Stop();
        }

        private void tmr_MouseUp_btn2_Tick(object sender, EventArgs e)
        {
            brushes[1] = new SolidBrush(backgroundColor);
            btn_2.Invalidate();
            tmr_MouseUp_btn2.Stop();
        }

        private void tmr_MouseUp_btn3_Tick(object sender, EventArgs e)
        {
            brushes[2] = new SolidBrush(backgroundColor);
            btn_3.Invalidate();
            tmr_MouseUp_btn3.Stop();
        }

        private void tmr_MouseUp_btn4_Tick(object sender, EventArgs e)
        {
            brushes[3] = new SolidBrush(backgroundColor);
            btn_4.Invalidate();
            tmr_MouseUp_btn4.Stop();
        }

        private void tmr_MouseUp_btn5_Tick(object sender, EventArgs e)
        {
            brushes[4] = new SolidBrush(backgroundColor);
            btn_5.Invalidate();
            tmr_MouseUp_btn5.Stop();
        }

        private void tmr_MouseUp_btn6_Tick(object sender, EventArgs e)
        {
            brushes[5] = new SolidBrush(backgroundColor);
            btn_6.Invalidate();
            tmr_MouseUp_btn6.Stop();
        }

        private void tmr_MouseUp_btn7_Tick(object sender, EventArgs e)
        {
            brushes[6] = new SolidBrush(backgroundColor);
            btn_7.Invalidate();
            tmr_MouseUp_btn7.Stop();
        }

        private void tmr_MouseUp_btn8_Tick(object sender, EventArgs e)
        {
            brushes[7] = new SolidBrush(backgroundColor);
            btn_8.Invalidate();
            tmr_MouseUp_btn8.Stop();
        }

        private void tmr_MouseUp_btn9_Tick(object sender, EventArgs e)
        {
            brushes[8] = new SolidBrush(backgroundColor);
            btn_9.Invalidate();
            tmr_MouseUp_btn9.Stop();
        }

        private void btn_Start_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(Color.Black, 2);
            Brush brush = brushStartbtn;
            e.Graphics.FillRoundedRectangle(brush, e.ClipRectangle, 15);
            brush = new SolidBrush(Color.White);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("Start", btn_Start.Font, brush, e.ClipRectangle, format);
            brush.Dispose();
        }

        private void btn_Start_MouseEnter(object sender, EventArgs e)
        {
            brushStartbtn = new SolidBrush(Color.FromArgb(0, 89, 179));
            btn_Start.Invalidate();
        }

        private void btn_Start_MouseLeave(object sender, EventArgs e)
        {
            brushStartbtn = new SolidBrush(backgroundColor);
            btn_Start.Invalidate();
        }

        private void form_Sequence_Memory_FormClosing(object sender, FormClosingEventArgs e)
        {
            HighScores.updateSequence_memory(level);
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
