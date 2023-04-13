using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FlashCards.Classes;

namespace FlashCards.UIElements
{
    /// <summary>
    /// Interaction logic for EditableFlashCard.xaml
    /// </summary>
    public partial class EditableFlashCard
    {
        private string Question
        {
            get => lblQuestion.Text;
            set => lblQuestion.Text = value;
        }

        private string Answer
        {
            get => lblAnswer.Text;
            set => lblAnswer.Text = value; 

        }

        private int id = int.MaxValue;
        private int ID
        {
            get => id;
            set
            {
                id = value;
                lblID.Content = value;
            }
        }
        
        private FlashCardData _currentData;

        public FlashCardData? CurrentData
        {
            get => _currentData;
            set
            {
                SaveData();
                _currentData = value;
                LoadData();
            }
        }

        public MiniCardButton CurrentCardButton { get; set; }

        public EditableFlashCard()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// loads the given data object into the text fields
        /// </summary>
        private void LoadData()
        {
            if (CurrentData == null) return;

            ID = CurrentData.ID;
            Question = CurrentData.Question; //triggers text changed.
            Answer = CurrentData.Answer; //triggers text changed.
        }

        /// <summary>
        /// saves the current text fields to the data object
        /// </summary>
        private void SaveData()
        {
            if (CurrentData == null) return;
            
            
            CurrentData.ID = ID;
            CurrentData.Question = Question;
            CurrentData.Answer = Answer;
                
            //---implement later---
            //_currentData.Filters = Filters;
        }
        
        
        
        
        /*===========================================
         *===========================================
         *              EVENT HANDLERS
         *===========================================
         *===========================================
         */

        private void OnFocus (object sender, MouseEventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void OnFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
           (sender as TextBox).SelectAll();
        }

        /// <summary>
        /// only used to change the text of the MiniCardButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CurrentCardButton == null) return;
            CurrentCardButton.tbQuestion.Text = Question;
        }

        private void OnLostFocus (object sender, RoutedEventArgs e)
        {
            SaveData();
        }
    }
}
