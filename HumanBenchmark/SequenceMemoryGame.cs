using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBenchmark
{
    public class SequenceMemoryGame
    {
        public List<int> OriginalSequence { get; set; }
        public int currNumber { get; set; }
        private int currIndex { get; set; }

        private Random random = new Random();
        public bool Completed { get; set; }
        public bool Failed {get; set; }
        public SequenceMemoryGame()
        {
            OriginalSequence = new List<int>();
            addToOriginalSequence();
            currIndex = 0;
            currNumber = OriginalSequence[0];
            Completed = false;
            Failed = false;
        }
        public void reset()
        {
            Completed = false;
            Failed = false;
            currIndex = 0;
            currNumber = OriginalSequence[currIndex];
        }
        public void addToOriginalSequence()
        {
            OriginalSequence.Add(random.Next(0,9));
        }
        public void playerGuess(int guess)
        {
            if (currIndex < OriginalSequence.Count)
            {
                currNumber = OriginalSequence[currIndex];
                if (currNumber != guess)
                {
                    Failed = true;
                }
                if (currIndex == OriginalSequence.Count - 1)
                {
                    Completed = true;
                }
            }
            else
            {
                Completed = true;
                Failed = false;
            }
            currIndex++;
        }
        public String getStringSequence()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in OriginalSequence)
            {
                sb.Append(i);
                sb.Append(", ");
            }
            return sb.ToString();
        }
    }
}
