﻿using System;
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
    public partial class form_Reaction_Time : Form
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
            Form1.disableHoverColorChange(btn_Back);
            Form1.disableHoverColorChange(btn_Reset_GHS);
            brushBtn_Global = new SolidBrush(Color.White);
            brushBtn_ALL = new SolidBrush(Color.White);
            lbl_Center.BackColor = System.Drawing.Color.Transparent;
        }
        private void Startup()
        {
            Started = false;
            clickPanel.BackColor = Color.FromArgb(51, 153, 255);
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
                isGreen = false;
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

        private void btn_Reset_GHS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the Global Highscore for this game?", "Reset Highscore?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HighScores.Reaction_Time = HighScores.MAXREACT;
                updateLabels();
                panel3.Invalidate();
            }
        }

        private void btn_Reset_GHS_Paint(object sender, PaintEventArgs e)
        {

            Brush brush2 = new SolidBrush(Color.Black);
            e.Graphics.FillRoundedRectangle(brushBtn_Global, e.ClipRectangle, 15);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("Clear Global\r\nHighscore", btn_Reset_GHS.Font, brush2, e.ClipRectangle, format);

            brush2.Dispose();
        }

        private void btn_Reset_GHS_MouseEnter(object sender, EventArgs e)
        {
            brushBtn_Global = new SolidBrush(Color.FromKnownColor(KnownColor.LightGray));
        }

        private void btn_Reset_GHS_MouseLeave(object sender, EventArgs e)
        {
            brushBtn_Global = new SolidBrush(Color.White);
        }

        private void clickPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Reset_ALL_Paint(object sender, PaintEventArgs e)
        {
            Brush brush2 = new SolidBrush(Color.Black);
            e.Graphics.FillRoundedRectangle(brushBtn_ALL, e.ClipRectangle, 15);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("Clear Local\r\nScore", btn_Reset_GHS.Font, brush2, e.ClipRectangle, format);

            brush2.Dispose();
        }

        private void btn_Reset_ALL_MouseEnter(object sender, EventArgs e)
        {
            brushBtn_ALL = new SolidBrush(Color.FromKnownColor(KnownColor.LightGray));
        }

        private void btn_Reset_ALL_MouseLeave(object sender, EventArgs e)
        {
            brushBtn_ALL = new SolidBrush(Color.White);
        }

        private void btn_Reset_ALL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the scores for this game?", "Reset scores?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                scores.clearScores();
                updateLabels();
                panel1.Invalidate();
                panel2.Invalidate();
            }
        }
    }
}