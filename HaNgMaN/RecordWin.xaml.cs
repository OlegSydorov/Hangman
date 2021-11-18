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
    /// Interaction logic for RecordWin.xaml
    /// </summary>
    public partial class RecordWin : Window
    {
        public RecordWin(List<Player> players)
        {
            InitializeComponent();
            players.Sort(new PlayerPointsFirst());
            
            string s = "\r\n\r\n\r\n                                 BEST RESULTS\r\n\r\n";
            int x = 1;
            foreach (Player p in players)
            {
                s += x+" place: "+p.Name + "  Points scored: " + p.Points + "  Games: "  + p.Games + "  Wins:" + p.Wins + "\r\n \r\n";
                x++;
                if (x > 3) break;
            }

            tBlock.Text = s;

        }

        private void okButtonClick(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
}
