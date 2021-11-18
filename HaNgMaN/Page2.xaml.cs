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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HaNgMaN
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            tBlock.Text = "\r\n\r\nHANGMAN RULES\r\n\r\nIf the selected letter is present in the word, it will be revealed, \n\r otherwise part of the gallows will be revealed";


            //"  ***  if the selected letter is present in the word, it will be revealed," +
            //"otherwise part of the gallows will be revealed\r\n" +
            //"  ***  to win you have to guess the word by revealing all of its letters" +
            //"before the gallows is complete - you have maximum of 10 moves";
        }

        private void Close_ButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);

        }
        private void Back_MouseDown(object sender, RoutedEventArgs e)
        {

            NavigationService nav;
            nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Page1());
        }
    
        private void Forward_MouseDown(object sender, RoutedEventArgs e)
        {

            NavigationService nav;
            nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Page3());
        }
    }
}
