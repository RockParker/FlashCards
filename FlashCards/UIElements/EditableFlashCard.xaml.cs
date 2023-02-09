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

namespace FlashCards.UIElements
{
    /// <summary>
    /// Interaction logic for EditableFlashCard.xaml
    /// </summary>
    public partial class EditableFlashCard : UserControl
    {
        public EditableFlashCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the click event handler that changes the size of the control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (lblAnswer.Visibility == Visibility.Collapsed)
            {
                bottomGrid.Height = new GridLength(32.0, GridUnitType.Star);
                //this is to "swap" the text
                lblAnswerInfo.Visibility = Visibility.Collapsed;
                lblAnswer.Visibility = Visibility.Visible;
            }
            else
            {
                bottomGrid.Height = new GridLength(1.0, GridUnitType.Star);
                lblAnswerInfo.Visibility = Visibility.Visible;
                lblAnswer.Visibility = Visibility.Collapsed;
            }
        }

        private void tbEditable_GotMouseCapture(object sender, MouseEventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void tbEditable_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
    }
}
