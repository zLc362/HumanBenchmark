namespace HumanBenchmark
{
    partial class form_Highscores
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
            panel_Reaction_Time = new Panel();
            panel_Reaction_time_background = new Panel();
            btn_clear_reaction_time = new Button();
            lbl_reaction_time = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btn_clear_Sequence_memory = new Button();
            lbl_Sequence_Memory = new Label();
            label3 = new Label();
            panel_Sequence_Memory = new Panel();
            panel3 = new Panel();
            btn_clear_word_memory = new Button();
            lbl_Word_Memory = new Label();
            label5 = new Label();
            panel_Word_Memory = new Panel();
            panel5 = new Panel();
            btn_clear_number_memory = new Button();
            lbl_Number_Memory = new Label();
            label7 = new Label();
            panel_Number_Memory = new Panel();
            btn_Back = new Button();
            label2 = new Label();
            panel_Reaction_time_background.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Reaction_Time
            // 
            panel_Reaction_Time.Anchor = AnchorStyles.None;
            panel_Reaction_Time.BackColor = Color.White;
            panel_Reaction_Time.BackgroundImage = Properties.Resources.Reaction_Time_Normal;
            panel_Reaction_Time.BackgroundImageLayout = ImageLayout.Zoom;
            panel_Reaction_Time.Location = new Point(14, 1);
            panel_Reaction_Time.Name = "panel_Reaction_Time";
            panel_Reaction_Time.Size = new Size(150, 150);
            panel_Reaction_Time.TabIndex = 10;
            // 
            // panel_Reaction_time_background
            // 
            panel_Reaction_time_background.Anchor = AnchorStyles.None;
            panel_Reaction_time_background.BackColor = SystemColors.MenuHighlight;
            panel_Reaction_time_background.Controls.Add(btn_clear_reaction_time);
            panel_Reaction_time_background.Controls.Add(lbl_reaction_time);
            panel_Reaction_time_background.Controls.Add(label1);
            panel_Reaction_time_background.Controls.Add(panel_Reaction_Time);
            panel_Reaction_time_background.Location = new Point(82, 179);
            panel_Reaction_time_background.Name = "panel_Reaction_time_background";
            panel_Reaction_time_background.Size = new Size(1335, 150);
            panel_Reaction_time_background.TabIndex = 0;
            panel_Reaction_time_background.Paint += panel_Reaction_time_background_Paint;
            // 
            // btn_clear_reaction_time
            // 
            btn_clear_reaction_time.BackColor = Color.White;
            btn_clear_reaction_time.FlatAppearance.BorderSize = 0;
            btn_clear_reaction_time.FlatStyle = FlatStyle.Flat;
            btn_clear_reaction_time.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear_reaction_time.Location = new Point(1207, 26);
            btn_clear_reaction_time.Name = "btn_clear_reaction_time";
            btn_clear_reaction_time.Size = new Size(100, 100);
            btn_clear_reaction_time.TabIndex = 2;
            btn_clear_reaction_time.Text = "CLEAR\r\nSCORE";
            btn_clear_reaction_time.UseVisualStyleBackColor = false;
            btn_clear_reaction_time.Click += btn_clear_reaction_time_Click;
            btn_clear_reaction_time.Paint += btn_clear_reaction_time_Paint;
            // 
            // lbl_reaction_time
            // 
            lbl_reaction_time.BackColor = Color.White;
            lbl_reaction_time.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_reaction_time.Location = new Point(171, 79);
            lbl_reaction_time.Name = "lbl_reaction_time";
            lbl_reaction_time.Size = new Size(237, 56);
            lbl_reaction_time.TabIndex = 1;
            lbl_reaction_time.Text = "label2";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(171, 26);
            label1.Name = "label1";
            label1.Size = new Size(298, 53);
            label1.TabIndex = 0;
            label1.Text = "Reaction Time:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(btn_clear_Sequence_memory);
            panel1.Controls.Add(lbl_Sequence_Memory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel_Sequence_Memory);
            panel1.Location = new Point(82, 355);
            panel1.Name = "panel1";
            panel1.Size = new Size(1335, 150);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // btn_clear_Sequence_memory
            // 
            btn_clear_Sequence_memory.BackColor = Color.White;
            btn_clear_Sequence_memory.FlatAppearance.BorderSize = 0;
            btn_clear_Sequence_memory.FlatStyle = FlatStyle.Flat;
            btn_clear_Sequence_memory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clear_Sequence_memory.Location = new Point(1207, 26);
            btn_clear_Sequence_memory.Name = "btn_clear_Sequence_memory";
            btn_clear_Sequence_memory.Size = new Size(100, 100);
            btn_clear_Sequence_memory.TabIndex = 2;
            btn_clear_Sequence_memory.Text = "Clear\r\nScore";
            btn_clear_Sequence_memory.UseVisualStyleBackColor = false;
            btn_clear_Sequence_memory.Click += btn_clear_Sequence_memory_Click;
            btn_clear_Sequence_memory.Paint += btn_clear_Sequence_memory_Paint;
            // 
            // lbl_Sequence_Memory
            // 
            lbl_Sequence_Memory.BackColor = Color.White;
            lbl_Sequence_Memory.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Sequence_Memory.Location = new Point(171, 70);
            lbl_Sequence_Memory.Name = "lbl_Sequence_Memory";
            lbl_Sequence_Memory.Size = new Size(237, 56);
            lbl_Sequence_Memory.TabIndex = 1;
            lbl_Sequence_Memory.Text = "label2";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(171, 17);
            label3.Name = "label3";
            label3.Size = new Size(298, 53);
            label3.TabIndex = 0;
            label3.Text = "Sequence Memory:";
            // 
            // panel_Sequence_Memory
            // 
            panel_Sequence_Memory.Anchor = AnchorStyles.None;
            panel_Sequence_Memory.BackColor = Color.White;
            panel_Sequence_Memory.BackgroundImage = Properties.Resources.Sequence_Memory_Normal;
            panel_Sequence_Memory.BackgroundImageLayout = ImageLayout.Zoom;
            panel_Sequence_Memory.Location = new Point(14, 1);
            panel_Sequence_Memory.Name = "panel_Sequence_Memory";
            panel_Sequence_Memory.Size = new Size(150, 150);
            panel_Sequence_Memory.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.Controls.Add(btn_clear_word_memory);
            panel3.Controls.Add(lbl_Word_Memory);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(panel_Word_Memory);
            panel3.Location = new Point(82, 528);
            panel3.Name = "panel3";
            panel3.Size = new Size(1335, 150);
            panel3.TabIndex = 13;
            panel3.Paint += panel3_Paint;
            // 
            // btn_clear_word_memory
            // 
            btn_clear_word_memory.BackColor = Color.White;
            btn_clear_word_memory.FlatAppearance.BorderSize = 0;
            btn_clear_word_memory.FlatStyle = FlatStyle.Flat;
            btn_clear_word_memory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clear_word_memory.Location = new Point(1207, 26);
            btn_clear_word_memory.Name = "btn_clear_word_memory";
            btn_clear_word_memory.Size = new Size(100, 100);
            btn_clear_word_memory.TabIndex = 2;
            btn_clear_word_memory.Text = "Clear\r\nScore";
            btn_clear_word_memory.UseVisualStyleBackColor = false;
            btn_clear_word_memory.Click += btn_clear_word_memory_Click;
            btn_clear_word_memory.Paint += btn_clear_word_memory_Paint;
            // 
            // lbl_Word_Memory
            // 
            lbl_Word_Memory.BackColor = Color.White;
            lbl_Word_Memory.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Word_Memory.Location = new Point(171, 70);
            lbl_Word_Memory.Name = "lbl_Word_Memory";
            lbl_Word_Memory.Size = new Size(237, 56);
            lbl_Word_Memory.TabIndex = 1;
            lbl_Word_Memory.Text = "label2";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(171, 17);
            label5.Name = "label5";
            label5.Size = new Size(298, 53);
            label5.TabIndex = 0;
            label5.Text = "Word Memory:";
            // 
            // panel_Word_Memory
            // 
            panel_Word_Memory.Anchor = AnchorStyles.None;
            panel_Word_Memory.BackColor = Color.White;
            panel_Word_Memory.BackgroundImage = Properties.Resources.Word_Memory_Normal;
            panel_Word_Memory.BackgroundImageLayout = ImageLayout.Zoom;
            panel_Word_Memory.Location = new Point(14, 1);
            panel_Word_Memory.Name = "panel_Word_Memory";
            panel_Word_Memory.Size = new Size(150, 150);
            panel_Word_Memory.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = SystemColors.MenuHighlight;
            panel5.Controls.Add(btn_clear_number_memory);
            panel5.Controls.Add(lbl_Number_Memory);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(panel_Number_Memory);
            panel5.Location = new Point(82, 701);
            panel5.Name = "panel5";
            panel5.Size = new Size(1335, 150);
            panel5.TabIndex = 15;
            panel5.Paint += panel5_Paint;
            // 
            // btn_clear_number_memory
            // 
            btn_clear_number_memory.BackColor = Color.White;
            btn_clear_number_memory.FlatAppearance.BorderSize = 0;
            btn_clear_number_memory.FlatStyle = FlatStyle.Flat;
            btn_clear_number_memory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clear_number_memory.Location = new Point(1207, 26);
            btn_clear_number_memory.Name = "btn_clear_number_memory";
            btn_clear_number_memory.Size = new Size(100, 100);
            btn_clear_number_memory.TabIndex = 2;
            btn_clear_number_memory.Text = "Clear\r\nScore";
            btn_clear_number_memory.UseVisualStyleBackColor = false;
            btn_clear_number_memory.Click += btn_clear_number_memory_Click;
            btn_clear_number_memory.Paint += btn_clear_number_memory_Paint;
            // 
            // lbl_Number_Memory
            // 
            lbl_Number_Memory.BackColor = Color.White;
            lbl_Number_Memory.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Number_Memory.Location = new Point(171, 70);
            lbl_Number_Memory.Name = "lbl_Number_Memory";
            lbl_Number_Memory.Size = new Size(237, 56);
            lbl_Number_Memory.TabIndex = 1;
            lbl_Number_Memory.Text = "label2";
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(171, 17);
            label7.Name = "label7";
            label7.Size = new Size(298, 53);
            label7.TabIndex = 0;
            label7.Text = "Number Memory:";
            // 
            // panel_Number_Memory
            // 
            panel_Number_Memory.Anchor = AnchorStyles.None;
            panel_Number_Memory.BackColor = Color.White;
            panel_Number_Memory.BackgroundImage = Properties.Resources.Number_Memory_Normal;
            panel_Number_Memory.BackgroundImageLayout = ImageLayout.Zoom;
            panel_Number_Memory.Location = new Point(14, 1);
            panel_Number_Memory.Name = "panel_Number_Memory";
            panel_Number_Memory.Size = new Size(150, 150);
            panel_Number_Memory.TabIndex = 16;
            // 
            // btn_Back
            // 
            btn_Back.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Back.BackgroundImage = Properties.Resources.Back_Normal;
            btn_Back.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Back.FlatAppearance.BorderColor = Color.White;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Location = new Point(12, 872);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(150, 150);
            btn_Back.TabIndex = 15;
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            btn_Back.MouseEnter += btn_Back_MouseEnter;
            btn_Back.MouseLeave += btn_Back_MouseLeave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(608, 78);
            label2.Name = "label2";
            label2.Size = new Size(341, 67);
            label2.TabIndex = 17;
            label2.Text = "HIGHSCORES";
            // 
            // form_Highscores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1501, 1034);
            Controls.Add(panel_Reaction_time_background);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btn_Back);
            Controls.Add(panel5);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_Highscores";
            Text = "Highscores";
            WindowState = FormWindowState.Maximized;
            panel_Reaction_time_background.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Reaction_Time;
        private Panel panel_Reaction_time_background;
        private Button btn_clear_reaction_time;
        private Label lbl_reaction_time;
        private Label label1;
        private Panel panel1;
        private Button btn_clear_Sequence_memory;
        private Label lbl_Sequence_Memory;
        private Label label3;
        private Panel panel_Sequence_Memory;
        private Panel panel3;
        private Button btn_clear_word_memory;
        private Label lbl_Word_Memory;
        private Label label5;
        private Panel panel_Word_Memory;
        private Panel panel5;
        private Button btn_clear_number_memory;
        private Label lbl_Number_Memory;
        private Label label7;
        private Panel panel_Number_Memory;
        private Button btn_Back;
        private Label label2;
    }
}