using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBenchmark
{
    public class ReactionTimeScores
    {
        public int score1 { get; set; }
        public int score2 { get; set; }
        public int score3 { get; set; }
        public int score4 { get; set; }
        public int score5 { get; set; }
        public int highScore { get; set; }
        public ReactionTimeScores()
        {
            score1 = 0;
            score2 = 0;
            score3 = 0;
            score4 = 0;
            score5 = 0;
            highScore = HighScores.MAXREACT;
        }
        public void newScore(int score)
        {
            score1 = score2;
            score2 = score3;
            score3 = score4;
            score4 = score5;
            score5 = score;
            if (score < highScore)
            {
                highScore = score;
                HighScores.updateReaction_Time(score);
            }
        }
        public void clearScores()
        {
            score1 = 0;
            score2 = 0;
            score3 = 0;
            score4 = 0;
            score5 = 0;
            highScore = HighScores.MAXREACT;
        }
    }
}
