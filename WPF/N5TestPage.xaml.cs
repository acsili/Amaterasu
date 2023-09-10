using Amaterasu.Data;
using Amaterasu.Data.DatabaseEntities;
using Amaterasu.Utils;
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

namespace Amaterasu
{
    public partial class N5TestPage : Page
    {
        public N5TestPage()
        {
            InitializeComponent();
            PrintRandomN5Words();
        }
        void PrintRandomN5Words()
        {
            var testCreator = new TestCreator();

            var randomWords = testCreator.GetRandomWords("N5");
            
            foreach (var word in randomWords)
            {
                ListBoxN5Words.Items.Add(word.WordInJapanese + " " +  word.Translation);
            }

        }

        private void ButtonBackToMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }
    }
}
