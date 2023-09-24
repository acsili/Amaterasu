using Amaterasu.Data.DatabaseEntities;
using Amaterasu.Data;
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

namespace Amaterasu.WPF.Files
{
    public partial class PasswordWindow : Window
    {
        public PasswordWindow()
        {
            InitializeComponent();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            using var db = new ApplicationContext();
            var menuPage = new MenuPage();

            if (e.Key == Key.Enter && TextBoxPassword.Text != "" && db.Passwords.Select(x => x.Value).Contains(TextBoxPassword.Text))
            {
                menuPage.Password = true;
            }
        }
    }
}
