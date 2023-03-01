using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FlashCards;

public partial class FilterPopUp : Window
{
    private Button sender;   
    public FilterPopUp(ref Button btn)
    {
        sender = btn;
        InitializeComponent();

        this.tbInput.Text = btn.Content.ToString();
        this.tbInput.Focus();
        this.tbInput.SelectAll();
    }

    private void TbInput_OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            btnOkay_OnClick(sender, new RoutedEventArgs());
        }
    }

    private void btnOkay_OnClick(object sender, RoutedEventArgs e)
    {
        this.sender.Content = tbInput.Text;
        this.Close();
    }
}