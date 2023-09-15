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

        private int NextWord;

        List<Word> RandomWords;
        List<List<Word>> RandomAnswers;

        public N5TestPage()
        {
            InitializeComponent();
            RandomWords = TestCreator.GetRandomWords("N5");
            RandomAnswers = TestCreator.GetRandomAnswers(RandomWords);

            DoN5Test();
        }

        void DoN5Test()
        {

            LabelQuestion.Content = RandomWords[NextWord].WordInJapanese;

            ListBoxN5Words.Items.Clear();

            for (int i = 0; i < 4; i++)
            {
                ListBoxN5Words.Items.Add(RandomAnswers[NextWord][i].WordInJapanese + " " + RandomAnswers[NextWord][i].Translation);
            }

            NextWord++;

        }

        private void ButtonBackToMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void ListBoxN5Words_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //var li = (string)ListBoxN5Words.Items[ListBoxN5Words.SelectedIndex];


            DoN5Test();



            //MessageBox.Show(li);

        }
    }
}
