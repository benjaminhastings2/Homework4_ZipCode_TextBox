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
using System.Text.RegularExpressions;   //using Regular expressions

namespace Homework4_ZipCode_TextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextChangedEventArgs e)
        {
            string myTextBoxEntry = ZipCodeTextBox.Text;

            bool ZipCodeCheck;

            ZipCodeCheck = CheckZipCode(myTextBoxEntry);

            if(ZipCodeCheck == true)
            {
                uxSubmit.IsEnabled = true;
            }
            else
            {
                uxSubmit.IsEnabled = false;
            }

        }

        private bool CheckZipCode(string textBoxEntry)
        {
            Regex ZipCodeRegex = new Regex("^[0-9]{5}(?:-[0-9]{4})?$|[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]");

            return ZipCodeRegex.IsMatch(textBoxEntry);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sumbitted ZipCode");
        }
    }

}
