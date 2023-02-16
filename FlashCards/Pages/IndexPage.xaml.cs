using FlashCards.UIElements;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FlashCards.Pages
{
    /// <summary>
    /// Interaction logic for IndexPage.xaml
    /// </summary>
    public partial class IndexPage : Page
    {

        private Frame _frame;
        public IndexPage(Frame frame)
        {
            InitializeComponent();
            _frame = frame;

            //setting properties of the flash card
            fcWelcome.Question = "This is a question";
            fcWelcome.Answer = "This is an answer";
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
