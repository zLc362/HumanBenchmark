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
            btn_Back = new Button();
            lbl_Center = new Label();
            button1 = new Button();
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
            // 
            // lbl_Center
            // 
            lbl_Center.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Center.ForeColor = Color.White;
            lbl_Center.Location = new Point(345, 274);
            lbl_Center.Name = "lbl_Center";
            lbl_Center.Size = new Size(761, 170);
            lbl_Center.TabIndex = 0;
            lbl_Center.Text = "A number will briefly show on the screen\r\nAfter it dissapears, write down the number";
            lbl_Center.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(668, 473);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            // 
            // form_Number_Memory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1434, 741);
            Controls.Add(button1);
            Controls.Add(lbl_Center);
            Controls.Add(btn_Back);
            Name = "form_Number_Memory";
            Text = "form_Number_Memory";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Back;
        private Label lbl_Center;
        private Button button1;
    }
}