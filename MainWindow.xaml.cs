using System;
using System.Windows;
using System.Text.RegularExpressions;
namespace AllMe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   public partial class MainWindow : Window

    {
       

        public MainWindow() => InitializeComponent();

      
        private void Button_Click(object sender, RoutedEventArgs e)

        {

            string text = txtInput.Text;

            string pattern = @"(>>\d+)";

            string replacement = "$1(You)";

            string v = Regex.Replace(text, pattern, replacement);
            string newText = v;



           



            txtOutput.Text = v;

        }

    }
}
