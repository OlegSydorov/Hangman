using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaNgMaN
{
    public class Game
    {
        Word word;

        int level;

        string playerName;

        string topic;

        List<char> lettersUsed;

        List<char> lettersNotUsed;

        public Word Word { get { return word; } set { word = value; } }
        public int Level { get { return level; } set { level = value; } }
        public string PlayerName { get { return playerName; } set { playerName = value; } }
        public string Topic { get { return topic; } set { topic = value; } }
        public List<char> LettersUsed { get { return lettersUsed; } set { lettersUsed = value; } }
        public List<char> LettersNotUsed { get { return lettersNotUsed; } set { lettersNotUsed = value; } }

        public Game()
        {
            LettersUsed = new List<char>();
            lettersNotUsed = new List<char>();

        }

        public Game(string line)
        {
            LettersUsed = new List<char>();
            lettersNotUsed = new List<char>();
            char[] delimiter = new char[] { '/' };
            string[] SUBs = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            level = Convert.ToInt32(SUBs[0]);
            word = new Word(SUBs[1]);
            topic = (SUBs[2]);
            playerName = (SUBs[3]);
            if (SUBs[4]!=null) lettersNotUsed.AddRange(SUBs[4].ToCharArray());
            if (SUBs.Length>5) lettersUsed.AddRange(SUBs[5].ToCharArray());
        }

    }

       
}
