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
    /// Interaction logic for RulesWin.xaml
    /// </summary>
    public partial class RulesWin : Window
    {
        public RulesWin()
        {
            InitializeComponent();
            tBlock.Text = "        \r\n\r\n                    HANGMAN RULES\r\n" +
                "  ***  select letter to fill in spaces in the word\r\n" +
                "  ***  if the selected letter is present in the word, it will be revealed," +
                "otherwise part of the gallows will be revealed\r\n" +
                "  ***  to win you have to guess the word by revealing all of its letters" +
                "before the gallows is complete - you have maximum of 10 moves";
        }

        private void okButtonClick(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }
    }
}
