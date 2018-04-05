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

namespace ActualGamev2.DialogWindows
{
    /// <summary>
    /// Interaction logic for CreateCharacterDialog.xaml
    /// </summary>
    public partial class CreateCharacterDialog : Window
    {
            //Create a delegate for the user input to show in the label.
        public delegate void InputChangedHandler(string input);

            //Create an event for when the user changes input
        public event InputChangedHandler inputChanged;

            //The input property that holds the userinput for the character name.
        private string _input;
        public string input
        {
            get { return _input; }
            set
            {
                _input = value;
                //Raises the event if there are subscribers and omits the userinput.
                if (inputChanged != null)
                    inputChanged(_input);
            }
        }


        public CreateCharacterDialog()
        {
            InitializeComponent();
                //Subscribe to the event when the window gets called.
            inputChanged += new InputChangedHandler(inputChangedMethod);
        }

            //This event is raised whenever the input in the user-textbox changes.
        private void characterName_TextChanged(object sender, TextChangedEventArgs e)
        {
                //Update the property that holds the userinput.
            input = characterName.Text;
        }
            //The method that is executed when the the property input changes.
        public void inputChangedMethod(string input)
        {
            charNameAuto.Content = input;
        }

        private void createPlayerClassButton_Click(object sender, RoutedEventArgs e)
        {
            if (mechanicGroupBox.IsChecked == true)
            {
                Classes.Mechanic newPlayer = new Classes.Mechanic(charNameAuto.Content.ToString());
                
                this.Visibility = Visibility.Collapsed;
                Windows.GameScreen gameWindow = new Windows.GameScreen();
                gameWindow.Visibility = Visibility.Visible;

            }
        }
    }
}
