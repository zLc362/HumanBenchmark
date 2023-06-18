namespace HumanBenchmark
{
    partial class form_Reaction_Time
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
            components = new System.ComponentModel.Container();
            clickPanel = new Panel();
            lbl_Center = new Label();
            lbl_Score1 = new Label();
            lbl_Score3 = new Label();
            lbl_Score5 = new Label();
            lbl_Score2 = new Label();
            lbl_Score4 = new Label();
            label_LFS = new Label();
            timer_Start_Game = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            lbl_localHS = new Label();
            lbl_globalHS = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btn_Back = new Button();
            btn_Reset_GHS = new Button();
            btn_Reset_ALL = new Button();
            clickPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // clickPanel
            // 
            clickPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clickPanel.AutoSize = true;
            clickPanel.BackColor = Color.Crimson;
            clickPanel.Controls.Add(lbl_Center);
            clickPanel.Location = new Point(-5, -2);
            clickPanel.Name = "clickPanel";
            clickPanel.Size = new Size(1598, 699);
            clickPanel.TabIndex = 0;
            clickPanel.MouseClick += clickPanel_MouseClick;
            // 
            // lbl_Center
            // 
            lbl_Center.Anchor = AnchorStyles.None;
            lbl_Center.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Center.ForeColor = Color.White;
            lbl_Center.Location = new Point(516, 290);
            lbl_Center.Name = "lbl_Center";
            lbl_Center.Size = new Size(626, 92);
            lbl_Center.TabIndex = 0;
            lbl_Center.Text = "Click as soon as the red turns to green\r\nClick on the blue to start";
            lbl_Center.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Center.MouseClick += lbl_Center_MouseClick;
            // 
            // lbl_Score1
            // 
            lbl_Score1.Anchor = AnchorStyles.Top;
            lbl_Score1.AutoSize = true;
            lbl_Score1.BackColor = Color.White;
            lbl_Score1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Score1.Location = new Point(94, 60);
            lbl_Score1.Name = "lbl_Score1";
            lbl_Score1.Size = new Size(96, 37);
            lbl_Score1.TabIndex = 1;
            lbl_Score1.Text = "label1";
            // 
            // lbl_Score3
            // 
            lbl_Score3.Anchor = AnchorStyles.Top;
            lbl_Score3.AutoSize = true;
            lbl_Score3.BackColor = Color.White;
            lbl_Score3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Score3.Location = new Point(494, 60);
            lbl_Score3.Name = "lbl_Score3";
            lbl_Score3.Size = new Size(96, 37);
            lbl_Score3.TabIndex = 2;
            lbl_Score3.Text = "label1";
            // 
            // lbl_Score5
            // 
            lbl_Score5.Anchor = AnchorStyles.Top;
            lbl_Score5.AutoSize = true;
            lbl_Score5.BackColor = Color.White;
            lbl_Score5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Score5.Location = new Point(894, 60);
            lbl_Score5.Name = "lbl_Score5";
            lbl_Score5.Size = new Size(96, 37);
            lbl_Score5.TabIndex = 3;
            lbl_Score5.Text = "label1";
            // 
            // lbl_Score2
            // 
            lbl_Score2.Anchor = AnchorStyles.Top;
            lbl_Score2.AutoSize = true;
            lbl_Score2.BackColor = Color.White;
            lbl_Score2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Score2.Location = new Point(294, 60);
            lbl_Score2.Name = "lbl_Score2";
            lbl_Score2.Size = new Size(96, 37);
            lbl_Score2.TabIndex = 4;
            lbl_Score2.Text = "label1";
            // 
            // lbl_Score4
            // 
            lbl_Score4.Anchor = AnchorStyles.Top;
            lbl_Score4.AutoSize = true;
            lbl_Score4.BackColor = Color.White;
            lbl_Score4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Score4.Location = new Point(694, 60);
            lbl_Score4.Name = "lbl_Score4";
            lbl_Score4.Size = new Size(96, 37);
            lbl_Score4.TabIndex = 5;
            lbl_Score4.Text = "label1";
            // 
            // label_LFS
            // 
            label_LFS.Anchor = AnchorStyles.Top;
            label_LFS.AutoSize = true;
            label_LFS.BackColor = Color.White;
            label_LFS.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_LFS.Location = new Point(413, 12);
            label_LFS.Name = "label_LFS";
            label_LFS.Size = new Size(257, 37);
            label_LFS.TabIndex = 6;
            label_LFS.Text = "LAST FIVE SCORES:";
            // 
            // timer_Start_Game
            // 
            timer_Start_Game.Tick += timer_Start_Game_Tick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 7);
            label1.Name = "label1";
            label1.Size = new Size(406, 37);
            label1.TabIndex = 7;
            label1.Text = "HIGH SCORE IN THIS SESSION:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(120, 7);
            label2.Name = "label2";
            label2.Size = new Size(294, 37);
            label2.TabIndex = 8;
            label2.Text = "HIGH SCORE GLOBAL:";
            // 
            // lbl_localHS
            // 
            lbl_localHS.Anchor = AnchorStyles.Top;
            lbl_localHS.AutoSize = true;
            lbl_localHS.BackColor = Color.White;
            lbl_localHS.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_localHS.Location = new Point(211, 63);
            lbl_localHS.Name = "lbl_localHS";
            lbl_localHS.Size = new Size(96, 37);
            lbl_localHS.TabIndex = 9;
            lbl_localHS.Text = "label1";
            // 
            // lbl_globalHS
            // 
            lbl_globalHS.Anchor = AnchorStyles.Top;
            lbl_globalHS.AutoSize = true;
            lbl_globalHS.BackColor = Color.White;
            lbl_globalHS.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_globalHS.Location = new Point(219, 63);
            lbl_globalHS.Name = "lbl_globalHS";
            lbl_globalHS.Size = new Size(96, 37);
            lbl_globalHS.TabIndex = 10;
            lbl_globalHS.Text = "label1";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(230, 232, 244);
            panel1.Controls.Add(lbl_Score4);
            panel1.Controls.Add(lbl_Score2);
            panel1.Controls.Add(lbl_Score5);
            panel1.Controls.Add(lbl_Score3);
            panel1.Controls.Add(lbl_Score1);
            panel1.Controls.Add(label_LFS);
            panel1.Location = new Point(262, 703);
            panel1.Name = "panel1";
            panel1.Size = new Size(1081, 107);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.FromArgb(230, 232, 244);
            panel2.Controls.Add(lbl_localHS);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(262, 834);
            panel2.Name = "panel2";
            panel2.Size = new Size(517, 118);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.FromArgb(230, 232, 244);
            panel3.Controls.Add(lbl_globalHS);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(808, 834);
            panel3.Name = "panel3";
            panel3.Size = new Size(535, 118);
            panel3.TabIndex = 13;
            panel3.Paint += panel3_Paint;
            // 
            // btn_Back
            // 
            btn_Back.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Back.BackgroundImage = Properties.Resources.Back_Normal;
            btn_Back.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Back.FlatAppearance.BorderColor = Color.White;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Location = new Point(12, 827);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(118, 118);
            btn_Back.TabIndex = 14;
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.MouseClick += btn_Back_MouseClick;
            btn_Back.MouseEnter += btn_Back_MouseEnter;
            btn_Back.MouseLeave += btn_Back_MouseLeave;
            // 
            // btn_Reset_GHS
            // 
            btn_Reset_GHS.Anchor = AnchorStyles.Top;
            btn_Reset_GHS.BackColor = Color.FromArgb(230, 232, 244);
            btn_Reset_GHS.FlatAppearance.BorderSize = 0;
            btn_Reset_GHS.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Reset_GHS.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Reset_GHS.FlatStyle = FlatStyle.Flat;
            btn_Reset_GHS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Reset_GHS.Location = new Point(1349, 895);
            btn_Reset_GHS.Name = "btn_Reset_GHS";
            btn_Reset_GHS.Size = new Size(112, 57);
            btn_Reset_GHS.TabIndex = 15;
            btn_Reset_GHS.Text = "Clear Global\r\nHighscore";
            btn_Reset_GHS.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_Reset_GHS.UseVisualStyleBackColor = false;
            btn_Reset_GHS.Click += btn_Reset_GHS_Click;
            btn_Reset_GHS.Paint += btn_Reset_GHS_Paint;
            btn_Reset_GHS.MouseEnter += btn_Reset_GHS_MouseEnter;
            btn_Reset_GHS.MouseLeave += btn_Reset_GHS_MouseLeave;
            // 
            // btn_Reset_ALL
            // 
            btn_Reset_ALL.Anchor = AnchorStyles.Top;
            btn_Reset_ALL.BackColor = Color.FromArgb(230, 232, 244);
            btn_Reset_ALL.FlatAppearance.BorderSize = 0;
            btn_Reset_ALL.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Reset_ALL.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Reset_ALL.FlatStyle = FlatStyle.Flat;
            btn_Reset_ALL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Reset_ALL.Location = new Point(1349, 834);
            btn_Reset_ALL.Name = "btn_Reset_ALL";
            btn_Reset_ALL.Size = new Size(112, 57);
            btn_Reset_ALL.TabIndex = 16;
            btn_Reset_ALL.Text = "Clear Local\r\nScores";
            btn_Reset_ALL.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_Reset_ALL.UseVisualStyleBackColor = false;
            btn_Reset_ALL.Click += btn_Reset_ALL_Click;
            btn_Reset_ALL.Paint += btn_Reset_ALL_Paint;
            btn_Reset_ALL.MouseEnter += btn_Reset_ALL_MouseEnter;
            btn_Reset_ALL.MouseLeave += btn_Reset_ALL_MouseLeave;
            // 
            // form_Reaction_Time
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 232, 244);
            ClientSize = new Size(1584, 957);
            Controls.Add(btn_Reset_ALL);
            Controls.Add(btn_Reset_GHS);
            Controls.Add(btn_Back);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(clickPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "form_Reaction_Time";
            Text = "Reaction Time";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            clickPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel clickPanel;
        private Label lbl_Center;
        private Label lbl_Score1;
        private Label lbl_Score3;
        private Label lbl_Score5;
        private Label lbl_Score2;
        private Label lbl_Score4;
        private Label label_LFS;
        private System.Windows.Forms.Timer timer_Start_Game;
        private Label label1;
        private Label label2;
        private Label lbl_localHS;
        private Label lbl_globalHS;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_Back;
        private Button btn_Reset_GHS;
        private Button btn_Reset_ALL;
    }
}