using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Media;

namespace HaNgMaN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, Player> players;
        Dictionary<int, Word> words;
        Dictionary<string, Game> games;
        MediaPlayer mp = new MediaPlayer();
        Player p;
        List<string> wordsUsed;
               
        Dictionary<int, Word> wordsByTopics;
        List<string> wordsTopicalUsed;
        Random rand = new Random();

        SoundEffects sound;

        int level;
        string pName;
        public MainWindow()
        {
            InitializeComponent();
         
            level = 0;
            players = new Dictionary<string, Player>();
            words = new Dictionary<int, Word>();
            games = new Dictionary<string, Game>();
            wordsUsed = new List<string>();
            wordsByTopics = new Dictionary<int, Word>();
            wordsTopicalUsed = new List<string>();

            StreamReader stream = new StreamReader("players.txt", Encoding.Default);
            string line = null;
            line = stream.ReadLine();


            while (line != null)
            {
                Player pNew = new Player(line);

                players.Add(pNew.Name, pNew);

                line = stream.ReadLine();

            }
            stream.Close();


            StreamReader streamG = new StreamReader("games.txt", Encoding.Default);
            string lineG = null;
            lineG = streamG.ReadLine();

            sound = new SoundEffects(lineG);
            mp.Open(new Uri("start.mp3", UriKind.Relative));
            mp.Volume = sound.Volume;
            mp.Balance = 0;
            mp.Position = TimeSpan.Zero;
            mp.SpeedRatio = 1;
            if (sound.Music == true) mp.Play();
            else mp.Stop();

            lineG = streamG.ReadLine();


            while (lineG != null)
            {
                Game g = new Game(lineG);
                games.Add(g.PlayerName, g);

                lineG = streamG.ReadLine();

            }
            streamG.Close();

            StreamReader streamW = new StreamReader("nouns2.txt", Encoding.Default);
            string lineW = null;
            lineW = streamW.ReadLine();
            int num = 1;
            while (lineW != null)
            {
                Word w = new Word(lineW);

                words.Add(num, w);
                num++;

                lineW = streamW.ReadLine();
            }
            streamW.Close();

            StreamReader streamW2 = new StreamReader("nouns4.txt", Encoding.Default);
            string lineW2 = null;

            lineW2 = streamW2.ReadLine();
            int num2 = 1;          
           
            string topic = null;            
            
            while (lineW2 != null)
            {
                char[] delimiter = new char[] { ' ' };
                string[] SUBs = lineW2.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

                string s1 = SUBs[0];
                string s2 = (SUBs[1]);

                if (s1 == "0")
                {
                    topic = s2;
                }

                else
                {
                    Word wT = new Word(s2);
                    wT.Topic = topic;
                    wordsByTopics.Add(num2, wT);
                    num2++;
                }

                lineW2 = streamW2.ReadLine();
            }
            streamW2.Close();


        }
        DoubleAnimation opacityAnimation = new DoubleAnimation(1, 0, TimeSpan.FromMilliseconds(1000));
        private void okButtonClick(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            pName = textBox.Text;
            mp.Stop();
            if (players.Count > 0)
            {
                if (players.ContainsKey(pName))
                {
                    p = players[pName];

                    if (players[pName].GameComplete == true)
                    {
                        SelectWin sWin = new SelectWin(0, sound);
                        sWin.OnLevelSelected += Form_OnLevelSelected;

                        bool result = (bool)sWin.ShowDialog();
                    }
                    else
                    { 
                        level = games[pName].Level;

                        ResumeWin rWin = new ResumeWin(sound);
                        rWin.OnResumeChecked += Form_OnResumeChecked;
                        bool result = (bool)rWin.ShowDialog();
                       
                    }
                }
                else 
                {
                    p = new Player(pName + " 0 0 0 0");
                    players.Add(pName, p);
                    SelectWin sWin = new SelectWin(0, sound);
                    sWin.OnLevelSelected += Form_OnLevelSelected;

                    bool result = (bool)sWin.ShowDialog();
                }
            }
            else
            {
                p = new Player(pName + " 0 0 0 0");
                players.Add(pName, p);
                SelectWin sWin = new SelectWin(0, sound);
                sWin.OnLevelSelected += Form_OnLevelSelected;

                bool result = (bool)sWin.ShowDialog();
            }
        }

        private void Form_OnResumeChecked(object sender, bool select)
        {
            if (select == true)
            {
                switch (level)
                {
                    case 1:
                        {
                            wordsTopicalUsed.Add(games[pName].Word.Text);

                            Level0Win l0Win = new Level0Win(games[pName].Word.Text, games[pName].Topic, p, games, players, sound);
                            l0Win.OnGameCompleted += Form_OnGameCompleted;

                            bool result = (bool)l0Win.ShowDialog();
                            break;
                        }
                    case 2:
                        {
                            wordsTopicalUsed.Add(games[pName].Word.Text);

                            Level2Win l2Win = new Level2Win(games[pName].Word.Text, games[pName].Topic, p, games, players, sound);
                            l2Win.OnGameCompleted += Form_OnGameCompleted;

                            bool result = (bool)l2Win.ShowDialog();
                            break;
                        }
                    case 3:
                        {
                            wordsUsed.Add(games[pName].Word.Text);

                            Level3Win l3Win = new Level3Win(games[pName].Word.Text, p, games, players, sound);
                            l3Win.OnGameCompleted += Form_OnGameCompleted;

                            bool result = (bool)l3Win.ShowDialog();
                            break;
                        }

                    case 4:
                        {
                            wordsUsed.Add(games[pName].Word.Text);

                            Level1Win l1Win = new Level1Win(games[pName].Word.Text, p, games, players, sound);
                            l1Win.OnGameCompleted += Form_OnGameCompleted;

                            bool result = (bool)l1Win.ShowDialog();
                            break;
                        }
                }
            }
            else 
            {
                if (games.ContainsKey(pName)) games.Remove(pName);
                SelectWin sWin = new SelectWin(0, sound);
                sWin.OnLevelSelected += Form_OnLevelSelected;

                bool result = (bool)sWin.ShowDialog();
            }
        }
        private void Form_OnLevelSelected(object sender, int x)
        {
            level = x;           
            

            switch (x)
            {
                case 1:
                    {
                        int select = rand.Next(1, 276);
                        wordsTopicalUsed.Add(wordsByTopics[select].Text);

                        Level0Win l0Win = new Level0Win(wordsByTopics[select].Text, wordsByTopics[select].Topic, p, games, players, sound);
                        l0Win.OnGameCompleted += Form_OnGameCompleted;

                        bool result = (bool)l0Win.ShowDialog();
                        break;
                    }
                case 2:
                    {
                        int select = rand.Next(1, 276);
                        wordsTopicalUsed.Add(wordsByTopics[select].Text);

                        Level2Win l2Win = new Level2Win(wordsByTopics[select].Text, wordsByTopics[select].Topic, p, games, players, sound);
                        l2Win.OnGameCompleted += Form_OnGameCompleted;

                        bool result = (bool)l2Win.ShowDialog();
                        break;
                    }
                case 3:
                    {
                        int select = rand.Next(1, 853);
                        wordsUsed.Add(words[select].Text);

                        Level3Win l3Win = new Level3Win(words[select].Text, p, games, players, sound);
                        l3Win.OnGameCompleted += Form_OnGameCompleted;

                        bool result = (bool)l3Win.ShowDialog();
                        break;
                    }
                case 4:
                    {
                        int select = rand.Next(1, 853);
                        wordsUsed.Add(words[select].Text);

                        Level1Win l1Win = new Level1Win(words[select].Text, p, games, players, sound);
                        l1Win.OnGameCompleted += Form_OnGameCompleted;

                        bool result = (bool)l1Win.ShowDialog();
                        break;
                    }
                case 5:
                    {
                        mp.Close();
                        this.Close();
                        break;
                    }
            }           
        }
        private void Form_OnGameCompleted(object sender, string state, string playerName, Game g, SoundEffects source)
        {
            sound.Music = source.Music;
            sound.Sound = source.Sound;
            sound.Melody = source.Melody;
            sound.Volume = source.Volume;
            switch (state)
            {
                case "wonFinish":
                    {
                        if (games.ContainsKey(playerName)) games.Remove(playerName); 
                        players[playerName].Games++;
                        players[playerName].Wins++;
                        int add = g.Level;
                        players[playerName].Points += add;
                        players[playerName].GameComplete = true;
                        
                        FinalizeSession();
                        break;
                    }
                case "wonContinue":
                    {
                        if (games.ContainsKey(playerName)) games.Remove(playerName);
                        players[playerName].Games++;
                        players[playerName].Wins++;
                        int add = g.Level;
                        players[playerName].Points += add;
                        players[playerName].GameComplete = true;

                      
                        switch (level)
                        {
                            case 1:
                                {
                                    int select = rand.Next(1, 276);
                                    string newWord = wordsByTopics[select].Text;

                                    while (wordsTopicalUsed.Contains(newWord))
                                    {
                                        select = rand.Next(1, 276);

                                        newWord = wordsByTopics[select].Text;
                                    }
                                    wordsTopicalUsed.Add(newWord);

                                    Level2Win l2Win = new Level2Win(wordsByTopics[select].Text, wordsByTopics[select].Topic, p, games, players, sound);

                                    l2Win.OnGameCompleted += Form_OnGameCompleted;

                                    bool result = (bool)l2Win.ShowDialog();
                                    break;
                                }
                            case 2:
                                {
                                    int select = rand.Next(1, 276);
                                    string newWord = wordsByTopics[select].Text;

                                    while (wordsTopicalUsed.Contains(newWord))
                                    {
                                        select = rand.Next(1, 276);

                                        newWord = wordsByTopics[select].Text;
                                    }
                                    wordsTopicalUsed.Add(newWord);

                                    Level2Win l2Win = new Level2Win(wordsByTopics[select].Text, wordsByTopics[select].Topic, p, games, players, sound);

                                    l2Win.OnGameCompleted += Form_OnGameCompleted;

                                    bool result = (bool)l2Win.ShowDialog();
                                    break;
                                 
                                }
                            case 3:
                                {
                                    int select = rand.Next(1, 853);

                                    string newWord = words[select].Text;

                                    while (wordsUsed.Contains(newWord))
                                    {
                                        select = rand.Next(1, 853);

                                        newWord = words[select].Text;
                                    }
                                    wordsUsed.Add(newWord);
                                    Level3Win l3Win = new Level3Win(newWord, p, games, players, sound);

                                    l3Win.OnGameCompleted += Form_OnGameCompleted;

                                    bool result = (bool)l3Win.ShowDialog();

                                    break;
                                }
                            case 4:
                                {
                                    int select = rand.Next(1, 853);

                                    string newWord = words[select].Text;

                                    while (wordsUsed.Contains(newWord))
                                    {
                                        select = rand.Next(1, 853);

                                        newWord = words[select].Text;
                                    }
                                    wordsUsed.Add(newWord); 
                                    Level1Win l1Win = new Level1Win(newWord, p, games, players, sound);

                                    l1Win.OnGameCompleted += Form_OnGameCompleted;

                                    bool result = (bool)l1Win.ShowDialog();

                                    break;
                                }
                        }
                        break;
                        
                    }
                case "wonSelectMenu":
                    {
                        if (games.ContainsKey(playerName)) games.Remove(playerName);
                        players[playerName].Games++;
                        players[playerName].Wins++;
                        int add = g.Level;
                        players[playerName].Points += add;
                        players[playerName].GameComplete = true;

                        SelectWin sWin = new SelectWin(1, sound);
                        sWin.OnLevelSelected += Form_OnLevelSelected;

                        bool result = (bool)sWin.ShowDialog();
                        break;
                    }
                case "lostFinish":
                    {
                        if (games.ContainsKey(playerName)) games.Remove(playerName);
                        players[playerName].Games++;
                        players[playerName].GameComplete = true;
                        
                        FinalizeSession();
                        break;
                    }
                case "lostContinue":
                    {
                        if (games.ContainsKey(playerName)) games.Remove(playerName); 
                        players[playerName].Games++;
                        players[playerName].GameComplete = true;
                       
                        switch (level)
                        {
                            case 1:
                                {
                                    int select = rand.Next(1, 276);
                                    string newWord = wordsByTopics[select].Text;

                                    while (wordsTopicalUsed.Contains(newWord))
                                    {
                                        select = rand.Next(1, 276);

                                        newWord = wordsByTopics[select].Text;
                                    }
                                    wordsTopicalUsed.Add(newWord); 
                                    Level0Win l0Win = new Level0Win(wordsByTopics[select].Text, wordsByTopics[select].Topic, p, games, players, sound);

                                    l0Win.OnGameCompleted += Form_OnGameCompleted;

                                    bool result = (bool)l0Win.ShowDialog();

                                    break;
                                }
                            case 2:
                                {
                                    int select = rand.Next(1, 276);
                                    string newWord = wordsByTopics[select].Text;

                                    while (wordsTopicalUsed.Contains(newWord))
                                    {
                                        select = rand.Next(1, 276);

                                        newWord = wordsByTopics[select].Text;
                                    }
                                    wordsTopicalUsed.Add(newWord);
                                    Level2Win l2Win = new Level2Win(wordsByTopics[select].Text, wordsByTopics[select].Topic, p, games, players, sound);

                                    l2Win.OnGameCompleted += Form_OnGameCompleted;

                                    bool result = (bool)l2Win.ShowDialog();

                                    break;
                                }
                            case 3:
                                {
                                    int select = rand.Next(1, 853);

                                    string newWord = words[select].Text;

                                    while (wordsUsed.Contains(newWord))
                                    {
                                        select = rand.Next(1, 853);

                                        newWord = words[select].Text;
                                    }
                                    wordsUsed.Add(newWord);
                                    Level3Win l3Win = new Level3Win(newWord, p, games, players, sound);

                                    l3Win.OnGameCompleted += Form_OnGameCompleted;

                                    bool result = (bool)l3Win.ShowDialog();

                                    break;
                                }
                            case 4:
                                {
                                    int select = rand.Next(1, 853);

                                    string newWord = words[select].Text;

                                    while (wordsUsed.Contains(newWord))
                                    {
                                        select = rand.Next(1, 853);

                                        newWord = words[select].Text;
                                    }
                                    wordsUsed.Add(newWord);
                                    Level1Win l1Win = new Level1Win(newWord, p, games, players, sound);

                                    l1Win.OnGameCompleted += Form_OnGameCompleted;

                                    bool result = (bool)l1Win.ShowDialog();

                                    break;
                                }
                        }
                        break;
                    }
                case "lostSelectMenu":
                    {
                        if (games.ContainsKey(playerName)) games.Remove(playerName);
                        players[playerName].Games++;
                        players[playerName].GameComplete = true;

                        SelectWin sWin = new SelectWin(1, sound);
                        sWin.OnLevelSelected += Form_OnLevelSelected;

                        bool result = (bool)sWin.ShowDialog();
                        break;
                    }
                case "nonCompleted":
                    {
                        if (games.ContainsKey(playerName)) games.Remove(playerName);
                        games.Add(playerName, g);
                        players[playerName].GameComplete = false;

                        FinalizeSession();
                        break;
                    }
            }
        }

        private void FinalizeSession()
        {
            StreamWriter writer = new StreamWriter(@"players.txt", false, Encoding.Default);
          
            foreach (var d in players)
            {
                int index = (d.Value.GameComplete) ? 1 : 0;
                string line = d.Key + " " + d.Value.Games + " " + d.Value.Wins + " " + d.Value.Points + " " + index;
                writer.WriteLine(line);
            }
            writer.Close();

            StreamWriter writerG = new StreamWriter(@"games.txt", false, Encoding.Default);
            
            string par1 = (sound.Music == true) ? "T" : "F";
            string par2 = (sound.Sound == true) ? "T" : "F";
            string soundSetting = par1+"/"+par2+"/"+sound.Melody+"/"+sound.Volume;
            writerG.WriteLine(soundSetting);

            foreach (var d in games)
            {
                string LU = null;
                foreach (char c in d.Value.LettersUsed) LU += c;
                string nLU = null;
                foreach (char c in d.Value.LettersNotUsed) nLU += c;
                string topic = (d.Value.Topic != null) ? d.Value.Topic : "none";
                string line = d.Value.Level + "/" + d.Value.Word.Text + "/" + topic + "/" + d.Key + "/" + nLU+ "/"+LU;
                writerG.WriteLine(line);
            }
            writerG.Close();

            this.Close();
        }
     
    }


}
