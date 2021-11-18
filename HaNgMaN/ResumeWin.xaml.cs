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
    /// Interaction logic for ResumeWin.xaml
    /// </summary>
    public delegate void ResumeChecked(object obj, bool select);
    public partial class ResumeWin : Window
    {
        public event ResumeChecked OnResumeChecked;
        bool select;
        MediaPlayer mp = new MediaPlayer();
        public ResumeWin(SoundEffects source)
        {
            InitializeComponent();
            mp.Open(new Uri("resume.mp3", UriKind.Relative));
            mp.Volume = 1;
            mp.Balance = 0;
            mp.Position = new TimeSpan(0, 0, 0);
            mp.SpeedRatio = 1;
            if (source.Music == true) mp.Play();
            else mp.Stop();
            select = false;
        }



        private void b1Click(object sender, RoutedEventArgs e)
        {
            select = true;
            mp.Close();
            OnResumeChecked?.Invoke(this, select);
            this.Close();
        }
        private void b2Click(object sender, RoutedEventArgs e)
        {
            select = false;
            mp.Close();
            OnResumeChecked?.Invoke(this, select);
            this.Close();
        }
    }
}
