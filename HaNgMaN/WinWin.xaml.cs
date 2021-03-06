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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public delegate void WinComplete(object obj, int index);
    public partial class WinWin : Window
    {
        public event WinComplete OnContinueChecked;
        MediaPlayer mp = new MediaPlayer();
        public WinWin(SoundEffects source)
        {
            InitializeComponent();
            mp.Open(new Uri("winlose.mp3", UriKind.Relative));
            mp.Volume = source.Volume;
            mp.Balance = 0;
            mp.Position = new TimeSpan(0, 0, 0);
            mp.SpeedRatio = 1;
            if (source.Music == true) mp.Play();
            else mp.Stop();
        }

        private void b1Click(object sender, RoutedEventArgs e)
        {
            mp.Close();
            OnContinueChecked?.Invoke(this, 1);
            this.Close();
        }
        private void b2Click(object sender, RoutedEventArgs e)
        {
            mp.Close();
            OnContinueChecked?.Invoke(this, 2);
            this.Close();
        }
        private void b3Click(object sender, RoutedEventArgs e)
        {
            mp.Close();
            OnContinueChecked?.Invoke(this, 0);
            this.Close();
        }

    }
}
