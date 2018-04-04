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

namespace ActualGamev2.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CharacterSelection : Window
    {
        public CharacterSelection()
        {
            InitializeComponent();
        }

        private void CreateCharacterBtn_Click(object sender, RoutedEventArgs e)
        {
            //Opens the CreateCharacterDialog window.
            DialogWindows.CreateCharacterDialog createDialog = new DialogWindows.CreateCharacterDialog();
            this.Visibility = Visibility.Collapsed;
            createDialog.Visibility = Visibility.Visible;
        }

        private void LoadCharacterBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Load char!");
        }
    }
}
