using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaNgMaN
{
   public class Word
    {
        string text;
        int length;
        List<char> letters;
        Dictionary<char, int> letterCount;
        Dictionary<char, int> letterSeq;
        string topic;

        public string Text { get { return text; } set { text = value; } }
        public string Topic { get { return topic; } set { topic = value; } }
        public int Length { get { return length; } set { length = value; } }
        public List<char> Letters { get { return letters; } set { letters = value; } }
        public Dictionary<char, int> LetterCount { get { return letterCount; } set { letterCount = value; } }
        public Dictionary<char, int> LetterSeq { get { return letterSeq; } set { letterSeq = value; } }


        public Word(string word)
        {
            text = word;
            length = word.Length;
            letters = new List<char>();
            letterCount = new Dictionary<char, int>();
            //letterSeq = new Dictionary<char, int>();

            char[] arr = word.ToCharArray();
            letters = arr.ToList();
            //int num=1;
            //foreach (char c in letters)
            //{
            //    letterSeq.Add(c, num);
            //    num++;
            //}
            foreach (char c in letters)
            {
                if (letterCount.ContainsKey(c))
                    letterCount[c]++;
                else letterCount.Add(c, 1);
            }
            topic = null;

        }
    }
}
