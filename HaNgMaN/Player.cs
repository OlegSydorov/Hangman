using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaNgMaN
{
    public class PlayerPointsFirst : Comparer<Player>
    {
      
        public override int Compare(Player a, Player b)
        {
            if (b.Points.CompareTo(a.Points) != 0)
            {
                return b.Points.CompareTo(a.Points);
            }
          
            else
            {
                return 0;
            }
        }
    }
    public class Player //: IComparer<Player>
    {
        string name;
        int games;
        int wins;
        int points;
        bool gameComplete;

        public string Name { get { return name; } set { name = value; } }
        public int Games { get { return games; } set { games = value; } }
        public int Wins { get { return wins; } set { wins = value; } }
        public int Points { get { return points; } set { points = value; } }

        public bool GameComplete { get { return gameComplete; } set { gameComplete = value; } }

        public Player(string s)
        {
            char[] delimiter = new char[] { ' ' };
            string[] SUBs = s.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            name = SUBs[0];
            games = Convert.ToInt32(SUBs[1]);
            wins = Convert.ToInt32(SUBs[2]);
            points = Convert.ToInt32(SUBs[3]);
            gameComplete = (SUBs[4] == "1") ? true : false;

        }

        //public int Compare(Player a, Player b)
        //{
        //    if (a.Points.CompareTo(b.Points) != 0)
        //    {
        //        return a.Points.CompareTo(b.Points);
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

    }
}
