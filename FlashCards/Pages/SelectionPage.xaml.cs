using System.Windows;
using System.Windows.Controls;

namespace FlashCards.Pages;

/// <summary>
/// In this class the goal is to allow the user to select the settings they want
/// so that they get the questions they want
/// </summary>
public partial class SelectionPage : Page
{
    /// <summary>
    /// should be able to select the number of questions, and then
    /// based on the filters, it should also be able to provide only questions from the given filters
    /// </summary>
    public SelectionPage()
    {
        InitializeComponent();
        
    }
    
    private void GetQuestions()
    {
        var mw = Application.Current.MainWindow as MainWindow;
        //take the selections from the filters
        
        
        //get the number of questions from the user
        
        
        //get the filters selected
        var data = mw.GetData();

        
        //randomize the order then return the list
        
        
    }
    
}