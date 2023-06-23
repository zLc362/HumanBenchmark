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
    public partial class form_Number_Memory : System.Windows.Forms.Form
    {
        private Random random = new Random();
        private String numberToGuess { get; set; }
        private int level { get; set; }
        private bool started { get; set; }
        private bool enteringNumber { get; set; }
        private String buttonDisplay { get; set; }
        private Font font_regular { get; set; }
        private Font font_large { get; set; }
        private Brush brushButtonStart { get; set; } = new SolidBrush(Color.FromArgb(0, 102, 204));

        public form_Number_Memory()
        {
            InitializeComponent();
            started = false;
            enteringNumber = false;

            tbx_number_enter.Hide();
            progress_bar_back.Hide();
            progress_bar_front.Hide();

            buttonDisplay = "Start";

            font_regular = lbl_Center.Font;
            font_large = new Font("Segoe UI", 40, FontStyle.Bold);

            form_Main_Menu.disableHoverColorChange(btn_Start_Next);
            form_Main_Menu.disableHoverColorChange(btn_Back);

        }
        private void getNewNumber()
        {
            StringBuilder numberToGuessString = new StringBuilder();
            for (int i = 0; i < level; i++)
            {
                numberToGuessString.Append(random.Next(0, 10));
            }
            numberToGuess = numberToGuessString.ToString();
        }
        private void tmr_countdown_Tick(object sender, EventArgs e)
        {

            if (progress_bar_front.Width < 1)
            {
                progress_bar_front.Width = progress_bar_back.Width;
                progress_bar_back.Hide();
                progress_bar_front.Hide();

                tmr_countdown.Stop();

                buttonDisplay = "Guess";
                btn_Start_Next.Invalidate();
                btn_Start_Next.Show();

                lbl_Center.Hide();
                lbl_Center.Font = font_regular;

                tbx_number_enter.Show();
                tbx_number_enter.Focus();

                enteringNumber = true;

                return;
            }
            progress_bar_front.Width = (int)(progress_bar_front.Width - (progress_bar_back.Width * 0.004));
        }
        private void StartUp()
        {
            started = true;
            tmr_countdown.Interval = 10;
            tmr_countdown.Start();

            level = 1;
            getNewNumber();
            lbl_Center.Text = numberToGuess.ToString();
            lbl_Center.Font = font_large;

            progress_bar_back.Show();
            progress_bar_front.Show();

            btn_Start_Next.Hide();
            buttonDisplay = "Next";
            btn_Start_Next.Invalidate();
        }

        private void btn_Start_Next_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                StartUp();
            }
            else
            {
                if (enteringNumber)
                {
                    enteringNumber = false;

                    lbl_Center.Font = font_regular;
                    lbl_Center.Text = String.Format("Number:\r\n{0}\r\nYour Guess:\r\n{1}\r\n\r\nLevel {2}", numberToGuess, tbx_number_enter.Text, level);
                    lbl_Center.Show();

                    tbx_number_enter.Hide();
                    if (numberToGuess.Equals(tbx_number_enter.Text))
                    {
                        level++;
                        buttonDisplay = "Next";
                        btn_Start_Next.Invalidate();
                    }
                    else
                    {
                        started = false;
                        buttonDisplay = "Start";
                        btn_Start_Next.Invalidate();
                    }
                    tbx_number_enter.Text = String.Empty;
                    getNewNumber();
                }
                else
                {
                    lbl_Center.Font = font_large;
                    lbl_Center.Text = numberToGuess.ToString();

                    tmr_countdown.Interval = (int)(tmr_countdown.Interval * 1.3);
                    tmr_countdown.Start();

                    btn_Start_Next.Hide();

                    progress_bar_back.Show();
                    progress_bar_front.Show();
                }
            }
            HighScores.updateNumber_Memory(level);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_Number_Memory_FormClosing(object sender, FormClosingEventArgs e)
        {
            HighScores.updateNumber_Memory(level);
        }

        private void form_Number_Memory_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (tbx_number_enter.Visible)
            {
                g.DrawRoundedRectangle(new Pen(progress_bar_back.BackColor, 2), tbx_number_enter.Location.X - 5, tbx_number_enter.Location.Y - 5, tbx_number_enter.Width + 10, tbx_number_enter.Height + 10, 15);
            }
            else
            {
                g.DrawRoundedRectangle(new Pen(this.BackColor, 2), tbx_number_enter.Location.X - 5, tbx_number_enter.Location.Y - 5, tbx_number_enter.Width + 10, tbx_number_enter.Height + 10, 15);
            }

        }

        private void btn_Start_Next_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(Color.Black, 2);
            Brush brush = brushButtonStart;
            e.Graphics.FillRoundedRectangle(brush, e.ClipRectangle, 15);
            brush = new SolidBrush(Color.White);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(buttonDisplay, btn_Start_Next.Font, brush, e.ClipRectangle, format);
        }

        private void tbx_number_enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                btn_Start_Next_Click(null, null);
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

        private void btn_Start_Next_MouseEnter(object sender, EventArgs e)
        {
            brushButtonStart = new SolidBrush(Color.FromArgb(0, 89, 179));
            btn_Start_Next.Invalidate();
        }

        private void btn_Start_Next_MouseLeave(object sender, EventArgs e)
        {
            brushButtonStart = new SolidBrush(Color.FromArgb(0, 102, 204));
            btn_Start_Next.Invalidate();
        }
    }
}
