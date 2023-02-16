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
    /// Interaction logic for MiniCardButton.xaml
    /// </summary>
    public partial class MiniCardButton : UserControl
    {
        public delegate void myDelegate(object sender);
        public myDelegate? clickInvoker;
        public int ID;
        public MiniCardButton(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Click(object sender, MouseEventArgs e)
        {
            if (clickInvoker == null)
            {
                MessageBox.Show("InvokerNullException\nTry a restart");
                return;
            }
            clickInvoker.Invoke(this);
        }
    }
}
