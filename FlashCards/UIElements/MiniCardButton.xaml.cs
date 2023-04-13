using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FlashCards.UIElements
{
    /// <summary>
    /// Interaction logic for MiniCardButton.xaml
    /// </summary>
    public partial class MiniCardButton : UserControl
    {
        public delegate void myDelegate(MiniCardButton sender,int id);
        public myDelegate? clickInvoker { get; set; }

        public String QuestionText
        {
            get => tbQuestion.Text; 
            set => tbQuestion.Text = value;
        }

        private int ID;
        
        
        public MiniCardButton(int id, myDelegate del)
        {
            InitializeComponent();
            ID = id;
            clickInvoker = del;
        }

        private void Click(object sender, MouseEventArgs e)
        {
            if (clickInvoker == null)
            {
                MessageBox.Show("InvokerNullException\nTry a restart");
                return;
            }
            clickInvoker.Invoke(this, ID);
        }
    }
}
