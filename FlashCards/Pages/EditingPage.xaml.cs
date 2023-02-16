using Accessibility;
using FlashCards.Classes;
using FlashCards.UIElements;
using System;
using System.CodeDom;
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
using System.Xml.Serialization;

namespace FlashCards.Pages
{
    /// <summary>
    /// Interaction logic for EditingPage.xaml
    /// </summary>
    public partial class EditingPage : Page
    {
        List<FlashCardData> _flashCards;

        public EditingPage()
        {

            InitializeComponent();
            //fcEditable.textChangedInvoker = CardTextChangedHandler;

            //reading the file to the list
            var temp = FileHandler.FiletoList();
            _flashCards = (temp == null) ? new() : temp;
        }
    }
}
