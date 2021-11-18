using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaNgMaN
{
    public class SoundEffects
    {
        bool music;
        bool sound;
        int melody;
        double volume;

        public bool Music { get { return music; } set { music = value; } }
        public bool Sound { get { return sound; } set { sound = value; } }
        public int Melody { get { return melody; } set { melody = value; } }
        public double Volume { get { return volume; } set { volume = value; } }

        public SoundEffects()
        { }

        public SoundEffects(string line)
        {
            char[] delimiter = new char[] { '/' };
            string[] SUBs = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            music = (SUBs[0]=="T")?true:false;
            sound = (SUBs[1] == "T") ? true : false;
            melody = Convert.ToInt32(SUBs[2]);
            volume = Convert.ToDouble(SUBs[3]);
        }
    }
}
