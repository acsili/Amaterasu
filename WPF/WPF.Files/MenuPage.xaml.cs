using Amaterasu.WPF.Files;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WPF;

namespace Amaterasu
{
    public partial class MenuPage : Page
    {
        public static bool Password = false;

        public MenuPage()
        {
            InitializeComponent();
        }


        private void ButtonAddWord_Click(object sender, RoutedEventArgs e)
        {
            var passwordWindow = new PasswordWindow();
            passwordWindow.Show();
            
            if (Password)
            {
                NavigationService.Navigate(new AddWordPage());
                passwordWindow.Close();
            }
                
        }

        private void ButtonTestN5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new N5TestPage());
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
