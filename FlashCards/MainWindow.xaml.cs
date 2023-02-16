using FlashCards.Pages;
using System.Windows;
using System.Windows.Controls;

namespace FlashCards
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EditingPage _editingpage;
        //other pages here in the future
        public MainWindow()
        {
            InitializeComponent();

            _editingpage = new();

            this.MainFrame.Navigate(new IndexPage(this.MainFrame));

        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(_editingpage);
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
