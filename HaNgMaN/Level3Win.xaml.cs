using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using System.Windows.Shapes;

namespace HaNgMaN
{
    /// <summary>
    /// Interaction logic for Level3Win.xaml
    /// </summary>
    public delegate void Game3Complete(object obj, string state, string playerName, Game g, SoundEffects sounds);
    public partial class Level3Win : Window
    {
        public event Game3Complete OnGameCompleted;
        int errorCount;
        string state;
        int len;
        int posIni;
        string playerName;
        Word w;
        Game g;
        MediaPlayer mp = new MediaPlayer();

        SoundPlayer splayer1 = new SoundPlayer("success.wav");
        SoundPlayer splayer2 = new SoundPlayer("fail.wav");
        SoundPlayer splayer3 = new SoundPlayer("button2.wav");
        SoundPlayer splayer4 = new SoundPlayer("exit.wav");

        SoundEffects sound;

        List<char> abc;
        Dictionary<char, Label> keyboard;
        List<Player> playersStats;


        public Level3Win(string word, Player p, Dictionary<string, Game> games, Dictionary<string, Player> players, SoundEffects source)
        {
            InitializeComponent();

            playersStats = new List<Player>();
            foreach (var d in players) playersStats.Add(d.Value);

            playerName = p.Name;
            name.Content = "PLAYER NAME:  " + p.Name;
            gameCount.Content = "      GAMES PLAYED:  " + p.Games.ToString();
            wins.Content = "      GAMES WON:  " + p.Wins.ToString();
            points.Content = "      POINTS EARNED:  " + p.Points.ToString();
            level.Content = "      CURRENT GAME LEVEL:  3";

            sound = new SoundEffects();
            sound.Music = source.Music;
            sound.Sound = source.Sound;
            sound.Melody = source.Melody;
            sound.Volume = source.Volume;

            switch (sound.Melody)
            {
                case 1:

                    mp.Open(new Uri("game.mp3", UriKind.Relative));

                    break;
                case 2:

                    mp.Open(new Uri("game2.mp3", UriKind.Relative));

                    break;
                case 3:

                    mp.Open(new Uri("game3.mp3", UriKind.Relative));

                    break;
                case 4:

                    mp.Open(new Uri("game4.mp3", UriKind.Relative));

                    break;
            }

            mp.Volume = sound.Volume;
            mp.Balance = 0;
            mp.Position = TimeSpan.Zero;
            mp.SpeedRatio = 1;
            if (sound.Music == true) mp.Play();
            else mp.Stop();
            mp.MediaEnded += new EventHandler(Media_Ended);

           

            w = new Word(word);
            g = new Game();
            g.Word = w;
            g.PlayerName = p.Name;
            g.Level = 3;
            g.Topic = null;

            abc = new List<char>();
            char[] Arr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                            'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
                                'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            abc.AddRange(Arr);
            keyboard = new Dictionary<char, Label>();
            keyboard.Add('A', la);
            keyboard.Add('B', lb);
            keyboard.Add('C', lc);
            keyboard.Add('D', ld);
            keyboard.Add('E', le);
            keyboard.Add('F', lf);
            keyboard.Add('G', lg);
            keyboard.Add('H', lh);
            keyboard.Add('I', li);
            keyboard.Add('J', lj);
            keyboard.Add('K', lk);
            keyboard.Add('L', ll);
            keyboard.Add('M', lm);
            keyboard.Add('N', ln);
            keyboard.Add('O', lo);
            keyboard.Add('P', lp);
            keyboard.Add('Q', lq);
            keyboard.Add('R', lr);
            keyboard.Add('S', ls);
            keyboard.Add('T', lt);
            keyboard.Add('U', lu);
            keyboard.Add('V', lv);
            keyboard.Add('W', lw);
            keyboard.Add('X', lx);
            keyboard.Add('Y', ly);
            keyboard.Add('Z', lz);

            List<char> correctLetters = new List<char>();
            Random rand = new Random();
            int x1 = rand.Next(0, word.Length-1);
            int x2 = 0;
            if (w.LetterCount.Count == 2)
            {
                char char1 = new char();
                char1 = w.Letters[x1];
                int index = 0;
                foreach (char c in w.Letters)
                {
                    if (c == char1 && index != x1)
                        x2 = index;

                    index++;
                }               
            }
            else if (w.LetterCount[w.Letters[x1]] == 2)
            {
                char char1 = new char();
                char1 = w.Letters[x1];
                int index = 0;
                foreach (char c in w.Letters)
                {
                    if (c == char1 && index != x1)
                        x2 = index;

                    index++;
                }
            }
            else
            {
                while (w.LetterCount[w.Letters[x1]] != 1)
                {
                    x1 = rand.Next(0, word.Length - 1);
                }

                 x2 = rand.Next(0, word.Length - 1);
                while (x2 == x1 || w.LetterCount[w.Letters[x2]] != 1)
                {
                    x2 = rand.Next(0, word.Length - 1);
                }

            }

            correctLetters.Add(w.Letters[x1]);
            correctLetters.Add(w.Letters[x2]);
                      

            errorCount = 0;
            state = null;
            len = w.Length;
            int pos = 10 - w.Length / 2;
            posIni = 10 - w.Length / 2;
            int num = 0;

            if (games.Count > 0)
            {
                if (!games.ContainsKey(p.Name))
                {
                    abc.Remove(w.Letters[x1]);
                    abc.Remove(w.Letters[x2]);
                    g.LettersUsed.Add(w.Letters[x1]);
                    g.LettersUsed.Add(w.Letters[x2]);

                    for (int i = 0; i < textGrid.Children.Count; i++)
                    {
                        if (pos == i && pos < (posIni + w.Length))
                        {
                            TextBlock tb = new TextBlock();
                            tb = textGrid.Children[i] as TextBlock;
                            if (num == x1)
                            {
                                tb.Text = w.Letters[x1].ToString();
                                len--;
                            }
                            else if (num==x2)
                            { 
                                tb.Text = w.Letters[x2].ToString();
                                len--;
                            }
                            else
                            {
                                tb.Text = "_";
                            }
                            pos++;
                          
                            num++;
                        }
                    }
                    foreach (char c in correctLetters) keyboard[c].Opacity = 0;
                }
                else
                {
                    correctLetters.Clear();
                    foreach (char c in games[p.Name].LettersUsed)
                    {
                        abc.Remove(c);
                        g.LettersUsed.Add(c);
                    }

                    for (int i = 0; i < textGrid.Children.Count; i++)
                    {
                        if (pos == i && pos < (posIni + w.Length))
                        {
                            TextBlock tb = new TextBlock();
                            tb = textGrid.Children[i] as TextBlock;
                            
                            if (games[p.Name].LettersUsed.Contains(w.Letters[num]))
                            {
                                tb.Text = w.Letters[num].ToString();
                                len--;
                                if (!correctLetters.Contains(w.Letters[num])) correctLetters.Add(w.Letters[num]);
                            }
                            else
                            {
                                tb.Text = "_";
                            }
                            pos++;
                            num++;
                        }
                    }

                    foreach (char c in games[p.Name].LettersUsed) keyboard[c].Opacity = 0;
                    List<char> inCorrectLetters = new List<char>();

                    foreach (char c in games[p.Name].LettersUsed) if (!correctLetters.Contains(c)) inCorrectLetters.Add(c);

                    for (int i = 0; i < inCorrectLetters.Count(); i++)
                    {
                        FrameworkElement s = new FrameworkElement();
                        s = viewGrid.Children[i] as FrameworkElement;
                        s.Opacity = 1;
                    }
                    errorCount = inCorrectLetters.Count(); //games[p.Name].LettersUsed.Count - correctLetters.Count;
                }
            }
            else
            {
                abc.Remove(w.Letters[x1]);
                abc.Remove(w.Letters[x2]);
                g.LettersUsed.Add(w.Letters[x1]);
                g.LettersUsed.Add(w.Letters[x2]);

                for (int i = 0; i < textGrid.Children.Count; i++)
                {
                    if (pos == i && pos < (posIni + w.Length))
                    {
                        TextBlock tb = new TextBlock();
                        tb = textGrid.Children[i] as TextBlock;
                        if (num == x1 )
                        { 
                            tb.Text = w.Letters[x1].ToString();
                            len--;
                        }
                        else if (num ==x2)
                        {
                            tb.Text = w.Letters[x2].ToString();
                            len--;
                        }
                        else
                        {
                            tb.Text = "_";
                        }                        
                        pos++;
                        num++;
                    }
                }
                foreach (char c in correctLetters) keyboard[c].Opacity = 0;
            }



        }

        private void Media_Ended(object sender, EventArgs e)
        {
            mp.Position = TimeSpan.Zero;
            mp.Play();
        }

        DoubleAnimation opacityAnimation = new DoubleAnimation(1, 0, TimeSpan.FromMilliseconds(1000));
        private void laMouseDown(object sender, MouseButtonEventArgs e)
        {
            la.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = la.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lbMouseDown(object sender, MouseButtonEventArgs e)
        {
            lb.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lb.Content.ToString()[0];
            LetterCheck(c);
        }

        private void lcMouseDown(object sender, MouseButtonEventArgs e)
        {
            lc.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lc.Content.ToString()[0];
            LetterCheck(c);
        }
        private void ldMouseDown(object sender, MouseButtonEventArgs e)
        {
            ld.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = ld.Content.ToString()[0];
            LetterCheck(c);
        }
        private void leMouseDown(object sender, MouseButtonEventArgs e)
        {
            le.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = le.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lfMouseDown(object sender, MouseButtonEventArgs e)
        {
            lf.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lf.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lgMouseDown(object sender, MouseButtonEventArgs e)
        {
            lg.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lg.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lhMouseDown(object sender, MouseButtonEventArgs e)
        {
            lh.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lh.Content.ToString()[0];
            LetterCheck(c);
        }
        private void liMouseDown(object sender, MouseButtonEventArgs e)
        {
            li.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = li.Content.ToString()[0];
            LetterCheck(c);
        }
        private void ljMouseDown(object sender, MouseButtonEventArgs e)
        {
            lj.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lj.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lkMouseDown(object sender, MouseButtonEventArgs e)
        {
            lk.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lk.Content.ToString()[0];
            LetterCheck(c);
        }
        private void llMouseDown(object sender, MouseButtonEventArgs e)
        {
            ll.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = ll.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lmMouseDown(object sender, MouseButtonEventArgs e)
        {
            lm.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lm.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ln.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = ln.Content.ToString()[0];
            LetterCheck(c);
        }
        private void loMouseDown(object sender, MouseButtonEventArgs e)
        {
            lo.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lo.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lpMouseDown(object sender, MouseButtonEventArgs e)
        {
            lp.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lp.Content.ToString()[0];
            LetterCheck(c);
        }

        private void lqMouseDown(object sender, MouseButtonEventArgs e)
        {
            lq.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lq.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lrMouseDown(object sender, MouseButtonEventArgs e)
        {
            lr.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lr.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lsMouseDown(object sender, MouseButtonEventArgs e)
        {
            ls.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = ls.Content.ToString()[0];
            LetterCheck(c);
        }
        private void ltMouseDown(object sender, MouseButtonEventArgs e)
        {
            lt.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lt.Content.ToString()[0];
            LetterCheck(c);
        }
        private void luMouseDown(object sender, MouseButtonEventArgs e)
        {
            lu.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lu.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lvMouseDown(object sender, MouseButtonEventArgs e)
        {
            lv.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lv.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lwMouseDown(object sender, MouseButtonEventArgs e)
        {
            lw.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lw.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lxMouseDown(object sender, MouseButtonEventArgs e)
        {
            lx.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lx.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lyMouseDown(object sender, MouseButtonEventArgs e)
        {
            ly.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = ly.Content.ToString()[0];
            LetterCheck(c);
        }
        private void lzMouseDown(object sender, MouseButtonEventArgs e)
        {
            lz.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);
            char c = lz.Content.ToString()[0];
            LetterCheck(c);
        }

        private void LetterCheck(char letter)
        {
            state = "play";
            abc.Remove(letter);
            g.LettersUsed.Add(letter);

            if (w.Text.Contains(letter))
            {
                if (sound.Sound == true) splayer1.Play();
                int x = 0;


                for (int i = 0; i < textGrid.Children.Count; i++)
                {
                    if (i >= posIni && i < (posIni + w.Length))
                    {
                        if (w.Letters[x] == letter)
                        {
                            TextBlock tb = new TextBlock();
                            tb = textGrid.Children[i] as TextBlock;

                            tb.Text = letter.ToString();

                            len--;
                        }
                        x++;
                    }
                }


                if (len == 0)
                {
                    mp.Close();
                    WinWin wWin = new WinWin(sound);
                    wWin.OnContinueChecked += Form_OnWinContinueChecked;

                    bool result = (bool)wWin.ShowDialog();

                }
            }
            else
            {
                if (sound.Sound == true) splayer2.Play();
                errorCount++;
            }

            switch (errorCount)
            {
                case 1:
                    {
                        Vertical.Opacity = 1;
                        break;
                    }
                case 2:
                    {
                        Horizontal.Opacity = 1;
                        break;
                    }
                case 3:
                    {
                        Diagonal.Opacity = 1;
                        break;
                    }
                case 4:
                    {
                        Rope.Opacity = 1;
                        break;
                    }
                case 5:
                    {
                        Head.Opacity = 1;
                        break;
                    }
                case 6:
                    {
                        RightHand.Opacity = 1;
                        break;
                    }
                case 7:
                    {
                        LeftHand.Opacity = 1;
                        break;
                    }
                case 8:
                    {
                        Body.Opacity = 1;
                        break;
                    }
                case 9:
                    {
                        RightLeg.Opacity = 1;
                        break;
                    }
                case 10:
                    {
                        LeftLeg.Opacity = 1;
                        mp.Close();
                        LostWin lWin = new LostWin(sound);
                        lWin.OnContinueChecked += Form_OnLostContinueChecked;
                        bool result = (bool)lWin.ShowDialog();
                        break;
                    }
            }

        }

        private void Form_OnWinContinueChecked(object sender, int select)
        {
            switch (select)
            {
                case 0:
                    {
                        OnGameCompleted?.Invoke(this, "wonFinish", playerName, g, sound);
                        this.Close();
                        break;
                    }
                case 1:
                    {
                        OnGameCompleted?.Invoke(this, "wonContinue", playerName, g, sound);
                        this.Close();
                        break;
                    }
                case 2:
                    {
                        OnGameCompleted?.Invoke(this, "wonSelectMenu", playerName, g, sound);
                        this.Close();
                        break;
                    }

            }
        }

        private void Form_OnLostContinueChecked(object sender, int select)
        {
            switch (select)
            {
                case 0:
                    {
                        OnGameCompleted?.Invoke(this, "lostFinish", playerName, g, sound);
                        this.Close();
                        break;
                    }
                case 1:
                    {
                        OnGameCompleted?.Invoke(this, "lostContinue", playerName, g, sound);
                        this.Close();
                        break;
                    }
                case 2:
                    {
                        OnGameCompleted?.Invoke(this, "lostSelectMenu", playerName, g, sound);
                        this.Close();
                        break;
                    }

            }

        }
        private void settingsButtonClick(object sender, RoutedEventArgs e)
        {

            if (sound.Sound == true) splayer3.Play();
            mp.Stop();
            SettingsWin sWin = new SettingsWin(sound);
            sWin.OnSettingsSelected += Form_OnSettingsSelected;
            bool result = (bool)sWin.ShowDialog();
        }

        private void Form_OnSettingsSelected(object sender, SoundEffects source)
        {
            mp.Stop();
            sound.Melody = source.Melody;
            switch (sound.Melody)
            {
                case 1:

                    mp.Open(new Uri("game.mp3", UriKind.Relative));

                    break;
                case 2:

                    mp.Open(new Uri("game2.mp3", UriKind.Relative));

                    break;
                case 3:

                    mp.Open(new Uri("game3.mp3", UriKind.Relative));

                    break;
                case 4:

                    mp.Open(new Uri("game4.mp3", UriKind.Relative));

                    break;
            }
            sound.Volume = source.Volume;
            mp.Volume = sound.Volume;
            sound.Music = source.Music;
            if (sound.Music == true)
            {
                mp.Play();
                r2.Fill = new ImageBrush(new BitmapImage(new Uri("sound.png", UriKind.Relative)));
            }
            else
            {
                r2.Fill = new ImageBrush(new BitmapImage(new Uri("OFFsound.png", UriKind.Relative)));
            }

            sound.Sound = source.Sound;

        }

        private void soundButtonClick(object sender, RoutedEventArgs e)
        {
            if (sound.Sound == true) splayer3.Play();
            if (sound.Music == true)
            {
                sound.Music = false;
                mp.Stop();

                r2.Fill = new ImageBrush(new BitmapImage(new Uri("OFFsound.png", UriKind.Relative)));
            }
            else if (sound.Music == false)
            {
                sound.Music = true;
                mp.Play();
                r2.Fill = new ImageBrush(new BitmapImage(new Uri("sound.png", UriKind.Relative)));
            }
        }

        private void recordsButtonClick(object sender, RoutedEventArgs e)
        {
            if (sound.Sound == true) splayer3.Play();
            RecordWin recWin = new RecordWin(playersStats);
            bool result = (bool)recWin.ShowDialog();
        }

        private void statsButtonClick(object sender, RoutedEventArgs e)
        {
            if (sound.Sound == true) splayer3.Play();
            RulesNavigationWin rnWin = new RulesNavigationWin();
            rnWin.Show();

            //RulesWin rWin = new RulesWin();
            //bool result = (bool)rWin.ShowDialog();
        }
        private void exitButtonClick(object sender, RoutedEventArgs e)
        {
            if (sound.Sound == true) splayer4.Play();
            mp.Close();
            foreach (char c in abc) g.LettersNotUsed.Add(c);
            OnGameCompleted?.Invoke(this, "nonCompleted", playerName, g, sound);
            this.Close();
        }

    }
}

