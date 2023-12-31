﻿using Amaterasu.Data;
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
        private int Correct;
        readonly List<Word> RandomWords;
        readonly List<List<Word>> RandomAnswers;

        public N5TestPage()
        {
            InitializeComponent();
            RandomWords = TestCreator.GetRandomWords("N5").ToList();
            RandomAnswers = TestCreator.GetRandomAnswers(RandomWords).ToList();
            DoN5Test();
        }


        /// <summary>
        /// Переход к следующему слову.
        /// </summary>
        /// 
        void DoN5Test()
        {

            LabelQuestion.Content = RandomWords[NextWord].WordInJapanese;

            ListBoxN5Words.Items.Clear();

            for (int i = 0; i < 4; i++)
            {
                ListBoxN5Words.Items.Add(RandomAnswers[NextWord][i].Translation);
            }

            LabelNumberOfQuestion.Content = ++NextWord;

        }

        private void ButtonBackToMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void ListBoxN5Words_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var li = (string)ListBoxN5Words.Items[ListBoxN5Words.SelectedIndex];

                if (RandomWords[NextWord - 1].Translation == li && NextWord != 10) Correct++;

                if (NextWord != 10)
                {
                    DoN5Test();
                }
                else
                    MessageBox.Show(Correct.ToString());
            }
            catch { }
            
        }
    }
}
