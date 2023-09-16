using Amaterasu.Data;
using Amaterasu.Data.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Amaterasu;

public partial class AddWordPage : Page
{
    public AddWordPage()
    {
        InitializeComponent();
    }

    private void ButtonBackToMenu_Click(object sender, RoutedEventArgs e)
    {
        NavigationService.Navigate(new MenuPage());
    }

    private void Grid_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter && TextBoxJapanese.Text != "" && TextBoxTranslation.Text != "" && TextBoxWordLevel.Text != "") 
        {
            using var db = new ApplicationContext();

            var word = new Word
            {
                WordInJapanese = TextBoxJapanese.Text,
                Translation = TextBoxTranslation.Text,
                Level = TextBoxWordLevel.Text
            };

            db.Words.Add(word);
            db.SaveChanges();
            MessageBox.Show("Слово успешно сохранено");
        }
    }
}

