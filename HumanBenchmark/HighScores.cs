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
        public static int Reaction_Time { get; set; } = 100000;
        public static int Sequence_Memory { get; set; } = 0;
        public static int Word_Memory { get; set; } = 0;
        public static int Number_Memory { get; set; } = 0;

        public static void resetReaction_time()
        {
            Reaction_Time = MAXREACT;
        }
        public static void updateReaction_Time(int reaction_time)
        {
            if (reaction_time < Reaction_Time)
            {
                Reaction_Time = reaction_time;
            }
        }
        public static void resetSequence_Memory()
        {
            Sequence_Memory = 0;
        }
        public static void updateSequence_memory(int sequence_memory)
        {
            if (sequence_memory > Sequence_Memory)
            {
                Sequence_Memory = sequence_memory;
            }
        }
        public static void resetWord_Memory()
        {
            Word_Memory = 0;
        }
        public static void updateWord_Memory(int word_memoory)
        {
            if (word_memoory > Word_Memory)
            {
                Word_Memory = word_memoory;
            }
        }
        public static void resetNumber_Memory()
        {
            Number_Memory = 0;
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
