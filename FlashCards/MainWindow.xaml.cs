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
        public MainWindow()
        {
            InitializeComponent();

            this.MainFrame.Navigate(new IndexPage(this.MainFrame));
        }
    }
}
