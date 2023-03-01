
using FlashCards.Classes;
using FlashCards.UIElements;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace FlashCards.Pages
{
    /// <summary>
    /// Interaction logic for EditingPage.xaml
    /// </summary>
    public partial class EditingPage : Page
    {
        List<FlashCardData> _flashCards;
        private Button? currentFilter;

        public EditingPage()
        {

            InitializeComponent();
            //fcEditable.textChangedInvoker = CardTextChangedHandler;

            //reading the file to the list
            var temp = FileHandler.FiletoList();
            _flashCards = (temp == null) ? new() : temp;
        }

        private void FilterMiniCards()
        {
            
        }


        private void btnNewFilter_Click(object sender, RoutedEventArgs e)
        {
            var filter = new Button();
            filter.Content = "New Filter";
            filter.Style = Resources["AnimatedButton"] as Style;
            spFilters.Children.Add(filter);
            spFilters.UpdateLayout();

            filter.Click += (o, args) =>
            {
                FilterMiniCards();
                currentFilter = o as Button;
            };

            filter.MouseDoubleClick += (o, args) =>
            {
                var popup = new FilterPopUp(ref filter);
                popup.Left = filter.PointToScreen(new Point(0, 0)).X;
                popup.Top = filter.PointToScreen(new Point(0, 0)).Y;
                popup.Show();
                popup.Topmost = true;
            };

            currentFilter = filter;

        }

        private void btnDeleteFilter_Click(object sender, RoutedEventArgs e)
        {
            if (!(spFilters.Children.Count > 0))
            {
                return;
            }

            if (currentFilter != null)
            {
                spFilters.Children.Remove(currentFilter);
                currentFilter = null;
            }

            else
            {
                spFilters.Children.RemoveAt(spFilters.Children.Count -1);
            }
        }

        private void BtnNewMiniCard_OnClick(object sender, RoutedEventArgs e)
        {
            //the id should always be unique to the card button
            MiniCardButton cb = new MiniCardButton(0, MiniButton_OnClick);
            wpCardButtons.Children.Add(cb);
        }


        private void MiniButton_OnClick(object sender)
        {
            MessageBox.Show("Invoker Worked");
        }
    }
}
