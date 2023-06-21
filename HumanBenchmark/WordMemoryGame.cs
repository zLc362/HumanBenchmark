using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBenchmark
{
    public class WordMemoryGame
    {
        public List<String> words { get; set; }
        public List<String> guessedWords { get; set; }
        public WordMemoryGame() {
            words = new List<String>();
            guessedWords = new List<String>();
            populateWords();
        }
        public void clearGuesses()
        {
            guessedWords.Clear();
        }
        private void populateWords()
        {
            words.Add("lucky");
            words.Add("trick");
            words.Add("scribble");
            words.Add("hollow");
            words.Add("observant");
            words.Add("saw");
            words.Add("null");
            words.Add("ban");
            words.Add("wire");
            words.Add("guard");
            words.Add("ice");
            words.Add("panicky");
            words.Add("wandering");
            words.Add("guitar");
            words.Add("cooperative");
            words.Add("beautiful");
            words.Add("whispering");
            words.Add("tail");
            words.Add("permissible");
            words.Add("ill-fated");
            words.Add("invention");
            words.Add("basin");
            words.Add("chew");
            words.Add("flow");
            words.Add("ignorant");
            words.Add("unequaled");
            words.Add("jumbled");
            words.Add("pleasure");
            words.Add("unadvised");
            words.Add("penitent");
            words.Add("print");
            words.Add("robin");
            words.Add("suppose");
            words.Add("psychedelic");
            words.Add("trains");
            words.Add("ants");
            words.Add("gaudy");
            words.Add("sister");
            words.Add("wind");
            words.Add("fold");
            words.Add("equable");
            words.Add("challenge");
            words.Add("mushy");
            words.Add("jolly");
            words.Add("defective");
            words.Add("dry");
            words.Add("discreet");
            words.Add("truck");
            words.Add("ahead");
            words.Add("ceaseless");
            words.Add("lick");
            words.Add("dock");
            words.Add("miss");
            words.Add("poke");
            words.Add("watch");
            words.Add("nutritious");
            words.Add("cheer");
            words.Add("decorous");
            words.Add("colorful");
            words.Add("stir");
            words.Add("tendency");
            words.Add("signal");
            words.Add("rare");
            words.Add("shape");
            words.Add("remind");
            words.Add("gather");
            words.Add("special");
            words.Add("rebel");
            words.Add("touch");
            words.Add("hushed");
            words.Add("clever");
            words.Add("belligerent");
            words.Add("cent");
            words.Add("pink");
            words.Add("swift");
            words.Add("alarm");
            words.Add("division");
            words.Add("stew");
            words.Add("meek");
            words.Add("camera");
            words.Add("fall");
            words.Add("greedy");
            words.Add("channel");
            words.Add("draconian");
            words.Add("truculent");
            words.Add("broad");
            words.Add("childlike");
            words.Add("malicious");
            words.Add("scrape");
            words.Add("frequent");
            words.Add("imminent");
            words.Add("story");
            words.Add("twist");
            words.Add("hunt");
            words.Add("groan");
            words.Add("cuddly");
            words.Add("float");
            words.Add("volatile");
            words.Add("file");

        }
        public bool guessWord(string word)
        {
            if (guessedWords.Contains(word)) return false;
            else
            {
                guessedWords.Add(word);
                return true;
            }
        }
        public String getRandomWord()
        {
            Random random = new Random();
            return words[random.Next(words.Count)];
        }
    }
}
