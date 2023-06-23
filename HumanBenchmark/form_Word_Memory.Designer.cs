namespace HumanBenchmark
{
    partial class form_Word_Memory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Word_Memory));
            btn_Start = new Button();
            lbl_Center = new Label();
            btn_Back = new Button();
            btn_New = new Button();
            btn_Seen = new Button();
            SuspendLayout();
            // 
            // btn_Start
            // 
            btn_Start.Anchor = AnchorStyles.None;
            btn_Start.FlatAppearance.BorderSize = 0;
            btn_Start.FlatStyle = FlatStyle.Flat;
            btn_Start.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Start.Location = new Point(631, 453);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(157, 61);
            btn_Start.TabIndex = 2;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            btn_Start.Paint += btn_Start_Paint;
            btn_Start.MouseEnter += btn_Start_MouseEnter;
            btn_Start.MouseLeave += btn_Start_MouseLeave;
            // 
            // lbl_Center
            // 
            lbl_Center.Anchor = AnchorStyles.None;
            lbl_Center.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Center.ForeColor = Color.White;
            lbl_Center.Location = new Point(290, 137);
            lbl_Center.Name = "lbl_Center";
            lbl_Center.Size = new Size(847, 313);
            lbl_Center.TabIndex = 3;
            lbl_Center.Text = "A word will show on the screen,\r\nsay if it has shown up before or not";
            lbl_Center.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Back
            // 
            btn_Back.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Back.BackgroundImage = Properties.Resources.Back_Normal;
            btn_Back.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Back.FlatAppearance.BorderColor = Color.White;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Location = new Point(12, 575);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(150, 150);
            btn_Back.TabIndex = 16;
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            btn_Back.MouseEnter += btn_Back_MouseEnter;
            btn_Back.MouseLeave += btn_Back_MouseLeave;
            // 
            // btn_New
            // 
            btn_New.Anchor = AnchorStyles.None;
            btn_New.FlatAppearance.BorderSize = 0;
            btn_New.FlatStyle = FlatStyle.Flat;
            btn_New.Location = new Point(545, 453);
            btn_New.Name = "btn_New";
            btn_New.Size = new Size(157, 61);
            btn_New.TabIndex = 17;
            btn_New.Text = "NEW";
            btn_New.UseVisualStyleBackColor = true;
            btn_New.Click += btn_New_Click;
            btn_New.Paint += btn_New_Paint;
            btn_New.MouseEnter += btn_New_MouseEnter;
            btn_New.MouseLeave += btn_New_MouseLeave;
            // 
            // btn_Seen
            // 
            btn_Seen.Anchor = AnchorStyles.None;
            btn_Seen.FlatAppearance.BorderSize = 0;
            btn_Seen.FlatStyle = FlatStyle.Flat;
            btn_Seen.Location = new Point(719, 453);
            btn_Seen.Name = "btn_Seen";
            btn_Seen.Size = new Size(157, 61);
            btn_Seen.TabIndex = 18;
            btn_Seen.Text = "SEEN";
            btn_Seen.UseVisualStyleBackColor = true;
            btn_Seen.Click += btn_Seen_Click;
            btn_Seen.Paint += btn_Seen_Paint;
            btn_Seen.MouseEnter += btn_Seen_MouseEnter;
            btn_Seen.MouseLeave += btn_Seen_MouseLeave;
            // 
            // form_Word_Memory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1395, 737);
            Controls.Add(btn_Seen);
            Controls.Add(btn_New);
            Controls.Add(btn_Back);
            Controls.Add(lbl_Center);
            Controls.Add(btn_Start);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "form_Word_Memory";
            Text = "form_Word_Memory";
            WindowState = FormWindowState.Maximized;
            FormClosing += form_Word_Memory_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Start;
        private Label lbl_Center;
        private Button btn_Back;
        private Button btn_New;
        private Button btn_Seen;
    }
}