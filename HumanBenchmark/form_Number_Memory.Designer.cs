namespace HumanBenchmark
{
    partial class form_Number_Memory
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
            btn_Back = new Button();
            lbl_Center = new Label();
            btn_Start_Next = new Button();
            progress_bar_back = new Panel();
            progress_bar_front = new Panel();
            tmr_countdown = new System.Windows.Forms.Timer(components);
            tbx_number_enter = new TextBox();
            lbl_highscore = new Label();
            SuspendLayout();
            // 
            // btn_Back
            // 
            btn_Back.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Back.BackgroundImage = Properties.Resources.Back_Normal;
            btn_Back.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Back.FlatAppearance.BorderColor = Color.White;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Location = new Point(12, 611);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(118, 118);
            btn_Back.TabIndex = 15;
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lbl_Center
            // 
            lbl_Center.Anchor = AnchorStyles.None;
            lbl_Center.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Center.ForeColor = Color.White;
            lbl_Center.Location = new Point(345, 131);
            lbl_Center.Name = "lbl_Center";
            lbl_Center.Size = new Size(761, 313);
            lbl_Center.TabIndex = 0;
            lbl_Center.Text = "A number will briefly show on the screen\r\nAfter it dissapears, write down the number";
            lbl_Center.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Start_Next
            // 
            btn_Start_Next.Anchor = AnchorStyles.None;
            btn_Start_Next.FlatAppearance.BorderSize = 0;
            btn_Start_Next.FlatStyle = FlatStyle.Flat;
            btn_Start_Next.Location = new Point(644, 459);
            btn_Start_Next.Name = "btn_Start_Next";
            btn_Start_Next.Size = new Size(157, 61);
            btn_Start_Next.TabIndex = 1;
            btn_Start_Next.Text = "Start";
            btn_Start_Next.UseVisualStyleBackColor = true;
            btn_Start_Next.Click += btn_Start_Next_Click;
            btn_Start_Next.Paint += btn_Start_Next_Paint;
            // 
            // progress_bar_back
            // 
            progress_bar_back.Anchor = AnchorStyles.None;
            progress_bar_back.BackColor = SystemColors.HotTrack;
            progress_bar_back.Location = new Point(579, 419);
            progress_bar_back.Name = "progress_bar_back";
            progress_bar_back.Size = new Size(283, 23);
            progress_bar_back.TabIndex = 17;
            // 
            // progress_bar_front
            // 
            progress_bar_front.Anchor = AnchorStyles.None;
            progress_bar_front.BackColor = Color.White;
            progress_bar_front.Location = new Point(579, 419);
            progress_bar_front.Name = "progress_bar_front";
            progress_bar_front.Size = new Size(283, 23);
            progress_bar_front.TabIndex = 18;
            // 
            // tmr_countdown
            // 
            tmr_countdown.Interval = 10;
            tmr_countdown.Tick += tmr_countdown_Tick;
            // 
            // tbx_number_enter
            // 
            tbx_number_enter.Anchor = AnchorStyles.None;
            tbx_number_enter.BackColor = SystemColors.MenuHighlight;
            tbx_number_enter.BorderStyle = BorderStyle.None;
            tbx_number_enter.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_number_enter.Location = new Point(361, 281);
            tbx_number_enter.Name = "tbx_number_enter";
            tbx_number_enter.Size = new Size(728, 54);
            tbx_number_enter.TabIndex = 18;
            tbx_number_enter.TextAlign = HorizontalAlignment.Center;
            tbx_number_enter.KeyPress += tbx_number_enter_KeyPress;
            // 
            // lbl_highscore
            // 
            lbl_highscore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_highscore.AutoSize = true;
            lbl_highscore.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_highscore.Location = new Point(1262, 669);
            lbl_highscore.Name = "lbl_highscore";
            lbl_highscore.Size = new Size(160, 60);
            lbl_highscore.TabIndex = 19;
            lbl_highscore.Text = "Level 0";
            lbl_highscore.Paint += lbl_highscore_Paint;
            // 
            // form_Number_Memory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1434, 741);
            Controls.Add(progress_bar_front);
            Controls.Add(lbl_highscore);
            Controls.Add(tbx_number_enter);
            Controls.Add(progress_bar_back);
            Controls.Add(btn_Start_Next);
            Controls.Add(lbl_Center);
            Controls.Add(btn_Back);
            Name = "form_Number_Memory";
            Text = "form_Number_Memory";
            WindowState = FormWindowState.Maximized;
            FormClosing += form_Number_Memory_FormClosing;
            Paint += form_Number_Memory_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Back;
        private Label lbl_Center;
        private Button btn_Start_Next;
        private Panel progress_bar_back;
        private Panel progress_bar_front;
        private System.Windows.Forms.Timer tmr_countdown;
        private TextBox tbx_number_enter;
        private Label lbl_highscore;
    }
}