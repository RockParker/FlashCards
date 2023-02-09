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

namespace FlashCards.Pages
{
    /// <summary>
    /// Interaction logic for EditingPage.xaml
    /// </summary>
    public partial class EditingPage : Page
    {
        Frame _frame;
        public EditingPage(Frame frame)
        {
            InitializeComponent();

            _frame = frame;
        }

        private void Mitchells_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BABABOOYIE");
        }
    }
}
