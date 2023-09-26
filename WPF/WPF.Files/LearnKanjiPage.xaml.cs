using Amaterasu.Data;
using System;
using System.Linq;
using System.Windows.Controls;

namespace Amaterasu.WPF.Files
{
    public partial class LearnKanjiPage : Page
    {
        public LearnKanjiPage()
        {
            InitializeComponent();

            using var db = new ApplicationContext();
            var kanji = db.Kanji.Select(x => x.Value).First();
            LabelKanji.Content = kanji;
        }
    }
}
