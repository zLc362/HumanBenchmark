using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBenchmark
{
    public static class HighScores
    {
        public static int MAXREACT = 100000;
        public static int Reaction_Time { get;set;}
        public static int Sequence_Memory { get; set; }
        public static int Word_Memory { get; set; }
        public static int Number_Memory { get; set; }

        public static void updateReaction_Time(int reaction_time)
        {
            if (reaction_time < Reaction_Time)
            {
                Reaction_Time = reaction_time;
            }
        }
        public static void updateSequence_memory(int sequence_memory)
        {
            if (sequence_memory > Sequence_Memory)
            {
                Sequence_Memory = sequence_memory;
            }
        }
        public static void updateWord_Memory(int word_memoory)
        {
            if (word_memoory > Word_Memory)
            {
                Word_Memory = word_memoory;
            }
        }
        public static void updateNumber_Memory(int number_memory)
        {
            if (number_memory > Number_Memory)
            {
                Number_Memory = number_memory;
            }
        }
    }
}
