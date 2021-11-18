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
    /// Interaction logic for SettingsWin.xaml
    /// </summary>
    public delegate void SelectSettings(object obj, SoundEffects sound);
    public partial class SettingsWin : Window
    {
        public event SelectSettings OnSettingsSelected;
      
        MediaPlayer mp = new MediaPlayer();
        SoundEffects sound;
        public SettingsWin(SoundEffects source)
        {
            InitializeComponent();
            sound = new SoundEffects();
            sound.Music = source.Music;
            sound.Sound = source.Sound;
            sound.Melody = source.Melody;
            sound.Volume = source.Volume;

            switch (sound.Melody)
            {
                case 1:
                    mp.Stop();
                    mp.Open(new Uri("game.mp3", UriKind.Relative));
                    mp.Play();
                    break;
                case 2:
                    mp.Stop();
                    mp.Open(new Uri("game2.mp3", UriKind.Relative));
                    mp.Play();
                    break;
                case 3:
                    mp.Stop();
                    mp.Open(new Uri("game3.mp3", UriKind.Relative));
                    mp.Play();
                    break;
                case 4:
                    mp.Stop();
                    mp.Open(new Uri("game4.mp3", UriKind.Relative));
                    mp.Play();
                    break;
            }
            mp.Volume = sound.Volume;
            mp.Balance = 0;
            mp.Position = TimeSpan.Zero;
            mp.SpeedRatio = 1;


            if (sound.Music == true)
            {               
                ellipseMusic.Margin = new Thickness(0, 0, -30, 0);               
                rectangleMusic.Fill = new SolidColorBrush(Colors.DarkGreen);
                mp.Play();
            }
            else if (sound.Music == false)
            {
                ellipseMusic.Margin = new Thickness(-30, 0, 0, 0);               
                rectangleMusic.Fill = new SolidColorBrush(Colors.Red);
                mp.Stop();
            }

            if (sound.Sound == true)
            {               
                ellipseSound.Margin = new Thickness(0, 0, -30, 0);
                rectangleSound.Fill = new SolidColorBrush(Colors.DarkGreen);
            }
            else
            {
                ellipseSound.Margin = new Thickness(-30, 0, 0, 0);
                rectangleSound.Fill = new SolidColorBrush(Colors.Red);
            }        
        }

        private void ellipseMusicMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sound.Music == true)
            {
                sound.Music = false;
                ellipseMusic.Margin = new Thickness(-30, 0, 0, 0);
                rectangleMusic.Fill = new SolidColorBrush(Colors.Red);
                mp.Stop();
            }
            else if (sound.Music == false)
            {
                sound.Music = true;
                ellipseMusic.Margin = new Thickness(0, 0, -30, 0);
                rectangleMusic.Fill = new SolidColorBrush(Colors.DarkGreen);
                mp.Play();
            }
        }

        private void ellipseSoundMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sound.Sound == true)
            {
                sound.Sound = false;
                ellipseSound.Margin = new Thickness(-30, 0, 0, 0);
                rectangleSound.Fill = new SolidColorBrush(Colors.Red);
            }
            else if (sound.Sound == false)
            {
                sound.Sound = true;
                ellipseSound.Margin = new Thickness(0, 0, -30, 0);
                rectangleSound.Fill = new SolidColorBrush(Colors.DarkGreen);
            }
        }

        private void rbChecked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (sender as RadioButton);
            sound.Melody= Convert.ToInt32(rb.Content.ToString().Substring(7, 1));
            switch (sound.Melody)
            {
                case 1:
                    mp.Stop();
                    mp.Open(new Uri("game.mp3", UriKind.Relative));
                    mp.Play();
                    break;
                case 2:
                    mp.Stop(); 
                    mp.Open(new Uri("game2.mp3", UriKind.Relative));
                    mp.Play();
                    break;
                case 3:
                    mp.Stop(); 
                    mp.Open(new Uri("game3.mp3", UriKind.Relative));
                    mp.Play();
                    break;
                case 4:
                    mp.Stop(); 
                    mp.Open(new Uri("game4.mp3", UriKind.Relative));
                    mp.Play();
                    break;
            }
        }
        private void okButtonClick(object sender, RoutedEventArgs e)
        {
            mp.Close();
            OnSettingsSelected?.Invoke(this, sound);
            this.Close();
        }

        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider sr = (sender as Slider);
            sr.SelectionEnd = e.NewValue;
        }
               

      

        private void thumbMove(object sender, MouseEventArgs e)
        {
            mp.Pause();
            Slider sr = (sender as Slider);

            sound.Volume = (double) Convert.ToInt32(sr.Value)/10;
            //double volumeDouble =(double) volume / 10;
            mp.Volume = sound.Volume;
            mp.Play();
        }
    }
}
