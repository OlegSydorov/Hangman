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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HaNgMaN
{
    /// <summary>
    /// Interaction logic for SelectWin.xaml
    /// </summary>
    public delegate void LevelSelect(object obj, int level);
    public partial class SelectWin : Window
    {
        public event LevelSelect OnLevelSelected;
        int selectFlag;
        MediaPlayer mp = new MediaPlayer();
        int index;
        public SelectWin(int index, SoundEffects source)
        {
            InitializeComponent();
            this.index = index;
            mp.Open(new Uri("select.mp3", UriKind.Relative));
            mp.Volume = source.Volume;
            mp.Balance = 0;
            mp.Position = new TimeSpan(0, 0, 0);
            mp.SpeedRatio = 1;
            if (source.Music == true) mp.Play();
            else mp.Stop();
            selectFlag = 0;

            if (index == 1)
            {
                b5.Visibility = Visibility.Hidden;
                b5.IsEnabled = false;
            }
        }

        private void b1Click(object sender, RoutedEventArgs e)
        {
            selectFlag = 1;
            mp.Close();
            OnLevelSelected?.Invoke(this, selectFlag);
            
            this.Close();
        }
        private void b2Click(object sender, RoutedEventArgs e)
        {
            selectFlag = 2;
            mp.Close();
            OnLevelSelected?.Invoke(this, selectFlag);
          
            this.Close();
        }

        private void b3Click(object sender, RoutedEventArgs e)
        {
            selectFlag = 3;
            mp.Close();
            OnLevelSelected?.Invoke(this, selectFlag);       
            this.Close();
        }
        private void b4Click(object sender, RoutedEventArgs e)
        {
            selectFlag = 4;
            mp.Close();
            OnLevelSelected?.Invoke(this, selectFlag);      
            this.Close();
        }
        private void b5Click(object sender, RoutedEventArgs e)
        {
            selectFlag = 5;
            mp.Close();
            OnLevelSelected?.Invoke(this, selectFlag);
            this.Close();
        }
    }
}
