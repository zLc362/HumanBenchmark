using HumanBenchmark.Properties;


namespace HumanBenchmark
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            DoubleBuffered = true;
            Startup();

        }
        private void Startup()
        {
            btn_Reaction_Time.BackgroundImage = Resources.Reaction_Time_Normal;
            btn_Number_Memory.BackgroundImage = Resources.Number_Memory_Normal;
            btn_Sequence_Memory.BackgroundImage = Resources.Sequence_Memory_Normal;
            btn_Word_Memory.BackgroundImage = Resources.Word_Memory_Normal;
            btn_Shut_Down.BackgroundImage = Resources.Shut_Down_Normal;

            disableHoverColorChange(btn_Reaction_Time);
            disableHoverColorChange(btn_Number_Memory);
            disableHoverColorChange(btn_Sequence_Memory);
            disableHoverColorChange(btn_Word_Memory);
            disableHoverColorChange(btn_Shut_Down);

            HighScores.Reaction_Time = Properties.Settings.Default.ReactionTime;
            HighScores.Word_Memory = Properties.Settings.Default.WordMemory;
            HighScores.Sequence_Memory = Properties.Settings.Default.SequenceMemory;
            HighScores.Number_Memory = Properties.Settings.Default.NumberMemory;


        }
        public static void disableHoverColorChange(Button button)
        {
            button.FlatAppearance.MouseOverBackColor = button.BackColor;
            button.BackColorChanged += (s, e) =>
            {
                button.FlatAppearance.MouseOverBackColor = button.BackColor;
            };
        }
        private void btn_Reaction_Time_MouseEnter(object sender, EventArgs e)
        {
            btn_Reaction_Time.BackgroundImage = Resources.Reaction_Time_Active;
        }

        private void btn_Reaction_Time_MouseLeave(object sender, EventArgs e)
        {
            btn_Reaction_Time.BackgroundImage = Resources.Reaction_Time_Normal;
        }

        private void btn_Number_Memory_MouseEnter(object sender, EventArgs e)
        {
            btn_Number_Memory.BackgroundImage = Resources.Number_Memory_Active;
        }

        private void btn_Number_Memory_MouseLeave(object sender, EventArgs e)
        {
            btn_Number_Memory.BackgroundImage = Resources.Number_Memory_Normal;
        }

        private void btn_Sequence_Memory_MouseLeave(object sender, EventArgs e)
        {
            btn_Sequence_Memory.BackgroundImage = Resources.Sequence_Memory_Normal;
        }

        private void btn_Sequence_Memory_MouseEnter(object sender, EventArgs e)
        {
            btn_Sequence_Memory.BackgroundImage = Resources.Sequence_Memory_Active;
        }

        private void btn_Word_Memory_MouseEnter(object sender, EventArgs e)
        {
            btn_Word_Memory.BackgroundImage = Resources.Word_Memory_Active;
        }

        private void btn_Word_Memory_MouseLeave(object sender, EventArgs e)
        {
            btn_Word_Memory.BackgroundImage = Resources.Word_Memory_Normal;
        }

        private void btn_Reaction_Time_Click(object sender, EventArgs e)
        {
            Form reactionTime = new form_Reaction_Time();
            this.Hide();
            reactionTime.ShowDialog();

            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ReactionTime = HighScores.Reaction_Time;
            Properties.Settings.Default.SequenceMemory = HighScores.Sequence_Memory;
            Properties.Settings.Default.WordMemory = HighScores.Word_Memory;
            Properties.Settings.Default.NumberMemory = HighScores.Number_Memory;
            Properties.Settings.Default.Save();
        }

        private void btn_Shut_Down_MouseEnter(object sender, EventArgs e)
        {
            btn_Shut_Down.BackgroundImage = Resources.Shut_Down_Active;
        }

        private void btn_Shut_Down_MouseLeave(object sender, EventArgs e)
        {
            btn_Shut_Down.BackgroundImage = Resources.Shut_Down_Normal;
        }

        private void btn_Shut_Down_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Number_Memory_Click(object sender, EventArgs e)
        {
            Form number_memory = new form_Number_Memory();
            this.Hide();
            number_memory.ShowDialog();

            this.Show();
        }
    }
}