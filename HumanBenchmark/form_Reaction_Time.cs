using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanBenchmark.Properties;
using Plasmoid.Extensions;

namespace HumanBenchmark
{
    public partial class form_Reaction_Time : System.Windows.Forms.Form
    {
        private bool Started { get; set; }
        public ReactionTimeScores scores { get; set; }
        private int changeToGreenTimer { get; set; }
        private Random random { get; set; }
        private bool isGreen { get; set; }
        public Stopwatch gameTime { get; set; }
        public int changeToGreenRandom { get; set; }
        private Brush brushBtn_Global { get; set; }
        private Brush brushBtn_ALL { get; set; }
        Font normalF = new Font("Segoe UI", 19, FontStyle.Bold);
        Font largeF = new Font("Segoe UI", 40, FontStyle.Bold);
        public form_Reaction_Time()
        {
            InitializeComponent();
            scores = new ReactionTimeScores();
            random = new Random();
            gameTime = new Stopwatch();
            Startup();
            updateLabels();
            form_Main_Menu.disableHoverColorChange(btn_Back);
            brushBtn_Global = new SolidBrush(Color.White);
            brushBtn_ALL = new SolidBrush(Color.White);
            lbl_Center.BackColor = System.Drawing.Color.Transparent;
        }
        private void Startup()
        {
            Started = false;
            clickPanel.BackColor = Color.FromKnownColor(KnownColor.MenuHighlight);
            isGreen = false;
            changeToGreenTimer = 0;
            changeToGreenRandom = random.Next(5, 30);
            timer_Start_Game.Stop();
        }
        private String checkNoneValue(int value)
        {
            if (value == 0 || value == HighScores.MAXREACT)
            {
                return "";
            }
            else
            {
                return value.ToString() + "ms";
            }
        }
        private void updateLabels()
        {
            lbl_Score1.Text = checkNoneValue(scores.score1);
            lbl_Score2.Text = checkNoneValue(scores.score2);
            lbl_Score3.Text = checkNoneValue(scores.score3);
            lbl_Score4.Text = checkNoneValue(scores.score4);
            lbl_Score5.Text = checkNoneValue(scores.score5);
            lbl_localHS.Text = checkNoneValue(scores.highScore);
            lbl_globalHS.Text = checkNoneValue(HighScores.Reaction_Time);

        }
        private void clickPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Started)
            {
                Started = true;
                clickPanel.BackColor = Color.FromArgb(206, 38, 54);
                timer_Start_Game.Interval = 100;
                timer_Start_Game.Start();
                lbl_Center.Text = "";
            }
            else
            {
                if (isGreen)
                {
                    gameTime.Stop();
                    scores.newScore((int)gameTime.ElapsedMilliseconds);
                    //HighScores.updateReaction_Time((int)gameTime.ElapsedMilliseconds);

                    lbl_Center.Text = String.Format("{0}ms", gameTime.ElapsedMilliseconds.ToString());
                    lbl_Center.Font = largeF;

                    gameTime.Reset();
                    Startup();
                    updateLabels();
                }
                else
                {
                    lbl_Center.Text = "TOO EARLY";
                    lbl_Center.Font = largeF;
                    Startup();
                }
            }
        }

        private void lbl_Center_MouseClick(object sender, MouseEventArgs e)
        {
            clickPanel_MouseClick(sender, e);
        }

        private void timer_Start_Game_Tick(object sender, EventArgs e)
        {
            changeToGreenTimer += 1;
            if (changeToGreenTimer > changeToGreenRandom)
            {
                timer_Start_Game.Stop();
                isGreen = true;
                clickPanel.BackColor = Color.FromArgb(75, 219, 106);
                gameTime.Start();
            }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.White);
            e.Graphics.FillRoundedRectangle(brush, e.ClipRectangle, 15);
            brush.Dispose();
        }


        private void btn_Back_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
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

        }
    }
}
