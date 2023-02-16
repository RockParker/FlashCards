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
        public delegate void myDelegate();
        public myDelegate textChangedInvoker;
        public string Question
        {
            get { return lblQuestion.Text; }
            set { lblQuestion.Text = value; }
        }

        public string Answer
        {
            get { return lblAnswer.Text; }
            set { lblAnswer.Text = value; }

        }

        private int id = int.MaxValue;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                lblID.Content = value;
            }
        }

        public EditableFlashCard()
        {
            InitializeComponent();
        }

        private void tbEditable_GotMouseCapture(object sender, MouseEventArgs e)
        {
            if (sender == null)
            {
                MessageBox.Show("NullSender\nHow...");
                return;
            }
            (sender as TextBox).SelectAll();
        }

        private void tbEditable_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender == null)
            {
                MessageBox.Show("NullSender\nHow...");
                return;
            }
            (sender as TextBox).SelectAll();
        }

        private void lbl_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textChangedInvoker == null)
                return;
            textChangedInvoker.Invoke();
        }
    }
}
