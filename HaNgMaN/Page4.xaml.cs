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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
            InitializeComponent();
            tBlock.Text = "\r\n\r\nHANGMAN RULES\r\n\r\nYou have maximum of 10 moves";


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
            nav.Navigate(new Page3());

        }
        private void Forward_MouseDown(object sender, RoutedEventArgs e)
        {

           
        }
    }
}
