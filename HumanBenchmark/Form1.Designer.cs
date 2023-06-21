namespace HumanBenchmark
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_Reaction_Time = new Button();
            btn_Number_Memory = new Button();
            btn_Sequence_Memory = new Button();
            btn_Word_Memory = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_Shut_Down = new Button();
            btn_highscores = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(527, -5);
            label1.Name = "label1";
            label1.Size = new Size(462, 67);
            label1.TabIndex = 0;
            label1.Text = "Human Benchmark";
            // 
            // btn_Reaction_Time
            // 
            btn_Reaction_Time.Anchor = AnchorStyles.None;
            btn_Reaction_Time.BackColor = SystemColors.MenuHighlight;
            btn_Reaction_Time.BackgroundImage = Properties.Resources.Reaction_Time_Normal;
            btn_Reaction_Time.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Reaction_Time.CausesValidation = false;
            btn_Reaction_Time.FlatAppearance.BorderSize = 0;
            btn_Reaction_Time.FlatStyle = FlatStyle.Flat;
            btn_Reaction_Time.Location = new Point(199, 186);
            btn_Reaction_Time.Name = "btn_Reaction_Time";
            btn_Reaction_Time.Size = new Size(250, 250);
            btn_Reaction_Time.TabIndex = 1;
            btn_Reaction_Time.UseVisualStyleBackColor = false;
            btn_Reaction_Time.Click += btn_Reaction_Time_Click;
            btn_Reaction_Time.MouseEnter += btn_Reaction_Time_MouseEnter;
            btn_Reaction_Time.MouseLeave += btn_Reaction_Time_MouseLeave;
            // 
            // btn_Number_Memory
            // 
            btn_Number_Memory.Anchor = AnchorStyles.None;
            btn_Number_Memory.BackColor = SystemColors.MenuHighlight;
            btn_Number_Memory.BackgroundImage = Properties.Resources.Number_Memory_Normal;
            btn_Number_Memory.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Number_Memory.CausesValidation = false;
            btn_Number_Memory.FlatAppearance.BorderSize = 0;
            btn_Number_Memory.FlatStyle = FlatStyle.Flat;
            btn_Number_Memory.Location = new Point(1090, 186);
            btn_Number_Memory.Name = "btn_Number_Memory";
            btn_Number_Memory.Size = new Size(250, 250);
            btn_Number_Memory.TabIndex = 2;
            btn_Number_Memory.UseVisualStyleBackColor = false;
            btn_Number_Memory.Click += btn_Number_Memory_Click;
            btn_Number_Memory.MouseEnter += btn_Number_Memory_MouseEnter;
            btn_Number_Memory.MouseLeave += btn_Number_Memory_MouseLeave;
            // 
            // btn_Sequence_Memory
            // 
            btn_Sequence_Memory.Anchor = AnchorStyles.None;
            btn_Sequence_Memory.BackColor = SystemColors.MenuHighlight;
            btn_Sequence_Memory.BackgroundImage = Properties.Resources.Sequence_Memory_Normal;
            btn_Sequence_Memory.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Sequence_Memory.CausesValidation = false;
            btn_Sequence_Memory.FlatAppearance.BorderSize = 0;
            btn_Sequence_Memory.FlatStyle = FlatStyle.Flat;
            btn_Sequence_Memory.Location = new Point(497, 186);
            btn_Sequence_Memory.Name = "btn_Sequence_Memory";
            btn_Sequence_Memory.Size = new Size(250, 250);
            btn_Sequence_Memory.TabIndex = 3;
            btn_Sequence_Memory.UseVisualStyleBackColor = false;
            btn_Sequence_Memory.MouseEnter += btn_Sequence_Memory_MouseEnter;
            btn_Sequence_Memory.MouseLeave += btn_Sequence_Memory_MouseLeave;
            // 
            // btn_Word_Memory
            // 
            btn_Word_Memory.Anchor = AnchorStyles.None;
            btn_Word_Memory.BackColor = SystemColors.MenuHighlight;
            btn_Word_Memory.BackgroundImage = Properties.Resources.Word_Memory_Normal;
            btn_Word_Memory.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Word_Memory.CausesValidation = false;
            btn_Word_Memory.FlatAppearance.BorderSize = 0;
            btn_Word_Memory.FlatStyle = FlatStyle.Flat;
            btn_Word_Memory.Location = new Point(789, 186);
            btn_Word_Memory.Name = "btn_Word_Memory";
            btn_Word_Memory.Size = new Size(250, 250);
            btn_Word_Memory.TabIndex = 4;
            btn_Word_Memory.UseVisualStyleBackColor = false;
            btn_Word_Memory.Click += btn_Word_Memory_Click;
            btn_Word_Memory.MouseEnter += btn_Word_Memory_MouseEnter;
            btn_Word_Memory.MouseLeave += btn_Word_Memory_MouseLeave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(263, 439);
            label2.Name = "label2";
            label2.Size = new Size(116, 70);
            label2.TabIndex = 5;
            label2.Text = "Reaction\r\nTime\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1159, 439);
            label3.Name = "label3";
            label3.Size = new Size(115, 70);
            label3.TabIndex = 6;
            label3.Text = "Number\r\nMemory";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(560, 439);
            label4.Name = "label4";
            label4.Size = new Size(128, 70);
            label4.TabIndex = 7;
            label4.Text = "Sequence\r\nMemory";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(859, 439);
            label5.Name = "label5";
            label5.Size = new Size(115, 70);
            label5.TabIndex = 8;
            label5.Text = "Word\r\nMemory";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_Shut_Down
            // 
            btn_Shut_Down.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Shut_Down.BackColor = SystemColors.MenuHighlight;
            btn_Shut_Down.BackgroundImage = Properties.Resources.Back_Normal;
            btn_Shut_Down.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Shut_Down.CausesValidation = false;
            btn_Shut_Down.FlatAppearance.BorderSize = 0;
            btn_Shut_Down.FlatStyle = FlatStyle.Flat;
            btn_Shut_Down.Location = new Point(12, 490);
            btn_Shut_Down.Name = "btn_Shut_Down";
            btn_Shut_Down.Size = new Size(150, 150);
            btn_Shut_Down.TabIndex = 9;
            btn_Shut_Down.UseVisualStyleBackColor = false;
            btn_Shut_Down.Click += btn_Shut_Down_Click;
            btn_Shut_Down.MouseEnter += btn_Shut_Down_MouseEnter;
            btn_Shut_Down.MouseLeave += btn_Shut_Down_MouseLeave;
            // 
            // btn_highscores
            // 
            btn_highscores.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_highscores.BackColor = SystemColors.MenuHighlight;
            btn_highscores.BackgroundImage = Properties.Resources.Highscore_Normal;
            btn_highscores.BackgroundImageLayout = ImageLayout.Zoom;
            btn_highscores.CausesValidation = false;
            btn_highscores.FlatAppearance.BorderSize = 0;
            btn_highscores.FlatStyle = FlatStyle.Flat;
            btn_highscores.Location = new Point(1365, 490);
            btn_highscores.Name = "btn_highscores";
            btn_highscores.Size = new Size(150, 150);
            btn_highscores.TabIndex = 10;
            btn_highscores.UseVisualStyleBackColor = false;
            btn_highscores.Click += btn_highscores_Click;
            btn_highscores.MouseEnter += btn_highscores_MouseEnter;
            btn_highscores.MouseLeave += btn_highscores_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1527, 652);
            Controls.Add(btn_highscores);
            Controls.Add(btn_Shut_Down);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_Word_Memory);
            Controls.Add(btn_Sequence_Memory);
            Controls.Add(btn_Number_Memory);
            Controls.Add(btn_Reaction_Time);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Human Benchmark";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Reaction_Time;
        private Button btn_Number_Memory;
        private Button btn_Sequence_Memory;
        private Button btn_Word_Memory;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_Shut_Down;
        private Button btn_highscores;
    }
}