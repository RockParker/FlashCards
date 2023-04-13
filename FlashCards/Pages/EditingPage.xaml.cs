using FlashCards.Classes;
using FlashCards.UIElements;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace FlashCards.Pages
{
    /// <summary>
    /// Interaction logic for EditingPage.xaml
    /// </summary>
    public partial class EditingPage
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
        
        /* Change the general functions of this class. The goal will be:
            have all of the information be dynamically loaded
            The mini flash card... stored in the flash card data class?
            */
        
        //first I will make a method which loads all the flash cards by default

        private void LoadAllFlashCards()
        {
            wpCardButtons.Children.Clear();
            foreach (var card in _flashCards)
            {
                wpCardButtons.Children.Add(DataToMiniCard(card));
            }
        }

        private void LoadFilteredFlashCards(string filter)
        {
            var list = _flashCards.Where(e => e.Filters.Contains(filter));

            wpCardButtons.Children.Clear();
            foreach (var data in list)
            {
                wpCardButtons.Children.Add(DataToMiniCard(data));
            }
        }

        private MiniCardButton DataToMiniCard (FlashCardData data)
        {
            var card = new MiniCardButton(data.ID, MiniButtonClick);

            return card;
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

        private void MiniButtonClick (MiniCardButton sender, int id)
        { 
            fcEditable.CurrentData = _flashCards.First(data => data.ID == id);
            //fcEditable.CurrentCardButton = sender;
        }

        /*
         *
         *  Here is where I handle the generation / removal of flashcard data
         * 
         */
        
        private void BtnNewMiniCard_OnClick(object sender, RoutedEventArgs e)
        {
            _flashCards.Add(new(_flashCards.Count, "", "", new()));
            LoadAllFlashCards();
        }

        private void BtnDeleteMiniCard_OnClick(object sender, RoutedEventArgs e)
        {
            if (_flashCards.Count <= 0) return;
            
            if (fcEditable.CurrentData != null)
            {
                _flashCards.Remove(fcEditable.CurrentData);
                fcEditable.CurrentData = null;
            }
            else
            {
                _flashCards.RemoveAt(_flashCards.Count-1);
            }

            for (int i = 0; i < _flashCards.Count; i++)
            {
                _flashCards.ElementAt(i).ID = i;
            }
            
            LoadAllFlashCards();
        }
    }
}
