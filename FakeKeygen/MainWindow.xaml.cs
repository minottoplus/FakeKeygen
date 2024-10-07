using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace FakeKeygen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            var keyList = new List<string>()
            {
                "114", "514", "1919", "810", "114", "514", "1919", "810"
            };
            var shuffledList = keyList.OrderBy(a => Guid.NewGuid()).ToList();
            string key = String.Join("-", shuffledList);
            KeyTextBox.Text = key;


        }

        private void GenButton_Click(object sender, RoutedEventArgs e)
        {
            var keyList = new List<string>()
            {
                "114", "514", "1919", "810", "114", "514", "1919", "810"
            };
            var shuffledList = keyList.OrderBy(a => Guid.NewGuid()).ToList();
            string key = String.Join("-", shuffledList);
            KeyTextBox.Text = key;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}